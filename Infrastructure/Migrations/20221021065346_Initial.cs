using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BuildingAddresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StreetName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BuildingNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: true),
                    CoordinateType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingAddresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
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
                    LocalNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaircaseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FullAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FullAddresses_BuildingAddresses_BuildingAddressId",
                        column: x => x.BuildingAddressId,
                        principalTable: "BuildingAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade); // TUTAJ ZMIANA
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
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
                        onDelete: ReferentialAction.Cascade); // TUTAJ ZMIANA
                });

            migrationBuilder.CreateTable(
                name: "PropertyManagers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullAddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyManagers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyManagers_FullAddresses_FullAddressId",
                        column: x => x.FullAddressId,
                        principalTable: "FullAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);//TUTAJ ZMIANA
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
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
                name: "Buildings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BuildingAddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                        onDelete: ReferentialAction.Cascade);//TUTAJ ZMIANA
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
                    FullAddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        onDelete: ReferentialAction.Cascade); // TUTAJ ZMIANA
                    table.ForeignKey(
                        name: "FK_Locals_FullAddresses_FullAddressId",
                        column: x => x.FullAddressId,
                        principalTable: "FullAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade); // TUTAJ ZMIANA
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
                        onDelete: ReferentialAction.Cascade);//ZMIANA
                    table.ForeignKey(
                        name: "FK_PropertyResident_Residents_ResidentsId",
                        column: x => x.ResidentsId,
                        principalTable: "Residents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);//ZMIANA
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5093d954-ce66-44d8-9b31-d0341c0634a2"), "Administrator" },
                    { new Guid("8b941392-dd5b-44ed-91fb-ac65e78c1d4e"), "Szef" },
                    { new Guid("bb17f303-f11d-4d99-8b1b-ea28ada0c2b5"), "Praktykant" },
                    { new Guid("cec08606-5378-401f-9c51-80f5680b7493"), "Pracownik" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("25826a19-de8f-427a-bcf9-66f3a14c1e28"), true, true, "Użytkownicy", true, new Guid("8b941392-dd5b-44ed-91fb-ac65e78c1d4e"), true, null },
                    { new Guid("61c38b90-c0d5-428b-b9d1-7847ac734243"), false, false, "Role", false, new Guid("bb17f303-f11d-4d99-8b1b-ea28ada0c2b5"), false, null },
                    { new Guid("6d75007e-2de4-47f3-be20-5bf0917a4719"), false, false, "Użytkownicy", false, new Guid("cec08606-5378-401f-9c51-80f5680b7493"), false, null },
                    { new Guid("753f8395-e9d9-4752-893c-3a0f6f2eba91"), false, false, "Użytkownicy", false, new Guid("bb17f303-f11d-4d99-8b1b-ea28ada0c2b5"), false, null },
                    { new Guid("a4c1298b-3795-4d06-ad5e-c8820fa29aec"), true, true, "Role", true, new Guid("8b941392-dd5b-44ed-91fb-ac65e78c1d4e"), true, null },
                    { new Guid("b3405004-b3ff-43b7-aa61-865b1a14d93a"), true, true, "Użytkownicy", true, new Guid("5093d954-ce66-44d8-9b31-d0341c0634a2"), true, null },
                    { new Guid("c9411af4-c030-438d-a369-b5583736eab8"), true, true, "Role", true, new Guid("5093d954-ce66-44d8-9b31-d0341c0634a2"), true, null },
                    { new Guid("cc0bc8aa-1992-454a-8084-8d8d405e4ea2"), false, false, "Role", false, new Guid("cec08606-5378-401f-9c51-80f5680b7493"), false, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("238f32c2-5b07-4cce-9721-aabee0da1c7b"), "b.smyk@gmail.com", "Bartosz", "Smyk", "a1", "", "213-546-879", new Guid("bb17f303-f11d-4d99-8b1b-ea28ada0c2b5") },
                    { new Guid("779e4a65-a60a-48b2-97e2-4d753b4464fa"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "k.tumiel", "", "123 456 789", new Guid("8b941392-dd5b-44ed-91fb-ac65e78c1d4e") },
                    { new Guid("891f52f8-0e7e-4ce2-a568-b5d3a645dd1a"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "", "+48 321 654 987", new Guid("cec08606-5378-401f-9c51-80f5680b7493") },
                    { new Guid("c10cfae4-5bc7-48d6-a1aa-a53c29782fad"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "", "987654321", new Guid("cec08606-5378-401f-9c51-80f5680b7493") },
                    { new Guid("ce3321f2-241f-47bf-ad0c-8b90524ca2f5"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "", "+48 312645978", new Guid("cec08606-5378-401f-9c51-80f5680b7493") },
                    { new Guid("ef9c4202-e052-452e-8c52-69ec99881f3e"), "", "admin", "", "admin", "admin", "", new Guid("5093d954-ce66-44d8-9b31-d0341c0634a2") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[] { new Guid("9583e591-067c-49c6-b02b-81014cfe75b3"), null, null, "Role", true, null, null, new Guid("c10cfae4-5bc7-48d6-a1aa-a53c29782fad") });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[] { new Guid("ebb81b8b-9134-45d3-89d1-1ed6fc64ff76"), null, null, "Użytkownicy", true, null, true, new Guid("ce3321f2-241f-47bf-ad0c-8b90524ca2f5") });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[] { new Guid("f6a39d89-1f39-403f-bb60-6100342f0cc0"), null, null, "Użytkownicy", true, null, null, new Guid("c10cfae4-5bc7-48d6-a1aa-a53c29782fad") });

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_BuildingAddressId",
                table: "Buildings",
                column: "BuildingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_PropertyManagerId",
                table: "Buildings",
                column: "PropertyManagerId");

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
                name: "IX_PropertyManagers_FullAddressId",
                table: "PropertyManagers",
                column: "FullAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyResident_ResidentsId",
                table: "PropertyResident",
                column: "ResidentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Residents_LocalId",
                table: "Residents",
                column: "LocalId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Name",
                table: "Roles",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Login",
                table: "Users",
                column: "Login",
                unique: true);

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
                name: "FullAddresses");

            migrationBuilder.DropTable(
                name: "BuildingAddresses");
        }
    }
}
