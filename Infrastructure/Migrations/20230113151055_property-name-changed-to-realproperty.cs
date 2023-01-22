using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class propertynamechangedtorealproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("09d218c6-f2b5-45c9-b423-4e0d748328e1"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0cc6e628-3bb1-458e-aa06-8942257cbbcd"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("35e64eee-de67-4a4a-a4ad-a64e9305bbfb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("385b4aec-0b0d-4cac-8203-bb0c24078a33"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5742c7fd-94bd-4ac4-912f-c8ce46b5bbae"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5e09f7bd-6f96-4dcc-9382-909d55f7cb98"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5edacfc0-d370-4ff6-ad0e-30f0c0b61ab7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b460e062-02b3-44ca-9344-97ddf46ae8b7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c70dc02d-cb2a-4c19-8c60-bb4cf6240954"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d2cfe8d8-4366-44d6-9d64-2edbb0113414"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("daa4764e-e02a-44d0-9421-1374d33dd749"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("dec0e7a9-f1c0-4b5d-a846-8353e4b269e4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e19bfa5b-a187-4fbd-9c16-98665325f0de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("537c41d9-d2b0-4445-8822-12c86a254330"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abc8fccc-314b-423b-b9e6-d782f51430ae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ac12db6f-39fb-485e-b075-bd9474f089be"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("81d07c98-343a-48a2-9452-02627c8a3567"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d50fef84-4ee8-4a62-b7a9-934862d99040"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("23f13fb1-ab2e-40ca-bc41-9de751c039f4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eeee14cf-0f5f-42cb-b002-5201bd5d7078"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("41c24085-b185-4ee2-8199-84eb63b81ae0"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("31275f60-0769-462d-9ed0-582b9e20a46b"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("5a6c522c-c45f-4489-8fea-1fcd0a3b5a2d"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("c0352709-5bf9-4a6a-9238-85e08e764b63"), "Szef" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("07f8d326-fc4a-423f-adaf-a14cf533079e"), true, true, true, new Guid("c0352709-5bf9-4a6a-9238-85e08e764b63"), "Roles", true, null },
                    { new Guid("0d6972dd-6b9b-4b7c-903b-1ff0e457b425"), false, false, false, new Guid("31275f60-0769-462d-9ed0-582b9e20a46b"), "Permissions", false, null },
                    { new Guid("19352bdc-d362-49c4-9db5-a64ecf7a9f21"), false, false, true, new Guid("31275f60-0769-462d-9ed0-582b9e20a46b"), "Users", false, null },
                    { new Guid("428287e2-dc24-4da0-91b0-4f0661fa3b44"), true, true, true, new Guid("c0352709-5bf9-4a6a-9238-85e08e764b63"), "Permissions", true, null },
                    { new Guid("503bf17c-46eb-4b87-8c90-9949d2100c2e"), false, false, true, new Guid("31275f60-0769-462d-9ed0-582b9e20a46b"), "Roles", false, null },
                    { new Guid("66ff4c6a-3d77-4104-b9dd-0666e2707d25"), true, true, true, new Guid("c0352709-5bf9-4a6a-9238-85e08e764b63"), "Users", true, null },
                    { new Guid("6f186ede-972b-491b-9f0c-a1d2b8237746"), true, true, true, new Guid("5a6c522c-c45f-4489-8fea-1fcd0a3b5a2d"), "Permissions", true, null },
                    { new Guid("9b9621f2-370b-4b0c-bf93-e5a6c642a3ee"), true, true, true, new Guid("5a6c522c-c45f-4489-8fea-1fcd0a3b5a2d"), "Roles", true, null },
                    { new Guid("b29130c0-da55-4baa-9042-c4c19ba726f2"), true, true, true, new Guid("5a6c522c-c45f-4489-8fea-1fcd0a3b5a2d"), "Users", true, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("16013e76-428a-4c19-99b5-0434801d71f4"), "", "admin", "", "admin", "admin", "", new Guid("5a6c522c-c45f-4489-8fea-1fcd0a3b5a2d") },
                    { new Guid("66a2806f-a3fd-4618-bf13-51e2cb4d0835"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "", "+48 312645978", new Guid("31275f60-0769-462d-9ed0-582b9e20a46b") },
                    { new Guid("8b776488-324c-4755-b368-505f06d461fd"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "", "+48 321 654 987", new Guid("31275f60-0769-462d-9ed0-582b9e20a46b") },
                    { new Guid("9d5515bd-4843-4bbc-98b4-cf1982b48e1b"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "", "987654321", new Guid("31275f60-0769-462d-9ed0-582b9e20a46b") },
                    { new Guid("a83ea4f0-dfda-46ea-8a2b-b49877c2e675"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "k.tumiel", "", "123 456 789", new Guid("c0352709-5bf9-4a6a-9238-85e08e764b63") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("35c3865b-ab12-430e-a1d8-effdda8b66ea"), null, null, false, null, "Roles", null, new Guid("9d5515bd-4843-4bbc-98b4-cf1982b48e1b") },
                    { new Guid("4d9bc78f-3e03-4202-929a-6b3e12fd36c0"), true, true, null, null, "Users", true, new Guid("66a2806f-a3fd-4618-bf13-51e2cb4d0835") },
                    { new Guid("97a15e2f-5d51-4174-8321-13f0417cf7f6"), true, null, null, null, "Roles", true, new Guid("66a2806f-a3fd-4618-bf13-51e2cb4d0835") },
                    { new Guid("e70a1383-6b2d-426a-96f5-1d801494bd70"), null, null, false, null, "Users", null, new Guid("9d5515bd-4843-4bbc-98b4-cf1982b48e1b") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("07f8d326-fc4a-423f-adaf-a14cf533079e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0d6972dd-6b9b-4b7c-903b-1ff0e457b425"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("19352bdc-d362-49c4-9db5-a64ecf7a9f21"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("35c3865b-ab12-430e-a1d8-effdda8b66ea"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("428287e2-dc24-4da0-91b0-4f0661fa3b44"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4d9bc78f-3e03-4202-929a-6b3e12fd36c0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("503bf17c-46eb-4b87-8c90-9949d2100c2e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("66ff4c6a-3d77-4104-b9dd-0666e2707d25"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6f186ede-972b-491b-9f0c-a1d2b8237746"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("97a15e2f-5d51-4174-8321-13f0417cf7f6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9b9621f2-370b-4b0c-bf93-e5a6c642a3ee"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b29130c0-da55-4baa-9042-c4c19ba726f2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e70a1383-6b2d-426a-96f5-1d801494bd70"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("16013e76-428a-4c19-99b5-0434801d71f4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8b776488-324c-4755-b368-505f06d461fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a83ea4f0-dfda-46ea-8a2b-b49877c2e675"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5a6c522c-c45f-4489-8fea-1fcd0a3b5a2d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c0352709-5bf9-4a6a-9238-85e08e764b63"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66a2806f-a3fd-4618-bf13-51e2cb4d0835"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d5515bd-4843-4bbc-98b4-cf1982b48e1b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("31275f60-0769-462d-9ed0-582b9e20a46b"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("41c24085-b185-4ee2-8199-84eb63b81ae0"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("81d07c98-343a-48a2-9452-02627c8a3567"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("d50fef84-4ee8-4a62-b7a9-934862d99040"), "Szef" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("385b4aec-0b0d-4cac-8203-bb0c24078a33"), false, false, true, new Guid("41c24085-b185-4ee2-8199-84eb63b81ae0"), "Users", false, null },
                    { new Guid("5742c7fd-94bd-4ac4-912f-c8ce46b5bbae"), true, true, true, new Guid("81d07c98-343a-48a2-9452-02627c8a3567"), "Users", true, null },
                    { new Guid("5e09f7bd-6f96-4dcc-9382-909d55f7cb98"), true, true, true, new Guid("d50fef84-4ee8-4a62-b7a9-934862d99040"), "Users", true, null },
                    { new Guid("5edacfc0-d370-4ff6-ad0e-30f0c0b61ab7"), true, true, true, new Guid("81d07c98-343a-48a2-9452-02627c8a3567"), "Permissions", true, null },
                    { new Guid("c70dc02d-cb2a-4c19-8c60-bb4cf6240954"), true, true, true, new Guid("81d07c98-343a-48a2-9452-02627c8a3567"), "Roles", true, null },
                    { new Guid("d2cfe8d8-4366-44d6-9d64-2edbb0113414"), true, true, true, new Guid("d50fef84-4ee8-4a62-b7a9-934862d99040"), "Roles", true, null },
                    { new Guid("daa4764e-e02a-44d0-9421-1374d33dd749"), true, true, true, new Guid("d50fef84-4ee8-4a62-b7a9-934862d99040"), "Permissions", true, null },
                    { new Guid("dec0e7a9-f1c0-4b5d-a846-8353e4b269e4"), false, false, false, new Guid("41c24085-b185-4ee2-8199-84eb63b81ae0"), "Permissions", false, null },
                    { new Guid("e19bfa5b-a187-4fbd-9c16-98665325f0de"), false, false, true, new Guid("41c24085-b185-4ee2-8199-84eb63b81ae0"), "Roles", false, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("23f13fb1-ab2e-40ca-bc41-9de751c039f4"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "", "987654321", new Guid("41c24085-b185-4ee2-8199-84eb63b81ae0") },
                    { new Guid("537c41d9-d2b0-4445-8822-12c86a254330"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "k.tumiel", "", "123 456 789", new Guid("d50fef84-4ee8-4a62-b7a9-934862d99040") },
                    { new Guid("abc8fccc-314b-423b-b9e6-d782f51430ae"), "", "admin", "", "admin", "admin", "", new Guid("81d07c98-343a-48a2-9452-02627c8a3567") },
                    { new Guid("ac12db6f-39fb-485e-b075-bd9474f089be"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "", "+48 321 654 987", new Guid("41c24085-b185-4ee2-8199-84eb63b81ae0") },
                    { new Guid("eeee14cf-0f5f-42cb-b002-5201bd5d7078"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "", "+48 312645978", new Guid("41c24085-b185-4ee2-8199-84eb63b81ae0") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("09d218c6-f2b5-45c9-b423-4e0d748328e1"), true, null, null, null, "Roles", true, new Guid("eeee14cf-0f5f-42cb-b002-5201bd5d7078") },
                    { new Guid("0cc6e628-3bb1-458e-aa06-8942257cbbcd"), true, true, null, null, "Users", true, new Guid("eeee14cf-0f5f-42cb-b002-5201bd5d7078") },
                    { new Guid("35e64eee-de67-4a4a-a4ad-a64e9305bbfb"), null, null, false, null, "Roles", null, new Guid("23f13fb1-ab2e-40ca-bc41-9de751c039f4") },
                    { new Guid("b460e062-02b3-44ca-9344-97ddf46ae8b7"), null, null, false, null, "Users", null, new Guid("23f13fb1-ab2e-40ca-bc41-9de751c039f4") }
                });
        }
    }
}
