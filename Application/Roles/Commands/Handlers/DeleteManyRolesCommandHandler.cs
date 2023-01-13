using Application.Roles.Commands.Requests;
using Infrastructure.Interfaces.UnitOfWork;
using MediatR;

namespace Application.Roles.Commands.Handlers;

public class DeleteManyRolesCommandHandler : IRequestHandler<DeleteManyRolesCommand>
{
    private readonly IRepositoriesUnitOfWork _unitOfWork;

    public DeleteManyRolesCommandHandler(IRepositoriesUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Unit> Handle(DeleteManyRolesCommand request, CancellationToken cancellationToken)
    {
        foreach (var id in request.Ids)
            await _unitOfWork.RolesRepository.DeleteAsync(id, cancellationToken);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}
