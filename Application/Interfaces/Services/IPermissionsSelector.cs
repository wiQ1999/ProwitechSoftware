using Application.Permissions.DTOs;

namespace Application.Interfaces.Services;
public interface IPermissionsSelector
{
    Task<IEnumerable<TranslatedPermissionDto>> GetAllRolePermissions(
        Guid roleId, CancellationToken cancellationToken);
    Task<IEnumerable<TranslatedNullablePermissionDto>> GetAllUserPermissions(
        Guid userId, CancellationToken cancellationToken);
    Task<IEnumerable<PermissionDto>> GetCompleteUserAndRolePermissions(
        Guid userId, CancellationToken cancellationToken);
}
