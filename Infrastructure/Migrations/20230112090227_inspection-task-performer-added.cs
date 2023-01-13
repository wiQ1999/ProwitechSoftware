using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class inspectiontaskperformeradded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("061e4b2a-c7f2-4479-b7fd-97299a079062"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("086ecc39-0831-4258-88a9-ed3ef289cda2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3e91ed8d-fadc-460e-abb8-08178048b67c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("46099ff3-8ca5-4bff-89b2-fdd78694f8b4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("565353e6-b9ce-4470-886a-2f3751ed8f4a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("680beffc-794d-4f8a-a2ec-db0192f4b7bb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9cc09d4b-1713-452c-bdb3-425cce258af9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a4762310-01f0-4426-b83b-b613775c68d1"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a697b13a-94ae-4f63-ae13-7e59037ca7d0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("abcaf32a-b71d-4596-89f8-c8c6fb9c2018"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b2056161-cc49-4a70-a1ec-a54e501ad280"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b433e09e-4348-43a6-b32b-afdad92abb7e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c8ad6ab1-5405-470c-b94b-25d716ed0ac4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("09162196-1f86-419e-9197-fc4b574bdb8c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("257306cb-0f7e-4774-894d-79f2a6ea97c6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("56061c1a-8c17-4190-aec5-3a0ce4482504"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("09b195d4-c916-4df0-b045-00ef5c1f3f02"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a1fb663b-c77d-416d-a028-f95cccde8233"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7c6b711f-308a-4be1-b02a-c0a3eba36625"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("826073a4-34be-4844-a213-5cac0df062bd"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e16a381f-64d5-483f-9d27-c7d1c6d09490"));

            migrationBuilder.AddColumn<Guid>(
                name: "TaskPerformerId",
                table: "InspectionTasks",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("26890951-57d2-40ca-9b8c-64c72077d04f"), "Szef" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("6de4c080-33fa-4aed-bb3e-6d0bbede6208"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("f640d588-6b85-458e-8023-105fd75d9f7d"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("10cec43f-2875-4fd9-a8e3-021c74e1ba72"), false, false, true, new Guid("f640d588-6b85-458e-8023-105fd75d9f7d"), "Roles", false, null },
                    { new Guid("170a9930-bf1e-46da-b2d5-b69491e8ee8a"), true, true, true, new Guid("6de4c080-33fa-4aed-bb3e-6d0bbede6208"), "Users", true, null },
                    { new Guid("290daab5-2eeb-4697-b436-59844e14ae5c"), true, true, true, new Guid("6de4c080-33fa-4aed-bb3e-6d0bbede6208"), "Permissions", true, null },
                    { new Guid("3c936e66-c06d-4973-8519-e40395ee178c"), true, true, true, new Guid("6de4c080-33fa-4aed-bb3e-6d0bbede6208"), "Roles", true, null },
                    { new Guid("44e4f671-079a-46a5-8af0-9f5471430ed7"), false, false, false, new Guid("f640d588-6b85-458e-8023-105fd75d9f7d"), "Permissions", false, null },
                    { new Guid("8c0406c9-03ac-4e87-a908-ac7f3ee7d8ff"), true, true, true, new Guid("26890951-57d2-40ca-9b8c-64c72077d04f"), "Roles", true, null },
                    { new Guid("9e15e718-0d1d-4c09-aada-8335a43a8617"), true, true, true, new Guid("26890951-57d2-40ca-9b8c-64c72077d04f"), "Users", true, null },
                    { new Guid("bd551cbe-e63a-4e0e-ae4c-bff0254400cc"), false, false, true, new Guid("f640d588-6b85-458e-8023-105fd75d9f7d"), "Users", false, null },
                    { new Guid("d0992a3c-ea88-4d5f-8f60-1c76b76c7a7a"), true, true, true, new Guid("26890951-57d2-40ca-9b8c-64c72077d04f"), "Permissions", true, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("3eb25eb8-0d70-40be-8caa-101578a5cb76"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "", "+48 312645978", new Guid("f640d588-6b85-458e-8023-105fd75d9f7d") },
                    { new Guid("4a67dd12-d14c-4791-80ed-11fc8ab90797"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "", "+48 321 654 987", new Guid("f640d588-6b85-458e-8023-105fd75d9f7d") },
                    { new Guid("bbc0815c-6328-46d6-8ee3-cb24de01e908"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "k.tumiel", "", "123 456 789", new Guid("26890951-57d2-40ca-9b8c-64c72077d04f") },
                    { new Guid("c20120a8-240e-4337-8cba-14f71ef939ab"), "", "admin", "", "admin", "admin", "", new Guid("6de4c080-33fa-4aed-bb3e-6d0bbede6208") },
                    { new Guid("ce55c1d3-c618-40cc-b7b3-1ad4dab6fae6"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "", "987654321", new Guid("f640d588-6b85-458e-8023-105fd75d9f7d") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("0b29b796-e629-4275-84f2-22fe46b6059b"), null, null, false, null, "Users", null, new Guid("ce55c1d3-c618-40cc-b7b3-1ad4dab6fae6") },
                    { new Guid("8c1adffc-5c1c-49a5-944d-77045df3c4c1"), null, null, false, null, "Roles", null, new Guid("ce55c1d3-c618-40cc-b7b3-1ad4dab6fae6") },
                    { new Guid("9ed1b03b-0a24-4e02-ba46-41eec695eb31"), true, null, null, null, "Roles", true, new Guid("3eb25eb8-0d70-40be-8caa-101578a5cb76") },
                    { new Guid("aabf63d0-aa00-4d73-8296-51a91e4f8ccb"), true, true, null, null, "Users", true, new Guid("3eb25eb8-0d70-40be-8caa-101578a5cb76") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_InspectionTasks_TaskPerformerId",
                table: "InspectionTasks",
                column: "TaskPerformerId");

            migrationBuilder.AddForeignKey(
                name: "FK_InspectionTasks_Users_TaskPerformerId",
                table: "InspectionTasks",
                column: "TaskPerformerId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InspectionTasks_Users_TaskPerformerId",
                table: "InspectionTasks");

            migrationBuilder.DropIndex(
                name: "IX_InspectionTasks_TaskPerformerId",
                table: "InspectionTasks");

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0b29b796-e629-4275-84f2-22fe46b6059b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("10cec43f-2875-4fd9-a8e3-021c74e1ba72"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("170a9930-bf1e-46da-b2d5-b69491e8ee8a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("290daab5-2eeb-4697-b436-59844e14ae5c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3c936e66-c06d-4973-8519-e40395ee178c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("44e4f671-079a-46a5-8af0-9f5471430ed7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8c0406c9-03ac-4e87-a908-ac7f3ee7d8ff"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8c1adffc-5c1c-49a5-944d-77045df3c4c1"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9e15e718-0d1d-4c09-aada-8335a43a8617"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9ed1b03b-0a24-4e02-ba46-41eec695eb31"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("aabf63d0-aa00-4d73-8296-51a91e4f8ccb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("bd551cbe-e63a-4e0e-ae4c-bff0254400cc"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d0992a3c-ea88-4d5f-8f60-1c76b76c7a7a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4a67dd12-d14c-4791-80ed-11fc8ab90797"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bbc0815c-6328-46d6-8ee3-cb24de01e908"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c20120a8-240e-4337-8cba-14f71ef939ab"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("26890951-57d2-40ca-9b8c-64c72077d04f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6de4c080-33fa-4aed-bb3e-6d0bbede6208"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3eb25eb8-0d70-40be-8caa-101578a5cb76"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ce55c1d3-c618-40cc-b7b3-1ad4dab6fae6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f640d588-6b85-458e-8023-105fd75d9f7d"));

            migrationBuilder.DropColumn(
                name: "TaskPerformerId",
                table: "InspectionTasks");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("09b195d4-c916-4df0-b045-00ef5c1f3f02"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("a1fb663b-c77d-416d-a028-f95cccde8233"), "Szef" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("e16a381f-64d5-483f-9d27-c7d1c6d09490"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("086ecc39-0831-4258-88a9-ed3ef289cda2"), true, true, true, new Guid("09b195d4-c916-4df0-b045-00ef5c1f3f02"), "Roles", true, null },
                    { new Guid("46099ff3-8ca5-4bff-89b2-fdd78694f8b4"), true, true, true, new Guid("a1fb663b-c77d-416d-a028-f95cccde8233"), "Users", true, null },
                    { new Guid("565353e6-b9ce-4470-886a-2f3751ed8f4a"), false, false, false, new Guid("e16a381f-64d5-483f-9d27-c7d1c6d09490"), "Permissions", false, null },
                    { new Guid("680beffc-794d-4f8a-a2ec-db0192f4b7bb"), false, false, true, new Guid("e16a381f-64d5-483f-9d27-c7d1c6d09490"), "Roles", false, null },
                    { new Guid("9cc09d4b-1713-452c-bdb3-425cce258af9"), false, false, true, new Guid("e16a381f-64d5-483f-9d27-c7d1c6d09490"), "Users", false, null },
                    { new Guid("a4762310-01f0-4426-b83b-b613775c68d1"), true, true, true, new Guid("09b195d4-c916-4df0-b045-00ef5c1f3f02"), "Permissions", true, null },
                    { new Guid("a697b13a-94ae-4f63-ae13-7e59037ca7d0"), true, true, true, new Guid("a1fb663b-c77d-416d-a028-f95cccde8233"), "Permissions", true, null },
                    { new Guid("abcaf32a-b71d-4596-89f8-c8c6fb9c2018"), true, true, true, new Guid("09b195d4-c916-4df0-b045-00ef5c1f3f02"), "Users", true, null },
                    { new Guid("b2056161-cc49-4a70-a1ec-a54e501ad280"), true, true, true, new Guid("a1fb663b-c77d-416d-a028-f95cccde8233"), "Roles", true, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("09162196-1f86-419e-9197-fc4b574bdb8c"), "", "admin", "", "admin", "admin", "", new Guid("09b195d4-c916-4df0-b045-00ef5c1f3f02") },
                    { new Guid("257306cb-0f7e-4774-894d-79f2a6ea97c6"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "k.tumiel", "", "123 456 789", new Guid("a1fb663b-c77d-416d-a028-f95cccde8233") },
                    { new Guid("56061c1a-8c17-4190-aec5-3a0ce4482504"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "", "+48 321 654 987", new Guid("e16a381f-64d5-483f-9d27-c7d1c6d09490") },
                    { new Guid("7c6b711f-308a-4be1-b02a-c0a3eba36625"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "", "987654321", new Guid("e16a381f-64d5-483f-9d27-c7d1c6d09490") },
                    { new Guid("826073a4-34be-4844-a213-5cac0df062bd"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "", "+48 312645978", new Guid("e16a381f-64d5-483f-9d27-c7d1c6d09490") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("061e4b2a-c7f2-4479-b7fd-97299a079062"), true, null, null, null, "Roles", true, new Guid("826073a4-34be-4844-a213-5cac0df062bd") },
                    { new Guid("3e91ed8d-fadc-460e-abb8-08178048b67c"), null, null, false, null, "Roles", null, new Guid("7c6b711f-308a-4be1-b02a-c0a3eba36625") },
                    { new Guid("b433e09e-4348-43a6-b32b-afdad92abb7e"), null, null, false, null, "Users", null, new Guid("7c6b711f-308a-4be1-b02a-c0a3eba36625") },
                    { new Guid("c8ad6ab1-5405-470c-b94b-25d716ed0ac4"), true, true, null, null, "Users", true, new Guid("826073a4-34be-4844-a213-5cac0df062bd") }
                });
        }
    }
}
