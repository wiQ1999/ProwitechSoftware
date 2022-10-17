using Application.Interfaces;
using Application.Permissions.DTOs;
using Application.Permissions.Queries.Requests;
using MediatR;

namespace Application.Permissions.Queries.Handlers;
public class GetUserPermissionsQueryHandler 
    : IRequestHandler<GetUserPermissionsQuery, IEnumerable<PermissionDto>>
{
    private readonly IPermissionsSelector _selector;

    public GetUserPermissionsQueryHandler(IPermissionsSelector selector)
    {
        _selector = selector;
    }

    public async Task<IEnumerable<PermissionDto>> Handle(
        GetUserPermissionsQuery request, CancellationToken cancellationToken)
    {
        if (request.UserRoleId == null)
            return await _selector.GetCompleteUserPermissions(
                request.UserId, cancellationToken);
        return await _selector.GetCompleteUserAndRolePermissions(
            request.UserId, (Guid)request.UserRoleId, cancellationToken);
    }
}
