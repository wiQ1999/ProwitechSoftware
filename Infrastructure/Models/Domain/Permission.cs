using Infrastructure.Models.Common;
using Infrastructure.Models.Enums;

namespace Infrastructure.Models.Domain;
public class Permission : BaseEntity
{
    public Guid? UserId { get; set; }
    public User? User { get; set; }
    public Guid? RoleId { get; set; }
    public Role? Role { get; set; }
    public AppSource Source { get; set; }
    public bool? Create { get; set; }
    public bool? Read { get; set; }
    public bool? Update { get; set; }
    public bool? Delete { get; set; }
}
