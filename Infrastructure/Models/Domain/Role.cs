using Infrastructure.Models.Common;

namespace Infrastructure.Models.Domain;

public class Role : BaseEntity
{
    public string Name { get; set; } = default!;
    public ICollection<User> Users { get; set; } = default!;
    public ICollection<Permission> Permissions { get; set; } = default!;
}
