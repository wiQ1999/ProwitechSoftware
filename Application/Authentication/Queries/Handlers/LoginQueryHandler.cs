using Application.Authentication.DTOs;
using Application.Authentication.Queries.Requests;
using Application.Interfaces.Services;
using Application.Users.DTOs;
using AutoMapper;
using Infrastructure.Interfaces.UnitOfWork;
using MediatR;

namespace Application.Authentication.Queries.Handlers;

public class LoginQueryHandler
    : IRequestHandler<LoginQuery, AuthenticationResponse>
{
    private readonly IRepositoriesUnitOfWork _unitOfWork;
    private readonly IPermissionsSelector _permissionsSelector;
    private readonly IMapper _mapper;
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public LoginQueryHandler(
        IRepositoriesUnitOfWork unitOfWork,
        IPermissionsSelector permissionsSelector,
        IMapper mapper,
        IJwtTokenGenerator jwtTokenGenerator)
    {
        _unitOfWork = unitOfWork;
        _permissionsSelector = permissionsSelector;
        _mapper = mapper;
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    public async Task<AuthenticationResponse> Handle(
        LoginQuery request, CancellationToken cancellationToken)
    {
        var user = await _unitOfWork.UsersRepository.GetByLoginAndPasswordAsync(
            request.Login, request.Password, cancellationToken);

        if (user == null)
            return new AuthenticationResponse(null, false);

        var mappedUser = _mapper.Map<UserDto>(user);

        var permissions = await _permissionsSelector.GetCompleteUserAndRolePermissions(
            user.Id, cancellationToken);

        var token = _jwtTokenGenerator.GenerateToken(mappedUser, permissions);

        return new AuthenticationResponse(token, !string.IsNullOrEmpty(token));
    }
}
