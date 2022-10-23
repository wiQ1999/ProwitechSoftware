using Application.Permissions.DTOs;

namespace Application.Interfaces.Services;
public interface IPermissionsSelector
{
    Task<IEnumerable<PermissionDto>> GetAllRolePermissions(
        Guid roleId, CancellationToken cancellationToken);
    Task<IEnumerable<NullablePermissionDto>> GetAllUserPermissions(
        Guid userId, CancellationToken cancellationToken);
    Task<IEnumerable<PermissionDto>> GetCompleteUserAndRolePermissions(
        Guid userId, CancellationToken cancellationToken);
}
