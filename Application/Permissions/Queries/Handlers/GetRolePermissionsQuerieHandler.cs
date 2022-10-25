using Application.Interfaces.Services;
using Application.Permissions.DTOs;
using Application.Permissions.Queries.Requests;
using MediatR;

namespace Application.Permissions.Queries.Handlers;

public class GetRolePermissionsQuerieHandler
    : IRequestHandler<GetRolePermissionsQuery, IEnumerable<PermissionDto>>
{
    private readonly IPermissionsSelector _selector;

    public GetRolePermissionsQuerieHandler(IPermissionsSelector selector)
    {
        _selector = selector;
    }

    public async Task<IEnumerable<PermissionDto>> Handle(
        GetRolePermissionsQuery request, CancellationToken cancellationToken) 
        => await _selector.GetAllRolePermissions(request.RoleId, cancellationToken);
}
