using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class inspectionprotocolstringtobool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<bool>(
                name: "A_Gazomierz_szafka_wentylowana",
                table: "InspectionProtocols",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("ce1de054-950c-42c1-a674-da95acf541c3"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("d981b703-60bd-4958-bce8-65f548f82992"), "Szef" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("e1dba996-66aa-4284-ab24-d2a995457b32"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("2a3b78f8-963e-4c2c-9342-15879bac9f81"), true, true, true, new Guid("d981b703-60bd-4958-bce8-65f548f82992"), "Roles", true, null },
                    { new Guid("3f47fce9-f319-42fb-9005-a3cf10ff33c9"), true, true, true, new Guid("ce1de054-950c-42c1-a674-da95acf541c3"), "Roles", true, null },
                    { new Guid("4d6ed460-9fbd-43ff-ae89-2c9f01ab3ad4"), false, false, false, new Guid("e1dba996-66aa-4284-ab24-d2a995457b32"), "Permissions", false, null },
                    { new Guid("b50eaa2e-c379-410f-a7e1-1a339a650872"), false, false, true, new Guid("e1dba996-66aa-4284-ab24-d2a995457b32"), "Roles", false, null },
                    { new Guid("d6221b0d-3323-4c03-ad75-1cdb378f54ba"), true, true, true, new Guid("ce1de054-950c-42c1-a674-da95acf541c3"), "Permissions", true, null },
                    { new Guid("dae40c25-2d30-4539-99f2-4057529108f8"), true, true, true, new Guid("d981b703-60bd-4958-bce8-65f548f82992"), "Users", true, null },
                    { new Guid("de654ea7-9c05-4cc6-87df-876a95ebc5ab"), true, true, true, new Guid("d981b703-60bd-4958-bce8-65f548f82992"), "Permissions", true, null },
                    { new Guid("eaf16833-e5c6-424a-86c9-5b9237ed0f9e"), true, true, true, new Guid("ce1de054-950c-42c1-a674-da95acf541c3"), "Users", true, null },
                    { new Guid("f4fc5a5f-0773-425f-a10e-81bd3af45831"), false, false, true, new Guid("e1dba996-66aa-4284-ab24-d2a995457b32"), "Users", false, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("0264fa38-e506-4a91-a192-6484709d9f7f"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "AQAAAAIAAYagAAAAEKGGwyQkd3ejD20mA1mKLf09+chd1tYdziwii24rlyrg8yFQSalZTwcpPPwLqOROug==", "987654321", new Guid("e1dba996-66aa-4284-ab24-d2a995457b32") },
                    { new Guid("2a318f93-0663-48f5-86a0-f4e9652cbb78"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "boss", "AQAAAAIAAYagAAAAEIWVaCTHIM7O/3aStuBUi/HqVNciGV53RwOVMpwBF2EQz1KE/bY/56kTZp6kuvlbCQ==", "123 456 789", new Guid("d981b703-60bd-4958-bce8-65f548f82992") },
                    { new Guid("2feb9e44-2f54-4709-8777-1b390619a9d4"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "AQAAAAIAAYagAAAAEM7f/cNic3YsIh3p2S3VsX4X7ED5ljqoccwH88KocIha/Et43Ye4HTwO1UAfO8fO1g==", "+48 312645978", new Guid("e1dba996-66aa-4284-ab24-d2a995457b32") },
                    { new Guid("bab0423b-5b3b-4480-b8a9-a9c4a67a3d1e"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "AQAAAAIAAYagAAAAEP2mTnnb+mMQzZr/4bxPfxt3/Xgk9boyuINa/+v6mqgmzjr7cWN084fjCDtRTLrr1g==", "+48 321 654 987", new Guid("e1dba996-66aa-4284-ab24-d2a995457b32") },
                    { new Guid("cb23019b-8700-4613-9715-8aad18f1da38"), "", "admin", "", "admin", "AQAAAAIAAYagAAAAEF2tRrfxKyh/Vyv50F+Y7g+AQmgjYalzxHVkiQ9Nn0xrpmRKHJu18fXCEheVeXaCaw==", "", new Guid("ce1de054-950c-42c1-a674-da95acf541c3") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("106c5e98-40e5-4087-8b56-c6b171be165a"), true, true, null, null, "Users", true, new Guid("2feb9e44-2f54-4709-8777-1b390619a9d4") },
                    { new Guid("58a2b8f5-716e-4df5-843b-7a59ef890918"), true, null, null, null, "Roles", true, new Guid("2feb9e44-2f54-4709-8777-1b390619a9d4") },
                    { new Guid("cf78f95f-ad5f-4bf9-9e9f-2f4f4e8028f6"), null, null, false, null, "Users", null, new Guid("0264fa38-e506-4a91-a192-6484709d9f7f") },
                    { new Guid("fbc4d37c-bd76-4729-a2ae-a488737d98ac"), null, null, false, null, "Roles", null, new Guid("0264fa38-e506-4a91-a192-6484709d9f7f") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("106c5e98-40e5-4087-8b56-c6b171be165a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2a3b78f8-963e-4c2c-9342-15879bac9f81"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3f47fce9-f319-42fb-9005-a3cf10ff33c9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4d6ed460-9fbd-43ff-ae89-2c9f01ab3ad4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("58a2b8f5-716e-4df5-843b-7a59ef890918"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b50eaa2e-c379-410f-a7e1-1a339a650872"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("cf78f95f-ad5f-4bf9-9e9f-2f4f4e8028f6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d6221b0d-3323-4c03-ad75-1cdb378f54ba"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("dae40c25-2d30-4539-99f2-4057529108f8"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("de654ea7-9c05-4cc6-87df-876a95ebc5ab"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("eaf16833-e5c6-424a-86c9-5b9237ed0f9e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f4fc5a5f-0773-425f-a10e-81bd3af45831"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fbc4d37c-bd76-4729-a2ae-a488737d98ac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2a318f93-0663-48f5-86a0-f4e9652cbb78"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bab0423b-5b3b-4480-b8a9-a9c4a67a3d1e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb23019b-8700-4613-9715-8aad18f1da38"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ce1de054-950c-42c1-a674-da95acf541c3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d981b703-60bd-4958-bce8-65f548f82992"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0264fa38-e506-4a91-a192-6484709d9f7f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2feb9e44-2f54-4709-8777-1b390619a9d4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e1dba996-66aa-4284-ab24-d2a995457b32"));

            migrationBuilder.AlterColumn<string>(
                name: "A_Gazomierz_szafka_wentylowana",
                table: "InspectionProtocols",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

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
    }
}
