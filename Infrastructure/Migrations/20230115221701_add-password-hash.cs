using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class addpasswordhash : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("14b3d37c-4c71-48e3-a097-dcf1a93c187a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3c0aca4a-322a-4d8a-94d9-11892e6964a7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("403ab00d-7ada-471c-80cb-9649d35ff7d3"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5fc7a591-3fb8-441d-a529-82ece5ecafe2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6ab6d23f-6b4a-4b37-bacd-3088c84174f5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7ef1e75b-e931-477d-aa62-6b1e0c0ec09c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("89dfb983-5d0b-4a3a-9959-6bd9195f5c59"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8c65d9e6-02db-4aca-8759-ddde3783aae5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8d9a800c-ad03-4ff5-9f77-9c3b9a0a5e8c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9f0d6f74-7f72-47df-a906-0732134a585b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("afd1c69c-111d-4885-bd37-227447608c84"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f2613ce9-c51e-46ad-bd22-817c8ff562f5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fd57779f-51b0-4575-98f0-19c1ca87024b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("12bf46b3-18d2-4696-bf71-bedcd379c355"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44ae24ce-581b-4501-8cbe-36b45a0d9b09"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d9d793d-71d0-4d28-a740-b0e49799a8c2"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a9a71591-a2f8-4a7b-afda-5e7fed17d121"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b26fd7d6-cfee-49ca-bfce-b16f669a6e8e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d38a07a1-3093-4817-8d35-4fc1c7313e53"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fdb5a6f8-4077-475e-9205-cb499b379522"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("afb52745-9b0e-40d2-b1b3-830d6e4dac7c"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("460b389d-95f0-4bc8-98a7-d376d4eb12eb"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("6d33db86-d0da-4fa0-9b0d-fc8ea9394eb4"), "Szef" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("cfad619b-601f-4a75-b892-05a8961eea71"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("1c86a295-7f83-4ad5-8f2b-a567a0425902"), true, true, true, new Guid("cfad619b-601f-4a75-b892-05a8961eea71"), "Roles", true, null },
                    { new Guid("3f05cfcb-2955-42b9-9645-6331f1ce9861"), true, true, true, new Guid("cfad619b-601f-4a75-b892-05a8961eea71"), "Permissions", true, null },
                    { new Guid("aa796b55-e035-4c3a-a250-ca240eb868e6"), true, true, true, new Guid("6d33db86-d0da-4fa0-9b0d-fc8ea9394eb4"), "Permissions", true, null },
                    { new Guid("b6111022-ed67-4f98-9030-c39cda3c64b7"), false, false, true, new Guid("460b389d-95f0-4bc8-98a7-d376d4eb12eb"), "Users", false, null },
                    { new Guid("b61d9a48-cc90-43f5-af4e-e7bf1192862a"), true, true, true, new Guid("6d33db86-d0da-4fa0-9b0d-fc8ea9394eb4"), "Roles", true, null },
                    { new Guid("df51df79-86be-4b4e-846a-2bfd94e7ab74"), false, false, false, new Guid("460b389d-95f0-4bc8-98a7-d376d4eb12eb"), "Permissions", false, null },
                    { new Guid("e6cea334-ce59-484f-9911-b352b63908b4"), true, true, true, new Guid("cfad619b-601f-4a75-b892-05a8961eea71"), "Users", true, null },
                    { new Guid("e97f9458-77fd-4c2c-a875-3a52c77c01de"), false, false, true, new Guid("460b389d-95f0-4bc8-98a7-d376d4eb12eb"), "Roles", false, null },
                    { new Guid("ecd9fa68-a6d3-4b5c-83ac-419aa94869b9"), true, true, true, new Guid("6d33db86-d0da-4fa0-9b0d-fc8ea9394eb4"), "Users", true, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("084d1507-50ce-4d9e-bae6-92d24ec6abab"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "AQAAAAIAAYagAAAAEEoHw8FcNbVCa/WzAXLh2CxuQCmFS6ncJ4H/qeGymRRZkqoDITrSQPY+4w4bGsZmTw==", "987654321", new Guid("460b389d-95f0-4bc8-98a7-d376d4eb12eb") },
                    { new Guid("3ec9ed8d-c041-45e6-92ed-5bd059014153"), "", "admin", "", "admin", "AQAAAAIAAYagAAAAEF8Zqyr1phdNaVtzk3uL30zjq/rR+y12LoLnQazIbs1g5hRCmHIYDQLmp9ocbut6MQ==", "", new Guid("cfad619b-601f-4a75-b892-05a8961eea71") },
                    { new Guid("874db573-fc0a-4829-9fc5-5a396b99859a"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "boss", "AQAAAAIAAYagAAAAEMBjbECSbGpr7cbY7ocSR2IzKEn+0HvOMFfi7R6DlnPxkU5ZUeN8IxM3zGIDvi2cXQ==", "123 456 789", new Guid("6d33db86-d0da-4fa0-9b0d-fc8ea9394eb4") },
                    { new Guid("973c7898-8d10-450a-9223-31eb537cfae4"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "AQAAAAIAAYagAAAAEI+CZNsO9741J3EwuzE9B3jLqxadYCSni7lQHkNsekja66C3nEDs7zg18XDHfBK/NQ==", "+48 321 654 987", new Guid("460b389d-95f0-4bc8-98a7-d376d4eb12eb") },
                    { new Guid("ceb5b020-d066-4b01-971f-0855c07266d8"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "AQAAAAIAAYagAAAAEHCPfrouoCAgKFWDkOK+NgXJ6tIHC9WHVa03N21uVWOajwInt/WZwu2CuREg7SQiiA==", "+48 312645978", new Guid("460b389d-95f0-4bc8-98a7-d376d4eb12eb") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("4b5dfdf8-b79e-48ca-b2b8-6f4a0fd523b3"), null, null, false, null, "Users", null, new Guid("084d1507-50ce-4d9e-bae6-92d24ec6abab") },
                    { new Guid("598a81e9-d9c8-49c9-abd9-2557a3901ecd"), true, null, null, null, "Roles", true, new Guid("ceb5b020-d066-4b01-971f-0855c07266d8") },
                    { new Guid("ee91c260-64f4-47be-9aed-9a5462a94d2e"), true, true, null, null, "Users", true, new Guid("ceb5b020-d066-4b01-971f-0855c07266d8") },
                    { new Guid("fc62e134-06f5-496d-b5e9-ed9c7f36e8db"), null, null, false, null, "Roles", null, new Guid("084d1507-50ce-4d9e-bae6-92d24ec6abab") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1c86a295-7f83-4ad5-8f2b-a567a0425902"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3f05cfcb-2955-42b9-9645-6331f1ce9861"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4b5dfdf8-b79e-48ca-b2b8-6f4a0fd523b3"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("598a81e9-d9c8-49c9-abd9-2557a3901ecd"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("aa796b55-e035-4c3a-a250-ca240eb868e6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b6111022-ed67-4f98-9030-c39cda3c64b7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b61d9a48-cc90-43f5-af4e-e7bf1192862a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("df51df79-86be-4b4e-846a-2bfd94e7ab74"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e6cea334-ce59-484f-9911-b352b63908b4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e97f9458-77fd-4c2c-a875-3a52c77c01de"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ecd9fa68-a6d3-4b5c-83ac-419aa94869b9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ee91c260-64f4-47be-9aed-9a5462a94d2e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fc62e134-06f5-496d-b5e9-ed9c7f36e8db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ec9ed8d-c041-45e6-92ed-5bd059014153"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("874db573-fc0a-4829-9fc5-5a396b99859a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("973c7898-8d10-450a-9223-31eb537cfae4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6d33db86-d0da-4fa0-9b0d-fc8ea9394eb4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("cfad619b-601f-4a75-b892-05a8961eea71"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("084d1507-50ce-4d9e-bae6-92d24ec6abab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ceb5b020-d066-4b01-971f-0855c07266d8"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("460b389d-95f0-4bc8-98a7-d376d4eb12eb"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("a9a71591-a2f8-4a7b-afda-5e7fed17d121"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("afb52745-9b0e-40d2-b1b3-830d6e4dac7c"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("b26fd7d6-cfee-49ca-bfce-b16f669a6e8e"), "Szef" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("14b3d37c-4c71-48e3-a097-dcf1a93c187a"), true, true, true, new Guid("b26fd7d6-cfee-49ca-bfce-b16f669a6e8e"), "Roles", true, null },
                    { new Guid("3c0aca4a-322a-4d8a-94d9-11892e6964a7"), false, false, true, new Guid("afb52745-9b0e-40d2-b1b3-830d6e4dac7c"), "Roles", false, null },
                    { new Guid("403ab00d-7ada-471c-80cb-9649d35ff7d3"), true, true, true, new Guid("b26fd7d6-cfee-49ca-bfce-b16f669a6e8e"), "Users", true, null },
                    { new Guid("5fc7a591-3fb8-441d-a529-82ece5ecafe2"), true, true, true, new Guid("a9a71591-a2f8-4a7b-afda-5e7fed17d121"), "Roles", true, null },
                    { new Guid("6ab6d23f-6b4a-4b37-bacd-3088c84174f5"), true, true, true, new Guid("b26fd7d6-cfee-49ca-bfce-b16f669a6e8e"), "Permissions", true, null },
                    { new Guid("7ef1e75b-e931-477d-aa62-6b1e0c0ec09c"), false, false, false, new Guid("afb52745-9b0e-40d2-b1b3-830d6e4dac7c"), "Permissions", false, null },
                    { new Guid("89dfb983-5d0b-4a3a-9959-6bd9195f5c59"), false, false, true, new Guid("afb52745-9b0e-40d2-b1b3-830d6e4dac7c"), "Users", false, null },
                    { new Guid("8c65d9e6-02db-4aca-8759-ddde3783aae5"), true, true, true, new Guid("a9a71591-a2f8-4a7b-afda-5e7fed17d121"), "Users", true, null },
                    { new Guid("8d9a800c-ad03-4ff5-9f77-9c3b9a0a5e8c"), true, true, true, new Guid("a9a71591-a2f8-4a7b-afda-5e7fed17d121"), "Permissions", true, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("12bf46b3-18d2-4696-bf71-bedcd379c355"), "", "admin", "", "admin", "admin", "", new Guid("a9a71591-a2f8-4a7b-afda-5e7fed17d121") },
                    { new Guid("44ae24ce-581b-4501-8cbe-36b45a0d9b09"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "", "+48 321 654 987", new Guid("afb52745-9b0e-40d2-b1b3-830d6e4dac7c") },
                    { new Guid("9d9d793d-71d0-4d28-a740-b0e49799a8c2"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "k.tumiel", "", "123 456 789", new Guid("b26fd7d6-cfee-49ca-bfce-b16f669a6e8e") },
                    { new Guid("d38a07a1-3093-4817-8d35-4fc1c7313e53"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "", "987654321", new Guid("afb52745-9b0e-40d2-b1b3-830d6e4dac7c") },
                    { new Guid("fdb5a6f8-4077-475e-9205-cb499b379522"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "", "+48 312645978", new Guid("afb52745-9b0e-40d2-b1b3-830d6e4dac7c") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("9f0d6f74-7f72-47df-a906-0732134a585b"), true, true, null, null, "Users", true, new Guid("fdb5a6f8-4077-475e-9205-cb499b379522") },
                    { new Guid("afd1c69c-111d-4885-bd37-227447608c84"), true, null, null, null, "Roles", true, new Guid("fdb5a6f8-4077-475e-9205-cb499b379522") },
                    { new Guid("f2613ce9-c51e-46ad-bd22-817c8ff562f5"), null, null, false, null, "Users", null, new Guid("d38a07a1-3093-4817-8d35-4fc1c7313e53") },
                    { new Guid("fd57779f-51b0-4575-98f0-19c1ca87024b"), null, null, false, null, "Roles", null, new Guid("d38a07a1-3093-4817-8d35-4fc1c7313e53") }
                });
        }
    }
}
