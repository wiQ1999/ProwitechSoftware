using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class buildingpropertymanagernullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<Guid>(
                name: "PropertyManagerId",
                table: "Buildings",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<Guid>(
                name: "PropertyManagerId",
                table: "Buildings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

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
        }
    }
}
