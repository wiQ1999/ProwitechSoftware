using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class inspectionprotocolinspectionperformeradded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<Guid>(
                name: "ResidentId",
                table: "InspectionProtocols",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "InspectionPerformerId",
                table: "InspectionProtocols",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("41c24085-b185-4ee2-8199-84eb63b81ae0"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("81d07c98-343a-48a2-9452-02627c8a3567"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("d50fef84-4ee8-4a62-b7a9-934862d99040"), "Szef" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("385b4aec-0b0d-4cac-8203-bb0c24078a33"), false, false, true, new Guid("41c24085-b185-4ee2-8199-84eb63b81ae0"), "Users", false, null },
                    { new Guid("5742c7fd-94bd-4ac4-912f-c8ce46b5bbae"), true, true, true, new Guid("81d07c98-343a-48a2-9452-02627c8a3567"), "Users", true, null },
                    { new Guid("5e09f7bd-6f96-4dcc-9382-909d55f7cb98"), true, true, true, new Guid("d50fef84-4ee8-4a62-b7a9-934862d99040"), "Users", true, null },
                    { new Guid("5edacfc0-d370-4ff6-ad0e-30f0c0b61ab7"), true, true, true, new Guid("81d07c98-343a-48a2-9452-02627c8a3567"), "Permissions", true, null },
                    { new Guid("c70dc02d-cb2a-4c19-8c60-bb4cf6240954"), true, true, true, new Guid("81d07c98-343a-48a2-9452-02627c8a3567"), "Roles", true, null },
                    { new Guid("d2cfe8d8-4366-44d6-9d64-2edbb0113414"), true, true, true, new Guid("d50fef84-4ee8-4a62-b7a9-934862d99040"), "Roles", true, null },
                    { new Guid("daa4764e-e02a-44d0-9421-1374d33dd749"), true, true, true, new Guid("d50fef84-4ee8-4a62-b7a9-934862d99040"), "Permissions", true, null },
                    { new Guid("dec0e7a9-f1c0-4b5d-a846-8353e4b269e4"), false, false, false, new Guid("41c24085-b185-4ee2-8199-84eb63b81ae0"), "Permissions", false, null },
                    { new Guid("e19bfa5b-a187-4fbd-9c16-98665325f0de"), false, false, true, new Guid("41c24085-b185-4ee2-8199-84eb63b81ae0"), "Roles", false, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("23f13fb1-ab2e-40ca-bc41-9de751c039f4"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "", "987654321", new Guid("41c24085-b185-4ee2-8199-84eb63b81ae0") },
                    { new Guid("537c41d9-d2b0-4445-8822-12c86a254330"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "k.tumiel", "", "123 456 789", new Guid("d50fef84-4ee8-4a62-b7a9-934862d99040") },
                    { new Guid("abc8fccc-314b-423b-b9e6-d782f51430ae"), "", "admin", "", "admin", "admin", "", new Guid("81d07c98-343a-48a2-9452-02627c8a3567") },
                    { new Guid("ac12db6f-39fb-485e-b075-bd9474f089be"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "", "+48 321 654 987", new Guid("41c24085-b185-4ee2-8199-84eb63b81ae0") },
                    { new Guid("eeee14cf-0f5f-42cb-b002-5201bd5d7078"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "", "+48 312645978", new Guid("41c24085-b185-4ee2-8199-84eb63b81ae0") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("09d218c6-f2b5-45c9-b423-4e0d748328e1"), true, null, null, null, "Roles", true, new Guid("eeee14cf-0f5f-42cb-b002-5201bd5d7078") },
                    { new Guid("0cc6e628-3bb1-458e-aa06-8942257cbbcd"), true, true, null, null, "Users", true, new Guid("eeee14cf-0f5f-42cb-b002-5201bd5d7078") },
                    { new Guid("35e64eee-de67-4a4a-a4ad-a64e9305bbfb"), null, null, false, null, "Roles", null, new Guid("23f13fb1-ab2e-40ca-bc41-9de751c039f4") },
                    { new Guid("b460e062-02b3-44ca-9344-97ddf46ae8b7"), null, null, false, null, "Users", null, new Guid("23f13fb1-ab2e-40ca-bc41-9de751c039f4") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_InspectionProtocols_InspectionPerformerId",
                table: "InspectionProtocols",
                column: "InspectionPerformerId");

            migrationBuilder.AddForeignKey(
                name: "FK_InspectionProtocols_Users_InspectionPerformerId",
                table: "InspectionProtocols",
                column: "InspectionPerformerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InspectionProtocols_Users_InspectionPerformerId",
                table: "InspectionProtocols");

            migrationBuilder.DropIndex(
                name: "IX_InspectionProtocols_InspectionPerformerId",
                table: "InspectionProtocols");

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("09d218c6-f2b5-45c9-b423-4e0d748328e1"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0cc6e628-3bb1-458e-aa06-8942257cbbcd"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("35e64eee-de67-4a4a-a4ad-a64e9305bbfb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("385b4aec-0b0d-4cac-8203-bb0c24078a33"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5742c7fd-94bd-4ac4-912f-c8ce46b5bbae"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5e09f7bd-6f96-4dcc-9382-909d55f7cb98"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5edacfc0-d370-4ff6-ad0e-30f0c0b61ab7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b460e062-02b3-44ca-9344-97ddf46ae8b7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c70dc02d-cb2a-4c19-8c60-bb4cf6240954"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d2cfe8d8-4366-44d6-9d64-2edbb0113414"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("daa4764e-e02a-44d0-9421-1374d33dd749"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("dec0e7a9-f1c0-4b5d-a846-8353e4b269e4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e19bfa5b-a187-4fbd-9c16-98665325f0de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("537c41d9-d2b0-4445-8822-12c86a254330"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abc8fccc-314b-423b-b9e6-d782f51430ae"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ac12db6f-39fb-485e-b075-bd9474f089be"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("81d07c98-343a-48a2-9452-02627c8a3567"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d50fef84-4ee8-4a62-b7a9-934862d99040"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("23f13fb1-ab2e-40ca-bc41-9de751c039f4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eeee14cf-0f5f-42cb-b002-5201bd5d7078"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("41c24085-b185-4ee2-8199-84eb63b81ae0"));

            migrationBuilder.DropColumn(
                name: "InspectionPerformerId",
                table: "InspectionProtocols");

            migrationBuilder.AlterColumn<Guid>(
                name: "ResidentId",
                table: "InspectionProtocols",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

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
    }
}
