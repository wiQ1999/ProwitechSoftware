using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class bosspermissionsaddpersonalprotocolspermission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("674870f0-b39f-43dd-bcd2-b3f2f0bb2452"), "Szef" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("95a14e4e-5a9c-4f59-897a-9ffe8f053672"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("f224a458-dcbf-430b-9739-a272db5b8fe4"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("1a0e6f35-c395-4122-a444-67b7c28fd63b"), true, true, true, new Guid("674870f0-b39f-43dd-bcd2-b3f2f0bb2452"), "RealProperties", true, null },
                    { new Guid("34c3762f-8905-416c-9d2f-d000ae3317af"), true, true, true, new Guid("674870f0-b39f-43dd-bcd2-b3f2f0bb2452"), "BuildingAddresses", true, null },
                    { new Guid("3dde2c01-3777-4a07-917b-d0caabee973d"), true, true, true, new Guid("674870f0-b39f-43dd-bcd2-b3f2f0bb2452"), "InspectionTasks", true, null },
                    { new Guid("46c4d209-a68d-467f-9d2a-e0e1992a0eb4"), true, true, true, new Guid("95a14e4e-5a9c-4f59-897a-9ffe8f053672"), "Permissions", true, null },
                    { new Guid("681f04db-628f-4ec4-97d3-007de489c69f"), true, true, true, new Guid("674870f0-b39f-43dd-bcd2-b3f2f0bb2452"), "AllInspectionProtocols", true, null },
                    { new Guid("6debf06e-f310-4cdd-8c4d-1985adbdd38c"), true, true, true, new Guid("674870f0-b39f-43dd-bcd2-b3f2f0bb2452"), "Users", true, null },
                    { new Guid("7da85c2d-cb61-4ce3-ba1f-a199c826a67f"), true, true, true, new Guid("95a14e4e-5a9c-4f59-897a-9ffe8f053672"), "Users", true, null },
                    { new Guid("8afbbc04-3b36-4196-a85b-a28352bab172"), true, true, true, new Guid("95a14e4e-5a9c-4f59-897a-9ffe8f053672"), "Roles", true, null },
                    { new Guid("91118a63-2e23-4320-b0df-54b4dfcaf28b"), true, true, true, new Guid("674870f0-b39f-43dd-bcd2-b3f2f0bb2452"), "PersonalProtocols", true, null },
                    { new Guid("a74f7a64-40aa-4f96-a5fa-7125b286cc27"), true, true, true, new Guid("674870f0-b39f-43dd-bcd2-b3f2f0bb2452"), "Permissions", true, null },
                    { new Guid("afdbf3a1-f259-4f69-9d78-a35a3fe62732"), true, true, true, new Guid("674870f0-b39f-43dd-bcd2-b3f2f0bb2452"), "Buildings", true, null },
                    { new Guid("c5ce62d7-97d9-4a4f-b2dd-59c26b2ec85b"), true, true, true, new Guid("f224a458-dcbf-430b-9739-a272db5b8fe4"), "PersonalProtocols", true, null },
                    { new Guid("c729ebda-578c-446c-a843-2e3192ca0abf"), true, true, true, new Guid("674870f0-b39f-43dd-bcd2-b3f2f0bb2452"), "Roles", true, null },
                    { new Guid("dd509f9c-a240-447c-b1e6-747aa6fd9ace"), true, true, true, new Guid("674870f0-b39f-43dd-bcd2-b3f2f0bb2452"), "PropertyManagers", true, null },
                    { new Guid("f3aad585-f2a4-42a1-bb69-ae49aff567af"), false, false, true, new Guid("f224a458-dcbf-430b-9739-a272db5b8fe4"), "InspectionTasks", true, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("4f08cc14-1181-4343-a6da-41ddb71c8377"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "boss", "AQAAAAIAAYagAAAAEJg0oWoNU5jc8XhnSYJOT4pmwz3kf6+1zl4hyFeh5NZhQScOWwSdTGKjXtCf7xPfMQ==", "123 456 789", new Guid("674870f0-b39f-43dd-bcd2-b3f2f0bb2452") },
                    { new Guid("74cbd864-03b1-44d8-bc5d-36959921297e"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "AQAAAAIAAYagAAAAEFwRGPUK+BjglP2KAcx5nFqHyzmnovpq08BBDs2JAOk1NSaDZedZaIFvz0v6YYycVg==", "+48 321 654 987", new Guid("f224a458-dcbf-430b-9739-a272db5b8fe4") },
                    { new Guid("c3930eb7-c7aa-4c53-9d3e-863e7173a12a"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "AQAAAAIAAYagAAAAEH4DH2BIBpwuODJcrhDiy6K8WXalowYQOjufWFy30CQ9NpxMAG37Br9Jskwv0sg2uQ==", "+48 312645978", new Guid("f224a458-dcbf-430b-9739-a272db5b8fe4") },
                    { new Guid("f387f845-13bf-4e19-a09d-b43e226ba95b"), "", "admin", "", "admin", "AQAAAAIAAYagAAAAEGOIc8FoEVTKWKHhXnijhzbk7FlRMCTwVFfp9coaSaRUX33xXHANIAMZShCAgTxqGw==", "", new Guid("95a14e4e-5a9c-4f59-897a-9ffe8f053672") },
                    { new Guid("fffbf755-8169-46f0-8b36-d3666ffed5ff"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "AQAAAAIAAYagAAAAEF0bjbyA6qg1V/F68F56dA6FE5aVlkSdjB0gAPHjzisGECT1pWB0LXPtFQyCqey8dg==", "987654321", new Guid("f224a458-dcbf-430b-9739-a272db5b8fe4") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("92d02646-2a08-490b-9598-a974f529400f"), true, true, true, null, "PersonalProtocols", true, new Guid("fffbf755-8169-46f0-8b36-d3666ffed5ff") },
                    { new Guid("a05031f1-5a5f-485b-bac7-1392592a3c0c"), false, false, true, null, "InspectionTasks", true, new Guid("c3930eb7-c7aa-4c53-9d3e-863e7173a12a") },
                    { new Guid("bf3bfd43-1bf8-4df5-acef-fe7605686ff1"), true, true, true, null, "PersonalProtocols", true, new Guid("c3930eb7-c7aa-4c53-9d3e-863e7173a12a") },
                    { new Guid("fc53dd59-0ac6-4d0a-b98b-a54ac0cfec57"), false, false, true, null, "InspectionTasks", true, new Guid("fffbf755-8169-46f0-8b36-d3666ffed5ff") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1a0e6f35-c395-4122-a444-67b7c28fd63b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("34c3762f-8905-416c-9d2f-d000ae3317af"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3dde2c01-3777-4a07-917b-d0caabee973d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("46c4d209-a68d-467f-9d2a-e0e1992a0eb4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("681f04db-628f-4ec4-97d3-007de489c69f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6debf06e-f310-4cdd-8c4d-1985adbdd38c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7da85c2d-cb61-4ce3-ba1f-a199c826a67f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8afbbc04-3b36-4196-a85b-a28352bab172"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("91118a63-2e23-4320-b0df-54b4dfcaf28b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("92d02646-2a08-490b-9598-a974f529400f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a05031f1-5a5f-485b-bac7-1392592a3c0c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a74f7a64-40aa-4f96-a5fa-7125b286cc27"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("afdbf3a1-f259-4f69-9d78-a35a3fe62732"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("bf3bfd43-1bf8-4df5-acef-fe7605686ff1"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c5ce62d7-97d9-4a4f-b2dd-59c26b2ec85b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c729ebda-578c-446c-a843-2e3192ca0abf"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("dd509f9c-a240-447c-b1e6-747aa6fd9ace"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f3aad585-f2a4-42a1-bb69-ae49aff567af"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fc53dd59-0ac6-4d0a-b98b-a54ac0cfec57"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4f08cc14-1181-4343-a6da-41ddb71c8377"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("74cbd864-03b1-44d8-bc5d-36959921297e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f387f845-13bf-4e19-a09d-b43e226ba95b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("674870f0-b39f-43dd-bcd2-b3f2f0bb2452"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("95a14e4e-5a9c-4f59-897a-9ffe8f053672"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c3930eb7-c7aa-4c53-9d3e-863e7173a12a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fffbf755-8169-46f0-8b36-d3666ffed5ff"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f224a458-dcbf-430b-9739-a272db5b8fe4"));

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
    }
}
