using Application.Permissions.DTOs;
using Infrastructure.Models.Domain;

namespace Application.Interfaces.Services;

public interface IJwtTokenGenerator
{
    string GenerateToken(
        User user, 
        IEnumerable<PermissionDto> permissions, 
        CancellationToken cancellationToken);
}
