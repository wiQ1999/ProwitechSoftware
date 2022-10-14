using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class buildingaddresschange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0c812423-8dbf-46ba-bf10-3540f3db0893"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("20597e4f-b8fe-4d38-9027-e28e5253d243"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("42ba9083-58bd-4886-9e93-da74fe9a22a9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("57f3c612-6661-48b8-91d0-a11ee058788f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5b399227-2774-4a53-8816-ab1900892d59"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("85450373-fc8f-4889-8365-9a6d8bf161cd"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("996934de-149c-44fa-ae88-0d156eb35590"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9c9728f0-678f-4a33-aae3-89962488320f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ab922881-e9df-4465-8f7f-573c8b2f412f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c78e868b-4e51-46d0-a931-a3c424ac16c8"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e17f5553-8e0d-43ef-a6b6-0e0489cee633"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5adbbeb9-4c28-4a2b-a75d-af65e9c0d173"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ae06153b-bde6-49c8-991d-f555ee95ccb7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f4db7085-c59e-44a2-83a1-b3fd57e3d2f6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa963995-ead7-4474-beb6-7fcb65db56c0"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("071fabb5-cfd9-421c-8f2f-683fd55e231e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c2ed58e7-2742-4359-a765-88b8df925ff5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("cbd1ceba-b59b-4c2b-9f23-cb7e0e2a06e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("21f9bdee-2114-49dc-9c07-2342bd8a6c79"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f7ed246d-e7db-4ed7-ab38-da8e3bc82cca"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c89bafcd-6d31-4f62-900a-4370e03bff16"));

            migrationBuilder.AlterColumn<string>(
                name: "StreetName",
                table: "BuildingAddresses",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "BuildingAddresses",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CoordinateType",
                table: "BuildingAddresses",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CityName",
                table: "BuildingAddresses",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "BuildingNumber",
                table: "BuildingAddresses",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1b2900a3-32ca-439e-b89e-2d562d1f982d"), "Pracownik" },
                    { new Guid("2437a73f-293e-4c29-b8e0-dc8dff0a1673"), "Szef" },
                    { new Guid("7fb295a8-9b81-4649-a6b5-4a414843cb74"), "Praktykant" },
                    { new Guid("98e5e09f-4f4d-4076-b4b8-23f335cd0205"), "Administrator" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("114183a3-3b33-418d-adba-d1831bdf51b5"), true, true, "Role", true, new Guid("2437a73f-293e-4c29-b8e0-dc8dff0a1673"), true, null },
                    { new Guid("21e61e4e-249b-40f4-9971-65188e70ab47"), false, false, "Użytkownicy", false, new Guid("7fb295a8-9b81-4649-a6b5-4a414843cb74"), false, null },
                    { new Guid("72cef907-1410-48a7-a623-3cf4d0cb33e2"), true, true, "Role", true, new Guid("98e5e09f-4f4d-4076-b4b8-23f335cd0205"), true, null },
                    { new Guid("9285c37b-f3eb-4d69-9541-5bdc450bec4d"), false, false, "Role", false, new Guid("1b2900a3-32ca-439e-b89e-2d562d1f982d"), false, null },
                    { new Guid("b47ad0a8-10ee-4aee-a509-e544e47ced7b"), true, true, "Użytkownicy", true, new Guid("2437a73f-293e-4c29-b8e0-dc8dff0a1673"), true, null },
                    { new Guid("c65cdb65-a414-40bb-9d5e-9c9e01bec012"), true, true, "Użytkownicy", true, new Guid("98e5e09f-4f4d-4076-b4b8-23f335cd0205"), true, null },
                    { new Guid("d22fc7c2-485d-4c8e-94ae-a541468dad17"), false, false, "Role", false, new Guid("7fb295a8-9b81-4649-a6b5-4a414843cb74"), false, null },
                    { new Guid("fbb54224-f1b1-4650-bbd7-decc59b73048"), false, false, "Użytkownicy", false, new Guid("1b2900a3-32ca-439e-b89e-2d562d1f982d"), false, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("09b85e27-5b85-4fb9-8725-4323de14404a"), "", "admin", "", "admin", "admin", "", new Guid("98e5e09f-4f4d-4076-b4b8-23f335cd0205") },
                    { new Guid("3d50d7cf-8e0d-4e85-8e34-fadb38d1ea41"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "", "987654321", new Guid("1b2900a3-32ca-439e-b89e-2d562d1f982d") },
                    { new Guid("72b0214b-748d-4a2a-a3c9-609595f2ec37"), "b.smyk@gmail.com", "Bartosz", "Smyk", "a1", "", "213-546-879", new Guid("7fb295a8-9b81-4649-a6b5-4a414843cb74") },
                    { new Guid("86db0a4d-4164-495f-9eb5-b6043f55585e"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "k.tumiel", "", "123 456 789", new Guid("2437a73f-293e-4c29-b8e0-dc8dff0a1673") },
                    { new Guid("c5fb40f3-1191-49e7-91ec-3fa07471bd8b"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "", "+48 321 654 987", new Guid("1b2900a3-32ca-439e-b89e-2d562d1f982d") },
                    { new Guid("d566f586-0737-4f32-bd51-a2be611dc795"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "", "+48 312645978", new Guid("1b2900a3-32ca-439e-b89e-2d562d1f982d") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[] { new Guid("40995710-42a5-4535-b89b-bc5de6525c43"), null, null, "Użytkownicy", true, null, null, new Guid("3d50d7cf-8e0d-4e85-8e34-fadb38d1ea41") });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[] { new Guid("8b4315d0-46cc-47e3-85eb-f6184ce218f4"), null, null, "Użytkownicy", true, null, true, new Guid("d566f586-0737-4f32-bd51-a2be611dc795") });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[] { new Guid("95304285-578f-45a6-973f-63b7765bed1a"), null, null, "Role", true, null, null, new Guid("3d50d7cf-8e0d-4e85-8e34-fadb38d1ea41") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("114183a3-3b33-418d-adba-d1831bdf51b5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("21e61e4e-249b-40f4-9971-65188e70ab47"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("40995710-42a5-4535-b89b-bc5de6525c43"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("72cef907-1410-48a7-a623-3cf4d0cb33e2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8b4315d0-46cc-47e3-85eb-f6184ce218f4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9285c37b-f3eb-4d69-9541-5bdc450bec4d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("95304285-578f-45a6-973f-63b7765bed1a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b47ad0a8-10ee-4aee-a509-e544e47ced7b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c65cdb65-a414-40bb-9d5e-9c9e01bec012"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d22fc7c2-485d-4c8e-94ae-a541468dad17"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fbb54224-f1b1-4650-bbd7-decc59b73048"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("09b85e27-5b85-4fb9-8725-4323de14404a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("72b0214b-748d-4a2a-a3c9-609595f2ec37"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("86db0a4d-4164-495f-9eb5-b6043f55585e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c5fb40f3-1191-49e7-91ec-3fa07471bd8b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2437a73f-293e-4c29-b8e0-dc8dff0a1673"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7fb295a8-9b81-4649-a6b5-4a414843cb74"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("98e5e09f-4f4d-4076-b4b8-23f335cd0205"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3d50d7cf-8e0d-4e85-8e34-fadb38d1ea41"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d566f586-0737-4f32-bd51-a2be611dc795"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1b2900a3-32ca-439e-b89e-2d562d1f982d"));

            migrationBuilder.AlterColumn<string>(
                name: "StreetName",
                table: "BuildingAddresses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "BuildingAddresses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "CoordinateType",
                table: "BuildingAddresses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "CityName",
                table: "BuildingAddresses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "BuildingNumber",
                table: "BuildingAddresses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("071fabb5-cfd9-421c-8f2f-683fd55e231e"), "Szef" },
                    { new Guid("c2ed58e7-2742-4359-a765-88b8df925ff5"), "Administrator" },
                    { new Guid("c89bafcd-6d31-4f62-900a-4370e03bff16"), "Pracownik" },
                    { new Guid("cbd1ceba-b59b-4c2b-9f23-cb7e0e2a06e4"), "Praktykant" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("0c812423-8dbf-46ba-bf10-3540f3db0893"), true, true, "Użytkownicy", true, new Guid("c2ed58e7-2742-4359-a765-88b8df925ff5"), true, null },
                    { new Guid("20597e4f-b8fe-4d38-9027-e28e5253d243"), false, false, "Użytkownicy", false, new Guid("cbd1ceba-b59b-4c2b-9f23-cb7e0e2a06e4"), false, null },
                    { new Guid("42ba9083-58bd-4886-9e93-da74fe9a22a9"), false, false, "Role", false, new Guid("cbd1ceba-b59b-4c2b-9f23-cb7e0e2a06e4"), false, null },
                    { new Guid("57f3c612-6661-48b8-91d0-a11ee058788f"), true, true, "Użytkownicy", true, new Guid("071fabb5-cfd9-421c-8f2f-683fd55e231e"), true, null },
                    { new Guid("5b399227-2774-4a53-8816-ab1900892d59"), false, false, "Role", false, new Guid("c89bafcd-6d31-4f62-900a-4370e03bff16"), false, null },
                    { new Guid("9c9728f0-678f-4a33-aae3-89962488320f"), true, true, "Role", true, new Guid("c2ed58e7-2742-4359-a765-88b8df925ff5"), true, null },
                    { new Guid("ab922881-e9df-4465-8f7f-573c8b2f412f"), true, true, "Role", true, new Guid("071fabb5-cfd9-421c-8f2f-683fd55e231e"), true, null },
                    { new Guid("c78e868b-4e51-46d0-a931-a3c424ac16c8"), false, false, "Użytkownicy", false, new Guid("c89bafcd-6d31-4f62-900a-4370e03bff16"), false, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("21f9bdee-2114-49dc-9c07-2342bd8a6c79"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "", "+48 312645978", new Guid("c89bafcd-6d31-4f62-900a-4370e03bff16") },
                    { new Guid("5adbbeb9-4c28-4a2b-a75d-af65e9c0d173"), "", "admin", "", "admin", "admin", "", new Guid("c2ed58e7-2742-4359-a765-88b8df925ff5") },
                    { new Guid("ae06153b-bde6-49c8-991d-f555ee95ccb7"), "b.smyk@gmail.com", "Bartosz", "Smyk", "a1", "", "213-546-879", new Guid("cbd1ceba-b59b-4c2b-9f23-cb7e0e2a06e4") },
                    { new Guid("f4db7085-c59e-44a2-83a1-b3fd57e3d2f6"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "", "+48 321 654 987", new Guid("c89bafcd-6d31-4f62-900a-4370e03bff16") },
                    { new Guid("f7ed246d-e7db-4ed7-ab38-da8e3bc82cca"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "", "987654321", new Guid("c89bafcd-6d31-4f62-900a-4370e03bff16") },
                    { new Guid("fa963995-ead7-4474-beb6-7fcb65db56c0"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "k.tumiel", "", "123 456 789", new Guid("071fabb5-cfd9-421c-8f2f-683fd55e231e") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[] { new Guid("85450373-fc8f-4889-8365-9a6d8bf161cd"), null, null, "Użytkownicy", true, null, null, new Guid("f7ed246d-e7db-4ed7-ab38-da8e3bc82cca") });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[] { new Guid("996934de-149c-44fa-ae88-0d156eb35590"), null, null, "Role", true, null, null, new Guid("f7ed246d-e7db-4ed7-ab38-da8e3bc82cca") });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[] { new Guid("e17f5553-8e0d-43ef-a6b6-0e0489cee633"), null, null, "Użytkownicy", true, null, true, new Guid("21f9bdee-2114-49dc-9c07-2342bd8a6c79") });
        }
    }
}
