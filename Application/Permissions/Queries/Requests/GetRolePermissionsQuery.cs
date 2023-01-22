using Application.Permissions.DTOs;
using MediatR;

namespace Application.Permissions.Queries.Requests;

public record GetRolePermissionsQuery : IRequest<IEnumerable<TranslatedPermissionDto>>
{
    public Guid RoleId { get; init; }

    public GetRolePermissionsQuery(Guid roleId)
    {
        RoleId = roleId;
    }
}
