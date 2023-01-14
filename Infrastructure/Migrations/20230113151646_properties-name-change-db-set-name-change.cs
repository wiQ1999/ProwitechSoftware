using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class propertiesnamechangedbsetnamechange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InspectionProtocols_Properties_InspectedPropertyId",
                table: "InspectionProtocols");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Buildings_BuildingId",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_PropertyAddresses_PropertyAddressId",
                table: "Properties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Properties",
                table: "Properties");

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("07f8d326-fc4a-423f-adaf-a14cf533079e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0d6972dd-6b9b-4b7c-903b-1ff0e457b425"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("19352bdc-d362-49c4-9db5-a64ecf7a9f21"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("35c3865b-ab12-430e-a1d8-effdda8b66ea"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("428287e2-dc24-4da0-91b0-4f0661fa3b44"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4d9bc78f-3e03-4202-929a-6b3e12fd36c0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("503bf17c-46eb-4b87-8c90-9949d2100c2e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("66ff4c6a-3d77-4104-b9dd-0666e2707d25"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6f186ede-972b-491b-9f0c-a1d2b8237746"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("97a15e2f-5d51-4174-8321-13f0417cf7f6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9b9621f2-370b-4b0c-bf93-e5a6c642a3ee"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b29130c0-da55-4baa-9042-c4c19ba726f2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e70a1383-6b2d-426a-96f5-1d801494bd70"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("16013e76-428a-4c19-99b5-0434801d71f4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8b776488-324c-4755-b368-505f06d461fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a83ea4f0-dfda-46ea-8a2b-b49877c2e675"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5a6c522c-c45f-4489-8fea-1fcd0a3b5a2d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c0352709-5bf9-4a6a-9238-85e08e764b63"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66a2806f-a3fd-4618-bf13-51e2cb4d0835"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d5515bd-4843-4bbc-98b4-cf1982b48e1b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("31275f60-0769-462d-9ed0-582b9e20a46b"));

            migrationBuilder.RenameTable(
                name: "Properties",
                newName: "RealProperties");

            migrationBuilder.RenameIndex(
                name: "IX_Properties_PropertyAddressId",
                table: "RealProperties",
                newName: "IX_RealProperties_PropertyAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Properties_BuildingId",
                table: "RealProperties",
                newName: "IX_RealProperties_BuildingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RealProperties",
                table: "RealProperties",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("102cea50-d49a-4003-94f1-54a76a42d1bc"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("672e3f48-b833-4b0d-8b18-c5cb8a7c04df"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("c4c7bf1e-db2c-4b8c-8d11-32f226ef6c7f"), "Szef" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("251193e8-67a5-41d5-a1d9-33765fcbc49f"), true, true, true, new Guid("672e3f48-b833-4b0d-8b18-c5cb8a7c04df"), "Roles", true, null },
                    { new Guid("2e6118f3-c3e8-4cd4-9e84-7861d0d754f6"), false, false, false, new Guid("102cea50-d49a-4003-94f1-54a76a42d1bc"), "Permissions", false, null },
                    { new Guid("3b112c6a-8090-41cf-99b2-85c79c147a19"), false, false, true, new Guid("102cea50-d49a-4003-94f1-54a76a42d1bc"), "Roles", false, null },
                    { new Guid("55562324-94b5-478d-a243-58f851268a77"), true, true, true, new Guid("672e3f48-b833-4b0d-8b18-c5cb8a7c04df"), "Users", true, null },
                    { new Guid("5e4d4010-ed2b-4fc9-838c-f7c8bebf1849"), true, true, true, new Guid("c4c7bf1e-db2c-4b8c-8d11-32f226ef6c7f"), "Permissions", true, null },
                    { new Guid("6076dddc-08d1-40e0-b99a-e1a7103cdcdd"), true, true, true, new Guid("c4c7bf1e-db2c-4b8c-8d11-32f226ef6c7f"), "Users", true, null },
                    { new Guid("68e6bc65-525f-4cdf-ba82-64e678623c27"), true, true, true, new Guid("672e3f48-b833-4b0d-8b18-c5cb8a7c04df"), "Permissions", true, null },
                    { new Guid("69224362-f329-40a4-8920-bb5c018c1b30"), false, false, true, new Guid("102cea50-d49a-4003-94f1-54a76a42d1bc"), "Users", false, null },
                    { new Guid("e20348fc-e9fc-499b-8b1d-a9f5dccb3a94"), true, true, true, new Guid("c4c7bf1e-db2c-4b8c-8d11-32f226ef6c7f"), "Roles", true, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("0b075ca9-bc32-4c1b-894b-d7d47dbdb666"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "", "+48 312645978", new Guid("102cea50-d49a-4003-94f1-54a76a42d1bc") },
                    { new Guid("53551129-a676-4cfd-bd0d-7702a2ac6a5d"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "", "+48 321 654 987", new Guid("102cea50-d49a-4003-94f1-54a76a42d1bc") },
                    { new Guid("6f9a2657-8c0c-41b9-98dd-acc3fc3da05c"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "k.tumiel", "", "123 456 789", new Guid("c4c7bf1e-db2c-4b8c-8d11-32f226ef6c7f") },
                    { new Guid("77d44802-d736-40c5-a50a-d20a5d08e3e6"), "", "admin", "", "admin", "admin", "", new Guid("672e3f48-b833-4b0d-8b18-c5cb8a7c04df") },
                    { new Guid("c2a686b5-d665-4cdf-bebd-e9e32e2e3839"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "", "987654321", new Guid("102cea50-d49a-4003-94f1-54a76a42d1bc") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("2efd0f59-8e9c-4a34-98ff-c16a99991225"), true, true, null, null, "Users", true, new Guid("0b075ca9-bc32-4c1b-894b-d7d47dbdb666") },
                    { new Guid("310c5e93-708b-4b26-ba6a-181d149d0eab"), null, null, false, null, "Users", null, new Guid("c2a686b5-d665-4cdf-bebd-e9e32e2e3839") },
                    { new Guid("4df55c7f-4850-4ee4-a420-c25da111d349"), null, null, false, null, "Roles", null, new Guid("c2a686b5-d665-4cdf-bebd-e9e32e2e3839") },
                    { new Guid("ce694c77-6fa4-4d14-8e01-2a364a1d1260"), true, null, null, null, "Roles", true, new Guid("0b075ca9-bc32-4c1b-894b-d7d47dbdb666") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_InspectionProtocols_RealProperties_InspectedPropertyId",
                table: "InspectionProtocols",
                column: "InspectedPropertyId",
                principalTable: "RealProperties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RealProperties_Buildings_BuildingId",
                table: "RealProperties",
                column: "BuildingId",
                principalTable: "Buildings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RealProperties_PropertyAddresses_PropertyAddressId",
                table: "RealProperties",
                column: "PropertyAddressId",
                principalTable: "PropertyAddresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InspectionProtocols_RealProperties_InspectedPropertyId",
                table: "InspectionProtocols");

            migrationBuilder.DropForeignKey(
                name: "FK_RealProperties_Buildings_BuildingId",
                table: "RealProperties");

            migrationBuilder.DropForeignKey(
                name: "FK_RealProperties_PropertyAddresses_PropertyAddressId",
                table: "RealProperties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RealProperties",
                table: "RealProperties");

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("251193e8-67a5-41d5-a1d9-33765fcbc49f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2e6118f3-c3e8-4cd4-9e84-7861d0d754f6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2efd0f59-8e9c-4a34-98ff-c16a99991225"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("310c5e93-708b-4b26-ba6a-181d149d0eab"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3b112c6a-8090-41cf-99b2-85c79c147a19"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4df55c7f-4850-4ee4-a420-c25da111d349"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("55562324-94b5-478d-a243-58f851268a77"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5e4d4010-ed2b-4fc9-838c-f7c8bebf1849"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6076dddc-08d1-40e0-b99a-e1a7103cdcdd"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("68e6bc65-525f-4cdf-ba82-64e678623c27"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("69224362-f329-40a4-8920-bb5c018c1b30"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ce694c77-6fa4-4d14-8e01-2a364a1d1260"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e20348fc-e9fc-499b-8b1d-a9f5dccb3a94"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("53551129-a676-4cfd-bd0d-7702a2ac6a5d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6f9a2657-8c0c-41b9-98dd-acc3fc3da05c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("77d44802-d736-40c5-a50a-d20a5d08e3e6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("672e3f48-b833-4b0d-8b18-c5cb8a7c04df"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c4c7bf1e-db2c-4b8c-8d11-32f226ef6c7f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0b075ca9-bc32-4c1b-894b-d7d47dbdb666"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c2a686b5-d665-4cdf-bebd-e9e32e2e3839"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("102cea50-d49a-4003-94f1-54a76a42d1bc"));

            migrationBuilder.RenameTable(
                name: "RealProperties",
                newName: "Properties");

            migrationBuilder.RenameIndex(
                name: "IX_RealProperties_PropertyAddressId",
                table: "Properties",
                newName: "IX_Properties_PropertyAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_RealProperties_BuildingId",
                table: "Properties",
                newName: "IX_Properties_BuildingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Properties",
                table: "Properties",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("31275f60-0769-462d-9ed0-582b9e20a46b"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("5a6c522c-c45f-4489-8fea-1fcd0a3b5a2d"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("c0352709-5bf9-4a6a-9238-85e08e764b63"), "Szef" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("07f8d326-fc4a-423f-adaf-a14cf533079e"), true, true, true, new Guid("c0352709-5bf9-4a6a-9238-85e08e764b63"), "Roles", true, null },
                    { new Guid("0d6972dd-6b9b-4b7c-903b-1ff0e457b425"), false, false, false, new Guid("31275f60-0769-462d-9ed0-582b9e20a46b"), "Permissions", false, null },
                    { new Guid("19352bdc-d362-49c4-9db5-a64ecf7a9f21"), false, false, true, new Guid("31275f60-0769-462d-9ed0-582b9e20a46b"), "Users", false, null },
                    { new Guid("428287e2-dc24-4da0-91b0-4f0661fa3b44"), true, true, true, new Guid("c0352709-5bf9-4a6a-9238-85e08e764b63"), "Permissions", true, null },
                    { new Guid("503bf17c-46eb-4b87-8c90-9949d2100c2e"), false, false, true, new Guid("31275f60-0769-462d-9ed0-582b9e20a46b"), "Roles", false, null },
                    { new Guid("66ff4c6a-3d77-4104-b9dd-0666e2707d25"), true, true, true, new Guid("c0352709-5bf9-4a6a-9238-85e08e764b63"), "Users", true, null },
                    { new Guid("6f186ede-972b-491b-9f0c-a1d2b8237746"), true, true, true, new Guid("5a6c522c-c45f-4489-8fea-1fcd0a3b5a2d"), "Permissions", true, null },
                    { new Guid("9b9621f2-370b-4b0c-bf93-e5a6c642a3ee"), true, true, true, new Guid("5a6c522c-c45f-4489-8fea-1fcd0a3b5a2d"), "Roles", true, null },
                    { new Guid("b29130c0-da55-4baa-9042-c4c19ba726f2"), true, true, true, new Guid("5a6c522c-c45f-4489-8fea-1fcd0a3b5a2d"), "Users", true, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("16013e76-428a-4c19-99b5-0434801d71f4"), "", "admin", "", "admin", "admin", "", new Guid("5a6c522c-c45f-4489-8fea-1fcd0a3b5a2d") },
                    { new Guid("66a2806f-a3fd-4618-bf13-51e2cb4d0835"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "", "+48 312645978", new Guid("31275f60-0769-462d-9ed0-582b9e20a46b") },
                    { new Guid("8b776488-324c-4755-b368-505f06d461fd"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "", "+48 321 654 987", new Guid("31275f60-0769-462d-9ed0-582b9e20a46b") },
                    { new Guid("9d5515bd-4843-4bbc-98b4-cf1982b48e1b"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "", "987654321", new Guid("31275f60-0769-462d-9ed0-582b9e20a46b") },
                    { new Guid("a83ea4f0-dfda-46ea-8a2b-b49877c2e675"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "k.tumiel", "", "123 456 789", new Guid("c0352709-5bf9-4a6a-9238-85e08e764b63") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("35c3865b-ab12-430e-a1d8-effdda8b66ea"), null, null, false, null, "Roles", null, new Guid("9d5515bd-4843-4bbc-98b4-cf1982b48e1b") },
                    { new Guid("4d9bc78f-3e03-4202-929a-6b3e12fd36c0"), true, true, null, null, "Users", true, new Guid("66a2806f-a3fd-4618-bf13-51e2cb4d0835") },
                    { new Guid("97a15e2f-5d51-4174-8321-13f0417cf7f6"), true, null, null, null, "Roles", true, new Guid("66a2806f-a3fd-4618-bf13-51e2cb4d0835") },
                    { new Guid("e70a1383-6b2d-426a-96f5-1d801494bd70"), null, null, false, null, "Users", null, new Guid("9d5515bd-4843-4bbc-98b4-cf1982b48e1b") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_InspectionProtocols_Properties_InspectedPropertyId",
                table: "InspectionProtocols",
                column: "InspectedPropertyId",
                principalTable: "Properties",
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
    }
}
