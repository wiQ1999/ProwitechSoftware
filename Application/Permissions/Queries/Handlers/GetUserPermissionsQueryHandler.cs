using Application.Interfaces.Services;
using Application.Permissions.DTOs;
using Application.Permissions.Queries.Requests;
using MediatR;

namespace Application.Permissions.Queries.Handlers;

public class GetUserPermissionsQueryHandler 
    : IRequestHandler<GetUserPermissionsQuery, IEnumerable<TranslatedNullablePermissionDto>>
{
    private readonly IPermissionsSelector _selector;

    public GetUserPermissionsQueryHandler(IPermissionsSelector selector)
    {
        _selector = selector;
    }

    public async Task<IEnumerable<TranslatedNullablePermissionDto>> Handle(
        GetUserPermissionsQuery request, CancellationToken cancellationToken)
        => await _selector.GetAllUserPermissions(request.UserId, cancellationToken);
}
