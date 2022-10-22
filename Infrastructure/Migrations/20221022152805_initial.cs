using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class initial : Migration
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
                        onDelete: ReferentialAction.Cascade);
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
                        principalColumn: "Id");
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
                values: new object[,]
                {
                    { new Guid("0cb17b9c-bf1f-49c8-ab4c-584761d53c67"), "Administrator" },
                    { new Guid("4265f5b7-c74e-43e0-8ec3-998ebd010a9e"), "Szef" },
                    { new Guid("51e271c3-017c-41a3-a8b0-df738292f739"), "Pracownik" },
                    { new Guid("f32717b6-ae57-41b7-950b-0845291a1600"), "Praktykant" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("1fded999-67f0-4177-8085-35aef6c42c39"), false, false, "Role", false, new Guid("51e271c3-017c-41a3-a8b0-df738292f739"), false, null },
                    { new Guid("497d9b8d-8903-4e8d-8f22-27dc7e4b80d7"), true, true, "Użytkownicy", true, new Guid("4265f5b7-c74e-43e0-8ec3-998ebd010a9e"), true, null },
                    { new Guid("6ecac474-1cfd-4989-9d6b-9a8be0df3ae8"), false, false, "Role", false, new Guid("f32717b6-ae57-41b7-950b-0845291a1600"), false, null },
                    { new Guid("706ecfc7-84c2-4bdf-b75f-1837dc50f672"), true, true, "Role", true, new Guid("0cb17b9c-bf1f-49c8-ab4c-584761d53c67"), true, null },
                    { new Guid("7ad1aabb-9db4-4abc-9928-b8906e60418f"), false, false, "Użytkownicy", false, new Guid("f32717b6-ae57-41b7-950b-0845291a1600"), false, null },
                    { new Guid("9ce60928-c46e-4f0b-b0d5-bdd14bf2dca7"), false, false, "Użytkownicy", false, new Guid("51e271c3-017c-41a3-a8b0-df738292f739"), false, null },
                    { new Guid("9d34aa7e-af09-430d-a88a-4f4b9e32c3b9"), true, true, "Użytkownicy", true, new Guid("0cb17b9c-bf1f-49c8-ab4c-584761d53c67"), true, null },
                    { new Guid("fd6b994c-8ff7-4756-9a02-ad1282e1ecb2"), true, true, "Role", true, new Guid("4265f5b7-c74e-43e0-8ec3-998ebd010a9e"), true, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("0657f743-44ea-465a-b6ce-fe02f9fbcce9"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "", "+48 312645978", new Guid("51e271c3-017c-41a3-a8b0-df738292f739") },
                    { new Guid("11ef09d1-aa9b-47c1-b5f1-61281e3945d6"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "", "+48 321 654 987", new Guid("51e271c3-017c-41a3-a8b0-df738292f739") },
                    { new Guid("1be0a5aa-4acf-41ed-b9ad-a59465d3666c"), "", "admin", "", "admin", "admin", "", new Guid("0cb17b9c-bf1f-49c8-ab4c-584761d53c67") },
                    { new Guid("c28ab15f-92d8-4ed1-a0a7-7910e8a65211"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "", "987654321", new Guid("51e271c3-017c-41a3-a8b0-df738292f739") },
                    { new Guid("e45f1049-effb-4409-8602-d468de61df53"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "k.tumiel", "", "123 456 789", new Guid("4265f5b7-c74e-43e0-8ec3-998ebd010a9e") },
                    { new Guid("ed9b5bce-e82a-4307-bf61-adcc15055496"), "b.smyk@gmail.com", "Bartosz", "Smyk", "a1", "", "213-546-879", new Guid("f32717b6-ae57-41b7-950b-0845291a1600") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[] { new Guid("1b9ba2b8-4531-480d-9efe-26c7082b48f9"), null, null, "Użytkownicy", true, null, null, new Guid("c28ab15f-92d8-4ed1-a0a7-7910e8a65211") });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[] { new Guid("2eb73469-fc14-4465-930d-b6c568916183"), null, null, "Użytkownicy", true, null, true, new Guid("0657f743-44ea-465a-b6ce-fe02f9fbcce9") });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[] { new Guid("776a517c-70bb-450d-8ec9-5f60a2981f4f"), null, null, "Role", true, null, null, new Guid("c28ab15f-92d8-4ed1-a0a7-7910e8a65211") });

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
