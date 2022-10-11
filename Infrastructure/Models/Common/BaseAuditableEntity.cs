using Infrastructure.Models.Domain;

namespace Infrastructure.Models.Common;
public abstract class BaseAuditableEntity : BaseEntity
{
    public DateTime Created { get; set; }
    public Guid CreatedById { get; set; }
    public User? CreatedBy { get; set; }    
    public DateTime? LastModified { get; set; }
    public Guid LastModifiedById { get; set; }
    public User? LastModifiedBy { get; set; }
}
