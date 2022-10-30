using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class fixpermissionsseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("39ee58d1-93f3-46d2-97c5-2f0ea65e1954"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("460852c4-c5b2-436a-9551-5baabcbcf469"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5f9adb48-beee-43b7-a171-0bdbbd3a69cd"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("60383fa8-2705-4a61-9a39-d13c40161cbf"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("67ee140d-587b-4a6a-a714-ddf5c4435e5c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("68faa1f9-b4ec-4e59-9448-bb245c53be98"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7276454a-00e9-4806-878e-483667e8eca7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c4c08264-863a-4853-80e4-59233cde2acd"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d257a0bc-8c81-48a0-bda8-baf3258263f3"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("db9e9386-4689-4373-924e-eb43a28b9100"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("dd166d55-6e02-4b95-aa2b-ba41b312249b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("dfc54869-f1d5-40ef-92aa-09ba2f9fbabf"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f883dd9e-a13d-4e0a-a828-f70252fdddf0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4989c876-fce8-4301-9774-7ee56d5094f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6e8d74ef-19dd-44e3-a3d7-02057b70f962"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f40d55a5-7ac2-4570-95a8-ebb815e34ad3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("66740179-c8d2-45cb-83c0-9459b5b0129c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e9f1cd96-b528-4a37-b2fe-5c0eae040945"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("50802870-c076-49b5-89ed-0295e12ca832"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("97deb265-1546-4f20-8e9f-5e67b7a5c64c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c9c539c2-0342-42a8-88c3-9f63ff7d12e9"));

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
                values: new object[] { new Guid("807b50c5-9706-4eff-a4ed-cef323536229"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("9818ba6c-c229-462e-8ba2-b8c474ffc85e"), "Szef" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("e359c81d-c19a-4e10-bb67-4eb22c9e9b06"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("031220fe-3d62-430f-80c4-105a8274798a"), true, true, true, new Guid("e359c81d-c19a-4e10-bb67-4eb22c9e9b06"), "Users", true, null },
                    { new Guid("48cb65bf-62dc-45ea-8268-8370cf5c9e11"), false, false, true, new Guid("807b50c5-9706-4eff-a4ed-cef323536229"), "Users", false, null },
                    { new Guid("5ef5eb10-8f4b-4447-8e81-136b0fadfefe"), true, true, true, new Guid("e359c81d-c19a-4e10-bb67-4eb22c9e9b06"), "Permissions", true, null },
                    { new Guid("6d9f5a67-03cb-4836-ab32-c33c66707933"), false, false, false, new Guid("807b50c5-9706-4eff-a4ed-cef323536229"), "Permissions", false, null },
                    { new Guid("7ef54b9e-31da-482f-9b78-0d5e6f553514"), true, true, true, new Guid("9818ba6c-c229-462e-8ba2-b8c474ffc85e"), "Roles", true, null },
                    { new Guid("8085ae73-cf6e-492d-882c-9e714a6106de"), true, true, true, new Guid("e359c81d-c19a-4e10-bb67-4eb22c9e9b06"), "Roles", true, null },
                    { new Guid("89c1760d-7750-44b9-9ed9-b1ac21a9c010"), true, true, true, new Guid("9818ba6c-c229-462e-8ba2-b8c474ffc85e"), "Users", true, null },
                    { new Guid("bd87c645-d2e8-4b18-97a7-392f9ae1e315"), false, false, true, new Guid("807b50c5-9706-4eff-a4ed-cef323536229"), "Roles", false, null },
                    { new Guid("f19754df-f3fa-4b56-a9c2-99a581295147"), true, true, true, new Guid("9818ba6c-c229-462e-8ba2-b8c474ffc85e"), "Permissions", true, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("784cb1dc-afbe-4a41-b157-b42129c5a33b"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "", "+48 312645978", new Guid("807b50c5-9706-4eff-a4ed-cef323536229") },
                    { new Guid("79d2ec2e-ea51-47c5-bc27-785b2bd86b5a"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "", "+48 321 654 987", new Guid("807b50c5-9706-4eff-a4ed-cef323536229") },
                    { new Guid("cc97c946-f7d6-4893-9815-5992f4503906"), "", "admin", "", "admin", "admin", "", new Guid("e359c81d-c19a-4e10-bb67-4eb22c9e9b06") },
                    { new Guid("d6a223bf-1557-436e-81c1-3a64f13b2ac2"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "k.tumiel", "", "123 456 789", new Guid("9818ba6c-c229-462e-8ba2-b8c474ffc85e") },
                    { new Guid("eeb64cb4-0cb7-4df5-9cfa-f60b7e379aed"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "", "987654321", new Guid("807b50c5-9706-4eff-a4ed-cef323536229") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("142f5039-1f97-4028-86df-69dd83bff411"), null, null, false, null, "Users", null, new Guid("eeb64cb4-0cb7-4df5-9cfa-f60b7e379aed") },
                    { new Guid("6d24e524-53e8-4b99-ab48-e800203a80b7"), true, null, null, null, "Roles", true, new Guid("784cb1dc-afbe-4a41-b157-b42129c5a33b") },
                    { new Guid("7386d5b3-43ea-4544-a10b-1eb9c4f93cbd"), null, null, false, null, "Roles", null, new Guid("eeb64cb4-0cb7-4df5-9cfa-f60b7e379aed") },
                    { new Guid("924be431-da45-499d-9bd5-1fc9e1611992"), true, true, null, null, "Users", true, new Guid("784cb1dc-afbe-4a41-b157-b42129c5a33b") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("031220fe-3d62-430f-80c4-105a8274798a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("142f5039-1f97-4028-86df-69dd83bff411"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("48cb65bf-62dc-45ea-8268-8370cf5c9e11"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5ef5eb10-8f4b-4447-8e81-136b0fadfefe"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6d24e524-53e8-4b99-ab48-e800203a80b7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6d9f5a67-03cb-4836-ab32-c33c66707933"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7386d5b3-43ea-4544-a10b-1eb9c4f93cbd"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7ef54b9e-31da-482f-9b78-0d5e6f553514"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8085ae73-cf6e-492d-882c-9e714a6106de"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("89c1760d-7750-44b9-9ed9-b1ac21a9c010"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("924be431-da45-499d-9bd5-1fc9e1611992"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("bd87c645-d2e8-4b18-97a7-392f9ae1e315"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f19754df-f3fa-4b56-a9c2-99a581295147"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("79d2ec2e-ea51-47c5-bc27-785b2bd86b5a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cc97c946-f7d6-4893-9815-5992f4503906"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d6a223bf-1557-436e-81c1-3a64f13b2ac2"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9818ba6c-c229-462e-8ba2-b8c474ffc85e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e359c81d-c19a-4e10-bb67-4eb22c9e9b06"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("784cb1dc-afbe-4a41-b157-b42129c5a33b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eeb64cb4-0cb7-4df5-9cfa-f60b7e379aed"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("807b50c5-9706-4eff-a4ed-cef323536229"));

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
                values: new object[] { new Guid("66740179-c8d2-45cb-83c0-9459b5b0129c"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("c9c539c2-0342-42a8-88c3-9f63ff7d12e9"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("e9f1cd96-b528-4a37-b2fe-5c0eae040945"), "Szef" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("460852c4-c5b2-436a-9551-5baabcbcf469"), true, true, true, new Guid("e9f1cd96-b528-4a37-b2fe-5c0eae040945"), "Permissions", true, null },
                    { new Guid("5f9adb48-beee-43b7-a171-0bdbbd3a69cd"), false, false, false, new Guid("c9c539c2-0342-42a8-88c3-9f63ff7d12e9"), "Permissions", false, null },
                    { new Guid("67ee140d-587b-4a6a-a714-ddf5c4435e5c"), true, true, true, new Guid("66740179-c8d2-45cb-83c0-9459b5b0129c"), "Users", true, null },
                    { new Guid("7276454a-00e9-4806-878e-483667e8eca7"), true, true, true, new Guid("e9f1cd96-b528-4a37-b2fe-5c0eae040945"), "Users", true, null },
                    { new Guid("c4c08264-863a-4853-80e4-59233cde2acd"), false, false, true, new Guid("c9c539c2-0342-42a8-88c3-9f63ff7d12e9"), "Users", false, null },
                    { new Guid("d257a0bc-8c81-48a0-bda8-baf3258263f3"), true, true, true, new Guid("66740179-c8d2-45cb-83c0-9459b5b0129c"), "Roles", true, null },
                    { new Guid("db9e9386-4689-4373-924e-eb43a28b9100"), true, true, true, new Guid("e9f1cd96-b528-4a37-b2fe-5c0eae040945"), "Roles", true, null },
                    { new Guid("dd166d55-6e02-4b95-aa2b-ba41b312249b"), true, true, true, new Guid("66740179-c8d2-45cb-83c0-9459b5b0129c"), "Users", true, null },
                    { new Guid("dfc54869-f1d5-40ef-92aa-09ba2f9fbabf"), false, false, true, new Guid("c9c539c2-0342-42a8-88c3-9f63ff7d12e9"), "Roles", false, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("4989c876-fce8-4301-9774-7ee56d5094f0"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "k.tumiel", "", "123 456 789", new Guid("e9f1cd96-b528-4a37-b2fe-5c0eae040945") },
                    { new Guid("50802870-c076-49b5-89ed-0295e12ca832"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "", "+48 312645978", new Guid("c9c539c2-0342-42a8-88c3-9f63ff7d12e9") },
                    { new Guid("6e8d74ef-19dd-44e3-a3d7-02057b70f962"), "", "admin", "", "admin", "admin", "", new Guid("66740179-c8d2-45cb-83c0-9459b5b0129c") },
                    { new Guid("97deb265-1546-4f20-8e9f-5e67b7a5c64c"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "", "987654321", new Guid("c9c539c2-0342-42a8-88c3-9f63ff7d12e9") },
                    { new Guid("f40d55a5-7ac2-4570-95a8-ebb815e34ad3"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "", "+48 321 654 987", new Guid("c9c539c2-0342-42a8-88c3-9f63ff7d12e9") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("39ee58d1-93f3-46d2-97c5-2f0ea65e1954"), true, null, null, null, "Permissions", true, new Guid("50802870-c076-49b5-89ed-0295e12ca832") },
                    { new Guid("60383fa8-2705-4a61-9a39-d13c40161cbf"), true, true, null, null, "Permissions", true, new Guid("50802870-c076-49b5-89ed-0295e12ca832") },
                    { new Guid("68faa1f9-b4ec-4e59-9448-bb245c53be98"), null, null, false, null, "Roles", null, new Guid("97deb265-1546-4f20-8e9f-5e67b7a5c64c") },
                    { new Guid("f883dd9e-a13d-4e0a-a828-f70252fdddf0"), null, null, false, null, "Users", null, new Guid("97deb265-1546-4f20-8e9f-5e67b7a5c64c") }
                });
        }
    }
}
