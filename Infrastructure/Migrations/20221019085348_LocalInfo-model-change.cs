using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class LocalInfomodelchange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1d448260-1841-4c16-89de-9ce6a354fe55"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("229b7178-2f0e-41cb-903a-d8767201a55b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("69b13991-6e6b-4a91-9710-a8630d09f1ae"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("83bf0ae7-99a9-46af-aef5-014502ac384b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("84f61f91-c239-4f57-a9a9-0616924b5ef6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("90a9a755-a25b-4791-ba0e-215c28223119"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b4852d4a-cb14-4105-9ce3-404aa0d68015"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("dcea27ab-846d-4cd4-be58-bf0911daf69f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("dd49f27b-bd7e-49c9-80ca-eb2cd4497e11"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e6edee5f-e103-4915-b438-c7ef709e1dcf"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e8423c77-40c1-457d-985a-32e60d30d517"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("28fc32af-8687-4d08-b84b-40673032865f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("84714bdf-6372-415f-bfca-46e71cb1548e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e8b93ff6-fb2e-405a-b672-10de5132b966"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ef95dac5-0b0d-431b-81cf-2514e2e57f79"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2d41aac4-12fa-483e-a0c7-84f79b647e9c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("54259fa6-5831-4d22-a7c0-bfd47b97e409"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("963de526-f5c9-4390-b960-29bd519b0f3c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("08296208-7e1f-4717-9465-8ed211078b44"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("79dd043d-339f-4bca-832a-09efc1e1be4f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1c3888ae-ed0f-4e11-a472-73449714767e"));

            migrationBuilder.AddColumn<Guid>(
                name: "BuildingAddressId",
                table: "LocalInfos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2bf88d09-a7fd-422a-998b-858afda2872d"), "Pracownik" },
                    { new Guid("4c8c8e3c-a642-498c-bb8b-d124a1c1629a"), "Szef" },
                    { new Guid("a57319a6-431b-4623-aee5-7b4c43877756"), "Administrator" },
                    { new Guid("bf15a53a-82d5-4684-ae2b-fc7d0703eebb"), "Praktykant" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("0396bbc3-d008-414f-8e7b-9a01fa8028d5"), true, true, "Role", true, new Guid("a57319a6-431b-4623-aee5-7b4c43877756"), true, null },
                    { new Guid("0b93e9d6-f5ad-4879-b5e7-a3b709b61107"), false, false, "Użytkownicy", false, new Guid("2bf88d09-a7fd-422a-998b-858afda2872d"), false, null },
                    { new Guid("34118c2d-6254-42e2-b65f-ba4fa3f1021c"), true, true, "Użytkownicy", true, new Guid("4c8c8e3c-a642-498c-bb8b-d124a1c1629a"), true, null },
                    { new Guid("5c85585a-e696-4bdb-9952-2df7667f89cf"), false, false, "Role", false, new Guid("bf15a53a-82d5-4684-ae2b-fc7d0703eebb"), false, null },
                    { new Guid("84a08a58-a2ef-4ad7-9250-30abe0b57d3d"), false, false, "Role", false, new Guid("2bf88d09-a7fd-422a-998b-858afda2872d"), false, null },
                    { new Guid("9def1529-bbd6-4102-bcdc-c6aba7494a59"), true, true, "Role", true, new Guid("4c8c8e3c-a642-498c-bb8b-d124a1c1629a"), true, null },
                    { new Guid("a62c8633-6aad-43b2-acda-581e0e27e58d"), false, false, "Użytkownicy", false, new Guid("bf15a53a-82d5-4684-ae2b-fc7d0703eebb"), false, null },
                    { new Guid("eee6f289-8650-46f5-9d72-86431d8a301e"), true, true, "Użytkownicy", true, new Guid("a57319a6-431b-4623-aee5-7b4c43877756"), true, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("15b0f2bc-cb2c-4358-b0dc-5b1930c8ba6f"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "", "+48 321 654 987", new Guid("2bf88d09-a7fd-422a-998b-858afda2872d") },
                    { new Guid("68079db0-5c63-42fe-8172-345f75b89b57"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "", "987654321", new Guid("2bf88d09-a7fd-422a-998b-858afda2872d") },
                    { new Guid("76dab38a-6ac2-4a00-b7e4-dc9c5eb54c17"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "k.tumiel", "", "123 456 789", new Guid("4c8c8e3c-a642-498c-bb8b-d124a1c1629a") },
                    { new Guid("877be63e-88a3-43c7-840d-1999c454a15d"), "", "admin", "", "admin", "admin", "", new Guid("a57319a6-431b-4623-aee5-7b4c43877756") },
                    { new Guid("b06cfb85-898c-4bba-9a60-c460e4353935"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "", "+48 312645978", new Guid("2bf88d09-a7fd-422a-998b-858afda2872d") },
                    { new Guid("dc0274f5-7dd4-446a-9cbc-107a9886993a"), "b.smyk@gmail.com", "Bartosz", "Smyk", "a1", "", "213-546-879", new Guid("bf15a53a-82d5-4684-ae2b-fc7d0703eebb") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[] { new Guid("465ab4ac-9b40-4307-865a-ed26203f5046"), null, null, "Użytkownicy", true, null, null, new Guid("68079db0-5c63-42fe-8172-345f75b89b57") });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[] { new Guid("9bb7eb2a-87d3-41b8-b470-7629348d1cca"), null, null, "Role", true, null, null, new Guid("68079db0-5c63-42fe-8172-345f75b89b57") });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[] { new Guid("fa4bff80-dda9-458a-bfb1-5779bbde0c99"), null, null, "Użytkownicy", true, null, true, new Guid("b06cfb85-898c-4bba-9a60-c460e4353935") });

            migrationBuilder.CreateIndex(
                name: "IX_LocalInfos_BuildingAddressId",
                table: "LocalInfos",
                column: "BuildingAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_LocalInfos_BuildingAddresses_BuildingAddressId",
                table: "LocalInfos",
                column: "BuildingAddressId",
                principalTable: "BuildingAddresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LocalInfos_BuildingAddresses_BuildingAddressId",
                table: "LocalInfos");

            migrationBuilder.DropIndex(
                name: "IX_LocalInfos_BuildingAddressId",
                table: "LocalInfos");

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0396bbc3-d008-414f-8e7b-9a01fa8028d5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0b93e9d6-f5ad-4879-b5e7-a3b709b61107"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("34118c2d-6254-42e2-b65f-ba4fa3f1021c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("465ab4ac-9b40-4307-865a-ed26203f5046"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5c85585a-e696-4bdb-9952-2df7667f89cf"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("84a08a58-a2ef-4ad7-9250-30abe0b57d3d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9bb7eb2a-87d3-41b8-b470-7629348d1cca"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9def1529-bbd6-4102-bcdc-c6aba7494a59"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a62c8633-6aad-43b2-acda-581e0e27e58d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("eee6f289-8650-46f5-9d72-86431d8a301e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fa4bff80-dda9-458a-bfb1-5779bbde0c99"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("15b0f2bc-cb2c-4358-b0dc-5b1930c8ba6f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("76dab38a-6ac2-4a00-b7e4-dc9c5eb54c17"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("877be63e-88a3-43c7-840d-1999c454a15d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc0274f5-7dd4-446a-9cbc-107a9886993a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("4c8c8e3c-a642-498c-bb8b-d124a1c1629a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a57319a6-431b-4623-aee5-7b4c43877756"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bf15a53a-82d5-4684-ae2b-fc7d0703eebb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68079db0-5c63-42fe-8172-345f75b89b57"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b06cfb85-898c-4bba-9a60-c460e4353935"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2bf88d09-a7fd-422a-998b-858afda2872d"));

            migrationBuilder.DropColumn(
                name: "BuildingAddressId",
                table: "LocalInfos");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1c3888ae-ed0f-4e11-a472-73449714767e"), "Pracownik" },
                    { new Guid("2d41aac4-12fa-483e-a0c7-84f79b647e9c"), "Administrator" },
                    { new Guid("54259fa6-5831-4d22-a7c0-bfd47b97e409"), "Szef" },
                    { new Guid("963de526-f5c9-4390-b960-29bd519b0f3c"), "Praktykant" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("229b7178-2f0e-41cb-903a-d8767201a55b"), true, true, "Użytkownicy", true, new Guid("54259fa6-5831-4d22-a7c0-bfd47b97e409"), true, null },
                    { new Guid("69b13991-6e6b-4a91-9710-a8630d09f1ae"), true, true, "Role", true, new Guid("2d41aac4-12fa-483e-a0c7-84f79b647e9c"), true, null },
                    { new Guid("83bf0ae7-99a9-46af-aef5-014502ac384b"), true, true, "Role", true, new Guid("54259fa6-5831-4d22-a7c0-bfd47b97e409"), true, null },
                    { new Guid("84f61f91-c239-4f57-a9a9-0616924b5ef6"), false, false, "Użytkownicy", false, new Guid("1c3888ae-ed0f-4e11-a472-73449714767e"), false, null },
                    { new Guid("b4852d4a-cb14-4105-9ce3-404aa0d68015"), false, false, "Role", false, new Guid("963de526-f5c9-4390-b960-29bd519b0f3c"), false, null },
                    { new Guid("dcea27ab-846d-4cd4-be58-bf0911daf69f"), true, true, "Użytkownicy", true, new Guid("2d41aac4-12fa-483e-a0c7-84f79b647e9c"), true, null },
                    { new Guid("e6edee5f-e103-4915-b438-c7ef709e1dcf"), false, false, "Użytkownicy", false, new Guid("963de526-f5c9-4390-b960-29bd519b0f3c"), false, null },
                    { new Guid("e8423c77-40c1-457d-985a-32e60d30d517"), false, false, "Role", false, new Guid("1c3888ae-ed0f-4e11-a472-73449714767e"), false, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("08296208-7e1f-4717-9465-8ed211078b44"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "", "987654321", new Guid("1c3888ae-ed0f-4e11-a472-73449714767e") },
                    { new Guid("28fc32af-8687-4d08-b84b-40673032865f"), "", "admin", "", "admin", "admin", "", new Guid("2d41aac4-12fa-483e-a0c7-84f79b647e9c") },
                    { new Guid("79dd043d-339f-4bca-832a-09efc1e1be4f"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "", "+48 312645978", new Guid("1c3888ae-ed0f-4e11-a472-73449714767e") },
                    { new Guid("84714bdf-6372-415f-bfca-46e71cb1548e"), "b.smyk@gmail.com", "Bartosz", "Smyk", "a1", "", "213-546-879", new Guid("963de526-f5c9-4390-b960-29bd519b0f3c") },
                    { new Guid("e8b93ff6-fb2e-405a-b672-10de5132b966"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "", "+48 321 654 987", new Guid("1c3888ae-ed0f-4e11-a472-73449714767e") },
                    { new Guid("ef95dac5-0b0d-431b-81cf-2514e2e57f79"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "k.tumiel", "", "123 456 789", new Guid("54259fa6-5831-4d22-a7c0-bfd47b97e409") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[] { new Guid("1d448260-1841-4c16-89de-9ce6a354fe55"), null, null, "Użytkownicy", true, null, null, new Guid("08296208-7e1f-4717-9465-8ed211078b44") });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[] { new Guid("90a9a755-a25b-4791-ba0e-215c28223119"), null, null, "Role", true, null, null, new Guid("08296208-7e1f-4717-9465-8ed211078b44") });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[] { new Guid("dd49f27b-bd7e-49c9-80ca-eb2cd4497e11"), null, null, "Użytkownicy", true, null, true, new Guid("79dd043d-339f-4bca-832a-09efc1e1be4f") });
        }
    }
}
