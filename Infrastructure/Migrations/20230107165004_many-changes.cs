using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class manychanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_FullAddresses_FullAddressId",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_Residents_Locals_LocalId",
                table: "Residents");

            migrationBuilder.DropTable(
                name: "Locals");

            migrationBuilder.DropTable(
                name: "PropertyResident");

            migrationBuilder.DropIndex(
                name: "IX_Residents_LocalId",
                table: "Residents");

            migrationBuilder.DropIndex(
                name: "IX_FullAddresses_BuildingAddressId",
                table: "FullAddresses");

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0346691a-30e0-408b-9caa-ad13dd4dc868"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0c214b48-2df8-4acd-8346-d2992c59e348"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("537be9f4-f14a-417a-afef-70cbb56902f9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7a5c7125-1602-4f4c-89e6-a7b24672950c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8eafd198-e5b5-4073-aa8d-8fa772a2aeea"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9738f917-8506-4ac6-ae51-79441ceac524"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a50a7bf9-74ea-4650-abfb-8d4c82fe7916"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b409600b-1c9d-493e-93ec-a7dfb9656f20"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ba3916f6-a547-4ac5-b531-37eaecb8d76b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("bd70f39b-fb5f-4557-b4bd-c50438149e01"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d3ff971b-8de7-4621-b27e-bdabe952cdd9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ee477485-d170-4105-accd-c6738f257a4f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fad3a06e-1f73-4689-9a74-df5f5679ca2b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("20277ef0-2189-452c-b0d0-c0593bd5a7b4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("493255e7-1bd9-4a2e-8e5a-235e987c6b60"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8fdd6a05-3eb5-479e-b1d3-7b464f7714f2"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("55730212-12b0-4da1-911c-d88c84a4b1cc"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6ca44709-7123-48df-bbe1-1bf881b659c9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("694c87d8-c5a8-4eb2-a7ae-fdb6a48628f1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8a493718-4f47-4cfd-b9f3-2f1dece02ffe"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9b9fb2f3-61f0-4a80-ab16-01346920fabd"));

            migrationBuilder.DropColumn(
                name: "LocalId",
                table: "Residents");

            migrationBuilder.DropColumn(
                name: "LocalNumber",
                table: "FullAddresses");

            migrationBuilder.DropColumn(
                name: "StaircaseNumber",
                table: "FullAddresses");

            migrationBuilder.RenameColumn(
                name: "FullAddressId",
                table: "Properties",
                newName: "BuildingId");

            migrationBuilder.RenameIndex(
                name: "IX_Properties_FullAddressId",
                table: "Properties",
                newName: "IX_Properties_BuildingId");

            migrationBuilder.AddColumn<Guid>(
                name: "PropertyAddressId",
                table: "Properties",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PropertyAddressId",
                table: "FullAddresses",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "PropertyManagerId",
                table: "Buildings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "InspectionTasks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TaskDelegatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BuildingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DueStartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InspectionTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InspectionTasks_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_InspectionTasks_Users_TaskDelegatorId",
                        column: x => x.TaskDelegatorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "PropertyAddresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VenueNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaircaseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyAddresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InspectionProtocols",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InspectionTaskId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InspectionDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InspectedPropertyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ResidentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    A_Gazomierz_umiejscowienie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    A_Gazomierz_szafka_wentylowana = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    A_Gazomierz_szczelnosc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    A_Gazomierz_usytuowanie_w_stosunku_do_1_go_odbiornika = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    A_Gazomierz_usytuowanie_w_stosunku_do_licznika_energii_elektr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    A_Gazomierz_kurek_przed_gazomierzem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    A_M_Przewody_rodzaj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    A_M_Przewody_przebieg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    A_M_Przewody_sposob_prowadzenia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    A_Przewody_przebieg_inst_gaz_przez_pokoje = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    A_Przewody_pion_inst_gaz_w_mieszkaniu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    A_Prawidlowosc_kuchenka_gazowa_typ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    A_Prawidlowosc_kuchenka_gazowa_stan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    A_Prawidlowosc_kuchenka_gazowa_podlaczenie_rodzaj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    A_Prawidlowosc_kuchenka_gazowa_podlaczenie_stan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    A_Prawidlowosc_kuchenka_gazowa_kurek_odcinajacy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    A_Prawidlowosc_kuchenka_gazowa_odleglosc_od_okna = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    A_Prawidlowosc_gazowy_podgrzewacz_cwu_stan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    A_Prawidlowosc_gazowy_podgrzewacz_cwu_kurek_odcinajacy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    A_Prawidlowosc_gazowy_podgrzewacz_cwu_rura_spalinowa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    A_Prawidlowosc_terma_gazowa_stan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    A_Prawidlowosc_terma_gazowa_kurek_odcinajacy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    A_Prawidlowosc_terma_gazowa_rura_spalinowa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    A_Prawidlowosc_kociol_co_z_kurkiek_i_rura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    A_Kubatura_warunku_techniczne = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    A_Wentylacja_kuchnia = table.Column<bool>(type: "bit", nullable: false),
                    A_Wentylacja_lazienka = table.Column<bool>(type: "bit", nullable: false),
                    A_Wentylacja_inne_pomieszczenia = table.Column<bool>(type: "bit", nullable: false),
                    A_Wentylacja_nawiew_kuchnia = table.Column<bool>(type: "bit", nullable: false),
                    A_Wentylacja_nawiew_lazienka = table.Column<bool>(type: "bit", nullable: false),
                    A_Wentylacja_nawiew_Zet_w_pomieszczeniu_z_kotlem = table.Column<bool>(type: "bit", nullable: false),
                    A_Wyniki_stan_szczelnosci = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    A_Wyniki_instalacja_wymaga_usuniecia_nieszczelnosci = table.Column<bool>(type: "bit", nullable: false),
                    A_Propan_butan = table.Column<bool>(type: "bit", nullable: false),
                    A_Inne_uwagi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InspectionProtocols", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InspectionProtocols_InspectionTasks_InspectionTaskId",
                        column: x => x.InspectionTaskId,
                        principalTable: "InspectionTasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_InspectionProtocols_Properties_InspectedPropertyId",
                        column: x => x.InspectedPropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InspectionProtocols_Residents_ResidentId",
                        column: x => x.ResidentId,
                        principalTable: "Residents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("0073a15a-9b19-4253-a7b8-95f33f9f2858"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("118c37eb-8e8f-4e87-b982-71bd13c79d52"), "Szef" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("c99788c6-d29e-411f-8c56-9200bc07e2db"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("1426693c-38f7-42f4-9dee-3d6f55647fb0"), true, true, true, new Guid("118c37eb-8e8f-4e87-b982-71bd13c79d52"), "Permissions", true, null },
                    { new Guid("25786e21-637c-4412-b2a0-d05032304810"), true, true, true, new Guid("118c37eb-8e8f-4e87-b982-71bd13c79d52"), "Users", true, null },
                    { new Guid("33c81f5e-0435-4320-a9e9-8eb5abfbaf64"), false, false, true, new Guid("0073a15a-9b19-4253-a7b8-95f33f9f2858"), "Users", false, null },
                    { new Guid("3c56f2ae-d159-4b06-bea6-f491d6ee607f"), false, false, false, new Guid("0073a15a-9b19-4253-a7b8-95f33f9f2858"), "Permissions", false, null },
                    { new Guid("4405f29e-5314-4954-8f69-f0f58fcab4a9"), true, true, true, new Guid("c99788c6-d29e-411f-8c56-9200bc07e2db"), "Users", true, null },
                    { new Guid("55a0c988-5d4f-4516-852c-75bedecc3778"), false, false, true, new Guid("0073a15a-9b19-4253-a7b8-95f33f9f2858"), "Roles", false, null },
                    { new Guid("94c84443-ba9f-47f4-b990-1bf1b897155c"), true, true, true, new Guid("c99788c6-d29e-411f-8c56-9200bc07e2db"), "Roles", true, null },
                    { new Guid("b7b79921-f5ff-4086-9235-bb78f46b5806"), true, true, true, new Guid("c99788c6-d29e-411f-8c56-9200bc07e2db"), "Permissions", true, null },
                    { new Guid("d8cf343f-2004-452c-bdd1-bcfa36d1d11a"), true, true, true, new Guid("118c37eb-8e8f-4e87-b982-71bd13c79d52"), "Roles", true, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("4e05a9b8-9e21-432a-bc0c-ee44c6dde748"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "", "+48 321 654 987", new Guid("0073a15a-9b19-4253-a7b8-95f33f9f2858") },
                    { new Guid("76b6c817-cb3c-4d47-9bb8-e2b2f0f77a95"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "", "987654321", new Guid("0073a15a-9b19-4253-a7b8-95f33f9f2858") },
                    { new Guid("830b6f44-2171-4a1c-927b-d354843c665c"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "k.tumiel", "", "123 456 789", new Guid("118c37eb-8e8f-4e87-b982-71bd13c79d52") },
                    { new Guid("9699dfd0-7689-40c3-8126-380e1eb9aa53"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "", "+48 312645978", new Guid("0073a15a-9b19-4253-a7b8-95f33f9f2858") },
                    { new Guid("ef2b6e2b-6f66-40ac-83e4-d7753bd644fa"), "", "admin", "", "admin", "admin", "", new Guid("c99788c6-d29e-411f-8c56-9200bc07e2db") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("2a0a20c2-4234-4821-8b4c-be4bb605116f"), true, true, null, null, "Users", true, new Guid("9699dfd0-7689-40c3-8126-380e1eb9aa53") },
                    { new Guid("710dcb8f-1a10-4402-9bb1-ee123d5f44e7"), true, null, null, null, "Roles", true, new Guid("9699dfd0-7689-40c3-8126-380e1eb9aa53") },
                    { new Guid("73bcdfdb-dba7-48f8-befc-e3087c18f938"), null, null, false, null, "Users", null, new Guid("76b6c817-cb3c-4d47-9bb8-e2b2f0f77a95") },
                    { new Guid("8aabab85-0e11-4ef2-8f2c-557d012cd08c"), null, null, false, null, "Roles", null, new Guid("76b6c817-cb3c-4d47-9bb8-e2b2f0f77a95") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Properties_PropertyAddressId",
                table: "Properties",
                column: "PropertyAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_FullAddresses_BuildingAddressId",
                table: "FullAddresses",
                column: "BuildingAddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FullAddresses_PropertyAddressId",
                table: "FullAddresses",
                column: "PropertyAddressId",
                unique: true,
                filter: "[PropertyAddressId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_InspectionProtocols_InspectedPropertyId",
                table: "InspectionProtocols",
                column: "InspectedPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_InspectionProtocols_InspectionTaskId",
                table: "InspectionProtocols",
                column: "InspectionTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_InspectionProtocols_ResidentId",
                table: "InspectionProtocols",
                column: "ResidentId");

            migrationBuilder.CreateIndex(
                name: "IX_InspectionTasks_BuildingId",
                table: "InspectionTasks",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_InspectionTasks_TaskDelegatorId",
                table: "InspectionTasks",
                column: "TaskDelegatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_FullAddresses_PropertyAddresses_PropertyAddressId",
                table: "FullAddresses",
                column: "PropertyAddressId",
                principalTable: "PropertyAddresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Buildings_BuildingId",
                table: "Properties",
                column: "BuildingId",
                principalTable: "Buildings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_PropertyAddresses_PropertyAddressId",
                table: "Properties",
                column: "PropertyAddressId",
                principalTable: "PropertyAddresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FullAddresses_PropertyAddresses_PropertyAddressId",
                table: "FullAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Buildings_BuildingId",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_PropertyAddresses_PropertyAddressId",
                table: "Properties");

            migrationBuilder.DropTable(
                name: "InspectionProtocols");

            migrationBuilder.DropTable(
                name: "PropertyAddresses");

            migrationBuilder.DropTable(
                name: "InspectionTasks");

            migrationBuilder.DropIndex(
                name: "IX_Properties_PropertyAddressId",
                table: "Properties");

            migrationBuilder.DropIndex(
                name: "IX_FullAddresses_BuildingAddressId",
                table: "FullAddresses");

            migrationBuilder.DropIndex(
                name: "IX_FullAddresses_PropertyAddressId",
                table: "FullAddresses");

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1426693c-38f7-42f4-9dee-3d6f55647fb0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("25786e21-637c-4412-b2a0-d05032304810"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2a0a20c2-4234-4821-8b4c-be4bb605116f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("33c81f5e-0435-4320-a9e9-8eb5abfbaf64"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3c56f2ae-d159-4b06-bea6-f491d6ee607f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4405f29e-5314-4954-8f69-f0f58fcab4a9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("55a0c988-5d4f-4516-852c-75bedecc3778"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("710dcb8f-1a10-4402-9bb1-ee123d5f44e7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("73bcdfdb-dba7-48f8-befc-e3087c18f938"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8aabab85-0e11-4ef2-8f2c-557d012cd08c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("94c84443-ba9f-47f4-b990-1bf1b897155c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b7b79921-f5ff-4086-9235-bb78f46b5806"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d8cf343f-2004-452c-bdd1-bcfa36d1d11a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4e05a9b8-9e21-432a-bc0c-ee44c6dde748"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("830b6f44-2171-4a1c-927b-d354843c665c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ef2b6e2b-6f66-40ac-83e4-d7753bd644fa"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("118c37eb-8e8f-4e87-b982-71bd13c79d52"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c99788c6-d29e-411f-8c56-9200bc07e2db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("76b6c817-cb3c-4d47-9bb8-e2b2f0f77a95"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9699dfd0-7689-40c3-8126-380e1eb9aa53"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0073a15a-9b19-4253-a7b8-95f33f9f2858"));

            migrationBuilder.DropColumn(
                name: "PropertyAddressId",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "PropertyAddressId",
                table: "FullAddresses");

            migrationBuilder.RenameColumn(
                name: "BuildingId",
                table: "Properties",
                newName: "FullAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Properties_BuildingId",
                table: "Properties",
                newName: "IX_Properties_FullAddressId");

            migrationBuilder.AddColumn<Guid>(
                name: "LocalId",
                table: "Residents",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LocalNumber",
                table: "FullAddresses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StaircaseNumber",
                table: "FullAddresses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "PropertyManagerId",
                table: "Buildings",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateTable(
                name: "Locals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BuildingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullAddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locals_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Locals_FullAddresses_FullAddressId",
                        column: x => x.FullAddressId,
                        principalTable: "FullAddresses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PropertyResident",
                columns: table => new
                {
                    PropertiesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ResidentsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyResident", x => new { x.PropertiesId, x.ResidentsId });
                    table.ForeignKey(
                        name: "FK_PropertyResident_Properties_PropertiesId",
                        column: x => x.PropertiesId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyResident_Residents_ResidentsId",
                        column: x => x.ResidentsId,
                        principalTable: "Residents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("55730212-12b0-4da1-911c-d88c84a4b1cc"), "Szef" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("6ca44709-7123-48df-bbe1-1bf881b659c9"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("9b9fb2f3-61f0-4a80-ab16-01346920fabd"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("0346691a-30e0-408b-9caa-ad13dd4dc868"), true, true, true, new Guid("55730212-12b0-4da1-911c-d88c84a4b1cc"), "Permissions", true, null },
                    { new Guid("537be9f4-f14a-417a-afef-70cbb56902f9"), true, true, true, new Guid("6ca44709-7123-48df-bbe1-1bf881b659c9"), "Users", true, null },
                    { new Guid("7a5c7125-1602-4f4c-89e6-a7b24672950c"), true, true, true, new Guid("6ca44709-7123-48df-bbe1-1bf881b659c9"), "Permissions", true, null },
                    { new Guid("a50a7bf9-74ea-4650-abfb-8d4c82fe7916"), false, false, false, new Guid("9b9fb2f3-61f0-4a80-ab16-01346920fabd"), "Permissions", false, null },
                    { new Guid("b409600b-1c9d-493e-93ec-a7dfb9656f20"), true, true, true, new Guid("6ca44709-7123-48df-bbe1-1bf881b659c9"), "Roles", true, null },
                    { new Guid("ba3916f6-a547-4ac5-b531-37eaecb8d76b"), true, true, true, new Guid("55730212-12b0-4da1-911c-d88c84a4b1cc"), "Users", true, null },
                    { new Guid("bd70f39b-fb5f-4557-b4bd-c50438149e01"), false, false, true, new Guid("9b9fb2f3-61f0-4a80-ab16-01346920fabd"), "Users", false, null },
                    { new Guid("d3ff971b-8de7-4621-b27e-bdabe952cdd9"), false, false, true, new Guid("9b9fb2f3-61f0-4a80-ab16-01346920fabd"), "Roles", false, null },
                    { new Guid("ee477485-d170-4105-accd-c6738f257a4f"), true, true, true, new Guid("55730212-12b0-4da1-911c-d88c84a4b1cc"), "Roles", true, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("20277ef0-2189-452c-b0d0-c0593bd5a7b4"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "", "+48 321 654 987", new Guid("9b9fb2f3-61f0-4a80-ab16-01346920fabd") },
                    { new Guid("493255e7-1bd9-4a2e-8e5a-235e987c6b60"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "k.tumiel", "", "123 456 789", new Guid("55730212-12b0-4da1-911c-d88c84a4b1cc") },
                    { new Guid("694c87d8-c5a8-4eb2-a7ae-fdb6a48628f1"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "", "+48 312645978", new Guid("9b9fb2f3-61f0-4a80-ab16-01346920fabd") },
                    { new Guid("8a493718-4f47-4cfd-b9f3-2f1dece02ffe"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "", "987654321", new Guid("9b9fb2f3-61f0-4a80-ab16-01346920fabd") },
                    { new Guid("8fdd6a05-3eb5-479e-b1d3-7b464f7714f2"), "", "admin", "", "admin", "admin", "", new Guid("6ca44709-7123-48df-bbe1-1bf881b659c9") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("0c214b48-2df8-4acd-8346-d2992c59e348"), null, null, false, null, "Roles", null, new Guid("8a493718-4f47-4cfd-b9f3-2f1dece02ffe") },
                    { new Guid("8eafd198-e5b5-4073-aa8d-8fa772a2aeea"), null, null, false, null, "Users", null, new Guid("8a493718-4f47-4cfd-b9f3-2f1dece02ffe") },
                    { new Guid("9738f917-8506-4ac6-ae51-79441ceac524"), true, true, null, null, "Users", true, new Guid("694c87d8-c5a8-4eb2-a7ae-fdb6a48628f1") },
                    { new Guid("fad3a06e-1f73-4689-9a74-df5f5679ca2b"), true, null, null, null, "Roles", true, new Guid("694c87d8-c5a8-4eb2-a7ae-fdb6a48628f1") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Residents_LocalId",
                table: "Residents",
                column: "LocalId");

            migrationBuilder.CreateIndex(
                name: "IX_FullAddresses_BuildingAddressId",
                table: "FullAddresses",
                column: "BuildingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Locals_BuildingId",
                table: "Locals",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_Locals_FullAddressId",
                table: "Locals",
                column: "FullAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyResident_ResidentsId",
                table: "PropertyResident",
                column: "ResidentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_FullAddresses_FullAddressId",
                table: "Properties",
                column: "FullAddressId",
                principalTable: "FullAddresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Residents_Locals_LocalId",
                table: "Residents",
                column: "LocalId",
                principalTable: "Locals",
                principalColumn: "Id");
        }
    }
}
