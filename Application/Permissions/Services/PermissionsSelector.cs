using Application.Interfaces.Services;
using Application.Permissions.DTOs;
using AutoMapper;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;
using Infrastructure.Models.Enums;
using Infrastructure.Models.Exceptions;

namespace Application.Permissions.Services;

public class PermissionsSelector : IPermissionsSelector
{
    private readonly IRoleRepository _roleRepository;
    private readonly IUsersRepository _usersRepository;
    private readonly IPermissionsRepository _permissionsRepository;
    private readonly IMapper _mapper;
    private readonly List<AppSource> _sources;

    public PermissionsSelector(
        IRoleRepository roleRepository, 
        IUsersRepository usersRepository,
        IPermissionsRepository permissionRepository,
        IMapper mapper)
    {
        _roleRepository = roleRepository;
        _usersRepository = usersRepository;
        _permissionsRepository = permissionRepository;
        _mapper = mapper;
        _sources = Enum.GetValues(typeof(AppSource))
            .Cast<AppSource>().ToList();
    }

    public async Task<IEnumerable<TranslatedPermissionDto>> GetAllRolePermissions(
        Guid roleId, CancellationToken cancellationToken)
    {
        var permissions = await GetAllRolePermissionsWithoutMapping(roleId, cancellationToken);
        return permissions.Select(p => _mapper.Map<TranslatedPermissionDto>(p));
    }

    private async Task<IEnumerable<Permission>> GetAllRolePermissionsWithoutMapping(
        Guid roleId, CancellationToken cancellationToken)
    {
        await _roleRepository.GetRoleByIdAsync(roleId, cancellationToken);

        var permissions = (await _permissionsRepository
            .GetRolePermissionsAsync(roleId, cancellationToken)).ToList();

        var nullPermissionProp = permissions.FirstOrDefault(p 
            => p.Create == null || p.Read == null || p.Update == null || p.Delete == null);
        if (nullPermissionProp != null)
            throw new RequiredAllPermissionPropertiesException(nullPermissionProp);

        if (permissions.Count == _sources.Count)
            return OrderBySource(permissions);

        if (permissions.Count > _sources.Count)
            throw new PermissionCountException();

        foreach (var source in _sources)
        {
            if (!permissions.Any(p => p.Source == source))
                permissions.Add(CreateRolePermission(roleId, source));
        }

        return OrderBySource(permissions);
    }

    private Permission CreateRolePermission(Guid roleId, AppSource source)
    {
        var permission = CreateNewPermission(source);
        permission.RoleId = roleId;

        return permission;
    }

    private Permission CreateNewPermission(AppSource source) =>
        new() {
            Id = Guid.NewGuid(),
            Source = source,
            Create = null,
            Read = null,
            Update = null,
            Delete = null
        };

    private IEnumerable<Permission> OrderBySource(IEnumerable<Permission> permissions)
        => permissions.OrderBy(p => p.Source);

    public async Task<IEnumerable<TranslatedNullablePermissionDto>> GetAllUserPermissions(
        Guid userId, CancellationToken cancellationToken)
    {
        var permissions = await GetAllUserPermissionsWithoutMapping(userId, cancellationToken);
        return permissions.Select(p => _mapper.Map<TranslatedNullablePermissionDto>(p));
    }

    private async Task<IEnumerable<Permission>> GetAllUserPermissionsWithoutMapping(
        Guid userId, CancellationToken cancellationToken)
    {
        await _usersRepository.GetUserByIdAsync(userId, cancellationToken);

        var permissions = (await _permissionsRepository
            .GetUserPermissionsAsync(userId, cancellationToken)).ToList();

        if (permissions.Count == _sources.Count)
            return OrderBySource(permissions);

        if (permissions.Count > _sources.Count)
            throw new PermissionCountException();

        foreach (var source in _sources)
        {
            if (!permissions.Any(p => p.Source == source))
                permissions.Add(CreateUserPermission(userId, source));
        }

        return OrderBySource(permissions);
    }

    private Permission CreateUserPermission(Guid userId, AppSource source)
    {
        var permission = CreateNewPermission(source);
        permission.UserId = userId;

        return permission;
    }

    public async Task<IEnumerable<PermissionDto>> GetCompleteUserAndRolePermissions(
        Guid userId, CancellationToken cancellationToken)
    {
        var permissions = await GetCompleteUserAndRolePermissionsWithoutMapping(userId, cancellationToken);
        return permissions.Select(p => _mapper.Map<PermissionDto>(p));
    }

    private async Task<IEnumerable<Permission>> GetCompleteUserAndRolePermissionsWithoutMapping(
        Guid userId, CancellationToken cancellationToken)
    {
        var user = await _usersRepository.GetUserByIdAsync(userId, cancellationToken);

        var userPermissions = (await GetAllUserPermissionsWithoutMapping(
            userId, cancellationToken)).ToList();

        if (user.RoleId == null)
            return OrderBySource(userPermissions);

        var rolePermissions = (await GetAllRolePermissionsWithoutMapping(
            (Guid)user.RoleId, cancellationToken)).ToList();

        for (int i = 0; i < userPermissions.Count; i++)
        {
            var userPerm = userPermissions[i];
            var rolePerm = rolePermissions[i];

            userPerm.Create ??= rolePerm.Create;
            userPerm.Read ??= rolePerm.Read;
            userPerm.Update ??= rolePerm.Update;
            userPerm.Delete ??= rolePerm.Delete;
        }

        return OrderBySource(userPermissions);
    }
}
