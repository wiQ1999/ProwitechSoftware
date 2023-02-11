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

        var role_admin = CreateRole("Administrator");
        var role_boss = CreateRole("Szef");
        var role_worker = CreateRole("Pracownik");
        ModelBuilder.Entity<Role>().HasData(role_admin, role_boss, role_worker);

        #endregion

        #region Users

        var user_admin = CreateUser("admin", "admin", "admin", null, null, role_admin);
        var user_boss = CreateUser("boss", "Krzysztof", "Tumiel", "k.tumiel@gmail.com", "123 456 789", role_boss);
        var user_w1 = CreateUser("w1", "Jan", "Kowalski", "j.kowalski@gmail.com", null, role_worker);
        var user_w2 = CreateUser("w2", "Zdzisław", "Piętka", "z.pietka@gmail.com", "987654321", role_worker);
        var user_w3 = CreateUser("w3", "Marek", "Wiosło", "m.wioslo@gmail.com", "+48 312645978", role_worker);
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

        #region BuildingAddresses

        var buildingAddress_ba1 = CreateBuildingAddress("Poznań", "Polna", "20", 16.8960173, 52.4119704, "ROOFTOP", "61-001");
        var buildingAddress_ba2 = CreateBuildingAddress("Poznań", "Szczepanowskiego", "15A", 16.8971863, 52.4172254, "ROOFTOP", "60-541");
        var buildingAddress_ba3 = CreateBuildingAddress("Poznań", "Jana Batorego", "33", 16.9247511, 52.460836, "ROOFTOP", "61-001");
        var buildingAddress_ba4 = CreateBuildingAddress("Poznań", "Polna", "20", null, null, null, "62");
        var buildingAddress_ba5 = CreateBuildingAddress("Poznań", "Smerfowa", "56", 16.8960173, 52.4119704, "ROOFTOP", "61-001");
        var buildingAddress_ba6 = CreateBuildingAddress("Poznań", "Szczepanowskiego", "15B", 16.897134, 52.4174434, "ROOFTOP", "60-541");
        var buildingAddress_ba7 = CreateBuildingAddress("Poznań", "Szczepanowskiego", "4", 16.8975302, 52.4189875, "ROOFTOP", "60-541");
        var buildingAddress_ba8 = CreateBuildingAddress("Poznań", "Jana Batorego", "33", 16.9247511, 52.460836, "ROOFTOP", "61-001");

        ModelBuilder.Entity<BuildingAddress>().HasData(
            buildingAddress_ba1,
            buildingAddress_ba2,
            buildingAddress_ba3,
            buildingAddress_ba4,
            buildingAddress_ba5,
            buildingAddress_ba6,
            buildingAddress_ba7,
            buildingAddress_ba8
        );

        #endregion

        #region PropertyManagers

        var propertyAddress_pa1 = CreatePropertyAddress("4", "2");
        var propertyAddress_pa2 = CreatePropertyAddress("12", null);

        ModelBuilder.Entity<PropertyAddress>().HasData(propertyAddress_pa1, propertyAddress_pa2);

        #endregion

        #region FullAddresses

        var fullAddress_fa1 = CreateFullAddress(buildingAddress_ba1, null);
        var fullAddress_fa2 = CreateFullAddress(buildingAddress_ba2, propertyAddress_pa1);
        var fullAddress_fa3 = CreateFullAddress(buildingAddress_ba3, propertyAddress_pa2);

        ModelBuilder.Entity<FullAddress>().HasData(fullAddress_fa1, fullAddress_fa2, fullAddress_fa3);

        #endregion

        #region PropertyManagers

        var propertyManager_pm1 = CreatePropertyManager("Robert Nowaczyk", "688233245", fullAddress_fa1);
        var propertyManager_pm2 = CreatePropertyManager("Joanna Zabłąńska", "608884221", fullAddress_fa2);
        var propertyManager_pm3 = CreatePropertyManager("Marek Wiosło", "722646194", fullAddress_fa3);

        ModelBuilder.Entity<PropertyManager>().HasData(propertyManager_pm1, propertyManager_pm2, propertyManager_pm3);

        #endregion

        #region Buildings

        var building_b1 = CreateBuilding(buildingAddress_ba4, "JEDNOLOKALOWY", propertyManager_pm1);
        var building_b2 = CreateBuilding(buildingAddress_ba5, "JEDNOLOKALOWY", null);
        var building_b3 = CreateBuilding(buildingAddress_ba6, "WIELOLOKALOWY", propertyManager_pm2);
        var building_b4 = CreateBuilding(buildingAddress_ba7, "WIELOLOKALOWY", propertyManager_pm2);
        var building_b5 = CreateBuilding(buildingAddress_ba8, "WIELOLOKALOWY", propertyManager_pm3);

        ModelBuilder.Entity<Building>().HasData(
            building_b1,
            building_b2,
            building_b3,
            building_b4,
            building_b5
        );

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

    private static PropertyManager CreatePropertyManager(string name, string pNumber, FullAddress? fullAddress)
        => new()
        {
            Id = Guid.NewGuid(),
            Name = name,
            PhoneNumber = pNumber,
            FullAddressId = fullAddress?.Id
        };

    private static FullAddress CreateFullAddress(BuildingAddress bAddress, PropertyAddress? pAddress)
        => new()
        {
            Id = Guid.NewGuid(),
            BuildingAddressId = bAddress.Id,
            PropertyAddressId = pAddress?.Id
        };

    private static BuildingAddress CreateBuildingAddress(string city, string street, string bNumer, double? longitude, double? latitude, string? cType, string? pCode)
        => new()
        {
            Id = Guid.NewGuid(),
            CityName = city,
            StreetName = street,
            BuildingNumber = bNumer,
            Longitude = longitude,
            Latitude = latitude,
            CoordinateType = cType,
            PostalCode = pCode
        };

    private static PropertyAddress CreatePropertyAddress(string? venue, string? staircase)
        => new()
        {
            Id = Guid.NewGuid(),
            VenueNumber = venue,
            StaircaseNumber = staircase
        };

    private static Building CreateBuilding(BuildingAddress bAddress, string type, PropertyManager? pManager)
        => new()
        {
            Id = Guid.NewGuid(),
            BuildingAddressId = bAddress.Id,
            Type = type,
            PropertyManagerId = pManager?.Id
        };
}
