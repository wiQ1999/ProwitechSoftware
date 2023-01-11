using Application.Roles.Commands.Requests;
using Infrastructure.Interfaces.Repositories;
using MediatR;

namespace Application.Roles.Commands.Handlers;

public class UpdateRoleCommandHandler : IRequestHandler<UpdateRoleCommand>
{
    private readonly IUnitOfWork _unitOfWork;

    public UpdateRoleCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Unit> Handle(UpdateRoleCommand request, CancellationToken cancellationToken)
    {
        var role = await _unitOfWork.RolesRepository.GetByIdAsync(request.Id, cancellationToken);

        role.Name = request.Name;

        await _unitOfWork.RolesRepository.UpdateAsync(role, cancellationToken);

        await _unitOfWork.SaveChangesAsync();

        return Unit.Value;
    }
}
