using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class addondeletetorolesandusers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permissions_Roles_RoleId",
                table: "Permissions");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("08b8ce2e-a8bb-4163-bc76-293d617f6910"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("499cb9c1-f425-4b30-bce4-c95773748607"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4ab18235-ff0d-498b-bac3-7bc44e6578b9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("51be3c80-f5e6-4396-b8b5-bb8b291c8496"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("642a54d2-a26c-4e72-8cdd-998ff3b2f755"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("676712af-4c32-4d7a-b88b-0fafa1c0dd16"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("aa982bda-21c3-4c93-8a70-011ecbb98a60"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ad1f69de-7498-4185-a01f-25bcce16fcea"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b4d9d8c0-2d3c-426f-8a9e-3f462658e23b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c8c3fd72-65a9-4831-88eb-c0e0ba731b2c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d83d3fc7-adb2-48c8-acc0-28a30ded2021"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("dbc8c35a-5c29-4d9a-8e73-54698ed5aa12"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f021c719-e843-4fbe-95b7-4b35d07fb42b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4f4392d6-e5ff-4c7f-af17-4335bd38aa47"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("50f05a8e-21c0-4441-ab05-675294bd3c7b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c8c265ca-2015-461d-b844-3cad4f0e5f04"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("4a9c7129-f040-4cba-8674-35a154fb08d3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f70ec82c-ac1e-469f-bf36-952ee81b0c4b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("05f7b625-56d5-4b8b-ac33-f185a06cf584"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d09e9d91-6888-4724-9527-117780ea53ef"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("59c247e5-e7c3-4fc4-bc8b-9179471e0393"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("704b2d55-84da-41b1-8cd9-df85e6b7df1a"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("d44d49ea-d094-4845-aa0f-b653f1c1e673"), "Szef" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("ef71e76d-6982-4e61-85bf-5586a9713b50"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("208fdebe-d86f-40d2-823b-3e371c0e6784"), false, false, true, new Guid("ef71e76d-6982-4e61-85bf-5586a9713b50"), "Users", false, null },
                    { new Guid("28242013-b2e2-41ba-bf76-bd41d134dea2"), true, true, true, new Guid("704b2d55-84da-41b1-8cd9-df85e6b7df1a"), "Roles", true, null },
                    { new Guid("5474da25-daa3-49bc-9157-358fcbe725b7"), true, true, true, new Guid("d44d49ea-d094-4845-aa0f-b653f1c1e673"), "Users", true, null },
                    { new Guid("639cb961-ec14-4214-b203-fe297584bd97"), true, true, true, new Guid("704b2d55-84da-41b1-8cd9-df85e6b7df1a"), "Users", true, null },
                    { new Guid("672a24c1-7549-48e8-9648-0613335b12e3"), false, false, true, new Guid("ef71e76d-6982-4e61-85bf-5586a9713b50"), "Roles", false, null },
                    { new Guid("813c2dbd-0159-47e1-86d0-b1d490df264f"), false, false, false, new Guid("ef71e76d-6982-4e61-85bf-5586a9713b50"), "Permissions", false, null },
                    { new Guid("83b78e8a-1058-4077-8e47-b7964675cc12"), true, true, true, new Guid("704b2d55-84da-41b1-8cd9-df85e6b7df1a"), "Permissions", true, null },
                    { new Guid("9f88b1c8-4906-4444-8a98-c940ef9a49c8"), true, true, true, new Guid("d44d49ea-d094-4845-aa0f-b653f1c1e673"), "Permissions", true, null },
                    { new Guid("d7e551a5-c64c-46a0-8ae8-9370ecf254dd"), true, true, true, new Guid("d44d49ea-d094-4845-aa0f-b653f1c1e673"), "Roles", true, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("0ce28c35-6eda-4f87-8377-3763d13f4277"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "", "+48 321 654 987", new Guid("ef71e76d-6982-4e61-85bf-5586a9713b50") },
                    { new Guid("4403b5dc-41f5-451d-a56c-56b41ee2f888"), "", "admin", "", "admin", "admin", "", new Guid("704b2d55-84da-41b1-8cd9-df85e6b7df1a") },
                    { new Guid("58f488b6-f278-40b9-b4c5-60a168690f6f"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "", "987654321", new Guid("ef71e76d-6982-4e61-85bf-5586a9713b50") },
                    { new Guid("65d80586-38ac-438b-8484-b40a42105e0b"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "k.tumiel", "", "123 456 789", new Guid("d44d49ea-d094-4845-aa0f-b653f1c1e673") },
                    { new Guid("a76b4aa0-5f14-4c2d-9920-72fa03e14f49"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "", "+48 312645978", new Guid("ef71e76d-6982-4e61-85bf-5586a9713b50") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("6eba63e5-6012-4db1-8efb-caa8b39fe8d5"), null, null, false, null, "Roles", null, new Guid("58f488b6-f278-40b9-b4c5-60a168690f6f") },
                    { new Guid("a962ad51-b45b-462e-8a7e-27a53044b012"), true, true, null, null, "Users", true, new Guid("a76b4aa0-5f14-4c2d-9920-72fa03e14f49") },
                    { new Guid("cdf7a2ea-bb08-4867-8e75-f1fb36db7276"), null, null, false, null, "Users", null, new Guid("58f488b6-f278-40b9-b4c5-60a168690f6f") },
                    { new Guid("f9e70775-8769-4a5e-a28e-605beebbc1d1"), true, null, null, null, "Roles", true, new Guid("a76b4aa0-5f14-4c2d-9920-72fa03e14f49") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_Roles_RoleId",
                table: "Permissions",
                column: "RoleId",
                principalTable: "Roles",
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
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("208fdebe-d86f-40d2-823b-3e371c0e6784"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("28242013-b2e2-41ba-bf76-bd41d134dea2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5474da25-daa3-49bc-9157-358fcbe725b7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("639cb961-ec14-4214-b203-fe297584bd97"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("672a24c1-7549-48e8-9648-0613335b12e3"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6eba63e5-6012-4db1-8efb-caa8b39fe8d5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("813c2dbd-0159-47e1-86d0-b1d490df264f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("83b78e8a-1058-4077-8e47-b7964675cc12"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9f88b1c8-4906-4444-8a98-c940ef9a49c8"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a962ad51-b45b-462e-8a7e-27a53044b012"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("cdf7a2ea-bb08-4867-8e75-f1fb36db7276"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d7e551a5-c64c-46a0-8ae8-9370ecf254dd"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f9e70775-8769-4a5e-a28e-605beebbc1d1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0ce28c35-6eda-4f87-8377-3763d13f4277"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4403b5dc-41f5-451d-a56c-56b41ee2f888"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("65d80586-38ac-438b-8484-b40a42105e0b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("704b2d55-84da-41b1-8cd9-df85e6b7df1a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d44d49ea-d094-4845-aa0f-b653f1c1e673"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("58f488b6-f278-40b9-b4c5-60a168690f6f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a76b4aa0-5f14-4c2d-9920-72fa03e14f49"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ef71e76d-6982-4e61-85bf-5586a9713b50"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("4a9c7129-f040-4cba-8674-35a154fb08d3"), "Szef" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("59c247e5-e7c3-4fc4-bc8b-9179471e0393"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("f70ec82c-ac1e-469f-bf36-952ee81b0c4b"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("08b8ce2e-a8bb-4163-bc76-293d617f6910"), true, true, true, new Guid("f70ec82c-ac1e-469f-bf36-952ee81b0c4b"), "Users", true, null },
                    { new Guid("499cb9c1-f425-4b30-bce4-c95773748607"), true, true, true, new Guid("4a9c7129-f040-4cba-8674-35a154fb08d3"), "Roles", true, null },
                    { new Guid("4ab18235-ff0d-498b-bac3-7bc44e6578b9"), true, true, true, new Guid("f70ec82c-ac1e-469f-bf36-952ee81b0c4b"), "Roles", true, null },
                    { new Guid("676712af-4c32-4d7a-b88b-0fafa1c0dd16"), false, false, true, new Guid("59c247e5-e7c3-4fc4-bc8b-9179471e0393"), "Roles", false, null },
                    { new Guid("aa982bda-21c3-4c93-8a70-011ecbb98a60"), true, true, true, new Guid("4a9c7129-f040-4cba-8674-35a154fb08d3"), "Users", true, null },
                    { new Guid("b4d9d8c0-2d3c-426f-8a9e-3f462658e23b"), false, false, false, new Guid("59c247e5-e7c3-4fc4-bc8b-9179471e0393"), "Permissions", false, null },
                    { new Guid("d83d3fc7-adb2-48c8-acc0-28a30ded2021"), true, true, true, new Guid("4a9c7129-f040-4cba-8674-35a154fb08d3"), "Permissions", true, null },
                    { new Guid("dbc8c35a-5c29-4d9a-8e73-54698ed5aa12"), false, false, true, new Guid("59c247e5-e7c3-4fc4-bc8b-9179471e0393"), "Users", false, null },
                    { new Guid("f021c719-e843-4fbe-95b7-4b35d07fb42b"), true, true, true, new Guid("f70ec82c-ac1e-469f-bf36-952ee81b0c4b"), "Permissions", true, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("05f7b625-56d5-4b8b-ac33-f185a06cf584"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "", "+48 312645978", new Guid("59c247e5-e7c3-4fc4-bc8b-9179471e0393") },
                    { new Guid("4f4392d6-e5ff-4c7f-af17-4335bd38aa47"), "", "admin", "", "admin", "admin", "", new Guid("f70ec82c-ac1e-469f-bf36-952ee81b0c4b") },
                    { new Guid("50f05a8e-21c0-4441-ab05-675294bd3c7b"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "", "+48 321 654 987", new Guid("59c247e5-e7c3-4fc4-bc8b-9179471e0393") },
                    { new Guid("c8c265ca-2015-461d-b844-3cad4f0e5f04"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "k.tumiel", "", "123 456 789", new Guid("4a9c7129-f040-4cba-8674-35a154fb08d3") },
                    { new Guid("d09e9d91-6888-4724-9527-117780ea53ef"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "", "987654321", new Guid("59c247e5-e7c3-4fc4-bc8b-9179471e0393") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("51be3c80-f5e6-4396-b8b5-bb8b291c8496"), true, null, null, null, "Roles", true, new Guid("05f7b625-56d5-4b8b-ac33-f185a06cf584") },
                    { new Guid("642a54d2-a26c-4e72-8cdd-998ff3b2f755"), null, null, false, null, "Roles", null, new Guid("d09e9d91-6888-4724-9527-117780ea53ef") },
                    { new Guid("ad1f69de-7498-4185-a01f-25bcce16fcea"), true, true, null, null, "Users", true, new Guid("05f7b625-56d5-4b8b-ac33-f185a06cf584") },
                    { new Guid("c8c3fd72-65a9-4831-88eb-c0e0ba731b2c"), null, null, false, null, "Users", null, new Guid("d09e9d91-6888-4724-9527-117780ea53ef") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_Roles_RoleId",
                table: "Permissions",
                column: "RoleId",
                principalTable: "Roles",
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
