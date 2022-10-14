using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class configurationapply : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("191a7acb-bee5-40c7-805b-8d813dfda265"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("253be0a4-8f38-49f9-be20-362f9806d40c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("61ad85dc-f495-419d-9bff-ff46f897d2f8"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("855265cc-0887-4b9e-ab2b-8239cdefab48"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b5db05dd-c607-41d4-9dac-e6f463dab46c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("bcaff8ba-afe5-4d46-b540-d011351439a2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d37b1d39-8431-4b47-ae0b-593d4cc9ee6f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("dff298e8-fd94-4a58-95ce-0a16ea529ca5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ed3a2cae-5ce3-47db-9c0d-e75345c3a202"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f04a1de7-a49f-4410-9ea6-dc71cff241d5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fb74ae84-f8d5-4e6b-a28f-981d9c4ee2fb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("203fb05b-4b7e-43c4-ad29-5f4d261dedbe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("34dbe071-d81d-4473-b0f1-a800f27cf0fa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3b79b22b-f943-494e-90d3-a965a346dd0a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b8c2b72f-8b17-4a74-a470-43a99b88c454"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("05d0d043-4b0d-440a-a45c-81b29485789c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ae317b3c-060d-4f09-a718-91f835f582d2"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bf9f7408-9db4-4a82-ad6f-e52848e81132"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c1462b14-a4ee-4f81-931e-e1d315b80608"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cd09194b-1b43-4837-8286-8e1b381919a3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b9bb8930-0c9d-47ed-84ec-15b36d794a8d"));

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Login",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Roles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Permissions",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
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

            migrationBuilder.CreateIndex(
                name: "IX_Users_Login",
                table: "Users",
                column: "Login",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Name",
                table: "Roles",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Login",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Roles_Name",
                table: "Roles");

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
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Login",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Permissions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("05d0d043-4b0d-440a-a45c-81b29485789c"), "Szef" },
                    { new Guid("ae317b3c-060d-4f09-a718-91f835f582d2"), "Praktykant" },
                    { new Guid("b9bb8930-0c9d-47ed-84ec-15b36d794a8d"), "Pracownik" },
                    { new Guid("bf9f7408-9db4-4a82-ad6f-e52848e81132"), "Administrator" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("191a7acb-bee5-40c7-805b-8d813dfda265"), false, false, "Role", false, new Guid("b9bb8930-0c9d-47ed-84ec-15b36d794a8d"), false, null },
                    { new Guid("61ad85dc-f495-419d-9bff-ff46f897d2f8"), true, true, "Role", true, new Guid("05d0d043-4b0d-440a-a45c-81b29485789c"), true, null },
                    { new Guid("b5db05dd-c607-41d4-9dac-e6f463dab46c"), true, true, "Użytkownicy", true, new Guid("05d0d043-4b0d-440a-a45c-81b29485789c"), true, null },
                    { new Guid("bcaff8ba-afe5-4d46-b540-d011351439a2"), false, false, "Role", false, new Guid("ae317b3c-060d-4f09-a718-91f835f582d2"), false, null },
                    { new Guid("d37b1d39-8431-4b47-ae0b-593d4cc9ee6f"), false, false, "Użytkownicy", false, new Guid("b9bb8930-0c9d-47ed-84ec-15b36d794a8d"), false, null },
                    { new Guid("dff298e8-fd94-4a58-95ce-0a16ea529ca5"), true, true, "Użytkownicy", true, new Guid("bf9f7408-9db4-4a82-ad6f-e52848e81132"), true, null },
                    { new Guid("ed3a2cae-5ce3-47db-9c0d-e75345c3a202"), false, false, "Użytkownicy", false, new Guid("ae317b3c-060d-4f09-a718-91f835f582d2"), false, null },
                    { new Guid("fb74ae84-f8d5-4e6b-a28f-981d9c4ee2fb"), true, true, "Role", true, new Guid("bf9f7408-9db4-4a82-ad6f-e52848e81132"), true, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("203fb05b-4b7e-43c4-ad29-5f4d261dedbe"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "", "+48 321 654 987", new Guid("b9bb8930-0c9d-47ed-84ec-15b36d794a8d") },
                    { new Guid("34dbe071-d81d-4473-b0f1-a800f27cf0fa"), "", "admin", "", "admin", "admin", "", new Guid("bf9f7408-9db4-4a82-ad6f-e52848e81132") },
                    { new Guid("3b79b22b-f943-494e-90d3-a965a346dd0a"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "k.tumiel", "", "123 456 789", new Guid("05d0d043-4b0d-440a-a45c-81b29485789c") },
                    { new Guid("b8c2b72f-8b17-4a74-a470-43a99b88c454"), "b.smyk@gmail.com", "Bartosz", "Smyk", "a1", "", "213-546-879", new Guid("ae317b3c-060d-4f09-a718-91f835f582d2") },
                    { new Guid("c1462b14-a4ee-4f81-931e-e1d315b80608"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "", "987654321", new Guid("b9bb8930-0c9d-47ed-84ec-15b36d794a8d") },
                    { new Guid("cd09194b-1b43-4837-8286-8e1b381919a3"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "", "+48 312645978", new Guid("b9bb8930-0c9d-47ed-84ec-15b36d794a8d") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[] { new Guid("253be0a4-8f38-49f9-be20-362f9806d40c"), null, null, "Użytkownicy", true, null, true, new Guid("cd09194b-1b43-4837-8286-8e1b381919a3") });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[] { new Guid("855265cc-0887-4b9e-ab2b-8239cdefab48"), null, null, "Role", true, null, null, new Guid("c1462b14-a4ee-4f81-931e-e1d315b80608") });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[] { new Guid("f04a1de7-a49f-4410-9ea6-dc71cff241d5"), null, null, "Użytkownicy", true, null, null, new Guid("c1462b14-a4ee-4f81-931e-e1d315b80608") });
        }
    }
}
