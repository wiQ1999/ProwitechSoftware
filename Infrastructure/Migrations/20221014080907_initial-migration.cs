using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BuildingAddresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BuildingNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: true),
                    CoordinateType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingAddresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocalInfos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocalNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StaircaseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FullAddresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BuildingAddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocalInfoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FullAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FullAddresses_BuildingAddresses_BuildingAddressId",
                        column: x => x.BuildingAddressId,
                        principalTable: "BuildingAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FullAddresses_LocalInfos_LocalInfoId",
                        column: x => x.LocalInfoId,
                        principalTable: "LocalInfos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ContactInfos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullAddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactInfos_FullAddresses_FullAddressId",
                        column: x => x.FullAddressId,
                        principalTable: "FullAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullAddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Properties_FullAddresses_FullAddressId",
                        column: x => x.FullAddressId,
                        principalTable: "FullAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Create = table.Column<bool>(type: "bit", nullable: true),
                    Read = table.Column<bool>(type: "bit", nullable: true),
                    Update = table.Column<bool>(type: "bit", nullable: true),
                    Delete = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permissions_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Permissions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PropertyManagers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInfoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyManagers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyManagers_ContactInfos_ContactInfoId",
                        column: x => x.ContactInfoId,
                        principalTable: "ContactInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BuildingAddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyManagerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Buildings_BuildingAddresses_BuildingAddressId",
                        column: x => x.BuildingAddressId,
                        principalTable: "BuildingAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Buildings_PropertyManagers_PropertyManagerId",
                        column: x => x.PropertyManagerId,
                        principalTable: "PropertyManagers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Locals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocalInfoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BuildingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                        name: "FK_Locals_LocalInfos_LocalInfoId",
                        column: x => x.LocalInfoId,
                        principalTable: "LocalInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Residents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocalId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Residents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Residents_Locals_LocalId",
                        column: x => x.LocalId,
                        principalTable: "Locals",
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
                values: new object[,]
                {
                    { new Guid("071fabb5-cfd9-421c-8f2f-683fd55e231e"), "Szef" },
                    { new Guid("c2ed58e7-2742-4359-a765-88b8df925ff5"), "Administrator" },
                    { new Guid("c89bafcd-6d31-4f62-900a-4370e03bff16"), "Pracownik" },
                    { new Guid("cbd1ceba-b59b-4c2b-9f23-cb7e0e2a06e4"), "Praktykant" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("0c812423-8dbf-46ba-bf10-3540f3db0893"), true, true, "Użytkownicy", true, new Guid("c2ed58e7-2742-4359-a765-88b8df925ff5"), true, null },
                    { new Guid("20597e4f-b8fe-4d38-9027-e28e5253d243"), false, false, "Użytkownicy", false, new Guid("cbd1ceba-b59b-4c2b-9f23-cb7e0e2a06e4"), false, null },
                    { new Guid("42ba9083-58bd-4886-9e93-da74fe9a22a9"), false, false, "Role", false, new Guid("cbd1ceba-b59b-4c2b-9f23-cb7e0e2a06e4"), false, null },
                    { new Guid("57f3c612-6661-48b8-91d0-a11ee058788f"), true, true, "Użytkownicy", true, new Guid("071fabb5-cfd9-421c-8f2f-683fd55e231e"), true, null },
                    { new Guid("5b399227-2774-4a53-8816-ab1900892d59"), false, false, "Role", false, new Guid("c89bafcd-6d31-4f62-900a-4370e03bff16"), false, null },
                    { new Guid("9c9728f0-678f-4a33-aae3-89962488320f"), true, true, "Role", true, new Guid("c2ed58e7-2742-4359-a765-88b8df925ff5"), true, null },
                    { new Guid("ab922881-e9df-4465-8f7f-573c8b2f412f"), true, true, "Role", true, new Guid("071fabb5-cfd9-421c-8f2f-683fd55e231e"), true, null },
                    { new Guid("c78e868b-4e51-46d0-a931-a3c424ac16c8"), false, false, "Użytkownicy", false, new Guid("c89bafcd-6d31-4f62-900a-4370e03bff16"), false, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("21f9bdee-2114-49dc-9c07-2342bd8a6c79"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "", "+48 312645978", new Guid("c89bafcd-6d31-4f62-900a-4370e03bff16") },
                    { new Guid("5adbbeb9-4c28-4a2b-a75d-af65e9c0d173"), "", "admin", "", "admin", "admin", "", new Guid("c2ed58e7-2742-4359-a765-88b8df925ff5") },
                    { new Guid("ae06153b-bde6-49c8-991d-f555ee95ccb7"), "b.smyk@gmail.com", "Bartosz", "Smyk", "a1", "", "213-546-879", new Guid("cbd1ceba-b59b-4c2b-9f23-cb7e0e2a06e4") },
                    { new Guid("f4db7085-c59e-44a2-83a1-b3fd57e3d2f6"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "", "+48 321 654 987", new Guid("c89bafcd-6d31-4f62-900a-4370e03bff16") },
                    { new Guid("f7ed246d-e7db-4ed7-ab38-da8e3bc82cca"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "", "987654321", new Guid("c89bafcd-6d31-4f62-900a-4370e03bff16") },
                    { new Guid("fa963995-ead7-4474-beb6-7fcb65db56c0"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "k.tumiel", "", "123 456 789", new Guid("071fabb5-cfd9-421c-8f2f-683fd55e231e") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[] { new Guid("85450373-fc8f-4889-8365-9a6d8bf161cd"), null, null, "Użytkownicy", true, null, null, new Guid("f7ed246d-e7db-4ed7-ab38-da8e3bc82cca") });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[] { new Guid("996934de-149c-44fa-ae88-0d156eb35590"), null, null, "Role", true, null, null, new Guid("f7ed246d-e7db-4ed7-ab38-da8e3bc82cca") });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[] { new Guid("e17f5553-8e0d-43ef-a6b6-0e0489cee633"), null, null, "Użytkownicy", true, null, true, new Guid("21f9bdee-2114-49dc-9c07-2342bd8a6c79") });

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_BuildingAddressId",
                table: "Buildings",
                column: "BuildingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_PropertyManagerId",
                table: "Buildings",
                column: "PropertyManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactInfos_FullAddressId",
                table: "ContactInfos",
                column: "FullAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_FullAddresses_BuildingAddressId",
                table: "FullAddresses",
                column: "BuildingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_FullAddresses_LocalInfoId",
                table: "FullAddresses",
                column: "LocalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Locals_BuildingId",
                table: "Locals",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_Locals_LocalInfoId",
                table: "Locals",
                column: "LocalInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_RoleId",
                table: "Permissions",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_UserId",
                table: "Permissions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_FullAddressId",
                table: "Properties",
                column: "FullAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyManagers_ContactInfoId",
                table: "PropertyManagers",
                column: "ContactInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyResident_ResidentsId",
                table: "PropertyResident",
                column: "ResidentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Residents_LocalId",
                table: "Residents",
                column: "LocalId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "PropertyResident");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "Residents");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Locals");

            migrationBuilder.DropTable(
                name: "Buildings");

            migrationBuilder.DropTable(
                name: "PropertyManagers");

            migrationBuilder.DropTable(
                name: "ContactInfos");

            migrationBuilder.DropTable(
                name: "FullAddresses");

            migrationBuilder.DropTable(
                name: "BuildingAddresses");

            migrationBuilder.DropTable(
                name: "LocalInfos");
        }
    }
}
