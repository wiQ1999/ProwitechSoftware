using Application.Permissions.DTOs;
using MediatR;

namespace Application.Permissions.Queries.Requests;
public record GetUserPermissionsQuery(Guid UserId, Guid? UserRoleId) 
    : IRequest<IEnumerable<PermissionDto>>;
