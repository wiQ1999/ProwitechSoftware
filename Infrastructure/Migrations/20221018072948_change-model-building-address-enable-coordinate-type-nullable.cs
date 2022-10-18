using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class changemodelbuildingaddressenablecoordinatetypenullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("03d7ebcd-5c1e-470f-99af-25fc7752f961"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2a7af6cc-8b1e-4174-a898-1cbf81514dee"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("462f9d6c-f158-4631-85da-756ca63b6dba"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("575d8780-a9ca-469c-b5db-5bde541ffd89"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("67267050-95fa-412f-8073-6c59a71cbb04"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7c489163-3e1e-4ce9-91c5-5598f91d5659"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("884b2dc9-31d6-45ec-ab15-5df473a03f02"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8c19ffbb-3ea8-4f33-a52f-85d32d8490b0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d44e1c8f-aa5c-4a1e-9f52-7b5937e6b46c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fe538eaf-b824-47b1-8812-777a35db7b9e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ff66a961-9bfa-4e4f-a790-78b014bc7e56"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3eb0198e-3df4-4b8d-95a9-abf6717cd0a6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5dd876b4-159c-4b18-882a-70c009ce405e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d663947-66b3-49e0-b348-74c34f9088fa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c76cdbfd-c9ed-479e-b91e-cdfade34b4f4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1b837d43-d5f7-49ac-8afe-72e1cf4cd62d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d6e05889-051d-4e7b-aeff-41bbc0292ee2"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e1988d9c-f870-4515-8310-eb795d35d2d1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f5b9b10-50bd-4fa1-9873-3e8adf531779"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5af4876-5676-4542-ba82-5ad055de0a4a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2fed8b26-1b4b-4361-a87d-2e888655e7a0"));

            migrationBuilder.AlterColumn<string>(
                name: "CoordinateType",
                table: "BuildingAddresses",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1c3888ae-ed0f-4e11-a472-73449714767e"), "Pracownik" },
                    { new Guid("2d41aac4-12fa-483e-a0c7-84f79b647e9c"), "Administrator" },
                    { new Guid("54259fa6-5831-4d22-a7c0-bfd47b97e409"), "Szef" },
                    { new Guid("963de526-f5c9-4390-b960-29bd519b0f3c"), "Praktykant" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("229b7178-2f0e-41cb-903a-d8767201a55b"), true, true, "Użytkownicy", true, new Guid("54259fa6-5831-4d22-a7c0-bfd47b97e409"), true, null },
                    { new Guid("69b13991-6e6b-4a91-9710-a8630d09f1ae"), true, true, "Role", true, new Guid("2d41aac4-12fa-483e-a0c7-84f79b647e9c"), true, null },
                    { new Guid("83bf0ae7-99a9-46af-aef5-014502ac384b"), true, true, "Role", true, new Guid("54259fa6-5831-4d22-a7c0-bfd47b97e409"), true, null },
                    { new Guid("84f61f91-c239-4f57-a9a9-0616924b5ef6"), false, false, "Użytkownicy", false, new Guid("1c3888ae-ed0f-4e11-a472-73449714767e"), false, null },
                    { new Guid("b4852d4a-cb14-4105-9ce3-404aa0d68015"), false, false, "Role", false, new Guid("963de526-f5c9-4390-b960-29bd519b0f3c"), false, null },
                    { new Guid("dcea27ab-846d-4cd4-be58-bf0911daf69f"), true, true, "Użytkownicy", true, new Guid("2d41aac4-12fa-483e-a0c7-84f79b647e9c"), true, null },
                    { new Guid("e6edee5f-e103-4915-b438-c7ef709e1dcf"), false, false, "Użytkownicy", false, new Guid("963de526-f5c9-4390-b960-29bd519b0f3c"), false, null },
                    { new Guid("e8423c77-40c1-457d-985a-32e60d30d517"), false, false, "Role", false, new Guid("1c3888ae-ed0f-4e11-a472-73449714767e"), false, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("08296208-7e1f-4717-9465-8ed211078b44"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "", "987654321", new Guid("1c3888ae-ed0f-4e11-a472-73449714767e") },
                    { new Guid("28fc32af-8687-4d08-b84b-40673032865f"), "", "admin", "", "admin", "admin", "", new Guid("2d41aac4-12fa-483e-a0c7-84f79b647e9c") },
                    { new Guid("79dd043d-339f-4bca-832a-09efc1e1be4f"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "", "+48 312645978", new Guid("1c3888ae-ed0f-4e11-a472-73449714767e") },
                    { new Guid("84714bdf-6372-415f-bfca-46e71cb1548e"), "b.smyk@gmail.com", "Bartosz", "Smyk", "a1", "", "213-546-879", new Guid("963de526-f5c9-4390-b960-29bd519b0f3c") },
                    { new Guid("e8b93ff6-fb2e-405a-b672-10de5132b966"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "", "+48 321 654 987", new Guid("1c3888ae-ed0f-4e11-a472-73449714767e") },
                    { new Guid("ef95dac5-0b0d-431b-81cf-2514e2e57f79"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "k.tumiel", "", "123 456 789", new Guid("54259fa6-5831-4d22-a7c0-bfd47b97e409") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[] { new Guid("1d448260-1841-4c16-89de-9ce6a354fe55"), null, null, "Użytkownicy", true, null, null, new Guid("08296208-7e1f-4717-9465-8ed211078b44") });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[] { new Guid("90a9a755-a25b-4791-ba0e-215c28223119"), null, null, "Role", true, null, null, new Guid("08296208-7e1f-4717-9465-8ed211078b44") });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[] { new Guid("dd49f27b-bd7e-49c9-80ca-eb2cd4497e11"), null, null, "Użytkownicy", true, null, true, new Guid("79dd043d-339f-4bca-832a-09efc1e1be4f") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1d448260-1841-4c16-89de-9ce6a354fe55"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("229b7178-2f0e-41cb-903a-d8767201a55b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("69b13991-6e6b-4a91-9710-a8630d09f1ae"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("83bf0ae7-99a9-46af-aef5-014502ac384b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("84f61f91-c239-4f57-a9a9-0616924b5ef6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("90a9a755-a25b-4791-ba0e-215c28223119"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b4852d4a-cb14-4105-9ce3-404aa0d68015"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("dcea27ab-846d-4cd4-be58-bf0911daf69f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("dd49f27b-bd7e-49c9-80ca-eb2cd4497e11"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e6edee5f-e103-4915-b438-c7ef709e1dcf"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e8423c77-40c1-457d-985a-32e60d30d517"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("28fc32af-8687-4d08-b84b-40673032865f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84714bdf-6372-415f-bfca-46e71cb1548e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e8b93ff6-fb2e-405a-b672-10de5132b966"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ef95dac5-0b0d-431b-81cf-2514e2e57f79"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2d41aac4-12fa-483e-a0c7-84f79b647e9c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("54259fa6-5831-4d22-a7c0-bfd47b97e409"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("963de526-f5c9-4390-b960-29bd519b0f3c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("08296208-7e1f-4717-9465-8ed211078b44"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("79dd043d-339f-4bca-832a-09efc1e1be4f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c3888ae-ed0f-4e11-a472-73449714767e"));

            migrationBuilder.AlterColumn<string>(
                name: "CoordinateType",
                table: "BuildingAddresses",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1b837d43-d5f7-49ac-8afe-72e1cf4cd62d"), "Szef" },
                    { new Guid("2fed8b26-1b4b-4361-a87d-2e888655e7a0"), "Pracownik" },
                    { new Guid("d6e05889-051d-4e7b-aeff-41bbc0292ee2"), "Praktykant" },
                    { new Guid("e1988d9c-f870-4515-8310-eb795d35d2d1"), "Administrator" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("03d7ebcd-5c1e-470f-99af-25fc7752f961"), true, true, "Role", true, new Guid("e1988d9c-f870-4515-8310-eb795d35d2d1"), true, null },
                    { new Guid("2a7af6cc-8b1e-4174-a898-1cbf81514dee"), false, false, "Role", false, new Guid("d6e05889-051d-4e7b-aeff-41bbc0292ee2"), false, null },
                    { new Guid("462f9d6c-f158-4631-85da-756ca63b6dba"), true, true, "Role", true, new Guid("1b837d43-d5f7-49ac-8afe-72e1cf4cd62d"), true, null },
                    { new Guid("575d8780-a9ca-469c-b5db-5bde541ffd89"), false, false, "Użytkownicy", false, new Guid("d6e05889-051d-4e7b-aeff-41bbc0292ee2"), false, null },
                    { new Guid("67267050-95fa-412f-8073-6c59a71cbb04"), false, false, "Użytkownicy", false, new Guid("2fed8b26-1b4b-4361-a87d-2e888655e7a0"), false, null },
                    { new Guid("884b2dc9-31d6-45ec-ab15-5df473a03f02"), true, true, "Użytkownicy", true, new Guid("1b837d43-d5f7-49ac-8afe-72e1cf4cd62d"), true, null },
                    { new Guid("d44e1c8f-aa5c-4a1e-9f52-7b5937e6b46c"), true, true, "Użytkownicy", true, new Guid("e1988d9c-f870-4515-8310-eb795d35d2d1"), true, null },
                    { new Guid("ff66a961-9bfa-4e4f-a790-78b014bc7e56"), false, false, "Role", false, new Guid("2fed8b26-1b4b-4361-a87d-2e888655e7a0"), false, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("0f5b9b10-50bd-4fa1-9873-3e8adf531779"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "", "987654321", new Guid("2fed8b26-1b4b-4361-a87d-2e888655e7a0") },
                    { new Guid("3eb0198e-3df4-4b8d-95a9-abf6717cd0a6"), "", "admin", "", "admin", "admin", "", new Guid("e1988d9c-f870-4515-8310-eb795d35d2d1") },
                    { new Guid("5dd876b4-159c-4b18-882a-70c009ce405e"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "", "+48 321 654 987", new Guid("2fed8b26-1b4b-4361-a87d-2e888655e7a0") },
                    { new Guid("9d663947-66b3-49e0-b348-74c34f9088fa"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "k.tumiel", "", "123 456 789", new Guid("1b837d43-d5f7-49ac-8afe-72e1cf4cd62d") },
                    { new Guid("c76cdbfd-c9ed-479e-b91e-cdfade34b4f4"), "b.smyk@gmail.com", "Bartosz", "Smyk", "a1", "", "213-546-879", new Guid("d6e05889-051d-4e7b-aeff-41bbc0292ee2") },
                    { new Guid("d5af4876-5676-4542-ba82-5ad055de0a4a"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "", "+48 312645978", new Guid("2fed8b26-1b4b-4361-a87d-2e888655e7a0") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[] { new Guid("7c489163-3e1e-4ce9-91c5-5598f91d5659"), null, null, "Użytkownicy", true, null, null, new Guid("0f5b9b10-50bd-4fa1-9873-3e8adf531779") });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[] { new Guid("8c19ffbb-3ea8-4f33-a52f-85d32d8490b0"), null, null, "Role", true, null, null, new Guid("0f5b9b10-50bd-4fa1-9873-3e8adf531779") });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[] { new Guid("fe538eaf-b824-47b1-8812-777a35db7b9e"), null, null, "Użytkownicy", true, null, true, new Guid("d5af4876-5676-4542-ba82-5ad055de0a4a") });
        }
    }
}
