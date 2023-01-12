using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class inspectiontaskbuildingnotnulldatetimesnullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDateTime",
                table: "InspectionTasks",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDateTime",
                table: "InspectionTasks",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueStartDateTime",
                table: "InspectionTasks",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<Guid>(
                name: "BuildingId",
                table: "InspectionTasks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("3245542f-700d-45a1-a4c3-f0baf52909f0"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("770d6b69-96b7-4d13-aadc-bb79b15297ee"), "Szef" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("c8e0f2d0-452b-4732-a6ae-729e2759577f"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("29fde220-a673-436e-98ce-2984c5a1a7a1"), true, true, true, new Guid("3245542f-700d-45a1-a4c3-f0baf52909f0"), "Users", true, null },
                    { new Guid("2dd6d360-f6ea-4311-b9d6-6d3c66b7f336"), false, false, true, new Guid("c8e0f2d0-452b-4732-a6ae-729e2759577f"), "Roles", false, null },
                    { new Guid("7a164c8e-73cc-481a-9f76-7adbe29ef2aa"), false, false, false, new Guid("c8e0f2d0-452b-4732-a6ae-729e2759577f"), "Permissions", false, null },
                    { new Guid("7e1569c1-0648-4b20-9e65-1ae6f8f76019"), true, true, true, new Guid("770d6b69-96b7-4d13-aadc-bb79b15297ee"), "Roles", true, null },
                    { new Guid("7e26b139-bdf2-416b-9cfc-e0ab90ccbeb4"), true, true, true, new Guid("3245542f-700d-45a1-a4c3-f0baf52909f0"), "Roles", true, null },
                    { new Guid("d6e42ad3-fd58-4da4-821c-dae6ea07ef0c"), true, true, true, new Guid("770d6b69-96b7-4d13-aadc-bb79b15297ee"), "Permissions", true, null },
                    { new Guid("f44b3d99-149b-4410-9204-d3e09c8980e3"), false, false, true, new Guid("c8e0f2d0-452b-4732-a6ae-729e2759577f"), "Users", false, null },
                    { new Guid("fd6a920f-f6a8-480f-b3a0-be3c342cfb4f"), true, true, true, new Guid("770d6b69-96b7-4d13-aadc-bb79b15297ee"), "Users", true, null },
                    { new Guid("ffff0d1e-203b-421f-b8e3-ee16c318685b"), true, true, true, new Guid("3245542f-700d-45a1-a4c3-f0baf52909f0"), "Permissions", true, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("0c2fbfc4-ad4e-45a9-946d-e7498f90b9fe"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "", "987654321", new Guid("c8e0f2d0-452b-4732-a6ae-729e2759577f") },
                    { new Guid("1c3600b9-a5bd-4ef8-a9e5-6c17b8b94399"), "", "admin", "", "admin", "admin", "", new Guid("3245542f-700d-45a1-a4c3-f0baf52909f0") },
                    { new Guid("595bbe15-0f6e-4549-b63f-bbade0a087de"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "", "+48 312645978", new Guid("c8e0f2d0-452b-4732-a6ae-729e2759577f") },
                    { new Guid("d85e2c8a-b4a2-41c2-bf5b-de49a62481d3"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "", "+48 321 654 987", new Guid("c8e0f2d0-452b-4732-a6ae-729e2759577f") },
                    { new Guid("f4630605-55f8-4c38-8dd3-58893498a61f"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "k.tumiel", "", "123 456 789", new Guid("770d6b69-96b7-4d13-aadc-bb79b15297ee") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("2e115fcc-4f7f-41d0-b55c-d0cb0aee47bb"), true, true, null, null, "Users", true, new Guid("595bbe15-0f6e-4549-b63f-bbade0a087de") },
                    { new Guid("3a7ae95f-bd8e-4d0a-bc64-9776dfb4a385"), null, null, false, null, "Roles", null, new Guid("0c2fbfc4-ad4e-45a9-946d-e7498f90b9fe") },
                    { new Guid("3f2e67f2-79a8-46e5-bdd6-53fa24434e21"), true, null, null, null, "Roles", true, new Guid("595bbe15-0f6e-4549-b63f-bbade0a087de") },
                    { new Guid("cfbdeff5-7f95-4f66-bbb5-5b9602f0afd6"), null, null, false, null, "Users", null, new Guid("0c2fbfc4-ad4e-45a9-946d-e7498f90b9fe") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("29fde220-a673-436e-98ce-2984c5a1a7a1"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2dd6d360-f6ea-4311-b9d6-6d3c66b7f336"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2e115fcc-4f7f-41d0-b55c-d0cb0aee47bb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3a7ae95f-bd8e-4d0a-bc64-9776dfb4a385"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3f2e67f2-79a8-46e5-bdd6-53fa24434e21"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7a164c8e-73cc-481a-9f76-7adbe29ef2aa"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7e1569c1-0648-4b20-9e65-1ae6f8f76019"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7e26b139-bdf2-416b-9cfc-e0ab90ccbeb4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("cfbdeff5-7f95-4f66-bbb5-5b9602f0afd6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d6e42ad3-fd58-4da4-821c-dae6ea07ef0c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f44b3d99-149b-4410-9204-d3e09c8980e3"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fd6a920f-f6a8-480f-b3a0-be3c342cfb4f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ffff0d1e-203b-421f-b8e3-ee16c318685b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c3600b9-a5bd-4ef8-a9e5-6c17b8b94399"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d85e2c8a-b4a2-41c2-bf5b-de49a62481d3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f4630605-55f8-4c38-8dd3-58893498a61f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3245542f-700d-45a1-a4c3-f0baf52909f0"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("770d6b69-96b7-4d13-aadc-bb79b15297ee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0c2fbfc4-ad4e-45a9-946d-e7498f90b9fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("595bbe15-0f6e-4549-b63f-bbade0a087de"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c8e0f2d0-452b-4732-a6ae-729e2759577f"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDateTime",
                table: "InspectionTasks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDateTime",
                table: "InspectionTasks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueStartDateTime",
                table: "InspectionTasks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "BuildingId",
                table: "InspectionTasks",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

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
        }
    }
}
