using Infrastructure.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database;
public class DataSeeder
{
    public ModelBuilder ModelBuilder { get; }

    public DataSeeder(ModelBuilder modelBuilder)
    {
        ModelBuilder = modelBuilder;
    }
    
    public void Seed()
    {
        Role adminRole = CreateRole("Administrator");
        Role bossRole = CreateRole("Szef");
        Role workerRole = CreateRole("Pracownik");
        Role apprenticeRole = CreateRole("Praktykant");
        ModelBuilder.Entity<Role>().HasData(adminRole, bossRole, workerRole, apprenticeRole);

        User admin = CreateUser("admin", "admin", "admin", string.Empty, string.Empty, string.Empty, adminRole);
        User boss = CreateUser("k.tumiel", string.Empty, "Krzysztof", "Tumiel", "k.tumiel@gmail.com", "123 456 789", bossRole);
        User worker1 = CreateUser("w1", string.Empty, "Jan", "Kowalski", "j.kowalski@gmail.com", "+48 321 654 987", workerRole);
        User worker2 = CreateUser("w2", string.Empty, "Zdzisław", "Piętka", "z.pietka@gmail.com", "987654321", workerRole);
        User worker3 = CreateUser("w3", string.Empty, "Marek", "Wiosło", "m.wioslo@gmail.com", "+48 312645978", workerRole);
        User apprentice1 = CreateUser("a1", string.Empty, "Bartosz", "Smyk", "b.smyk@gmail.com", "213-546-879", apprenticeRole);
        ModelBuilder.Entity<User>().HasData(admin, boss, worker1, worker2, worker3, apprentice1);

        Permission adminR_Roles = CreatePermission("Role", null, adminRole, true, true, true, true);
        Permission adminR_Users = CreatePermission("Użytkownicy", null, adminRole, true, true, true, true);
        Permission bossR_Roles = CreatePermission("Role", null, bossRole, true, true, true, true);
        Permission bossR_Users = CreatePermission("Użytkownicy", null, bossRole, true, true, true, true);
        Permission workerR_Roles = CreatePermission("Role", null, workerRole, false, false, false, false);
        Permission workerR_Users = CreatePermission("Użytkownicy", null, workerRole, false, false, false, false);
        Permission apprenticeR_Roles = CreatePermission("Role", null, apprenticeRole, false, false, false, false);
        Permission apprenticeR_Users = CreatePermission("Użytkownicy", null, apprenticeRole, false, false, false, false);
        Permission worker2Roles = CreatePermission("Role", worker2, null, null, true, null, null);
        Permission worker2Users = CreatePermission("Użytkownicy", worker2, null, null, true, null, null);
        Permission worker3Users = CreatePermission("Użytkownicy", worker3, null, null, true, true, null);
        ModelBuilder.Entity<Permission>().HasData(
            adminR_Roles, adminR_Users, bossR_Roles, bossR_Users,
            workerR_Roles, workerR_Users, apprenticeR_Roles, apprenticeR_Users,
            worker2Roles, worker2Users, worker3Users);
    }

    private Role CreateRole(string name) => new() { 
            Id = Guid.NewGuid(),
            Name = name 
        };

    private User CreateUser(string login, string pwd, string fName, string lName, 
        string email, string pNumber, Role role) => new() { 
            Id = Guid.NewGuid(), 
            Login = login, 
            Password = pwd, 
            FirstName = fName,
            LastName = lName,
            Email = email,
            PhoneNumber = pNumber,
            RoleId = role.Id
        };

    private Permission CreatePermission(string name, User? user, Role? role,
        bool? c, bool? r, bool? u, bool? d) => new() { 
            Id = Guid.NewGuid(),
            Name = name,
            UserId = user?.Id,
            RoleId = role?.Id,
            Create = c,
            Read = r,
            Update = u,
            Delete = d
        };
}
