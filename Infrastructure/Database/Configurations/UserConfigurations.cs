using Infrastructure.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Database.Configurations;
public class UserConfigurations : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.Property(up => up.Login)
            .HasMaxLength(50)
            .IsRequired();
        builder.HasIndex(up => up.Login)
            .IsUnique();
        builder.Property(up => up.Password)
            .HasMaxLength(50)
            .IsRequired();
        builder.Property(up => up.FirstName)
            .HasMaxLength(50);
        builder.Property(up => up.LastName)
            .HasMaxLength(50);
        builder.Property(up => up.Email)
            .HasMaxLength(100);
        builder.Property(up => up.PhoneNumber)
            .HasMaxLength(30);

        builder
            .HasOne(u => u.Role)
            .WithMany(r => r.Users)
            .HasForeignKey(u => u.RoleId);
    }
}
