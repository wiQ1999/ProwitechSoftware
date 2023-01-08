using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class buildingaddondeleteofpropertymanager : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_PropertyManagers_PropertyManagerId",
                table: "Buildings");

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
                values: new object[] { new Guid("55730212-12b0-4da1-911c-d88c84a4b1cc"), "Szef" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("6ca44709-7123-48df-bbe1-1bf881b659c9"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("9b9fb2f3-61f0-4a80-ab16-01346920fabd"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("0346691a-30e0-408b-9caa-ad13dd4dc868"), true, true, true, new Guid("55730212-12b0-4da1-911c-d88c84a4b1cc"), "Permissions", true, null },
                    { new Guid("537be9f4-f14a-417a-afef-70cbb56902f9"), true, true, true, new Guid("6ca44709-7123-48df-bbe1-1bf881b659c9"), "Users", true, null },
                    { new Guid("7a5c7125-1602-4f4c-89e6-a7b24672950c"), true, true, true, new Guid("6ca44709-7123-48df-bbe1-1bf881b659c9"), "Permissions", true, null },
                    { new Guid("a50a7bf9-74ea-4650-abfb-8d4c82fe7916"), false, false, false, new Guid("9b9fb2f3-61f0-4a80-ab16-01346920fabd"), "Permissions", false, null },
                    { new Guid("b409600b-1c9d-493e-93ec-a7dfb9656f20"), true, true, true, new Guid("6ca44709-7123-48df-bbe1-1bf881b659c9"), "Roles", true, null },
                    { new Guid("ba3916f6-a547-4ac5-b531-37eaecb8d76b"), true, true, true, new Guid("55730212-12b0-4da1-911c-d88c84a4b1cc"), "Users", true, null },
                    { new Guid("bd70f39b-fb5f-4557-b4bd-c50438149e01"), false, false, true, new Guid("9b9fb2f3-61f0-4a80-ab16-01346920fabd"), "Users", false, null },
                    { new Guid("d3ff971b-8de7-4621-b27e-bdabe952cdd9"), false, false, true, new Guid("9b9fb2f3-61f0-4a80-ab16-01346920fabd"), "Roles", false, null },
                    { new Guid("ee477485-d170-4105-accd-c6738f257a4f"), true, true, true, new Guid("55730212-12b0-4da1-911c-d88c84a4b1cc"), "Roles", true, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("20277ef0-2189-452c-b0d0-c0593bd5a7b4"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "", "+48 321 654 987", new Guid("9b9fb2f3-61f0-4a80-ab16-01346920fabd") },
                    { new Guid("493255e7-1bd9-4a2e-8e5a-235e987c6b60"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "k.tumiel", "", "123 456 789", new Guid("55730212-12b0-4da1-911c-d88c84a4b1cc") },
                    { new Guid("694c87d8-c5a8-4eb2-a7ae-fdb6a48628f1"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "", "+48 312645978", new Guid("9b9fb2f3-61f0-4a80-ab16-01346920fabd") },
                    { new Guid("8a493718-4f47-4cfd-b9f3-2f1dece02ffe"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "", "987654321", new Guid("9b9fb2f3-61f0-4a80-ab16-01346920fabd") },
                    { new Guid("8fdd6a05-3eb5-479e-b1d3-7b464f7714f2"), "", "admin", "", "admin", "admin", "", new Guid("6ca44709-7123-48df-bbe1-1bf881b659c9") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("0c214b48-2df8-4acd-8346-d2992c59e348"), null, null, false, null, "Roles", null, new Guid("8a493718-4f47-4cfd-b9f3-2f1dece02ffe") },
                    { new Guid("8eafd198-e5b5-4073-aa8d-8fa772a2aeea"), null, null, false, null, "Users", null, new Guid("8a493718-4f47-4cfd-b9f3-2f1dece02ffe") },
                    { new Guid("9738f917-8506-4ac6-ae51-79441ceac524"), true, true, null, null, "Users", true, new Guid("694c87d8-c5a8-4eb2-a7ae-fdb6a48628f1") },
                    { new Guid("fad3a06e-1f73-4689-9a74-df5f5679ca2b"), true, null, null, null, "Roles", true, new Guid("694c87d8-c5a8-4eb2-a7ae-fdb6a48628f1") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Buildings_PropertyManagers_PropertyManagerId",
                table: "Buildings",
                column: "PropertyManagerId",
                principalTable: "PropertyManagers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_PropertyManagers_PropertyManagerId",
                table: "Buildings");

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0346691a-30e0-408b-9caa-ad13dd4dc868"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0c214b48-2df8-4acd-8346-d2992c59e348"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("537be9f4-f14a-417a-afef-70cbb56902f9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7a5c7125-1602-4f4c-89e6-a7b24672950c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8eafd198-e5b5-4073-aa8d-8fa772a2aeea"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9738f917-8506-4ac6-ae51-79441ceac524"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a50a7bf9-74ea-4650-abfb-8d4c82fe7916"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b409600b-1c9d-493e-93ec-a7dfb9656f20"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ba3916f6-a547-4ac5-b531-37eaecb8d76b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("bd70f39b-fb5f-4557-b4bd-c50438149e01"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d3ff971b-8de7-4621-b27e-bdabe952cdd9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ee477485-d170-4105-accd-c6738f257a4f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fad3a06e-1f73-4689-9a74-df5f5679ca2b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("20277ef0-2189-452c-b0d0-c0593bd5a7b4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("493255e7-1bd9-4a2e-8e5a-235e987c6b60"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8fdd6a05-3eb5-479e-b1d3-7b464f7714f2"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("55730212-12b0-4da1-911c-d88c84a4b1cc"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6ca44709-7123-48df-bbe1-1bf881b659c9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("694c87d8-c5a8-4eb2-a7ae-fdb6a48628f1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8a493718-4f47-4cfd-b9f3-2f1dece02ffe"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9b9fb2f3-61f0-4a80-ab16-01346920fabd"));

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
                name: "FK_Buildings_PropertyManagers_PropertyManagerId",
                table: "Buildings",
                column: "PropertyManagerId",
                principalTable: "PropertyManagers",
                principalColumn: "Id");
        }
    }
}
