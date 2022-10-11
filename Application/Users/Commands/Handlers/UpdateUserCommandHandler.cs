using Application.Users.Commands.Requests;
using Infrastructure.Interfaces.Repositories;
using MediatR;

namespace Application.Users.Commands.Handlers;
public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand>
{
    private readonly IUsersRepository _usersRepository;
    private readonly IRoleRepository _roleRepository;

    public UpdateUserCommandHandler(IUsersRepository usersRepository, IRoleRepository roleRepository)
    {
        _usersRepository = usersRepository;
        _roleRepository = roleRepository;
    }

    public async Task<Unit> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        var user = await _usersRepository.GetUserByIdAsync(request.Id, cancellationToken);
        if (user == null)
            throw new Exception($"Nie znaleziono użytkownika o identyfikatorze {request.Id}.");
        if (await _roleRepository.GetRoleByIdAsync(request.RoleId, cancellationToken) == null)
            throw new Exception($"Nie znaleziono roli o identyfikatorze {request.RoleId}.");
        user.Login = request.Login;
        user.FirstName = request.FirstName;
        user.LastName = request.LastName;
        user.Email = request.Email;
        user.PhoneNumber = request.PhoneNumber;
        user.RoleId = request.RoleId;
        await _usersRepository.UpdateUserAsync(user, cancellationToken);
        return Unit.Value;
    }
}
