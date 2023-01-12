using Application.Roles.Commands.Requests;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;
using MediatR;

namespace Application.Roles.Commands.Handlers;

public class CreateRoleCommandHandler : IRequestHandler<CreateRoleCommand, Guid>
{
    private readonly IUnitOfWork _unitOfWork;

    public CreateRoleCommandHandler(IUnitOfWork unitOfWork)
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
