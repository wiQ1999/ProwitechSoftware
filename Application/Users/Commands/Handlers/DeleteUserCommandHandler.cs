using Application.Users.Commands.Requests;
using Infrastructure.Interfaces.Repositories;
using MediatR;

namespace Application.Users.Commands.Handlers;
public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand>
{
    private readonly IUsersRepository _usersRepository;

    public DeleteUserCommandHandler(IUsersRepository usersRepository)
    {
        _usersRepository = usersRepository;
    }

    public async Task<Unit> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        await _usersRepository.DeleteUserAsync(request.Id, cancellationToken);
        return Unit.Value;
    }
}
