using Application.Permissions.DTOs;
using Infrastructure.Models.Domain;

namespace Application.Interfaces;
public interface IPermissionsSelector
{
    Task<IEnumerable<PermissionDto>> GetCompleteRolePermissionsWithMapping(
        Guid roleId, CancellationToken cancellationToken);
    Task<IEnumerable<Permission>> GetCompleteRolePermissionsWithoutMapping(
        Guid roleId, CancellationToken cancellationToken);
    Task<IEnumerable<PermissionDto>> GetCompleteUserPermissionsWithMapping(
        Guid userId, CancellationToken cancellationToken);
    Task<IEnumerable<Permission>> GetCompleteUserPermissionsWithoutMapping(
        Guid userId, CancellationToken cancellationToken);
    Task<IEnumerable<PermissionDto>> GetCompleteUserAndRolePermissionsWithMapping(
        Guid userId, Guid userRoleId, CancellationToken cancellationToken);
    Task<IEnumerable<Permission>> GetCompleteUserAndRolePermissionsWithoutMapping(
        Guid userId, Guid userRoleId, CancellationToken cancellationToken);
}
