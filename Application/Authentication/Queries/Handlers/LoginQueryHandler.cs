using Application.Authentication.Queries.Requests;
using Application.Interfaces.Services;
using Infrastructure.Interfaces.Repositories;
using MediatR;

namespace Application.Authentication.Queries.Handlers;

public class LoginQueryHandler
    : IRequestHandler<LoginQuery, string?>
{
    private readonly IUsersRepository _usersRepository;
    private readonly IPermissionsSelector _permissionsSelector;
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public LoginQueryHandler(
        IUsersRepository usersRepository, 
        IPermissionsSelector permissionsSelector, 
        IJwtTokenGenerator jwtTokenGenerator)
    {
        _usersRepository = usersRepository;
        _permissionsSelector = permissionsSelector;
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    public async Task<string?> Handle(
        LoginQuery request, CancellationToken cancellationToken)
    {
        var user = await _usersRepository.GetUserByLoginAndPasswordAsync(
            request.Login, request.Password, cancellationToken);

        if (user == null)
            return null!;
        
        var permissions = await _permissionsSelector.GetCompleteUserAndRolePermissions(
            user.Id, cancellationToken);

        var token = _jwtTokenGenerator.GenerateToken(user, permissions);

        return token;
    }
}
