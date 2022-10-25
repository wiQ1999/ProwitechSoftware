using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class seedsupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
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
                values: new object[] { new Guid("1215a1ea-eed1-47a4-9603-524b83e54296"), "Szef" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("58d4fbd3-3858-4a82-8004-ff271f76345d"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("7f9edc16-0822-4e51-bf25-39a81c222beb"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("3d00c487-4940-42af-80c2-03928e9a09de"), false, false, true, new Guid("58d4fbd3-3858-4a82-8004-ff271f76345d"), "Users", false, null },
                    { new Guid("514037b3-0d45-4fb8-88e7-b5af73963429"), true, true, true, new Guid("1215a1ea-eed1-47a4-9603-524b83e54296"), "Permissions", true, null },
                    { new Guid("7986f059-e01f-4e0f-b299-6c25b144c50f"), false, false, false, new Guid("58d4fbd3-3858-4a82-8004-ff271f76345d"), "Permissions", false, null },
                    { new Guid("a9808a69-a45f-4e0b-b6de-d0dcb56a90a4"), true, true, true, new Guid("7f9edc16-0822-4e51-bf25-39a81c222beb"), "Roles", true, null },
                    { new Guid("c55eaa1b-0ac0-495b-8dc6-7c2382ee78dc"), true, true, true, new Guid("7f9edc16-0822-4e51-bf25-39a81c222beb"), "Users", true, null },
                    { new Guid("c5ed678a-1487-4cce-9ae0-5691ba7b68e5"), true, true, true, new Guid("1215a1ea-eed1-47a4-9603-524b83e54296"), "Roles", true, null },
                    { new Guid("d4398ee5-e046-409e-bd8c-595ef33b16b8"), false, false, true, new Guid("58d4fbd3-3858-4a82-8004-ff271f76345d"), "Roles", false, null },
                    { new Guid("e2fb4b2d-ef05-420e-b016-2e1c4901115f"), true, true, true, new Guid("7f9edc16-0822-4e51-bf25-39a81c222beb"), "Users", true, null },
                    { new Guid("e89ce4c6-2782-4d50-8db8-aa277bee3414"), true, true, true, new Guid("1215a1ea-eed1-47a4-9603-524b83e54296"), "Users", true, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("207392e2-d5ce-463f-8098-4f06dedddeab"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "k.tumiel", "", "123 456 789", new Guid("1215a1ea-eed1-47a4-9603-524b83e54296") },
                    { new Guid("73255fa1-fcff-439d-91b0-3c13b2f4ddaa"), "", "admin", "", "admin", "admin", "", new Guid("7f9edc16-0822-4e51-bf25-39a81c222beb") },
                    { new Guid("749bd581-76a3-40d7-bada-195c2b22ac39"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "", "+48 312645978", new Guid("58d4fbd3-3858-4a82-8004-ff271f76345d") },
                    { new Guid("87a79b24-2f45-4982-a5eb-83dcb0301b0c"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "", "+48 321 654 987", new Guid("58d4fbd3-3858-4a82-8004-ff271f76345d") },
                    { new Guid("dc2c3391-35a4-4d1f-9072-e2025e27696a"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "", "987654321", new Guid("58d4fbd3-3858-4a82-8004-ff271f76345d") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("13ecfc1a-57df-4d29-ba5f-682a99ffe324"), true, null, null, null, "Permissions", true, new Guid("749bd581-76a3-40d7-bada-195c2b22ac39") },
                    { new Guid("b14984d5-5417-4f77-a729-61f4a67bd654"), null, null, false, null, "Users", null, new Guid("dc2c3391-35a4-4d1f-9072-e2025e27696a") },
                    { new Guid("b78d3284-83cf-461c-b726-1c3f0e2aa6ea"), true, true, null, null, "Permissions", true, new Guid("749bd581-76a3-40d7-bada-195c2b22ac39") },
                    { new Guid("e1a92096-c5e3-46d1-9b48-601e2dc0fcbb"), null, null, false, null, "Roles", null, new Guid("dc2c3391-35a4-4d1f-9072-e2025e27696a") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("13ecfc1a-57df-4d29-ba5f-682a99ffe324"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3d00c487-4940-42af-80c2-03928e9a09de"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("514037b3-0d45-4fb8-88e7-b5af73963429"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7986f059-e01f-4e0f-b299-6c25b144c50f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a9808a69-a45f-4e0b-b6de-d0dcb56a90a4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b14984d5-5417-4f77-a729-61f4a67bd654"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b78d3284-83cf-461c-b726-1c3f0e2aa6ea"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c55eaa1b-0ac0-495b-8dc6-7c2382ee78dc"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c5ed678a-1487-4cce-9ae0-5691ba7b68e5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d4398ee5-e046-409e-bd8c-595ef33b16b8"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e1a92096-c5e3-46d1-9b48-601e2dc0fcbb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e2fb4b2d-ef05-420e-b016-2e1c4901115f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e89ce4c6-2782-4d50-8db8-aa277bee3414"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("207392e2-d5ce-463f-8098-4f06dedddeab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("73255fa1-fcff-439d-91b0-3c13b2f4ddaa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("87a79b24-2f45-4982-a5eb-83dcb0301b0c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1215a1ea-eed1-47a4-9603-524b83e54296"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7f9edc16-0822-4e51-bf25-39a81c222beb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("749bd581-76a3-40d7-bada-195c2b22ac39"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc2c3391-35a4-4d1f-9072-e2025e27696a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("58d4fbd3-3858-4a82-8004-ff271f76345d"));

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
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
    }
}
