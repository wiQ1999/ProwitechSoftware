using Application.Permissions.DTOs;
using Application.Users.DTOs;

namespace Application.Interfaces.Services;

public interface IJwtTokenGenerator
{
    string GenerateToken(UserDto user, IEnumerable<PermissionDto> permissions);
}
