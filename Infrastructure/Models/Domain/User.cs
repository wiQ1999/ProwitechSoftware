using Infrastructure.Models.Common;

namespace Infrastructure.Models.Domain;
public class User : BaseEntity
{
    public string Login { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public Guid? RoleId { get; set; }
    public Role? Role { get; set; }
    public ICollection<Permission>? Permissions { get; set; }
}
