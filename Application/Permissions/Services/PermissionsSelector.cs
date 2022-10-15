using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;
using Infrastructure.Models.Enums;
using Infrastructure.Models.Exceptions;

namespace Application.Permissions.Services;
public class PermissionsSelector
{
    private readonly IPermissionsRepository _permissionsRepository;
    private List<AppSource> _sources;

    public PermissionsSelector(IPermissionsRepository permissionRepository)
    {
        _permissionsRepository = permissionRepository;
        _sources = Enum.GetValues(typeof(AppSource))
            .Cast<AppSource>().ToList();
    }

    public async Task<IEnumerable<Permission>> GetCompleteUserPermissions(
        Guid userId, CancellationToken cancellationToken)
    {
        var permissions = await _permissionsRepository
            .GetUserPermissionsAsync(userId, cancellationToken);
        var permissionsList = permissions.ToList();

        if (permissionsList.Count > _sources.Count)
            throw new PermissionCountException();

        foreach (var source in _sources)
        {
            if (!permissionsList.Any(p => p.Source == source))
                permissionsList.Add(CreateUserPermission(userId, source));
        }

        return permissionsList;
    }

    private Permission CreateUserPermission(Guid userId, AppSource source)
    {
        var permission = CreateNewPermission(source);
        permission.UserId = userId;
        return permission;
    }


    private Permission CreateNewPermission(AppSource source) =>
        new()
        {
            Id = Guid.NewGuid(),
            Source = source,
            Create = null,
            Read = null,
        };
}
