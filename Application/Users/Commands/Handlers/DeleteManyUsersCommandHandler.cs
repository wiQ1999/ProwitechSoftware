using Application.Users.Commands.Requests;
using Infrastructure.Interfaces.Repositories;
using MediatR;

namespace Application.Roles.Commands.Handlers;

public class DeleteManyUsersCommandHandler : IRequestHandler<DeleteManyUsersCommand>
{
    private readonly IUnitOfWork _unitOfWork;

    public DeleteManyUsersCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Unit> Handle(DeleteManyUsersCommand request, CancellationToken cancellationToken)
    {
        foreach (var id in request.Ids)
            await _unitOfWork.UsersRepository.DeleteAsync(id, cancellationToken);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}
