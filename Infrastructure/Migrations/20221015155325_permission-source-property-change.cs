using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class permissionsourcepropertychange : Migration
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

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Permissions");

            migrationBuilder.AddColumn<string>(
                name: "Source",
                table: "Permissions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1dbe9084-a3b7-4ecf-9f89-5796be332a0a"), "Szef" },
                    { new Guid("361c182c-6824-442d-8214-36ba90246efa"), "Pracownik" },
                    { new Guid("a2201bd4-1d53-42dd-b106-93aab1deb5fb"), "Administrator" },
                    { new Guid("e65302f8-089d-4c33-a95b-09785828b7cb"), "Praktykant" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("0b6ff4c0-7493-4767-9060-a7cc629eb92f"), true, true, true, new Guid("a2201bd4-1d53-42dd-b106-93aab1deb5fb"), "Roles", true, null },
                    { new Guid("337bc030-dd0c-4fb4-aafd-797f8b719617"), false, false, false, new Guid("e65302f8-089d-4c33-a95b-09785828b7cb"), "Roles", false, null },
                    { new Guid("4ac5f063-8392-48e9-8a75-d9b8214aa883"), false, false, false, new Guid("e65302f8-089d-4c33-a95b-09785828b7cb"), "Users", false, null },
                    { new Guid("4cc7a339-e801-4452-9eab-60af79b96222"), true, true, true, new Guid("1dbe9084-a3b7-4ecf-9f89-5796be332a0a"), "Users", true, null },
                    { new Guid("4de9a311-988d-425a-8580-79c216d2909f"), true, true, true, new Guid("1dbe9084-a3b7-4ecf-9f89-5796be332a0a"), "Roles", true, null },
                    { new Guid("950e1a8b-6d98-48fd-b1b7-eb4c04a367dd"), false, false, false, new Guid("361c182c-6824-442d-8214-36ba90246efa"), "Users", false, null },
                    { new Guid("d68fe7ec-1d1d-41be-abf9-9c4a41d37106"), true, true, true, new Guid("a2201bd4-1d53-42dd-b106-93aab1deb5fb"), "Users", true, null },
                    { new Guid("ed401182-1e93-4883-8ac9-299affd76f13"), false, false, false, new Guid("361c182c-6824-442d-8214-36ba90246efa"), "Roles", false, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("067cda45-9a13-4cad-938c-cef764cfac29"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "", "+48 321 654 987", new Guid("361c182c-6824-442d-8214-36ba90246efa") },
                    { new Guid("3b3c4ddc-fd1c-48d6-be2e-622ca35d1a82"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "k.tumiel", "", "123 456 789", new Guid("1dbe9084-a3b7-4ecf-9f89-5796be332a0a") },
                    { new Guid("616ea80b-5f67-4c0d-93be-183f5857c0e5"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "", "987654321", new Guid("361c182c-6824-442d-8214-36ba90246efa") },
                    { new Guid("7e3eb05d-9522-494b-88ba-eb60a57264e8"), "b.smyk@gmail.com", "Bartosz", "Smyk", "a1", "", "213-546-879", new Guid("e65302f8-089d-4c33-a95b-09785828b7cb") },
                    { new Guid("884b2fe1-d24f-4f6b-8d07-27d74d00efe1"), "", "admin", "", "admin", "admin", "", new Guid("a2201bd4-1d53-42dd-b106-93aab1deb5fb") },
                    { new Guid("f5544c36-fafc-4f99-91c9-9bd2625fbe27"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "", "+48 312645978", new Guid("361c182c-6824-442d-8214-36ba90246efa") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[] { new Guid("57012e8d-0a51-4730-96dc-10b771a03d32"), null, null, true, null, "Roles", null, new Guid("616ea80b-5f67-4c0d-93be-183f5857c0e5") });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[] { new Guid("8dae57fd-4cfb-4dfd-91d8-91071998ef30"), null, null, true, null, "Users", null, new Guid("616ea80b-5f67-4c0d-93be-183f5857c0e5") });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[] { new Guid("995db1dc-ddcb-4283-bcac-cc3d573c6104"), null, null, true, null, "Users", true, new Guid("f5544c36-fafc-4f99-91c9-9bd2625fbe27") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0b6ff4c0-7493-4767-9060-a7cc629eb92f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("337bc030-dd0c-4fb4-aafd-797f8b719617"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4ac5f063-8392-48e9-8a75-d9b8214aa883"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4cc7a339-e801-4452-9eab-60af79b96222"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4de9a311-988d-425a-8580-79c216d2909f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("57012e8d-0a51-4730-96dc-10b771a03d32"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8dae57fd-4cfb-4dfd-91d8-91071998ef30"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("950e1a8b-6d98-48fd-b1b7-eb4c04a367dd"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("995db1dc-ddcb-4283-bcac-cc3d573c6104"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d68fe7ec-1d1d-41be-abf9-9c4a41d37106"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ed401182-1e93-4883-8ac9-299affd76f13"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("067cda45-9a13-4cad-938c-cef764cfac29"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3b3c4ddc-fd1c-48d6-be2e-622ca35d1a82"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7e3eb05d-9522-494b-88ba-eb60a57264e8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("884b2fe1-d24f-4f6b-8d07-27d74d00efe1"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1dbe9084-a3b7-4ecf-9f89-5796be332a0a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a2201bd4-1d53-42dd-b106-93aab1deb5fb"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e65302f8-089d-4c33-a95b-09785828b7cb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("616ea80b-5f67-4c0d-93be-183f5857c0e5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f5544c36-fafc-4f99-91c9-9bd2625fbe27"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("361c182c-6824-442d-8214-36ba90246efa"));

            migrationBuilder.DropColumn(
                name: "Source",
                table: "Permissions");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Permissions",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

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
