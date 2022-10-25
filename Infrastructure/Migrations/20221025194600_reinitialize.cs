using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class reinitialize : Migration
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
                    PostalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyManagers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullAddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyManagers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyManagers_FullAddresses_FullAddressId",
                        column: x => x.FullAddressId,
                        principalTable: "FullAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    FullAddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                        name: "FK_Locals_FullAddresses_FullAddressId",
                        column: x => x.FullAddressId,
                        principalTable: "FullAddresses",
                        principalColumn: "Id");
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
                values: new object[] { new Guid("66740179-c8d2-45cb-83c0-9459b5b0129c"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("c9c539c2-0342-42a8-88c3-9f63ff7d12e9"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("e9f1cd96-b528-4a37-b2fe-5c0eae040945"), "Szef" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("460852c4-c5b2-436a-9551-5baabcbcf469"), true, true, true, new Guid("e9f1cd96-b528-4a37-b2fe-5c0eae040945"), "Permissions", true, null },
                    { new Guid("5f9adb48-beee-43b7-a171-0bdbbd3a69cd"), false, false, false, new Guid("c9c539c2-0342-42a8-88c3-9f63ff7d12e9"), "Permissions", false, null },
                    { new Guid("67ee140d-587b-4a6a-a714-ddf5c4435e5c"), true, true, true, new Guid("66740179-c8d2-45cb-83c0-9459b5b0129c"), "Users", true, null },
                    { new Guid("7276454a-00e9-4806-878e-483667e8eca7"), true, true, true, new Guid("e9f1cd96-b528-4a37-b2fe-5c0eae040945"), "Users", true, null },
                    { new Guid("c4c08264-863a-4853-80e4-59233cde2acd"), false, false, true, new Guid("c9c539c2-0342-42a8-88c3-9f63ff7d12e9"), "Users", false, null },
                    { new Guid("d257a0bc-8c81-48a0-bda8-baf3258263f3"), true, true, true, new Guid("66740179-c8d2-45cb-83c0-9459b5b0129c"), "Roles", true, null },
                    { new Guid("db9e9386-4689-4373-924e-eb43a28b9100"), true, true, true, new Guid("e9f1cd96-b528-4a37-b2fe-5c0eae040945"), "Roles", true, null },
                    { new Guid("dd166d55-6e02-4b95-aa2b-ba41b312249b"), true, true, true, new Guid("66740179-c8d2-45cb-83c0-9459b5b0129c"), "Users", true, null },
                    { new Guid("dfc54869-f1d5-40ef-92aa-09ba2f9fbabf"), false, false, true, new Guid("c9c539c2-0342-42a8-88c3-9f63ff7d12e9"), "Roles", false, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("4989c876-fce8-4301-9774-7ee56d5094f0"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "k.tumiel", "", "123 456 789", new Guid("e9f1cd96-b528-4a37-b2fe-5c0eae040945") },
                    { new Guid("50802870-c076-49b5-89ed-0295e12ca832"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "", "+48 312645978", new Guid("c9c539c2-0342-42a8-88c3-9f63ff7d12e9") },
                    { new Guid("6e8d74ef-19dd-44e3-a3d7-02057b70f962"), "", "admin", "", "admin", "admin", "", new Guid("66740179-c8d2-45cb-83c0-9459b5b0129c") },
                    { new Guid("97deb265-1546-4f20-8e9f-5e67b7a5c64c"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "", "987654321", new Guid("c9c539c2-0342-42a8-88c3-9f63ff7d12e9") },
                    { new Guid("f40d55a5-7ac2-4570-95a8-ebb815e34ad3"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "", "+48 321 654 987", new Guid("c9c539c2-0342-42a8-88c3-9f63ff7d12e9") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("39ee58d1-93f3-46d2-97c5-2f0ea65e1954"), true, null, null, null, "Permissions", true, new Guid("50802870-c076-49b5-89ed-0295e12ca832") },
                    { new Guid("60383fa8-2705-4a61-9a39-d13c40161cbf"), true, true, null, null, "Permissions", true, new Guid("50802870-c076-49b5-89ed-0295e12ca832") },
                    { new Guid("68faa1f9-b4ec-4e59-9448-bb245c53be98"), null, null, false, null, "Roles", null, new Guid("97deb265-1546-4f20-8e9f-5e67b7a5c64c") },
                    { new Guid("f883dd9e-a13d-4e0a-a828-f70252fdddf0"), null, null, false, null, "Users", null, new Guid("97deb265-1546-4f20-8e9f-5e67b7a5c64c") }
                });

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
