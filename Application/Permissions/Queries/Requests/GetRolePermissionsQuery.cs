using Application.Permissions.DTOs;
using MediatR;

namespace Application.Permissions.Queries.Requests;

public record GetRolePermissionsQuery(Guid RoleId) 
    : IRequest<IEnumerable<TranslatedPermissionDto>>;
