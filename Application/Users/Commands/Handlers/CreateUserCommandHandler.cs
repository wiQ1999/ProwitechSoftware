using Application.Users.Commands.Requests;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;
using Infrastructure.Models.Enums;
using Infrastructure.Models.Exceptions;
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
        if (request.RoleId != null)
            await _roleRepository.GetRoleByIdAsync((Guid)request.RoleId, cancellationToken);
            
        User user = new()
        {
            Login = request.Login,
            Password = request.Password,
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = request.Email,
            PhoneNumber = request.PhoneNumber,
            RoleId = request.RoleId
        };

        return await _usersRepository.CreateUserAsync(user, cancellationToken);
    }
}
