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


        Permission bossRole_BuildingAddresses = CreatePermissionForRole(bossRole, AppSource.BuildingAddresses, true, true, true, true);
        Permission bossRole_Buildings = CreatePermissionForRole(bossRole, AppSource.Buildings, true, true, true, true);
        Permission bossRole_AllInspectionProtocols = CreatePermissionForRole(bossRole, AppSource.AllInspectionProtocols, true, true, true, true);
        Permission bossRole_PersonalInspectionProtocols = CreatePermissionForRole(bossRole, AppSource.PersonalProtocols, true, true, true, true);
        Permission bossRole_InspectionTasks = CreatePermissionForRole(bossRole, AppSource.InspectionTasks, true, true, true, true);
        Permission bossRole_Permissions = CreatePermissionForRole(bossRole, AppSource.Permissions, true, true, true, true);
        Permission bossRole_PropertyManagers = CreatePermissionForRole(bossRole, AppSource.PropertyManagers, true, true, true, true);
        Permission bossRole_RealProperties = CreatePermissionForRole(bossRole, AppSource.RealProperties, true, true, true, true);
        Permission bossRole_Roles = CreatePermissionForRole(bossRole, AppSource.Roles, true, true, true, true);
        Permission bossRole_Users = CreatePermissionForRole(bossRole, AppSource.Users, true, true, true, true);
       
        ModelBuilder.Entity<Permission>().HasData
            (bossRole_Roles, bossRole_Users, bossRole_Permissions, bossRole_Buildings, bossRole_RealProperties,
            bossRole_BuildingAddresses, bossRole_PropertyManagers, bossRole_InspectionTasks, bossRole_AllInspectionProtocols, bossRole_PersonalInspectionProtocols);
        
        Permission workerRole_InspectionTasks = CreatePermissionForRole(workerRole, AppSource.InspectionTasks, false, true, true, false);
        Permission workerRole_PersonalInspectionProtocols = CreatePermissionForRole(workerRole, AppSource.PersonalProtocols, true, true, true, true);


        ModelBuilder.Entity<Permission>().HasData(workerRole_InspectionTasks, workerRole_PersonalInspectionProtocols);

        #endregion

        #region For users

        Permission worker1_BuildingAddresses = CreatePermissionForUser(worker1, AppSource.BuildingAddresses, false, true, false, false);
        Permission worker1_Buildings = CreatePermissionForUser(worker1, AppSource.Buildings, false, true, false, false);
        Permission worker1_PersonalProtocols = CreatePermissionForUser(worker1, AppSource.PersonalProtocols, true, true, true, true);
        Permission worker1_InspectionTasks = CreatePermissionForUser(worker1, AppSource.InspectionTasks, false, true, true, false);
        Permission worker1_PropertyManagers = CreatePermissionForUser(worker1, AppSource.PropertyManagers, false, true, false, false);
        Permission worker1_RealProperties = CreatePermissionForUser(worker1, AppSource.RealProperties, false, true, false, false);
        Permission worker1_Users = CreatePermissionForUser(worker1, AppSource.Users, false, true, false, false);

        Permission worker2_BuildingAddresses = CreatePermissionForUser(worker2, AppSource.BuildingAddresses, false, true, false, false);
        Permission worker2_Buildings = CreatePermissionForUser(worker2, AppSource.Buildings, false, true, false, false);
        Permission worker2_PersonalProtocols = CreatePermissionForUser(worker2, AppSource.PersonalProtocols, true,true,true,true);
        Permission worker2_InspectionTasks = CreatePermissionForUser(worker2, AppSource.InspectionTasks, false,true,true,false);
        Permission worker2_PropertyManagers = CreatePermissionForUser(worker2, AppSource.PropertyManagers, false,true,false,false);
        Permission worker2_RealProperties = CreatePermissionForUser(worker2, AppSource.RealProperties, false,true,false,false);
        Permission worker2_Users = CreatePermissionForUser(worker2, AppSource.Users, false,true,false,false);

        Permission worker3_BuildingAddresses = CreatePermissionForUser(worker3, AppSource.BuildingAddresses, false, true, false, false);
        Permission worker3_Buildings = CreatePermissionForUser(worker3, AppSource.Buildings, false, true, false, false);
        Permission worker3_PersonalProtocols = CreatePermissionForUser(worker3, AppSource.PersonalProtocols, true, true, true, true);
        Permission worker3_InspectionTasks = CreatePermissionForUser(worker3, AppSource.InspectionTasks, false, true, true, false);
        Permission worker3_PropertyManagers = CreatePermissionForUser(worker3, AppSource.PropertyManagers, false, true, false, false);
        Permission worker3_RealProperties = CreatePermissionForUser(worker3, AppSource.RealProperties, false, true, false, false);
        Permission worker3_Users = CreatePermissionForUser(worker3, AppSource.Users, false, true, false, false);

        ModelBuilder.Entity<Permission>().HasData
            (worker1_BuildingAddresses, worker1_Buildings, worker1_PersonalProtocols, worker1_InspectionTasks, worker1_PropertyManagers, worker1_RealProperties, worker1_Users,
            worker2_BuildingAddresses, worker2_Buildings, worker2_PersonalProtocols, worker2_InspectionTasks, worker2_PropertyManagers, worker2_RealProperties, worker2_Users,
            worker3_BuildingAddresses, worker3_Buildings, worker3_PersonalProtocols, worker3_InspectionTasks, worker3_PropertyManagers, worker3_RealProperties, worker3_Users);




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
