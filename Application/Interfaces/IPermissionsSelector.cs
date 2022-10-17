using Application.Permissions.DTOs;

namespace Application.Interfaces;
public interface IPermissionsSelector
{
    Task<IEnumerable<PermissionDto>> GetCompleteRolePermissions(
        Guid roleId, CancellationToken cancellationToken);
    Task<IEnumerable<PermissionDto>> GetCompleteUserPermissions(
        Guid userId, CancellationToken cancellationToken);
    Task<IEnumerable<PermissionDto>> GetCompleteUserAndRolePermissions(
        Guid userId, Guid userRoleId, CancellationToken cancellationToken);
}
