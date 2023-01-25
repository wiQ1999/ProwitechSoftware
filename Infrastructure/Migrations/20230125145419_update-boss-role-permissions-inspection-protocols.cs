using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class updatebossrolepermissionsinspectionprotocols : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("1952c272-d1c4-476e-90f6-09b51f3d939f"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("4029c159-3cb1-42e5-a61c-95e68522186f"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("92730631-cf3e-426d-9765-aecc52566d3f"), "Szef" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("15b13fc8-6858-4aaf-b61a-77e105967061"), true, true, true, new Guid("92730631-cf3e-426d-9765-aecc52566d3f"), "InspectionTasks", true, null },
                    { new Guid("3e2d7aaa-e5be-42c3-bc16-3d65536f8062"), false, false, true, new Guid("4029c159-3cb1-42e5-a61c-95e68522186f"), "Users", false, null },
                    { new Guid("5114b8d1-b199-4664-835d-0e9816102bd5"), true, true, true, new Guid("92730631-cf3e-426d-9765-aecc52566d3f"), "Permissions", true, null },
                    { new Guid("5d47cb31-f6ee-4dd6-acdf-635f776faf4b"), true, true, true, new Guid("92730631-cf3e-426d-9765-aecc52566d3f"), "Roles", true, null },
                    { new Guid("60b522e5-2568-4681-8a57-ff70e108e2a2"), true, true, true, new Guid("92730631-cf3e-426d-9765-aecc52566d3f"), "Buildings", true, null },
                    { new Guid("78a0b804-6b8f-446e-a19f-b7a82e669dbd"), true, true, true, new Guid("92730631-cf3e-426d-9765-aecc52566d3f"), "Users", true, null },
                    { new Guid("90010a16-c909-4db1-9a87-0f29112190c2"), true, true, true, new Guid("1952c272-d1c4-476e-90f6-09b51f3d939f"), "Roles", true, null },
                    { new Guid("9183ebfc-66fe-4c10-89d2-b408bfa41e8c"), false, false, false, new Guid("4029c159-3cb1-42e5-a61c-95e68522186f"), "Permissions", false, null },
                    { new Guid("c10b05f0-a301-4bf1-b3dc-fe011db505b7"), true, true, true, new Guid("1952c272-d1c4-476e-90f6-09b51f3d939f"), "Permissions", true, null },
                    { new Guid("e98d37a7-253a-41a1-8918-503e8c644ccd"), true, true, true, new Guid("92730631-cf3e-426d-9765-aecc52566d3f"), "PropertyManagers", true, null },
                    { new Guid("f3346704-014d-458f-b604-287711ebf51b"), false, false, true, new Guid("4029c159-3cb1-42e5-a61c-95e68522186f"), "Roles", false, null },
                    { new Guid("f6ba3b3f-927e-4f23-b7d3-025f312e3eef"), true, true, true, new Guid("92730631-cf3e-426d-9765-aecc52566d3f"), "InspectionProtocols", true, null },
                    { new Guid("fb871ce7-a019-4e64-80ed-7937c0e24505"), true, true, true, new Guid("1952c272-d1c4-476e-90f6-09b51f3d939f"), "Users", true, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("1dd6098b-3f23-43e9-8a91-ee27332db176"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "AQAAAAIAAYagAAAAEPD79WehssCzbUbqTXv+xKJ8mJh5+yWSte8Ql5UJJFOOseFn5skWxEce5TnwxqUaCg==", "+48 312645978", new Guid("4029c159-3cb1-42e5-a61c-95e68522186f") },
                    { new Guid("265545d5-81c4-4b8d-9d5e-4a95c4f19149"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "AQAAAAIAAYagAAAAEH6xrra9/KnZ1FJh8Y+gRIn6w1Jn/X5nPBm2sDMu0WJEcgCo9T5XJ+3xVeDTWcEHdw==", "987654321", new Guid("4029c159-3cb1-42e5-a61c-95e68522186f") },
                    { new Guid("2c8ec0e6-0dcc-4dc6-96fb-000447c6c691"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "boss", "AQAAAAIAAYagAAAAEPpQDI46cyPqM7F0xbLDmamDnjAMZ8Ew131tvHw6Zq1jq114wSTIIj556Wg3B1KIdQ==", "123 456 789", new Guid("92730631-cf3e-426d-9765-aecc52566d3f") },
                    { new Guid("6dcdb949-5000-47cb-aaed-67b63d35e802"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "AQAAAAIAAYagAAAAEJTWfWko40Tfa5FuwFRRwlyW+6sYq2IXgCuvpuvJqR3m3JRXEr/5R7+gtk5N6z9ANQ==", "+48 321 654 987", new Guid("4029c159-3cb1-42e5-a61c-95e68522186f") },
                    { new Guid("aa2fadaa-ad70-49a1-b9b8-e728c7e20c79"), "", "admin", "", "admin", "AQAAAAIAAYagAAAAEOEtjCs0iSLX2ii0VkhuLtRKThNwaBc9p+TCI7zYbr8LdaGrBR32+vK6zfyoay92uQ==", "", new Guid("1952c272-d1c4-476e-90f6-09b51f3d939f") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("1babe02a-5122-4bc5-b294-3519d6ef08a2"), null, null, false, null, "Roles", null, new Guid("265545d5-81c4-4b8d-9d5e-4a95c4f19149") },
                    { new Guid("2e5b008e-f521-4a72-84aa-97e766175b01"), true, null, null, null, "Roles", true, new Guid("1dd6098b-3f23-43e9-8a91-ee27332db176") },
                    { new Guid("dfe11b1a-1926-402f-a29d-0c364a8f9515"), true, true, null, null, "Users", true, new Guid("1dd6098b-3f23-43e9-8a91-ee27332db176") },
                    { new Guid("f559be8e-c880-49cd-8e03-2d1e2e853fa5"), null, null, false, null, "Users", null, new Guid("265545d5-81c4-4b8d-9d5e-4a95c4f19149") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("15b13fc8-6858-4aaf-b61a-77e105967061"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1babe02a-5122-4bc5-b294-3519d6ef08a2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2e5b008e-f521-4a72-84aa-97e766175b01"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3e2d7aaa-e5be-42c3-bc16-3d65536f8062"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5114b8d1-b199-4664-835d-0e9816102bd5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5d47cb31-f6ee-4dd6-acdf-635f776faf4b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("60b522e5-2568-4681-8a57-ff70e108e2a2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("78a0b804-6b8f-446e-a19f-b7a82e669dbd"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("90010a16-c909-4db1-9a87-0f29112190c2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9183ebfc-66fe-4c10-89d2-b408bfa41e8c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c10b05f0-a301-4bf1-b3dc-fe011db505b7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("dfe11b1a-1926-402f-a29d-0c364a8f9515"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e98d37a7-253a-41a1-8918-503e8c644ccd"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f3346704-014d-458f-b604-287711ebf51b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f559be8e-c880-49cd-8e03-2d1e2e853fa5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f6ba3b3f-927e-4f23-b7d3-025f312e3eef"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fb871ce7-a019-4e64-80ed-7937c0e24505"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2c8ec0e6-0dcc-4dc6-96fb-000447c6c691"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6dcdb949-5000-47cb-aaed-67b63d35e802"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa2fadaa-ad70-49a1-b9b8-e728c7e20c79"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1952c272-d1c4-476e-90f6-09b51f3d939f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("92730631-cf3e-426d-9765-aecc52566d3f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1dd6098b-3f23-43e9-8a91-ee27332db176"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("265545d5-81c4-4b8d-9d5e-4a95c4f19149"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("4029c159-3cb1-42e5-a61c-95e68522186f"));

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
    }
}
