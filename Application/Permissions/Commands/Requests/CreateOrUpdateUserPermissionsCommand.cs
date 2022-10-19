using Application.Permissions.DTOs;
using MediatR;

namespace Application.Permissions.Commands.Requests;
public record CreateOrUpdateUserPermissionsCommand : IRequest
{
    public Guid UserId { get; set; }
    public Guid? UserRoleId { get; set; }
    public IEnumerable<PermissionDto> Permissions { get; set; } = null!;
}
