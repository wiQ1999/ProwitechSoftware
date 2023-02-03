using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class rolesseederchanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("525c9c25-fed8-4a88-a835-3e01d07f1995"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("a601e976-ecfd-4b86-90e8-c611185fc9aa"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("adb7181e-52b6-463a-8010-db2ef637731b"), "Szef" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("0e95abba-6f4f-4343-bce4-02342f84d474"), true, true, true, new Guid("a601e976-ecfd-4b86-90e8-c611185fc9aa"), "Roles", true, null },
                    { new Guid("35a2e0e8-3d1d-4efb-8d69-83bb8dd21330"), false, false, true, new Guid("525c9c25-fed8-4a88-a835-3e01d07f1995"), "InspectionTasks", true, null },
                    { new Guid("49651940-4d3d-4112-a3ec-2a7b4444d416"), true, true, true, new Guid("a601e976-ecfd-4b86-90e8-c611185fc9aa"), "Users", true, null },
                    { new Guid("5b1483a9-f5f8-4652-98cf-0fb5298f6674"), true, true, true, new Guid("adb7181e-52b6-463a-8010-db2ef637731b"), "Users", true, null },
                    { new Guid("7c7758c5-f0e8-431a-bd2e-52122bc913ee"), true, true, true, new Guid("adb7181e-52b6-463a-8010-db2ef637731b"), "AllInspectionProtocols", true, null },
                    { new Guid("98eab0bc-5c57-4302-9be2-3afb9ca9fa7e"), true, true, true, new Guid("adb7181e-52b6-463a-8010-db2ef637731b"), "Permissions", true, null },
                    { new Guid("99a829a1-10d8-442e-8499-d7eaae4fb452"), true, true, true, new Guid("adb7181e-52b6-463a-8010-db2ef637731b"), "Buildings", true, null },
                    { new Guid("9b0c6372-4d29-4143-9e50-6a5f03a32edd"), true, true, true, new Guid("adb7181e-52b6-463a-8010-db2ef637731b"), "BuildingAddresses", true, null },
                    { new Guid("abe01ae0-6808-40e4-b6f7-851434e4134b"), true, true, true, new Guid("adb7181e-52b6-463a-8010-db2ef637731b"), "InspectionTasks", true, null },
                    { new Guid("b96de3ba-4557-4082-bdaa-b45949889b5e"), true, true, true, new Guid("a601e976-ecfd-4b86-90e8-c611185fc9aa"), "Permissions", true, null },
                    { new Guid("c58afdea-bf27-4259-a0f7-e10f87b44c33"), true, true, true, new Guid("adb7181e-52b6-463a-8010-db2ef637731b"), "Roles", true, null },
                    { new Guid("cf59840b-a3b3-4f0e-a1d8-dfc228e7d188"), true, true, true, new Guid("525c9c25-fed8-4a88-a835-3e01d07f1995"), "PersonalProtocols", true, null },
                    { new Guid("e4ba68c9-037a-46e0-b4a6-0455510e509d"), true, true, true, new Guid("adb7181e-52b6-463a-8010-db2ef637731b"), "PropertyManagers", true, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("033ee777-3d8f-4084-bf42-af185b36eb3d"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "AQAAAAIAAYagAAAAECm6KiDZP8S8vW93NzgUpKY6KmQGKgXeKYlAvIIIITasWvM9bgv8eBnBonyECQR9dA==", "987654321", new Guid("525c9c25-fed8-4a88-a835-3e01d07f1995") },
                    { new Guid("1505d9c9-5cb8-45c2-a882-09b27613fb1a"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "AQAAAAIAAYagAAAAEFs31bGqcOa6FzMIuJbx7Gd4q6f1uvGa1X1MkwCx1KxwvIVd0vkJ68BGn3JZh7bRJg==", "+48 312645978", new Guid("525c9c25-fed8-4a88-a835-3e01d07f1995") },
                    { new Guid("2ecf2694-2aa1-4a4e-9d92-1c46455bf54b"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "AQAAAAIAAYagAAAAEA5accMeEAbM5NWza6dIexdmA9pm0lwkn0FdC25LndNtqpWv3LLAFAxJMI603QEYYQ==", "+48 321 654 987", new Guid("525c9c25-fed8-4a88-a835-3e01d07f1995") },
                    { new Guid("65156ad5-be11-49ce-bbf0-cd6d42af2322"), "", "admin", "", "admin", "AQAAAAIAAYagAAAAEEyMdVd750y7HB7JctoYjXsH3zgYoRaFvtMC2pWLbNopqfffQzxATAQ868CJ28BZTg==", "", new Guid("a601e976-ecfd-4b86-90e8-c611185fc9aa") },
                    { new Guid("6bbc5e8f-0444-4cf2-9396-cdac6d532fe5"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "boss", "AQAAAAIAAYagAAAAEHdhme/atVeeNvyXv2JLRvCWcdZkzsQ/xdmcB63eas9CiG1T+F0ZMadu88gvSa5OKQ==", "123 456 789", new Guid("adb7181e-52b6-463a-8010-db2ef637731b") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("04c1fe07-c312-4647-9e0c-7a784fda51a7"), null, null, false, null, "Users", null, new Guid("033ee777-3d8f-4084-bf42-af185b36eb3d") },
                    { new Guid("56756986-0d4e-4463-bd30-43379fe41c5f"), null, null, false, null, "Roles", null, new Guid("033ee777-3d8f-4084-bf42-af185b36eb3d") },
                    { new Guid("6f7493fd-3907-4415-a301-5856026fc245"), true, true, null, null, "Users", true, new Guid("1505d9c9-5cb8-45c2-a882-09b27613fb1a") },
                    { new Guid("a008f971-98b8-492c-aa64-eef86b77354a"), true, null, null, null, "Roles", true, new Guid("1505d9c9-5cb8-45c2-a882-09b27613fb1a") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("04c1fe07-c312-4647-9e0c-7a784fda51a7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0e95abba-6f4f-4343-bce4-02342f84d474"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("35a2e0e8-3d1d-4efb-8d69-83bb8dd21330"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("49651940-4d3d-4112-a3ec-2a7b4444d416"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("56756986-0d4e-4463-bd30-43379fe41c5f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5b1483a9-f5f8-4652-98cf-0fb5298f6674"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6f7493fd-3907-4415-a301-5856026fc245"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7c7758c5-f0e8-431a-bd2e-52122bc913ee"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("98eab0bc-5c57-4302-9be2-3afb9ca9fa7e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("99a829a1-10d8-442e-8499-d7eaae4fb452"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9b0c6372-4d29-4143-9e50-6a5f03a32edd"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a008f971-98b8-492c-aa64-eef86b77354a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("abe01ae0-6808-40e4-b6f7-851434e4134b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b96de3ba-4557-4082-bdaa-b45949889b5e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c58afdea-bf27-4259-a0f7-e10f87b44c33"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("cf59840b-a3b3-4f0e-a1d8-dfc228e7d188"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e4ba68c9-037a-46e0-b4a6-0455510e509d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2ecf2694-2aa1-4a4e-9d92-1c46455bf54b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("65156ad5-be11-49ce-bbf0-cd6d42af2322"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6bbc5e8f-0444-4cf2-9396-cdac6d532fe5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a601e976-ecfd-4b86-90e8-c611185fc9aa"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("adb7181e-52b6-463a-8010-db2ef637731b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("033ee777-3d8f-4084-bf42-af185b36eb3d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1505d9c9-5cb8-45c2-a882-09b27613fb1a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("525c9c25-fed8-4a88-a835-3e01d07f1995"));

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
    }
}
