using Application.Permissions.DTOs;
using MediatR;

namespace Application.Permissions.Commands.Requests;

public record CreateOrUpdateUserPermissionsCommand : IRequest
{
    public Guid UserId { get; set; }
    public IEnumerable<TranslatedNullablePermissionDto> Permissions { get; set; } = null!;
}
