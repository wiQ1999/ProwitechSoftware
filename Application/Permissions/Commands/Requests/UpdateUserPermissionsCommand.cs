using Application.Permissions.DTOs;
using MediatR;

namespace Application.Permissions.Commands.Requests;
public record UpdateUserPermissionsCommand : IRequest
{
    public Guid Id { get; set; }
    public IEnumerable<PermissionDto> Permissions { get; set; } = null!;
}
