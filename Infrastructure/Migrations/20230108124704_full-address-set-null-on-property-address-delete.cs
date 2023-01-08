using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class fulladdresssetnullonpropertyaddressdelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FullAddresses_PropertyAddresses_PropertyAddressId",
                table: "FullAddresses");

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1426693c-38f7-42f4-9dee-3d6f55647fb0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("25786e21-637c-4412-b2a0-d05032304810"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2a0a20c2-4234-4821-8b4c-be4bb605116f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("33c81f5e-0435-4320-a9e9-8eb5abfbaf64"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3c56f2ae-d159-4b06-bea6-f491d6ee607f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4405f29e-5314-4954-8f69-f0f58fcab4a9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("55a0c988-5d4f-4516-852c-75bedecc3778"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("710dcb8f-1a10-4402-9bb1-ee123d5f44e7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("73bcdfdb-dba7-48f8-befc-e3087c18f938"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8aabab85-0e11-4ef2-8f2c-557d012cd08c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("94c84443-ba9f-47f4-b990-1bf1b897155c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b7b79921-f5ff-4086-9235-bb78f46b5806"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d8cf343f-2004-452c-bdd1-bcfa36d1d11a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4e05a9b8-9e21-432a-bc0c-ee44c6dde748"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("830b6f44-2171-4a1c-927b-d354843c665c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ef2b6e2b-6f66-40ac-83e4-d7753bd644fa"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("118c37eb-8e8f-4e87-b982-71bd13c79d52"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c99788c6-d29e-411f-8c56-9200bc07e2db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("76b6c817-cb3c-4d47-9bb8-e2b2f0f77a95"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9699dfd0-7689-40c3-8126-380e1eb9aa53"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0073a15a-9b19-4253-a7b8-95f33f9f2858"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("dd431576-72a0-4c77-97a9-55017b8c0882"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("f3af5bc7-8cd4-4eaf-968f-fd84f84894ee"), "Szef" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("f58fe9d2-0753-4be3-a539-4c08f4cca4ee"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("0f6802e2-acc5-445c-8d98-ae6255b8e928"), false, false, false, new Guid("dd431576-72a0-4c77-97a9-55017b8c0882"), "Permissions", false, null },
                    { new Guid("3cea7f25-82af-43ad-9f9c-7107eddaf2e6"), true, true, true, new Guid("f3af5bc7-8cd4-4eaf-968f-fd84f84894ee"), "Permissions", true, null },
                    { new Guid("40eafd0b-2144-4ef0-832d-8a38a0607217"), true, true, true, new Guid("f58fe9d2-0753-4be3-a539-4c08f4cca4ee"), "Permissions", true, null },
                    { new Guid("499e2413-eefd-4334-9c1d-804fa2defde7"), true, true, true, new Guid("f58fe9d2-0753-4be3-a539-4c08f4cca4ee"), "Users", true, null },
                    { new Guid("4ad6233d-4fd6-4e87-ab94-0c7279e2808c"), true, true, true, new Guid("f3af5bc7-8cd4-4eaf-968f-fd84f84894ee"), "Roles", true, null },
                    { new Guid("54fa1703-a97e-43d1-a157-ce7c2d555431"), false, false, true, new Guid("dd431576-72a0-4c77-97a9-55017b8c0882"), "Roles", false, null },
                    { new Guid("64fc5f9f-d2b8-49bf-ac81-7feb0c7ebf1c"), true, true, true, new Guid("f58fe9d2-0753-4be3-a539-4c08f4cca4ee"), "Roles", true, null },
                    { new Guid("8033ba21-9031-4b06-b46e-fb2f6a92b224"), false, false, true, new Guid("dd431576-72a0-4c77-97a9-55017b8c0882"), "Users", false, null },
                    { new Guid("88a7affc-8102-46e6-854b-8c1d4531e18a"), true, true, true, new Guid("f3af5bc7-8cd4-4eaf-968f-fd84f84894ee"), "Users", true, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("2b1e4faf-57fd-43e9-a2a3-2313a534d2f9"), "", "admin", "", "admin", "admin", "", new Guid("f58fe9d2-0753-4be3-a539-4c08f4cca4ee") },
                    { new Guid("8dcc7b90-8ecf-4535-b00a-78800b2aad83"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "k.tumiel", "", "123 456 789", new Guid("f3af5bc7-8cd4-4eaf-968f-fd84f84894ee") },
                    { new Guid("ca09db3f-28e0-4cd5-888d-1f850c245ac9"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "", "+48 312645978", new Guid("dd431576-72a0-4c77-97a9-55017b8c0882") },
                    { new Guid("dc22f20e-2368-4e35-9de2-a5372f87b067"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "", "+48 321 654 987", new Guid("dd431576-72a0-4c77-97a9-55017b8c0882") },
                    { new Guid("e4bb27c8-052b-4cb5-a9a0-11e7969a03b1"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "", "987654321", new Guid("dd431576-72a0-4c77-97a9-55017b8c0882") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("3a862189-3fdc-450b-a020-e840e932a9d9"), true, true, null, null, "Users", true, new Guid("ca09db3f-28e0-4cd5-888d-1f850c245ac9") },
                    { new Guid("5ac70586-db40-408b-98f3-9dbe8756e8df"), null, null, false, null, "Users", null, new Guid("e4bb27c8-052b-4cb5-a9a0-11e7969a03b1") },
                    { new Guid("65df5c69-258d-4472-8e72-fd4cdf58d96a"), true, null, null, null, "Roles", true, new Guid("ca09db3f-28e0-4cd5-888d-1f850c245ac9") },
                    { new Guid("973fef8d-7590-4bf5-92e9-522e3553fd9e"), null, null, false, null, "Roles", null, new Guid("e4bb27c8-052b-4cb5-a9a0-11e7969a03b1") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_FullAddresses_PropertyAddresses_PropertyAddressId",
                table: "FullAddresses",
                column: "PropertyAddressId",
                principalTable: "PropertyAddresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FullAddresses_PropertyAddresses_PropertyAddressId",
                table: "FullAddresses");

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0f6802e2-acc5-445c-8d98-ae6255b8e928"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3a862189-3fdc-450b-a020-e840e932a9d9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3cea7f25-82af-43ad-9f9c-7107eddaf2e6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("40eafd0b-2144-4ef0-832d-8a38a0607217"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("499e2413-eefd-4334-9c1d-804fa2defde7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4ad6233d-4fd6-4e87-ab94-0c7279e2808c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("54fa1703-a97e-43d1-a157-ce7c2d555431"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5ac70586-db40-408b-98f3-9dbe8756e8df"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("64fc5f9f-d2b8-49bf-ac81-7feb0c7ebf1c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("65df5c69-258d-4472-8e72-fd4cdf58d96a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8033ba21-9031-4b06-b46e-fb2f6a92b224"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("88a7affc-8102-46e6-854b-8c1d4531e18a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("973fef8d-7590-4bf5-92e9-522e3553fd9e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2b1e4faf-57fd-43e9-a2a3-2313a534d2f9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8dcc7b90-8ecf-4535-b00a-78800b2aad83"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc22f20e-2368-4e35-9de2-a5372f87b067"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f3af5bc7-8cd4-4eaf-968f-fd84f84894ee"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f58fe9d2-0753-4be3-a539-4c08f4cca4ee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ca09db3f-28e0-4cd5-888d-1f850c245ac9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e4bb27c8-052b-4cb5-a9a0-11e7969a03b1"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dd431576-72a0-4c77-97a9-55017b8c0882"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("0073a15a-9b19-4253-a7b8-95f33f9f2858"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("118c37eb-8e8f-4e87-b982-71bd13c79d52"), "Szef" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("c99788c6-d29e-411f-8c56-9200bc07e2db"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("1426693c-38f7-42f4-9dee-3d6f55647fb0"), true, true, true, new Guid("118c37eb-8e8f-4e87-b982-71bd13c79d52"), "Permissions", true, null },
                    { new Guid("25786e21-637c-4412-b2a0-d05032304810"), true, true, true, new Guid("118c37eb-8e8f-4e87-b982-71bd13c79d52"), "Users", true, null },
                    { new Guid("33c81f5e-0435-4320-a9e9-8eb5abfbaf64"), false, false, true, new Guid("0073a15a-9b19-4253-a7b8-95f33f9f2858"), "Users", false, null },
                    { new Guid("3c56f2ae-d159-4b06-bea6-f491d6ee607f"), false, false, false, new Guid("0073a15a-9b19-4253-a7b8-95f33f9f2858"), "Permissions", false, null },
                    { new Guid("4405f29e-5314-4954-8f69-f0f58fcab4a9"), true, true, true, new Guid("c99788c6-d29e-411f-8c56-9200bc07e2db"), "Users", true, null },
                    { new Guid("55a0c988-5d4f-4516-852c-75bedecc3778"), false, false, true, new Guid("0073a15a-9b19-4253-a7b8-95f33f9f2858"), "Roles", false, null },
                    { new Guid("94c84443-ba9f-47f4-b990-1bf1b897155c"), true, true, true, new Guid("c99788c6-d29e-411f-8c56-9200bc07e2db"), "Roles", true, null },
                    { new Guid("b7b79921-f5ff-4086-9235-bb78f46b5806"), true, true, true, new Guid("c99788c6-d29e-411f-8c56-9200bc07e2db"), "Permissions", true, null },
                    { new Guid("d8cf343f-2004-452c-bdd1-bcfa36d1d11a"), true, true, true, new Guid("118c37eb-8e8f-4e87-b982-71bd13c79d52"), "Roles", true, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("4e05a9b8-9e21-432a-bc0c-ee44c6dde748"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "", "+48 321 654 987", new Guid("0073a15a-9b19-4253-a7b8-95f33f9f2858") },
                    { new Guid("76b6c817-cb3c-4d47-9bb8-e2b2f0f77a95"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "", "987654321", new Guid("0073a15a-9b19-4253-a7b8-95f33f9f2858") },
                    { new Guid("830b6f44-2171-4a1c-927b-d354843c665c"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "k.tumiel", "", "123 456 789", new Guid("118c37eb-8e8f-4e87-b982-71bd13c79d52") },
                    { new Guid("9699dfd0-7689-40c3-8126-380e1eb9aa53"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "", "+48 312645978", new Guid("0073a15a-9b19-4253-a7b8-95f33f9f2858") },
                    { new Guid("ef2b6e2b-6f66-40ac-83e4-d7753bd644fa"), "", "admin", "", "admin", "admin", "", new Guid("c99788c6-d29e-411f-8c56-9200bc07e2db") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("2a0a20c2-4234-4821-8b4c-be4bb605116f"), true, true, null, null, "Users", true, new Guid("9699dfd0-7689-40c3-8126-380e1eb9aa53") },
                    { new Guid("710dcb8f-1a10-4402-9bb1-ee123d5f44e7"), true, null, null, null, "Roles", true, new Guid("9699dfd0-7689-40c3-8126-380e1eb9aa53") },
                    { new Guid("73bcdfdb-dba7-48f8-befc-e3087c18f938"), null, null, false, null, "Users", null, new Guid("76b6c817-cb3c-4d47-9bb8-e2b2f0f77a95") },
                    { new Guid("8aabab85-0e11-4ef2-8f2c-557d012cd08c"), null, null, false, null, "Roles", null, new Guid("76b6c817-cb3c-4d47-9bb8-e2b2f0f77a95") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_FullAddresses_PropertyAddresses_PropertyAddressId",
                table: "FullAddresses",
                column: "PropertyAddressId",
                principalTable: "PropertyAddresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
