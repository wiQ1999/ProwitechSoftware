using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class fulladdressremoveindexes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_FullAddresses_BuildingAddressId",
                table: "FullAddresses");

            migrationBuilder.DropIndex(
                name: "IX_FullAddresses_PropertyAddressId",
                table: "FullAddresses");

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("05eb921d-4f82-48fd-811a-cdaff068b84b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0607762f-a124-41ed-af0e-753b6a703c48"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5fc29123-2612-4461-adb0-2e0d1712c776"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6664c0f6-cba7-4a72-ae08-4daeeb3d2198"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7ac5347c-01fe-43ff-9577-5cd1aa1dd957"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7fe5dc76-3e91-4338-9305-883cfab4c469"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("84a25236-949c-4907-98e5-a02a989e24e6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8b6e47d0-cef8-427b-a179-cae987fd9ff4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9ce3eb79-65bd-4422-834a-cba6a2327f7a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a06af6e7-f37b-4caa-8719-0a3841d3abdb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a71b68e2-92f3-4654-abef-e295f969aaf6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d193ceb8-e0a7-4a79-8df8-0087fe221f59"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fc920de5-c7f8-4010-a06d-a3402d293c7e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("12ca9c2b-8e5e-471e-bbce-df87e3639ab4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4b07e00f-5b80-4b59-9c98-104e1ea79d60"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ae8ab760-4f4a-4345-b654-145c3ac008e2"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("87702f2e-2d40-43a3-b9ef-1918df04e30f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d6863ec3-f5cc-4839-afd8-57b5053e36fa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1ccc416e-7e92-4192-a969-668d80fa9bd2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("74e18999-9982-49dd-adcd-b91a47b44e7b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("97bcac27-1428-4aa0-b903-85743aab0a82"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("09b195d4-c916-4df0-b045-00ef5c1f3f02"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("a1fb663b-c77d-416d-a028-f95cccde8233"), "Szef" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("e16a381f-64d5-483f-9d27-c7d1c6d09490"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("086ecc39-0831-4258-88a9-ed3ef289cda2"), true, true, true, new Guid("09b195d4-c916-4df0-b045-00ef5c1f3f02"), "Roles", true, null },
                    { new Guid("46099ff3-8ca5-4bff-89b2-fdd78694f8b4"), true, true, true, new Guid("a1fb663b-c77d-416d-a028-f95cccde8233"), "Users", true, null },
                    { new Guid("565353e6-b9ce-4470-886a-2f3751ed8f4a"), false, false, false, new Guid("e16a381f-64d5-483f-9d27-c7d1c6d09490"), "Permissions", false, null },
                    { new Guid("680beffc-794d-4f8a-a2ec-db0192f4b7bb"), false, false, true, new Guid("e16a381f-64d5-483f-9d27-c7d1c6d09490"), "Roles", false, null },
                    { new Guid("9cc09d4b-1713-452c-bdb3-425cce258af9"), false, false, true, new Guid("e16a381f-64d5-483f-9d27-c7d1c6d09490"), "Users", false, null },
                    { new Guid("a4762310-01f0-4426-b83b-b613775c68d1"), true, true, true, new Guid("09b195d4-c916-4df0-b045-00ef5c1f3f02"), "Permissions", true, null },
                    { new Guid("a697b13a-94ae-4f63-ae13-7e59037ca7d0"), true, true, true, new Guid("a1fb663b-c77d-416d-a028-f95cccde8233"), "Permissions", true, null },
                    { new Guid("abcaf32a-b71d-4596-89f8-c8c6fb9c2018"), true, true, true, new Guid("09b195d4-c916-4df0-b045-00ef5c1f3f02"), "Users", true, null },
                    { new Guid("b2056161-cc49-4a70-a1ec-a54e501ad280"), true, true, true, new Guid("a1fb663b-c77d-416d-a028-f95cccde8233"), "Roles", true, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("09162196-1f86-419e-9197-fc4b574bdb8c"), "", "admin", "", "admin", "admin", "", new Guid("09b195d4-c916-4df0-b045-00ef5c1f3f02") },
                    { new Guid("257306cb-0f7e-4774-894d-79f2a6ea97c6"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "k.tumiel", "", "123 456 789", new Guid("a1fb663b-c77d-416d-a028-f95cccde8233") },
                    { new Guid("56061c1a-8c17-4190-aec5-3a0ce4482504"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "", "+48 321 654 987", new Guid("e16a381f-64d5-483f-9d27-c7d1c6d09490") },
                    { new Guid("7c6b711f-308a-4be1-b02a-c0a3eba36625"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "", "987654321", new Guid("e16a381f-64d5-483f-9d27-c7d1c6d09490") },
                    { new Guid("826073a4-34be-4844-a213-5cac0df062bd"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "", "+48 312645978", new Guid("e16a381f-64d5-483f-9d27-c7d1c6d09490") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("061e4b2a-c7f2-4479-b7fd-97299a079062"), true, null, null, null, "Roles", true, new Guid("826073a4-34be-4844-a213-5cac0df062bd") },
                    { new Guid("3e91ed8d-fadc-460e-abb8-08178048b67c"), null, null, false, null, "Roles", null, new Guid("7c6b711f-308a-4be1-b02a-c0a3eba36625") },
                    { new Guid("b433e09e-4348-43a6-b32b-afdad92abb7e"), null, null, false, null, "Users", null, new Guid("7c6b711f-308a-4be1-b02a-c0a3eba36625") },
                    { new Guid("c8ad6ab1-5405-470c-b94b-25d716ed0ac4"), true, true, null, null, "Users", true, new Guid("826073a4-34be-4844-a213-5cac0df062bd") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FullAddresses_BuildingAddressId",
                table: "FullAddresses",
                column: "BuildingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_FullAddresses_PropertyAddressId",
                table: "FullAddresses",
                column: "PropertyAddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_FullAddresses_BuildingAddressId",
                table: "FullAddresses");

            migrationBuilder.DropIndex(
                name: "IX_FullAddresses_PropertyAddressId",
                table: "FullAddresses");

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("061e4b2a-c7f2-4479-b7fd-97299a079062"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("086ecc39-0831-4258-88a9-ed3ef289cda2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3e91ed8d-fadc-460e-abb8-08178048b67c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("46099ff3-8ca5-4bff-89b2-fdd78694f8b4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("565353e6-b9ce-4470-886a-2f3751ed8f4a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("680beffc-794d-4f8a-a2ec-db0192f4b7bb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9cc09d4b-1713-452c-bdb3-425cce258af9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a4762310-01f0-4426-b83b-b613775c68d1"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a697b13a-94ae-4f63-ae13-7e59037ca7d0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("abcaf32a-b71d-4596-89f8-c8c6fb9c2018"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b2056161-cc49-4a70-a1ec-a54e501ad280"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b433e09e-4348-43a6-b32b-afdad92abb7e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c8ad6ab1-5405-470c-b94b-25d716ed0ac4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("09162196-1f86-419e-9197-fc4b574bdb8c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("257306cb-0f7e-4774-894d-79f2a6ea97c6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("56061c1a-8c17-4190-aec5-3a0ce4482504"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("09b195d4-c916-4df0-b045-00ef5c1f3f02"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a1fb663b-c77d-416d-a028-f95cccde8233"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7c6b711f-308a-4be1-b02a-c0a3eba36625"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("826073a4-34be-4844-a213-5cac0df062bd"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e16a381f-64d5-483f-9d27-c7d1c6d09490"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("87702f2e-2d40-43a3-b9ef-1918df04e30f"), "Szef" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("97bcac27-1428-4aa0-b903-85743aab0a82"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("d6863ec3-f5cc-4839-afd8-57b5053e36fa"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("0607762f-a124-41ed-af0e-753b6a703c48"), true, true, true, new Guid("87702f2e-2d40-43a3-b9ef-1918df04e30f"), "Permissions", true, null },
                    { new Guid("6664c0f6-cba7-4a72-ae08-4daeeb3d2198"), true, true, true, new Guid("d6863ec3-f5cc-4839-afd8-57b5053e36fa"), "Roles", true, null },
                    { new Guid("7ac5347c-01fe-43ff-9577-5cd1aa1dd957"), true, true, true, new Guid("87702f2e-2d40-43a3-b9ef-1918df04e30f"), "Users", true, null },
                    { new Guid("7fe5dc76-3e91-4338-9305-883cfab4c469"), false, false, true, new Guid("97bcac27-1428-4aa0-b903-85743aab0a82"), "Roles", false, null },
                    { new Guid("84a25236-949c-4907-98e5-a02a989e24e6"), true, true, true, new Guid("87702f2e-2d40-43a3-b9ef-1918df04e30f"), "Roles", true, null },
                    { new Guid("9ce3eb79-65bd-4422-834a-cba6a2327f7a"), true, true, true, new Guid("d6863ec3-f5cc-4839-afd8-57b5053e36fa"), "Permissions", true, null },
                    { new Guid("a71b68e2-92f3-4654-abef-e295f969aaf6"), false, false, true, new Guid("97bcac27-1428-4aa0-b903-85743aab0a82"), "Users", false, null },
                    { new Guid("d193ceb8-e0a7-4a79-8df8-0087fe221f59"), false, false, false, new Guid("97bcac27-1428-4aa0-b903-85743aab0a82"), "Permissions", false, null },
                    { new Guid("fc920de5-c7f8-4010-a06d-a3402d293c7e"), true, true, true, new Guid("d6863ec3-f5cc-4839-afd8-57b5053e36fa"), "Users", true, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("12ca9c2b-8e5e-471e-bbce-df87e3639ab4"), "", "admin", "", "admin", "admin", "", new Guid("d6863ec3-f5cc-4839-afd8-57b5053e36fa") },
                    { new Guid("1ccc416e-7e92-4192-a969-668d80fa9bd2"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "", "+48 312645978", new Guid("97bcac27-1428-4aa0-b903-85743aab0a82") },
                    { new Guid("4b07e00f-5b80-4b59-9c98-104e1ea79d60"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "k.tumiel", "", "123 456 789", new Guid("87702f2e-2d40-43a3-b9ef-1918df04e30f") },
                    { new Guid("74e18999-9982-49dd-adcd-b91a47b44e7b"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "", "987654321", new Guid("97bcac27-1428-4aa0-b903-85743aab0a82") },
                    { new Guid("ae8ab760-4f4a-4345-b654-145c3ac008e2"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "", "+48 321 654 987", new Guid("97bcac27-1428-4aa0-b903-85743aab0a82") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("05eb921d-4f82-48fd-811a-cdaff068b84b"), null, null, false, null, "Roles", null, new Guid("74e18999-9982-49dd-adcd-b91a47b44e7b") },
                    { new Guid("5fc29123-2612-4461-adb0-2e0d1712c776"), true, true, null, null, "Users", true, new Guid("1ccc416e-7e92-4192-a969-668d80fa9bd2") },
                    { new Guid("8b6e47d0-cef8-427b-a179-cae987fd9ff4"), null, null, false, null, "Users", null, new Guid("74e18999-9982-49dd-adcd-b91a47b44e7b") },
                    { new Guid("a06af6e7-f37b-4caa-8719-0a3841d3abdb"), true, null, null, null, "Roles", true, new Guid("1ccc416e-7e92-4192-a969-668d80fa9bd2") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FullAddresses_BuildingAddressId",
                table: "FullAddresses",
                column: "BuildingAddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FullAddresses_PropertyAddressId",
                table: "FullAddresses",
                column: "PropertyAddressId",
                unique: true,
                filter: "[PropertyAddressId] IS NOT NULL");
        }
    }
}
