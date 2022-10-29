using Application.Permissions.DTOs;
using MediatR;

namespace Application.Permissions.Commands.Requests;

public record CreateOrUpdateRolePermissionsCommand : IRequest
{
    public Guid RoleId { get; set; }
    public IEnumerable<TranslatedPermissionDto> Permissions { get; set; } = null!;
}
