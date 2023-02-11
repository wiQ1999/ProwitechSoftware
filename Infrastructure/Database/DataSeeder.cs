using Infrastructure.Models.Domain;
using Infrastructure.Models.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database;

public class DataSeeder
{
    private readonly ModelBuilder ModelBuilder;
    private readonly IPasswordHasher<User> _hasher;

    public DataSeeder(ModelBuilder modelBuilder, IPasswordHasher<User> hasher)
    {
        ModelBuilder = modelBuilder;
        _hasher = hasher;
    }
    
    public void DevSeed()
    {
        #region Roles

        Role role_admin = CreateRole("Administrator");
        Role role_boss = CreateRole("Szef");
        Role role_worker = CreateRole("Pracownik");
        ModelBuilder.Entity<Role>().HasData(role_admin, role_boss, role_worker);

        #endregion

        #region Users

        User user_admin = CreateUser("admin", "admin", "admin", null, null, role_admin);
        User user_boss = CreateUser("boss", "Krzysztof", "Tumiel", "k.tumiel@gmail.com", "123 456 789", role_boss);
        User user_w1 = CreateUser("w1", "Jan", "Kowalski", "j.kowalski@gmail.com", null, role_worker);
        User user_w2 = CreateUser("w2", "Zdzisław", "Piętka", "z.pietka@gmail.com", "987654321", role_worker);
        User user_w3 = CreateUser("w3", "Marek", "Wiosło", "m.wioslo@gmail.com", "+48 312645978", role_worker);
        ModelBuilder.Entity<User>().HasData(user_admin, user_boss, user_w1, user_w2, user_w3);

        #endregion

        #region Permissions

        #region For roles

        ModelBuilder.Entity<Permission>().HasData(
            CreatePermissionForRole(role_admin, AppSource.Roles,                    true, true, true, true),
            CreatePermissionForRole(role_admin, AppSource.Users,                    true, true, true, true),
            CreatePermissionForRole(role_admin, AppSource.Permissions,              true, true, true, true),
            CreatePermissionForRole(role_admin, AppSource.Buildings,                true, true, true, true),
            CreatePermissionForRole(role_admin, AppSource.BuildingAddresses,        true, true, true, true),
            CreatePermissionForRole(role_admin, AppSource.AllInspectionProtocols,   true, true, true, true),
            CreatePermissionForRole(role_admin, AppSource.PersonalProtocols,        true, true, true, true),
            CreatePermissionForRole(role_admin, AppSource.InspectionTasks,          true, true, true, true),
            CreatePermissionForRole(role_admin, AppSource.PropertyManagers,         true, true, true, true),
            CreatePermissionForRole(role_admin, AppSource.RealProperties,           true, true, true, true)
        );

        ModelBuilder.Entity<Permission>().HasData(
            CreatePermissionForRole(role_boss, AppSource.Roles,                     true, true, true, true),
            CreatePermissionForRole(role_boss, AppSource.Users,                     true, true, true, true),
            CreatePermissionForRole(role_boss, AppSource.Permissions,               true, true, true, true),
            CreatePermissionForRole(role_boss, AppSource.Buildings,                 true, true, true, true),
            CreatePermissionForRole(role_boss, AppSource.BuildingAddresses,         true, true, true, true),
            CreatePermissionForRole(role_boss, AppSource.AllInspectionProtocols,    true, true, true, true),
            CreatePermissionForRole(role_boss, AppSource.PersonalProtocols,         true, true, true, true),
            CreatePermissionForRole(role_boss, AppSource.InspectionTasks,           true, true, true, true),
            CreatePermissionForRole(role_boss, AppSource.PropertyManagers,          true, true, true, true),
            CreatePermissionForRole(role_boss, AppSource.RealProperties,            true, true, true, true)
        );

        ModelBuilder.Entity<Permission>().HasData(
            CreatePermissionForRole(role_worker, AppSource.Roles,                   false, false, false, false),
            CreatePermissionForRole(role_worker, AppSource.Users,                   false, false, false, false),
            CreatePermissionForRole(role_worker, AppSource.Permissions,             false, false, false, false),
            CreatePermissionForRole(role_worker, AppSource.Buildings,               false, true, false, false),
            CreatePermissionForRole(role_worker, AppSource.BuildingAddresses,       false, true, false, false),
            CreatePermissionForRole(role_worker, AppSource.AllInspectionProtocols,  false, false, false, false),
            CreatePermissionForRole(role_worker, AppSource.PersonalProtocols,       true, true, true, false),
            CreatePermissionForRole(role_worker, AppSource.InspectionTasks,         false, true, true, false),
            CreatePermissionForRole(role_worker, AppSource.PropertyManagers,        false, true, false, false),
            CreatePermissionForRole(role_worker, AppSource.RealProperties,          false, true, false, false)
        );

        #endregion

        #region For users

        ModelBuilder.Entity<Permission>().HasData(
            CreatePermissionForUser(user_w1, AppSource.Users,                       null, true, null, null),
            CreatePermissionForUser(user_w1, AppSource.PersonalProtocols,           null, null, null, true)
        );

        ModelBuilder.Entity<Permission>().HasData(
            CreatePermissionForUser(user_w2, AppSource.Users,                       null, true, null, null)
        );

        ModelBuilder.Entity<Permission>().HasData(
            CreatePermissionForUser(user_w3, AppSource.Roles,                       null, true, null, null),
            CreatePermissionForUser(user_w3, AppSource.Users,                       null, true, null, null),
            CreatePermissionForUser(user_w3, AppSource.Buildings,                   null, null, true, null),
            CreatePermissionForUser(user_w3, AppSource.BuildingAddresses,           null, null, true, null),
            CreatePermissionForUser(user_w3, AppSource.PersonalProtocols,           null, null, null, true),
            CreatePermissionForUser(user_w3, AppSource.InspectionTasks,             true, null, null, null),
            CreatePermissionForUser(user_w3, AppSource.PropertyManagers,            null, null, true, null),
            CreatePermissionForUser(user_w3, AppSource.RealProperties,              null, null, true, null)
        );

        #endregion

        #endregion


    }

    private static Role CreateRole(string name) 
        => new() { 
            Id = Guid.NewGuid(),
            Name = name 
        };

    private User CreateUser(string login, string? fName, string? lName, string? email, string? pNumber, Role role)
    {
        var user = new User()
        {
            Id = Guid.NewGuid(),
            Login = login,
            FirstName = fName,
            LastName = lName,
            Email = email,
            PhoneNumber = pNumber,
            RoleId = role.Id
        };

        user.Password = _hasher.HashPassword(user, "zaq1@WSX");

        return user;
    }

    private static Permission CreatePermissionForRole(Role role, AppSource source, bool c, bool r, bool u, bool d) 
        => CreatePermission(null, role, source, c, r, u, d);

    private static Permission CreatePermissionForUser(User user, AppSource source, bool? c, bool? r, bool? u, bool? d)
        => CreatePermission(user, null, source, c, r, u, d);

    private static Permission CreatePermission(User? user, Role? role, AppSource source, bool? c, bool? r, bool? u, bool? d) 
        => new() { 
            Id = Guid.NewGuid(),
            Source = source,
            UserId = user?.Id,
            RoleId = role?.Id,
            Create = c,
            Read = r,
            Update = u,
            Delete = d
        };
}
