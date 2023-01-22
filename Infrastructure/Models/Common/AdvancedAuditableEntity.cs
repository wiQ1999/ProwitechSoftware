using Infrastructure.Models.Domain;

namespace Infrastructure.Models.Common;

public abstract class AdvancedAuditableEntity : BaseAuditableEntity
{
    public Guid CreatedById { get; set; }
    public Guid LastModifiedById { get; set; }

    public virtual User CreatedBy { get; set; } = default!;
    public virtual User LastModifiedBy { get; set; } = default!;
}
