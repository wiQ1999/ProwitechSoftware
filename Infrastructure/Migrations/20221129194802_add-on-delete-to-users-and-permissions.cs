using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class addondeletetousersandpermissions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permissions_Roles_RoleId",
                table: "Permissions");

            migrationBuilder.DropForeignKey(
                name: "FK_Permissions_Users_UserId",
                table: "Permissions");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

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

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("0a5d88aa-c8a0-4f88-9bc0-ddca8c867613"), "Szef" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("68e410da-4162-40e9-9659-d495a1bda4a6"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("ab2094a8-20c1-4523-8c5c-0bcdceebf692"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("006708ed-9f9e-49b3-ae5a-26f9c66a7685"), true, true, true, new Guid("ab2094a8-20c1-4523-8c5c-0bcdceebf692"), "Permissions", true, null },
                    { new Guid("30f0d4a1-bc1a-43cd-978f-89770a8e7592"), false, false, true, new Guid("68e410da-4162-40e9-9659-d495a1bda4a6"), "Roles", false, null },
                    { new Guid("5c5230d9-0f47-464b-b790-ac8f4ac6b74e"), false, false, false, new Guid("68e410da-4162-40e9-9659-d495a1bda4a6"), "Permissions", false, null },
                    { new Guid("6d4ddd78-8e35-4df0-b0b7-2a4eec2d1d1f"), true, true, true, new Guid("ab2094a8-20c1-4523-8c5c-0bcdceebf692"), "Users", true, null },
                    { new Guid("70c606c5-9527-48f2-a534-1eaec1134da4"), true, true, true, new Guid("0a5d88aa-c8a0-4f88-9bc0-ddca8c867613"), "Roles", true, null },
                    { new Guid("9887634c-e710-4ed9-aab7-74857f32f264"), true, true, true, new Guid("0a5d88aa-c8a0-4f88-9bc0-ddca8c867613"), "Users", true, null },
                    { new Guid("cf722225-b07d-4606-bd83-8321c9432dc5"), true, true, true, new Guid("0a5d88aa-c8a0-4f88-9bc0-ddca8c867613"), "Permissions", true, null },
                    { new Guid("f2f8f2a8-6130-4b20-8dcf-db17aa31d193"), true, true, true, new Guid("ab2094a8-20c1-4523-8c5c-0bcdceebf692"), "Roles", true, null },
                    { new Guid("fe8efacf-2718-4047-b635-8aaa4361fa9e"), false, false, true, new Guid("68e410da-4162-40e9-9659-d495a1bda4a6"), "Users", false, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("1a75760f-eea9-4271-aa74-91003b8ee567"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "", "+48 312645978", new Guid("68e410da-4162-40e9-9659-d495a1bda4a6") },
                    { new Guid("22ea0197-0e00-48ef-83db-1aeba8a4aced"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "k.tumiel", "", "123 456 789", new Guid("0a5d88aa-c8a0-4f88-9bc0-ddca8c867613") },
                    { new Guid("4ef086d0-4618-43bb-a1e6-3b288eb5fe71"), "", "admin", "", "admin", "admin", "", new Guid("ab2094a8-20c1-4523-8c5c-0bcdceebf692") },
                    { new Guid("6bb5ca6e-9728-4087-a765-df7c6f5cdff8"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "", "987654321", new Guid("68e410da-4162-40e9-9659-d495a1bda4a6") },
                    { new Guid("f1728813-9fba-494c-911f-1313e5150198"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "", "+48 321 654 987", new Guid("68e410da-4162-40e9-9659-d495a1bda4a6") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("1ef9f2e8-8661-43d3-a69c-20f32ddf1820"), true, true, null, null, "Users", true, new Guid("1a75760f-eea9-4271-aa74-91003b8ee567") },
                    { new Guid("305789b5-ebe9-4833-b1bf-53b392d2ecd9"), null, null, false, null, "Roles", null, new Guid("6bb5ca6e-9728-4087-a765-df7c6f5cdff8") },
                    { new Guid("6aa479f5-973b-4086-89d7-ac8dfbd53960"), true, null, null, null, "Roles", true, new Guid("1a75760f-eea9-4271-aa74-91003b8ee567") },
                    { new Guid("fa136fdb-bff4-4a62-8985-26fdd6c66471"), null, null, false, null, "Users", null, new Guid("6bb5ca6e-9728-4087-a765-df7c6f5cdff8") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_Roles_RoleId",
                table: "Permissions",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_Users_UserId",
                table: "Permissions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permissions_Roles_RoleId",
                table: "Permissions");

            migrationBuilder.DropForeignKey(
                name: "FK_Permissions_Users_UserId",
                table: "Permissions");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("006708ed-9f9e-49b3-ae5a-26f9c66a7685"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1ef9f2e8-8661-43d3-a69c-20f32ddf1820"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("305789b5-ebe9-4833-b1bf-53b392d2ecd9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("30f0d4a1-bc1a-43cd-978f-89770a8e7592"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5c5230d9-0f47-464b-b790-ac8f4ac6b74e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6aa479f5-973b-4086-89d7-ac8dfbd53960"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6d4ddd78-8e35-4df0-b0b7-2a4eec2d1d1f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("70c606c5-9527-48f2-a534-1eaec1134da4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9887634c-e710-4ed9-aab7-74857f32f264"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("cf722225-b07d-4606-bd83-8321c9432dc5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f2f8f2a8-6130-4b20-8dcf-db17aa31d193"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fa136fdb-bff4-4a62-8985-26fdd6c66471"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fe8efacf-2718-4047-b635-8aaa4361fa9e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22ea0197-0e00-48ef-83db-1aeba8a4aced"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ef086d0-4618-43bb-a1e6-3b288eb5fe71"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f1728813-9fba-494c-911f-1313e5150198"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0a5d88aa-c8a0-4f88-9bc0-ddca8c867613"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ab2094a8-20c1-4523-8c5c-0bcdceebf692"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a75760f-eea9-4271-aa74-91003b8ee567"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6bb5ca6e-9728-4087-a765-df7c6f5cdff8"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("68e410da-4162-40e9-9659-d495a1bda4a6"));

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

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_Roles_RoleId",
                table: "Permissions",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_Users_UserId",
                table: "Permissions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id");
        }
    }
}
