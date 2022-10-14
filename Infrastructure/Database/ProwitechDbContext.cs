using Infrastructure.Database.Configurations;
using Infrastructure.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;

namespace Infrastructure.Database;
public class ProwitechDbContext : DbContext
{
    public DbSet<Role> Roles => Set<Role>();
    public DbSet<User> Users => Set<User>();
    public DbSet<Permission> Permissions => Set<Permission>();

    public DbSet<Building> Buildings => Set<Building>();
    public DbSet<BuildingAddress> BuildingAddresses => Set<BuildingAddress>();
    public DbSet<ContactInfo> ContactInfos =>Set<ContactInfo>();
    public DbSet<FullAddress> FullAddresses =>Set<FullAddress>();
    public DbSet<Local> Locals =>Set<Local>();
    public DbSet<LocalInfo> LocalInfos =>Set<LocalInfo>();
    public DbSet<Property> Properties =>Set<Property>();
    public DbSet<PropertyManager> PropertyManagers =>Set<PropertyManager>();
    public DbSet<Resident> Residents =>Set<Resident>();

    public ProwitechDbContext(DbContextOptions<ProwitechDbContext> options) : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        new BuildingConfiguration().Configure(modelBuilder.Entity<Building>());
        new DataSeeder(modelBuilder).Seed();
    }
}
