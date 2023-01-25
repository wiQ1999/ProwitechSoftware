using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class updatebossrolepermissions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0a6d0ab6-54cb-471c-b4f1-02c41004abf0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("10da4589-9144-47bd-8d85-29902a0ea7bf"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("156854ed-8cb3-4b5e-9236-1f10689d607b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1bbbee29-8032-4cb0-95d8-523ea85c0d65"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3842107c-ff76-4901-9884-0269c2bde4a8"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("49f9632e-e526-4e07-ad20-e8d32e18bc9a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("59c85e18-91a0-4133-82be-5c8bed77d631"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("909a023f-4e71-4ec7-a667-f91a90b63c6a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9bc215f2-525b-49b7-aa69-5672c320af59"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("be103e5a-4e5d-43c1-88d6-65fb8766e2ea"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("cea5481a-523c-4bda-b6ff-4d04aa4be369"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d46f3e57-d352-4dff-bbf5-fa0187605bb1"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ff58a69b-fec5-4d40-a80b-8772c88f6837"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5050b5e1-9480-4bda-8250-3a60f2e75e78"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a16e60d8-5e64-4c24-8d98-0c010431deac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ee499277-8a67-45c8-9b67-3465bc94c3bb"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b93e2927-47d6-42c0-bf95-3a587b0e680c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("fc433f74-7b14-4eb6-929f-15ea9f1ae786"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("18aaf8d7-2b5a-4fe5-b14c-01f9cb29f0b9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("afcae8be-7d40-47ec-b0e6-a12f9391b474"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c77232f3-7681-410d-8916-bcbf5250b833"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("77960d80-d908-4975-8e5c-49dd5f7ae23c"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("a41a8b4a-022f-41c8-a267-a3c4a3c96f41"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("a655845d-4304-4c97-a706-6b5f80f6d338"), "Szef" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("0e171da1-f20d-467a-b2b9-4b67375c0814"), true, true, true, new Guid("a655845d-4304-4c97-a706-6b5f80f6d338"), "Users", true, null },
                    { new Guid("2e74812f-e340-4137-9231-8cc5352b7e29"), false, false, true, new Guid("a41a8b4a-022f-41c8-a267-a3c4a3c96f41"), "Users", false, null },
                    { new Guid("47858025-ca81-4855-9232-90fd9f502fef"), true, true, true, new Guid("a655845d-4304-4c97-a706-6b5f80f6d338"), "Roles", true, null },
                    { new Guid("54a9db9a-4381-41aa-ba29-cd942da60365"), true, true, true, new Guid("77960d80-d908-4975-8e5c-49dd5f7ae23c"), "Roles", true, null },
                    { new Guid("5587a07f-16a6-4ca9-853e-c50a7ce7d72a"), false, false, false, new Guid("a41a8b4a-022f-41c8-a267-a3c4a3c96f41"), "Permissions", false, null },
                    { new Guid("6f7731a9-00f0-4941-a927-509eac6c5833"), true, true, true, new Guid("77960d80-d908-4975-8e5c-49dd5f7ae23c"), "Permissions", true, null },
                    { new Guid("7c8c522b-7288-4b48-ba67-76a307073f48"), true, true, true, new Guid("a655845d-4304-4c97-a706-6b5f80f6d338"), "Buildings", true, null },
                    { new Guid("7e940fd8-3ce7-490e-b50f-6ab66d2afcf9"), false, false, true, new Guid("a41a8b4a-022f-41c8-a267-a3c4a3c96f41"), "Roles", false, null },
                    { new Guid("a4e2e8da-0f29-4feb-a927-f56979ce05ea"), true, true, true, new Guid("77960d80-d908-4975-8e5c-49dd5f7ae23c"), "Users", true, null },
                    { new Guid("ce9aae2b-eff3-4116-8fba-76733dec4796"), true, true, true, new Guid("a655845d-4304-4c97-a706-6b5f80f6d338"), "PropertyManagers", true, null },
                    { new Guid("d95bdb46-8554-44c6-a34d-95a41a4e349e"), true, true, true, new Guid("a655845d-4304-4c97-a706-6b5f80f6d338"), "InspectionTasks", true, null },
                    { new Guid("f758588d-2870-4acb-8337-5b93de7422f5"), true, true, true, new Guid("a655845d-4304-4c97-a706-6b5f80f6d338"), "Permissions", true, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("3e5775f3-334d-4f6d-afa3-bf7812b50308"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "AQAAAAIAAYagAAAAEAuxnwo1Cg+xt5vuuq8buwVwu2ZQ9VA1odtQa5a2CoDdtvsKIe+qKCWnE9DVxuyAWA==", "987654321", new Guid("a41a8b4a-022f-41c8-a267-a3c4a3c96f41") },
                    { new Guid("66b1756b-dc4f-4521-890f-e12ba6b050fe"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "boss", "AQAAAAIAAYagAAAAEBdvNdFHDlt6MNUUG5IC8xpiZxwktnPdc3zAeX+pQJ92YEqQne+qtr9o1iH7NzL8gQ==", "123 456 789", new Guid("a655845d-4304-4c97-a706-6b5f80f6d338") },
                    { new Guid("a5ba25f0-caaf-4180-9d99-77ce7d32e6b1"), "", "admin", "", "admin", "AQAAAAIAAYagAAAAEN90WhEs7z2qD3U77ZyZ//VmwWMM5GTncBEa+1QuTYPgKiETUsng8MwsFCsH3TW/AA==", "", new Guid("77960d80-d908-4975-8e5c-49dd5f7ae23c") },
                    { new Guid("c36de207-972b-4d7f-a666-2108d57f7f26"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "AQAAAAIAAYagAAAAELkqZJwKdIUtBI2OBLnyMmYeQrKd0VPkqAWLp/i/8XWgeqhbMp03kFKGqPMQpTp+SA==", "+48 321 654 987", new Guid("a41a8b4a-022f-41c8-a267-a3c4a3c96f41") },
                    { new Guid("d1bc04b1-7514-4cd0-908d-fbc0292761d4"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "AQAAAAIAAYagAAAAELNB2bkIabUHLv830yEp1QSX+zhqkt2s6r8Xv8otrlFPbv1CENZAzYfOrRb3bc911w==", "+48 312645978", new Guid("a41a8b4a-022f-41c8-a267-a3c4a3c96f41") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("184f8da4-f4e2-4d4c-a766-407a2d3ab26b"), true, null, null, null, "Roles", true, new Guid("d1bc04b1-7514-4cd0-908d-fbc0292761d4") },
                    { new Guid("32a4531e-396c-482f-a17e-1271b36f4806"), true, true, null, null, "Users", true, new Guid("d1bc04b1-7514-4cd0-908d-fbc0292761d4") },
                    { new Guid("85cec170-784f-476b-b0a5-928ab3457950"), null, null, false, null, "Users", null, new Guid("3e5775f3-334d-4f6d-afa3-bf7812b50308") },
                    { new Guid("9c45c0d6-2d4f-480c-a91b-692078484c75"), null, null, false, null, "Roles", null, new Guid("3e5775f3-334d-4f6d-afa3-bf7812b50308") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0e171da1-f20d-467a-b2b9-4b67375c0814"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("184f8da4-f4e2-4d4c-a766-407a2d3ab26b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2e74812f-e340-4137-9231-8cc5352b7e29"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("32a4531e-396c-482f-a17e-1271b36f4806"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("47858025-ca81-4855-9232-90fd9f502fef"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("54a9db9a-4381-41aa-ba29-cd942da60365"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5587a07f-16a6-4ca9-853e-c50a7ce7d72a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6f7731a9-00f0-4941-a927-509eac6c5833"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7c8c522b-7288-4b48-ba67-76a307073f48"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7e940fd8-3ce7-490e-b50f-6ab66d2afcf9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("85cec170-784f-476b-b0a5-928ab3457950"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9c45c0d6-2d4f-480c-a91b-692078484c75"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a4e2e8da-0f29-4feb-a927-f56979ce05ea"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ce9aae2b-eff3-4116-8fba-76733dec4796"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d95bdb46-8554-44c6-a34d-95a41a4e349e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f758588d-2870-4acb-8337-5b93de7422f5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66b1756b-dc4f-4521-890f-e12ba6b050fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a5ba25f0-caaf-4180-9d99-77ce7d32e6b1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c36de207-972b-4d7f-a666-2108d57f7f26"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("77960d80-d908-4975-8e5c-49dd5f7ae23c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a655845d-4304-4c97-a706-6b5f80f6d338"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3e5775f3-334d-4f6d-afa3-bf7812b50308"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d1bc04b1-7514-4cd0-908d-fbc0292761d4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a41a8b4a-022f-41c8-a267-a3c4a3c96f41"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("b93e2927-47d6-42c0-bf95-3a587b0e680c"), "Szef" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("c77232f3-7681-410d-8916-bcbf5250b833"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("fc433f74-7b14-4eb6-929f-15ea9f1ae786"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("156854ed-8cb3-4b5e-9236-1f10689d607b"), true, true, true, new Guid("b93e2927-47d6-42c0-bf95-3a587b0e680c"), "Permissions", true, null },
                    { new Guid("1bbbee29-8032-4cb0-95d8-523ea85c0d65"), true, true, true, new Guid("fc433f74-7b14-4eb6-929f-15ea9f1ae786"), "Permissions", true, null },
                    { new Guid("3842107c-ff76-4901-9884-0269c2bde4a8"), false, false, true, new Guid("c77232f3-7681-410d-8916-bcbf5250b833"), "Users", false, null },
                    { new Guid("59c85e18-91a0-4133-82be-5c8bed77d631"), false, false, false, new Guid("c77232f3-7681-410d-8916-bcbf5250b833"), "Permissions", false, null },
                    { new Guid("909a023f-4e71-4ec7-a667-f91a90b63c6a"), true, true, true, new Guid("b93e2927-47d6-42c0-bf95-3a587b0e680c"), "Roles", true, null },
                    { new Guid("be103e5a-4e5d-43c1-88d6-65fb8766e2ea"), false, false, true, new Guid("c77232f3-7681-410d-8916-bcbf5250b833"), "Roles", false, null },
                    { new Guid("cea5481a-523c-4bda-b6ff-4d04aa4be369"), true, true, true, new Guid("b93e2927-47d6-42c0-bf95-3a587b0e680c"), "Users", true, null },
                    { new Guid("d46f3e57-d352-4dff-bbf5-fa0187605bb1"), true, true, true, new Guid("fc433f74-7b14-4eb6-929f-15ea9f1ae786"), "Roles", true, null },
                    { new Guid("ff58a69b-fec5-4d40-a80b-8772c88f6837"), true, true, true, new Guid("fc433f74-7b14-4eb6-929f-15ea9f1ae786"), "Users", true, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("18aaf8d7-2b5a-4fe5-b14c-01f9cb29f0b9"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "AQAAAAIAAYagAAAAECOxSYhPtAPPNmdjnlVkLjvIXdqGujn7o2LRM2/d8Ayj9chrHOH9qe6G+o+P/9QwfQ==", "+48 312645978", new Guid("c77232f3-7681-410d-8916-bcbf5250b833") },
                    { new Guid("5050b5e1-9480-4bda-8250-3a60f2e75e78"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "AQAAAAIAAYagAAAAEODdVktzfP6To5AkFRNswjElhlcZzAq5j3EuDYtMbdk2Rv6/O5H3jHqsI0ZUnwWYWQ==", "+48 321 654 987", new Guid("c77232f3-7681-410d-8916-bcbf5250b833") },
                    { new Guid("a16e60d8-5e64-4c24-8d98-0c010431deac"), "", "admin", "", "admin", "AQAAAAIAAYagAAAAEEjDNYOizs2XqIILQxXvyluJs4nVo2vybTETSGjSO/S0nPXoDPbuDuSAlsUitDUNEA==", "", new Guid("fc433f74-7b14-4eb6-929f-15ea9f1ae786") },
                    { new Guid("afcae8be-7d40-47ec-b0e6-a12f9391b474"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "AQAAAAIAAYagAAAAEAabiO2crPNKtykkocch8mRrvtZGkCjRqDbNXBUMHlqkxHzLPpGkEzt8GI06aXaMiA==", "987654321", new Guid("c77232f3-7681-410d-8916-bcbf5250b833") },
                    { new Guid("ee499277-8a67-45c8-9b67-3465bc94c3bb"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "boss", "AQAAAAIAAYagAAAAEOLYItq3N8NHPyo/HHygC3E7k8e3otc8IvSYFmuO73BskrF5cHgEZKzhQwVynVCNww==", "123 456 789", new Guid("b93e2927-47d6-42c0-bf95-3a587b0e680c") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("0a6d0ab6-54cb-471c-b4f1-02c41004abf0"), null, null, false, null, "Users", null, new Guid("afcae8be-7d40-47ec-b0e6-a12f9391b474") },
                    { new Guid("10da4589-9144-47bd-8d85-29902a0ea7bf"), true, true, null, null, "Users", true, new Guid("18aaf8d7-2b5a-4fe5-b14c-01f9cb29f0b9") },
                    { new Guid("49f9632e-e526-4e07-ad20-e8d32e18bc9a"), true, null, null, null, "Roles", true, new Guid("18aaf8d7-2b5a-4fe5-b14c-01f9cb29f0b9") },
                    { new Guid("9bc215f2-525b-49b7-aa69-5672c320af59"), null, null, false, null, "Roles", null, new Guid("afcae8be-7d40-47ec-b0e6-a12f9391b474") }
                });
        }
    }
}
