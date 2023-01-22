using Infrastructure.Models.Common;

namespace Infrastructure.Models.Domain;

public class User : BaseEntity
{
    public string Login { get; set; } = default!;
    public string Password { get; set; } = default!;
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public Guid? RoleId { get; set; }

    public virtual Role? Role { get; set; }
    public virtual ICollection<Permission> Permissions { get; set; } = default!;
}
