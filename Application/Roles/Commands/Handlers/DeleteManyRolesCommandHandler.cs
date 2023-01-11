using Application.Roles.Commands.Requests;
using Infrastructure.Interfaces.Repositories;
using MediatR;

namespace Application.Roles.Commands.Handlers;

public class DeleteManyRolesCommandHandler : IRequestHandler<DeleteManyRolesCommand>
{
    private readonly IUnitOfWork _unitOfWork;

    public DeleteManyRolesCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Unit> Handle(DeleteManyRolesCommand request, CancellationToken cancellationToken)
    {
        foreach (var id in request.Ids)
            await _unitOfWork.RolesRepository.DeleteAsync(id, cancellationToken);

        await _unitOfWork.SaveChangesAsync();

        return Unit.Value;
    }
}
