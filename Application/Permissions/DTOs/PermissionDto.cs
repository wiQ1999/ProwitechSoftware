using Application.Roles.DTOs;
using Application.Users.DTOs;
using Infrastructure.Models.Enums;

namespace Application.Permissions.DTOs;
public class PermissionDto
{
    public Guid Id { get; set; }
    public Guid? UserId { get; set; }
    public Guid? RoleId { get; set; }
    public AppSource Source { get; set; }
    public bool? Create { get; set; }
    public bool? Read { get; set; }
    public bool? Update { get; set; }
    public bool? Delete { get; set; }
}
