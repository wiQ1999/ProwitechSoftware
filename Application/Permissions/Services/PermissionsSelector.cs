using Application.Interfaces;
using Application.Permissions.DTOs;
using AutoMapper;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Models.Domain;
using Infrastructure.Models.Enums;
using Infrastructure.Models.Exceptions;

namespace Application.Permissions.Services;
public class PermissionsSelector : IPermissionsSelector
{
    private readonly IPermissionsRepository _permissionsRepository;
    private readonly IUsersRepository _usersRepository;
    private readonly IMapper _mapper;
    private readonly List<AppSource> _sources;

    public PermissionsSelector(
        IPermissionsRepository permissionRepository, 
        IUsersRepository usersRepository, 
        IMapper mapper)
    {
        _permissionsRepository = permissionRepository;
        _usersRepository = usersRepository;
        _mapper = mapper;
        _sources = Enum.GetValues(typeof(AppSource))
            .Cast<AppSource>().ToList();
    }

    public async Task<IEnumerable<PermissionDto>> GetCompleteRolePermissions(
        Guid roleId, CancellationToken cancellationToken)
    {
        var permissions = await GetCompleteRolePermissionsWithoutMapping(
            roleId, cancellationToken);
        return SetOrderAndMapPermissions(permissions);
    }

    private async Task<IEnumerable<Permission>> GetCompleteRolePermissionsWithoutMapping(
        Guid roleId, CancellationToken cancellationToken)
    {
        var permissions = (await _permissionsRepository
            .GetRolePermissionsAsync(roleId, cancellationToken)).ToList();

        var nullPermissionProp = permissions.FirstOrDefault(p =>
            p.Create == null || p.Read == null || p.Update == null || p.Delete == null);
        if (nullPermissionProp != null)
            throw new RequiredAllPermissionPropertiesException(nullPermissionProp);

        if (permissions.Count == _sources.Count)
            return permissions;
        if (permissions.Count > _sources.Count)
            throw new PermissionCountException();

        foreach (var source in _sources)
            if (!permissions.Any(p => p.Source == source))
                permissions.Add(CreateRolePermission(roleId, source));

        return permissions;
    }

    private IEnumerable<PermissionDto> SetOrderAndMapPermissions(
        IEnumerable<Permission> permissions) =>
        permissions.OrderBy(p => p.Source).Select(p =>
            _mapper.Map<PermissionDto>(p)).ToList();

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

    public async Task<IEnumerable<PermissionDto>> GetCompleteUserPermissions(
        Guid userId, CancellationToken cancellationToken)
    {
        var permissions = await GetCompleteRolePermissionsWithoutMapping(
            userId, cancellationToken);
        return SetOrderAndMapPermissions(permissions);
    }

    public async Task<IEnumerable<Permission>> GetCompleteUserPermissionsWithoutMapping(
        Guid userId, CancellationToken cancellationToken)
    {
        var permissions = (await _permissionsRepository
            .GetUserPermissionsAsync(userId, cancellationToken)).ToList();

        if (permissions.Count == _sources.Count)
            return permissions;
        if (permissions.Count > _sources.Count)
            throw new PermissionCountException();

        foreach (var source in _sources)
            if (!permissions.Any(p => p.Source == source))
                permissions.Add(CreateUserPermission(userId, source));

        return permissions;
    }

    private Permission CreateUserPermission(Guid userId, AppSource source)
    {
        var permission = CreateNewPermission(source);
        permission.UserId = userId;
        return permission;
    }

    public async Task<IEnumerable<PermissionDto>> GetCompleteUserAndRolePermissions(
        Guid userId, Guid userRoleId, CancellationToken cancellationToken)
    {
        var user = await _usersRepository.GetUserByIdAsync(userId, cancellationToken);
        if (user == null)
            throw new NotFoundInDbExcption(AppSource.Users, userId);
        if (user.RoleId != userRoleId)
            throw new InvalidForeignKeyException();

        var userPermissions = (await GetCompleteUserPermissionsWithoutMapping(
            userId, cancellationToken)).ToList();
        var rolePermissions = (await GetCompleteRolePermissionsWithoutMapping(
            userRoleId, cancellationToken)).ToList();

        for (int i = 0; i < userPermissions.Count; i++)
        {
            var userPerm = userPermissions[i];
            var rolePerm = rolePermissions[i];

            userPerm.Create ??= rolePerm.Create;
            userPerm.Read ??= rolePerm.Read;
            userPerm.Update ??= rolePerm.Update;
            userPerm.Delete ??= rolePerm.Delete;
        }

        return SetOrderAndMapPermissions(userPermissions);
    }
}
