using Application.Permissions.DTOs;
using MediatR;

namespace Application.Permissions.Queries.Requests;

public record GetUserPermissionsQuery : IRequest<IEnumerable<TranslatedNullablePermissionDto>>
{
    public Guid UserId { get; init; }

    public GetUserPermissionsQuery(Guid userId)
    {
        UserId = userId;
    }
}
