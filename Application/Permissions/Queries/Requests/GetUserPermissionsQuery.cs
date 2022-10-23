using Application.Permissions.DTOs;
using MediatR;

namespace Application.Permissions.Queries.Requests;

public record GetUserPermissionsQuery(Guid UserId) 
    : IRequest<IEnumerable<NullablePermissionDto>>;
