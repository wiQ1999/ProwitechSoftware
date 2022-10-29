using Application.Interfaces.Services;
using Application.Permissions.DTOs;
using Application.Permissions.Queries.Requests;
using Infrastructure.Interfaces.Repositories;
using MediatR;

namespace Application.Permissions.Queries.Handlers;

public class GetUserPermissionsQueryHandler 
    : IRequestHandler<GetUserPermissionsQuery, IEnumerable<TranslatedNullablePermissionDto>>
{
    private readonly IUsersRepository _usersRepository;
    private readonly IPermissionsSelector _selector;

    public GetUserPermissionsQueryHandler(
        IUsersRepository usersRepository,
        IPermissionsSelector selector)
    {
        _usersRepository = usersRepository;
        _selector = selector;
    }

    public async Task<IEnumerable<TranslatedNullablePermissionDto>> Handle(
        GetUserPermissionsQuery request, CancellationToken cancellationToken)
        => await _selector.GetAllUserPermissions(request.UserId, cancellationToken);
}
