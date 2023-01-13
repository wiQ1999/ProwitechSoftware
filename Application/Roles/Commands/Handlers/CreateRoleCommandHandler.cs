using Application.Roles.Commands.Requests;
using Infrastructure.Interfaces.UnitOfWork;
using Infrastructure.Models.Domain;
using MediatR;

namespace Application.Roles.Commands.Handlers;

public class CreateRoleCommandHandler : IRequestHandler<CreateRoleCommand, Guid>
{
    private readonly IRepositoriesUnitOfWork _unitOfWork;

    public CreateRoleCommandHandler(IRepositoriesUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Guid> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
    {
        Role role = new() 
        { 
            Name = request.Name
        };

        var guid = await _unitOfWork.RolesRepository.CreateAsync(role, cancellationToken);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return guid;
    }
}
