using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class permissionsforworkersupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("3fd1a8b4-198d-4316-8a31-e24470cfa23e"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("6f22c910-e7f4-49e2-93b3-0ca3735f27b8"), "Szef" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("bf112d54-5c5a-4c81-a7a1-fb355a1e8f5e"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("5715815f-151e-41b8-931c-80b0955aab77"), true, true, true, new Guid("6f22c910-e7f4-49e2-93b3-0ca3735f27b8"), "Users", true, null },
                    { new Guid("5e194fb8-bcd3-42c0-a4d9-b5ec6c8b88bd"), true, true, true, new Guid("6f22c910-e7f4-49e2-93b3-0ca3735f27b8"), "Buildings", true, null },
                    { new Guid("6e2359db-b8e7-4473-8d4a-c367017aa57a"), true, true, true, new Guid("bf112d54-5c5a-4c81-a7a1-fb355a1e8f5e"), "PersonalProtocols", true, null },
                    { new Guid("756b1dd8-648d-4067-a796-916ef4533aa4"), true, true, true, new Guid("6f22c910-e7f4-49e2-93b3-0ca3735f27b8"), "Permissions", true, null },
                    { new Guid("762ac805-a3f6-4091-971f-ae96337eec78"), false, false, true, new Guid("bf112d54-5c5a-4c81-a7a1-fb355a1e8f5e"), "InspectionTasks", true, null },
                    { new Guid("7ad78227-9ba8-4a6d-94dd-5f8684e70338"), true, true, true, new Guid("3fd1a8b4-198d-4316-8a31-e24470cfa23e"), "Users", true, null },
                    { new Guid("9365f267-0ee7-4a40-bc15-46f55f58975b"), true, true, true, new Guid("3fd1a8b4-198d-4316-8a31-e24470cfa23e"), "Permissions", true, null },
                    { new Guid("9930acbf-ac5e-4f90-908d-060a97556ce9"), true, true, true, new Guid("6f22c910-e7f4-49e2-93b3-0ca3735f27b8"), "AllInspectionProtocols", true, null },
                    { new Guid("a8dbdf3d-8df8-4767-989a-0b0867091f1d"), true, true, true, new Guid("6f22c910-e7f4-49e2-93b3-0ca3735f27b8"), "PropertyManagers", true, null },
                    { new Guid("de2344d4-a36e-4e8f-abb5-72c9c5187a69"), true, true, true, new Guid("3fd1a8b4-198d-4316-8a31-e24470cfa23e"), "Roles", true, null },
                    { new Guid("e4709c0f-3031-449f-b445-bd512979ef53"), true, true, true, new Guid("6f22c910-e7f4-49e2-93b3-0ca3735f27b8"), "BuildingAddresses", true, null },
                    { new Guid("f1a8ef10-341a-4905-bdc5-f6db0c56ed8c"), true, true, true, new Guid("6f22c910-e7f4-49e2-93b3-0ca3735f27b8"), "Roles", true, null },
                    { new Guid("fafd1422-22eb-48e6-953c-7c95f3bea137"), true, true, true, new Guid("6f22c910-e7f4-49e2-93b3-0ca3735f27b8"), "InspectionTasks", true, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("2bc9a608-3d32-4d7d-86bd-0e6a180d8af2"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "AQAAAAIAAYagAAAAEIdYydZZfg06D7XpOSmIRpdIXdclSRNUJh/KdkW9aEpB9c4BlhRAiD8n+eX07EElog==", "+48 312645978", new Guid("bf112d54-5c5a-4c81-a7a1-fb355a1e8f5e") },
                    { new Guid("34507545-b723-46c8-98be-1f7580a319b6"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "boss", "AQAAAAIAAYagAAAAEP3TJADetxZlv9Oroi2fpW0tmvVxASYjEUqfXObH4hgYVLjcxPX/DbnOklf7QIDNzg==", "123 456 789", new Guid("6f22c910-e7f4-49e2-93b3-0ca3735f27b8") },
                    { new Guid("656e3782-88bc-40da-8882-4bae7ff5ceaa"), "", "admin", "", "admin", "AQAAAAIAAYagAAAAEJsZaigY+rOGPjVd6zT2FIQrrwktLIG0+EVQdhVOCyQxqI7+DhrjYf7YQdtfl6ZEiA==", "", new Guid("3fd1a8b4-198d-4316-8a31-e24470cfa23e") },
                    { new Guid("a8176e9c-8682-49f0-a8df-e13b4d2ae8df"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "AQAAAAIAAYagAAAAEHEeKj6FKPd3lVXn9bFZkZw9f9KS+a35KhNYY025bhp79ytXkqtjBKo3Gkif7t2jwQ==", "987654321", new Guid("bf112d54-5c5a-4c81-a7a1-fb355a1e8f5e") },
                    { new Guid("deedee82-ad41-4cac-9479-26ed385f2476"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "AQAAAAIAAYagAAAAEOr33laCCXjyEs4pYZRGePFxNitwOPDnKLOyBi3CaPMH8AsU3vuCmXyS9rsV2LSpYA==", "+48 321 654 987", new Guid("bf112d54-5c5a-4c81-a7a1-fb355a1e8f5e") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("0cbdec0b-037f-4f50-9fcd-cfb43ea77312"), true, true, true, null, "PersonalProtocols", true, new Guid("2bc9a608-3d32-4d7d-86bd-0e6a180d8af2") },
                    { new Guid("31632bfe-c082-4ee3-bb93-667f1dab7c4a"), false, false, true, null, "InspectionTasks", true, new Guid("2bc9a608-3d32-4d7d-86bd-0e6a180d8af2") },
                    { new Guid("5c7b5ac3-78cf-4741-8935-f7cd9db8ac00"), false, false, true, null, "InspectionTasks", true, new Guid("a8176e9c-8682-49f0-a8df-e13b4d2ae8df") },
                    { new Guid("dd4bde3c-ecc3-446c-b336-0a8d69de5ecc"), true, true, true, null, "PersonalProtocols", true, new Guid("a8176e9c-8682-49f0-a8df-e13b4d2ae8df") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0cbdec0b-037f-4f50-9fcd-cfb43ea77312"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("31632bfe-c082-4ee3-bb93-667f1dab7c4a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5715815f-151e-41b8-931c-80b0955aab77"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5c7b5ac3-78cf-4741-8935-f7cd9db8ac00"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5e194fb8-bcd3-42c0-a4d9-b5ec6c8b88bd"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6e2359db-b8e7-4473-8d4a-c367017aa57a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("756b1dd8-648d-4067-a796-916ef4533aa4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("762ac805-a3f6-4091-971f-ae96337eec78"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7ad78227-9ba8-4a6d-94dd-5f8684e70338"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9365f267-0ee7-4a40-bc15-46f55f58975b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9930acbf-ac5e-4f90-908d-060a97556ce9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a8dbdf3d-8df8-4767-989a-0b0867091f1d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("dd4bde3c-ecc3-446c-b336-0a8d69de5ecc"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("de2344d4-a36e-4e8f-abb5-72c9c5187a69"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e4709c0f-3031-449f-b445-bd512979ef53"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f1a8ef10-341a-4905-bdc5-f6db0c56ed8c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fafd1422-22eb-48e6-953c-7c95f3bea137"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("34507545-b723-46c8-98be-1f7580a319b6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("656e3782-88bc-40da-8882-4bae7ff5ceaa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("deedee82-ad41-4cac-9479-26ed385f2476"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3fd1a8b4-198d-4316-8a31-e24470cfa23e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6f22c910-e7f4-49e2-93b3-0ca3735f27b8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2bc9a608-3d32-4d7d-86bd-0e6a180d8af2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a8176e9c-8682-49f0-a8df-e13b4d2ae8df"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bf112d54-5c5a-4c81-a7a1-fb355a1e8f5e"));

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
    }
}
