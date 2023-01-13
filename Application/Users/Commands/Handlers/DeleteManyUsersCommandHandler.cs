using Application.Users.Commands.Requests;
using Infrastructure.Interfaces.UnitOfWork;
using MediatR;

namespace Application.Users.Commands.Handlers;

public class DeleteManyUsersCommandHandler : IRequestHandler<DeleteManyUsersCommand>
{
    private readonly IRepositoriesUnitOfWork _unitOfWork;

    public DeleteManyUsersCommandHandler(IRepositoriesUnitOfWork unitOfWork)
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
