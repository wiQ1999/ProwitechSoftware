using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class bossrolerealproperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("0c8ffef9-543c-445a-9418-8dc5627bf1a5"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("ca388e07-f67d-4a7b-baff-84ca56157251"), "Szef" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("e17b3de3-e5e1-43bf-bed1-c262c0703a26"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("015ff924-df36-4cfb-85e8-d0104327e674"), true, true, true, new Guid("ca388e07-f67d-4a7b-baff-84ca56157251"), "AllInspectionProtocols", true, null },
                    { new Guid("1d110c34-5bc0-45ac-88ac-b4f68e1eecfb"), true, true, true, new Guid("ca388e07-f67d-4a7b-baff-84ca56157251"), "BuildingAddresses", true, null },
                    { new Guid("2771efe8-8db8-4e50-af34-8c73e1cf6612"), true, true, true, new Guid("0c8ffef9-543c-445a-9418-8dc5627bf1a5"), "Permissions", true, null },
                    { new Guid("3a9df43e-1ca0-4d81-80b1-6e753a03e402"), true, true, true, new Guid("ca388e07-f67d-4a7b-baff-84ca56157251"), "Permissions", true, null },
                    { new Guid("43bd9081-3faa-48e1-98ec-ce139167306b"), true, true, true, new Guid("ca388e07-f67d-4a7b-baff-84ca56157251"), "Buildings", true, null },
                    { new Guid("45620df2-1895-4553-a4c2-d23418720f89"), true, true, true, new Guid("ca388e07-f67d-4a7b-baff-84ca56157251"), "Roles", true, null },
                    { new Guid("4e802817-dbfa-4f43-9abe-6cb6619c98c7"), true, true, true, new Guid("0c8ffef9-543c-445a-9418-8dc5627bf1a5"), "Roles", true, null },
                    { new Guid("4f06c728-6e3d-4cb8-b52e-3335fe166354"), true, true, true, new Guid("0c8ffef9-543c-445a-9418-8dc5627bf1a5"), "Users", true, null },
                    { new Guid("8b1605db-b2f1-4b1a-93ca-132587d2dc48"), true, true, true, new Guid("ca388e07-f67d-4a7b-baff-84ca56157251"), "PropertyManagers", true, null },
                    { new Guid("a02d144a-e9d0-4fca-a5fa-2d3d1cee8b75"), true, true, true, new Guid("ca388e07-f67d-4a7b-baff-84ca56157251"), "InspectionTasks", true, null },
                    { new Guid("a4fdbe5d-b872-4d8d-a1c1-8c6f89765299"), true, true, true, new Guid("e17b3de3-e5e1-43bf-bed1-c262c0703a26"), "PersonalProtocols", true, null },
                    { new Guid("cea9c5bb-f15f-478c-9ab4-aaf4cd120b4e"), true, true, true, new Guid("ca388e07-f67d-4a7b-baff-84ca56157251"), "RealProperties", true, null },
                    { new Guid("d669745f-dfe4-426c-9e30-8635c37834fd"), false, false, true, new Guid("e17b3de3-e5e1-43bf-bed1-c262c0703a26"), "InspectionTasks", true, null },
                    { new Guid("e02b1d41-39a2-4756-a52d-e09147cbd610"), true, true, true, new Guid("ca388e07-f67d-4a7b-baff-84ca56157251"), "Users", true, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("73dfacae-a122-4278-8e90-f5cbaefeffc2"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "AQAAAAIAAYagAAAAEM76j3mq2q9gyaBmVrctHpQOuqqCXprWFTqnhtCAI0C2lqm2b7lY3e/t7Bs4FgAJEQ==", "987654321", new Guid("e17b3de3-e5e1-43bf-bed1-c262c0703a26") },
                    { new Guid("a3dea2df-fe3c-482d-b560-8a15881c8a8e"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "AQAAAAIAAYagAAAAEFTdCGbcUQb219CuPJWOSK/wTFMENDwhcM7j/bhoqlmEBUnHNbaNNlDTj2VEI+6a0A==", "+48 321 654 987", new Guid("e17b3de3-e5e1-43bf-bed1-c262c0703a26") },
                    { new Guid("e14e643c-ef11-48a7-801e-b59febc84094"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "boss", "AQAAAAIAAYagAAAAEH4hpdnkBdX6fiTzoWEFPdEv4G7XA9t9J7SS9a11oAu5oEDWYkIsprWqO3InnfYMMQ==", "123 456 789", new Guid("ca388e07-f67d-4a7b-baff-84ca56157251") },
                    { new Guid("e93438aa-0218-4e08-bdea-b59a7c47c079"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "AQAAAAIAAYagAAAAEPHAdyiERnmUYj/Lh6y0+3rF7t3sMvfM8GFdDIkOSK7DbTxeO7kDnBG/zaelrXtdeA==", "+48 312645978", new Guid("e17b3de3-e5e1-43bf-bed1-c262c0703a26") },
                    { new Guid("fcfc5c6b-c853-463f-a127-976582b20f7d"), "", "admin", "", "admin", "AQAAAAIAAYagAAAAEPbPNpnbPq/5zt83kTVWIirLWRFvd99C0hy2/FY0iS1xQAqd0znOqeSDqukjsUXs+Q==", "", new Guid("0c8ffef9-543c-445a-9418-8dc5627bf1a5") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("5184c06a-7a51-45aa-81b0-150539d21cd5"), false, false, true, null, "InspectionTasks", true, new Guid("73dfacae-a122-4278-8e90-f5cbaefeffc2") },
                    { new Guid("a514d867-7237-4eab-a4d6-1377ac29fb67"), false, false, true, null, "InspectionTasks", true, new Guid("e93438aa-0218-4e08-bdea-b59a7c47c079") },
                    { new Guid("f86ecb06-8e99-4747-aeda-98d770726b43"), true, true, true, null, "PersonalProtocols", true, new Guid("73dfacae-a122-4278-8e90-f5cbaefeffc2") },
                    { new Guid("fa0a0d2f-61eb-480b-b4ca-97cdd9c419d4"), true, true, true, null, "PersonalProtocols", true, new Guid("e93438aa-0218-4e08-bdea-b59a7c47c079") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("015ff924-df36-4cfb-85e8-d0104327e674"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1d110c34-5bc0-45ac-88ac-b4f68e1eecfb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2771efe8-8db8-4e50-af34-8c73e1cf6612"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3a9df43e-1ca0-4d81-80b1-6e753a03e402"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("43bd9081-3faa-48e1-98ec-ce139167306b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("45620df2-1895-4553-a4c2-d23418720f89"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4e802817-dbfa-4f43-9abe-6cb6619c98c7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4f06c728-6e3d-4cb8-b52e-3335fe166354"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5184c06a-7a51-45aa-81b0-150539d21cd5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8b1605db-b2f1-4b1a-93ca-132587d2dc48"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a02d144a-e9d0-4fca-a5fa-2d3d1cee8b75"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a4fdbe5d-b872-4d8d-a1c1-8c6f89765299"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a514d867-7237-4eab-a4d6-1377ac29fb67"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("cea9c5bb-f15f-478c-9ab4-aaf4cd120b4e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d669745f-dfe4-426c-9e30-8635c37834fd"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e02b1d41-39a2-4756-a52d-e09147cbd610"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f86ecb06-8e99-4747-aeda-98d770726b43"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fa0a0d2f-61eb-480b-b4ca-97cdd9c419d4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a3dea2df-fe3c-482d-b560-8a15881c8a8e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e14e643c-ef11-48a7-801e-b59febc84094"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fcfc5c6b-c853-463f-a127-976582b20f7d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0c8ffef9-543c-445a-9418-8dc5627bf1a5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ca388e07-f67d-4a7b-baff-84ca56157251"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("73dfacae-a122-4278-8e90-f5cbaefeffc2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e93438aa-0218-4e08-bdea-b59a7c47c079"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e17b3de3-e5e1-43bf-bed1-c262c0703a26"));

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
    }
}
