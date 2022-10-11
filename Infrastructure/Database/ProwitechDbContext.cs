using Infrastructure.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database;
public class ProwitechDbContext : DbContext
{
    public DbSet<Role> Roles => Set<Role>();
    public DbSet<User> Users => Set<User>();
    public DbSet<Permission> Permissions => Set<Permission>();

    public ProwitechDbContext(DbContextOptions<ProwitechDbContext> options) : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        new DataSeeder(modelBuilder).Seed();
    }
}
