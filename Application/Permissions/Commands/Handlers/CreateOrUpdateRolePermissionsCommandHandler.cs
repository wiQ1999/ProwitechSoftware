using Application.Permissions.Commands.Requests;
using Infrastructure.Interfaces.Repositories;
using MediatR;

namespace Application.Permissions.Commands.Handlers;

public class CreateOrUpdateRolePermissionsCommandHandler
    : IRequestHandler<CreateOrUpdateRolePermissionsCommand, Unit>
{
    private readonly IRoleRepository _roleRepository;
    private readonly IPermissionsRepository _permissionsRepository;

    public CreateOrUpdateRolePermissionsCommandHandler(
        IRoleRepository roleRepository,
        IPermissionsRepository permissionsRepository)
    {
        _roleRepository = roleRepository;
        _permissionsRepository = permissionsRepository;
    }

    public async Task<Unit> Handle(
        CreateOrUpdateRolePermissionsCommand request, CancellationToken cancellationToken)
    {
        foreach (var permission in request.Permissions)
        {
            
        }

        return Unit.Value;
    }
}
