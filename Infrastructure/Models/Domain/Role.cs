﻿using Infrastructure.Models.Common;

namespace Infrastructure.Models.Domain;
public class Role : BaseEntity
{
    public string Name { get; set; } = null!;
    public ICollection<User>? Users { get; set; }
    public ICollection<Permission>? Permissions { get; set; }
}
