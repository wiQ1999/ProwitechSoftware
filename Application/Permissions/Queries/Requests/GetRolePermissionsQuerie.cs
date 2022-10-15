using Application.Permissions.DTOs;
using MediatR;

namespace Application.Permissions.Queries.Requests;
public record GetRolePermissionsQuerie(Guid RoleId) : IRequest<IEnumerable<PermissionDto>>;
