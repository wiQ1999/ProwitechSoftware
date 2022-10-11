using Application.Roles.DTOs;
using Application.Users.DTOs;

namespace Application.Permissions.DTOs;
public class PermissionDto
{
    public Guid Id { get; set; }
    public UserDto? User { get; set; }
    public RoleDto? Role { get; set; }
    public string? Name { get; set; }
    public bool? Create { get; set; }
    public bool? Read { get; set; }
    public bool? Update { get; set; }
    public bool? Delete { get; set; }
}
