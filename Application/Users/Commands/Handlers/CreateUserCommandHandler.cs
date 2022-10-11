using Application.Users.Commands.Requests;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;
using MediatR;

namespace Application.Users.Commands.Handlers;
public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Guid>
{
    private readonly IUsersRepository _usersRepository;
    private readonly IRoleRepository _roleRepository;

    public CreateUserCommandHandler(IUsersRepository usersRepository, IRoleRepository roleRepository)
    {
        _usersRepository = usersRepository;
        _roleRepository = roleRepository;
    }

    public async Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var role = await _roleRepository.GetRoleByIdAsync(request.RoleId, cancellationToken);
        if (role == null)
            throw new Exception($"Nie znaleziono roli o identyfikatorze {request.RoleId}.");
        User user = new()
        {
            Login = request.Login,
            Password = request.Password,
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = string.IsNullOrEmpty(request.Email) ? null : request.Email,
            PhoneNumber = request.PhoneNumber,
            RoleId = role.Id
        };
        return await _usersRepository.CreateUserAsync(user, cancellationToken);
    }
}
