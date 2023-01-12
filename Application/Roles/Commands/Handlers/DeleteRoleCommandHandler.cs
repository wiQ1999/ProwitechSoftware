using Application.Roles.Commands.Requests;
using Infrastructure.Interfaces.Repositories;
using MediatR;

namespace Application.Roles.Commands.Handlers;

public class DeleteRoleCommandHandler : IRequestHandler<DeleteRoleCommand>
{
    private readonly IUnitOfWork _unitOfWork;

    public DeleteRoleCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Unit> Handle(DeleteRoleCommand request, CancellationToken cancellationToken)
    {
        await _unitOfWork.RolesRepository.DeleteAsync(request.Id, cancellationToken);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}
