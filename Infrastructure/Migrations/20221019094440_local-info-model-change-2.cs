using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class localinfomodelchange2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1ffc64ad-a367-4ae0-affa-3f241bce99e7"), "Praktykant" },
                    { new Guid("6fdc0908-0c4c-462b-a4b3-9520c3954636"), "Pracownik" },
                    { new Guid("b93fee3f-1e03-44c4-8343-29c2f38afc86"), "Administrator" },
                    { new Guid("d80353b5-f91d-4465-ad8d-94e0906626b1"), "Szef" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("2fbf3119-4701-438d-80ed-4d0c197be154"), true, true, "Role", true, new Guid("b93fee3f-1e03-44c4-8343-29c2f38afc86"), true, null },
                    { new Guid("4750b504-9f04-42ee-8093-80b086e24712"), false, false, "Role", false, new Guid("1ffc64ad-a367-4ae0-affa-3f241bce99e7"), false, null },
                    { new Guid("66bbe07d-49b6-4d7e-964a-0ce1232f8d79"), true, true, "Użytkownicy", true, new Guid("b93fee3f-1e03-44c4-8343-29c2f38afc86"), true, null },
                    { new Guid("8e9c8803-1137-4577-8e95-d75639e830d9"), false, false, "Użytkownicy", false, new Guid("1ffc64ad-a367-4ae0-affa-3f241bce99e7"), false, null },
                    { new Guid("cce8e160-505c-4128-bbbf-ed74379c53f2"), true, true, "Role", true, new Guid("d80353b5-f91d-4465-ad8d-94e0906626b1"), true, null },
                    { new Guid("f396d23a-0632-4a4d-bdf2-4ff0a3c6ef1d"), true, true, "Użytkownicy", true, new Guid("d80353b5-f91d-4465-ad8d-94e0906626b1"), true, null },
                    { new Guid("fb0893b7-34f1-404e-a061-97e9bdfb419b"), false, false, "Użytkownicy", false, new Guid("6fdc0908-0c4c-462b-a4b3-9520c3954636"), false, null },
                    { new Guid("fce2b54e-a666-4ad0-8540-665d7d497292"), false, false, "Role", false, new Guid("6fdc0908-0c4c-462b-a4b3-9520c3954636"), false, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("080b5333-3ccb-4767-bfa2-f62393319bce"), "b.smyk@gmail.com", "Bartosz", "Smyk", "a1", "", "213-546-879", new Guid("1ffc64ad-a367-4ae0-affa-3f241bce99e7") },
                    { new Guid("0f5c7283-cef0-4171-9f63-3d45fd351cf1"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "", "+48 312645978", new Guid("6fdc0908-0c4c-462b-a4b3-9520c3954636") },
                    { new Guid("7320c0c9-a520-45cf-94da-dd3f833af073"), "", "admin", "", "admin", "admin", "", new Guid("b93fee3f-1e03-44c4-8343-29c2f38afc86") },
                    { new Guid("7849b131-e48e-4f66-a923-b8b4f32163b2"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "", "+48 321 654 987", new Guid("6fdc0908-0c4c-462b-a4b3-9520c3954636") },
                    { new Guid("79c062d0-59b2-4834-bc38-23afbf05c8f8"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "", "987654321", new Guid("6fdc0908-0c4c-462b-a4b3-9520c3954636") },
                    { new Guid("bc2e7865-c892-43c2-b2fc-3e1b91d3df5b"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "k.tumiel", "", "123 456 789", new Guid("d80353b5-f91d-4465-ad8d-94e0906626b1") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[] { new Guid("17ce0d83-4dac-4093-b090-15132949d418"), null, null, "Użytkownicy", true, null, null, new Guid("79c062d0-59b2-4834-bc38-23afbf05c8f8") });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[] { new Guid("bb3dc281-1442-4ad0-91a9-16c718fbeb88"), null, null, "Role", true, null, null, new Guid("79c062d0-59b2-4834-bc38-23afbf05c8f8") });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[] { new Guid("ec21a1d9-596e-4f09-a4c1-dce94c53ab06"), null, null, "Użytkownicy", true, null, true, new Guid("0f5c7283-cef0-4171-9f63-3d45fd351cf1") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("17ce0d83-4dac-4093-b090-15132949d418"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2fbf3119-4701-438d-80ed-4d0c197be154"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4750b504-9f04-42ee-8093-80b086e24712"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("66bbe07d-49b6-4d7e-964a-0ce1232f8d79"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8e9c8803-1137-4577-8e95-d75639e830d9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("bb3dc281-1442-4ad0-91a9-16c718fbeb88"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("cce8e160-505c-4128-bbbf-ed74379c53f2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ec21a1d9-596e-4f09-a4c1-dce94c53ab06"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f396d23a-0632-4a4d-bdf2-4ff0a3c6ef1d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fb0893b7-34f1-404e-a061-97e9bdfb419b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fce2b54e-a666-4ad0-8540-665d7d497292"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("080b5333-3ccb-4767-bfa2-f62393319bce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7320c0c9-a520-45cf-94da-dd3f833af073"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7849b131-e48e-4f66-a923-b8b4f32163b2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bc2e7865-c892-43c2-b2fc-3e1b91d3df5b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1ffc64ad-a367-4ae0-affa-3f241bce99e7"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b93fee3f-1e03-44c4-8343-29c2f38afc86"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d80353b5-f91d-4465-ad8d-94e0906626b1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f5c7283-cef0-4171-9f63-3d45fd351cf1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("79c062d0-59b2-4834-bc38-23afbf05c8f8"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6fdc0908-0c4c-462b-a4b3-9520c3954636"));

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
    }
}
