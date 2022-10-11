using Application.Permissions.DTOs;
using Application.Permissions.Queries.Requests;
using MediatR;

namespace Application.Permissions.Queries.Handlers;
public class GetUserPermissionsQueryHandler : IRequestHandler<GetUserPermissionsQuery, IEnumerable<PermissionDto>>
{
    public Task<IEnumerable<PermissionDto>> Handle(GetUserPermissionsQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
