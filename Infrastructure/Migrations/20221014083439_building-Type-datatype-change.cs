using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class buildingTypedatatypechange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Type",
                table: "Buildings",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "Type",
                table: "Buildings",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

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
    }
}
