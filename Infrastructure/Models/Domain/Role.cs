﻿namespace Infrastructure.Models.Domain;
public class Role
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public ICollection<User>? Users { get; set; }
    public ICollection<Permission>? Permissions { get; set; }
}
