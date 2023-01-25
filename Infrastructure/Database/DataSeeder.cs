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

        Role adminRole = CreateRole("Administrator");
        Role bossRole = CreateRole("Szef");
        Role workerRole = CreateRole("Pracownik");
        ModelBuilder.Entity<Role>().HasData(adminRole, bossRole, workerRole);

        #endregion

        #region Users

        User admin = CreateUser("admin", "admin", string.Empty, string.Empty, string.Empty, adminRole);
        User boss = CreateUser("boss", "Krzysztof", "Tumiel", "k.tumiel@gmail.com", "123 456 789", bossRole);
        User worker1 = CreateUser("w1", "Jan", "Kowalski", "j.kowalski@gmail.com", "+48 321 654 987", workerRole);
        User worker2 = CreateUser("w2", "Zdzisław", "Piętka", "z.pietka@gmail.com", "987654321", workerRole);
        User worker3 = CreateUser("w3", "Marek", "Wiosło", "m.wioslo@gmail.com", "+48 312645978", workerRole);
        ModelBuilder.Entity<User>().HasData(admin, boss, worker1, worker2, worker3);

        #endregion

        #region Permissions

        #region For roles

        Permission adminRole_Roles = CreatePermissionForRole(adminRole, AppSource.Roles, true, true, true, true);
        Permission adminRole_Users = CreatePermissionForRole(adminRole, AppSource.Users, true, true, true, true);
        Permission adminRole_Permissions = CreatePermissionForRole(adminRole, AppSource.Permissions, true, true, true, true);
        ModelBuilder.Entity<Permission>().HasData(adminRole_Roles, adminRole_Users, adminRole_Permissions);

        Permission bossRole_Roles = CreatePermissionForRole(bossRole, AppSource.Roles, true, true, true, true);
        Permission bossRole_Users = CreatePermissionForRole(bossRole, AppSource.Users, true, true, true, true);
        Permission bossRole_Permissions = CreatePermissionForRole(bossRole, AppSource.Permissions, true, true, true, true);
        Permission bossRole_Buildings = CreatePermissionForRole(bossRole, AppSource.Buildings, true, true, true, true);
        Permission bossRole_PropertyManagers = CreatePermissionForRole(bossRole, AppSource.PropertyManagers, true, true, true, true);
        Permission bossRole_InspectionTasks = CreatePermissionForRole(bossRole, AppSource.InspectionTasks, true, true, true, true);
        Permission bossRole_InspectionProtocols = CreatePermissionForRole(bossRole, AppSource.InspectionProtocols, true, true, true, true);
        ModelBuilder.Entity<Permission>().HasData
            (bossRole_Roles, bossRole_Users, bossRole_Permissions, bossRole_Buildings, bossRole_PropertyManagers, bossRole_InspectionTasks, bossRole_InspectionProtocols);

        Permission workerRole_Roles = CreatePermissionForRole(workerRole, AppSource.Roles, false, true, false, false);
        Permission workerRole_Users = CreatePermissionForRole(workerRole, AppSource.Users, false, true, false, false);
        Permission workerRole_Permissions = CreatePermissionForRole(workerRole, AppSource.Permissions, false, false, false, false);
        ModelBuilder.Entity<Permission>().HasData(workerRole_Roles, workerRole_Users, workerRole_Permissions);

        #endregion

        #region For users

        Permission worker2_Roles = CreatePermissionForUser(worker2, AppSource.Roles, null, false, null, null);
        Permission worker2_Users = CreatePermissionForUser(worker2, AppSource.Users, null, false, null, null);
        Permission worker3U_Roles = CreatePermissionForUser(worker3, AppSource.Roles, true, null, true, null);
        Permission worker3U_Users = CreatePermissionForUser(worker3, AppSource.Users, true, null, true, true);
        ModelBuilder.Entity<Permission>().HasData(worker2_Roles, worker2_Users, worker3U_Roles, worker3U_Users);

        #endregion

        #endregion
    }

    private static Role CreateRole(string name) 
        => new() { 
            Id = Guid.NewGuid(),
            Name = name 
        };

    private User CreateUser(string login, string fName, string lName, string email, string pNumber, Role role)
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

    private static Permission CreatePermissionForRole(Role? role, AppSource source, bool? c, bool? r, bool? u, bool? d) 
        => CreatePermission(null, role, source, c, r, u, d);

    private static Permission CreatePermissionForUser(User? user, AppSource source, bool? c, bool? r, bool? u, bool? d)
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
