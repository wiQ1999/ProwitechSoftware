using Application.Roles.DTOs;

namespace Application.Users.DTOs;
public class UserDto
{
    public Guid Id { get; set; }
    public string? Login { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public RoleDto? Role { get; set; }
}
