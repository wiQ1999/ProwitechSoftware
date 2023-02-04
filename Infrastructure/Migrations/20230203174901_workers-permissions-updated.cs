using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class workerspermissionsupdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1a0e6f35-c395-4122-a444-67b7c28fd63b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("34c3762f-8905-416c-9d2f-d000ae3317af"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3dde2c01-3777-4a07-917b-d0caabee973d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("46c4d209-a68d-467f-9d2a-e0e1992a0eb4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("681f04db-628f-4ec4-97d3-007de489c69f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6debf06e-f310-4cdd-8c4d-1985adbdd38c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7da85c2d-cb61-4ce3-ba1f-a199c826a67f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8afbbc04-3b36-4196-a85b-a28352bab172"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("91118a63-2e23-4320-b0df-54b4dfcaf28b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("92d02646-2a08-490b-9598-a974f529400f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a05031f1-5a5f-485b-bac7-1392592a3c0c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a74f7a64-40aa-4f96-a5fa-7125b286cc27"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("afdbf3a1-f259-4f69-9d78-a35a3fe62732"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("bf3bfd43-1bf8-4df5-acef-fe7605686ff1"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c5ce62d7-97d9-4a4f-b2dd-59c26b2ec85b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c729ebda-578c-446c-a843-2e3192ca0abf"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("dd509f9c-a240-447c-b1e6-747aa6fd9ace"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f3aad585-f2a4-42a1-bb69-ae49aff567af"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fc53dd59-0ac6-4d0a-b98b-a54ac0cfec57"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4f08cc14-1181-4343-a6da-41ddb71c8377"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("74cbd864-03b1-44d8-bc5d-36959921297e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f387f845-13bf-4e19-a09d-b43e226ba95b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("674870f0-b39f-43dd-bcd2-b3f2f0bb2452"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("95a14e4e-5a9c-4f59-897a-9ffe8f053672"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c3930eb7-c7aa-4c53-9d3e-863e7173a12a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fffbf755-8169-46f0-8b36-d3666ffed5ff"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f224a458-dcbf-430b-9739-a272db5b8fe4"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("17996ef3-d75d-4660-855c-c2a013041f5e"), "Szef" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("285710e0-b17d-4372-ac0e-ba1c350fa413"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("78de5652-3818-496c-bff3-7d341c7aec1c"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("06f8eee3-2a97-451c-b3eb-3e65a4d42b64"), true, true, true, new Guid("17996ef3-d75d-4660-855c-c2a013041f5e"), "RealProperties", true, null },
                    { new Guid("185b3978-dbbf-47a7-9b5d-b65d0b8b18e1"), true, true, true, new Guid("17996ef3-d75d-4660-855c-c2a013041f5e"), "BuildingAddresses", true, null },
                    { new Guid("358bd333-e751-449d-b724-266d07436edd"), true, true, true, new Guid("78de5652-3818-496c-bff3-7d341c7aec1c"), "Roles", true, null },
                    { new Guid("3dc2cd3d-47d6-4d30-ba43-e754ef7599bc"), true, true, true, new Guid("285710e0-b17d-4372-ac0e-ba1c350fa413"), "PersonalProtocols", true, null },
                    { new Guid("504f890c-cda2-4008-ad49-1097906ec93c"), true, true, true, new Guid("17996ef3-d75d-4660-855c-c2a013041f5e"), "Buildings", true, null },
                    { new Guid("526afc3d-64fa-4727-ab9f-db513f705ae9"), true, true, true, new Guid("17996ef3-d75d-4660-855c-c2a013041f5e"), "AllInspectionProtocols", true, null },
                    { new Guid("7586dc7a-fa97-4725-82f2-e340254a4570"), true, true, true, new Guid("17996ef3-d75d-4660-855c-c2a013041f5e"), "InspectionTasks", true, null },
                    { new Guid("7ab2e5e3-e66d-4226-8b62-23783f75bf60"), true, true, true, new Guid("78de5652-3818-496c-bff3-7d341c7aec1c"), "Users", true, null },
                    { new Guid("9cfb6852-c3f9-4bb0-becd-b1cd7b408cb9"), false, false, true, new Guid("285710e0-b17d-4372-ac0e-ba1c350fa413"), "InspectionTasks", true, null },
                    { new Guid("d1b53e0b-ab4a-4c27-930a-099c2cccc9f5"), true, true, true, new Guid("17996ef3-d75d-4660-855c-c2a013041f5e"), "PropertyManagers", true, null },
                    { new Guid("d76959c5-16a4-4ba5-a649-76b4cd51d32a"), true, true, true, new Guid("17996ef3-d75d-4660-855c-c2a013041f5e"), "PersonalProtocols", true, null },
                    { new Guid("e2af1d75-08d6-48b1-86da-5424f4ea3c1d"), true, true, true, new Guid("17996ef3-d75d-4660-855c-c2a013041f5e"), "Users", true, null },
                    { new Guid("e63d55eb-dafd-44a0-8183-d96e1e6488a2"), true, true, true, new Guid("78de5652-3818-496c-bff3-7d341c7aec1c"), "Permissions", true, null },
                    { new Guid("e7119637-0d5c-4223-94ed-78125da5d4af"), true, true, true, new Guid("17996ef3-d75d-4660-855c-c2a013041f5e"), "Roles", true, null },
                    { new Guid("ed1c3653-1949-4846-9b13-3ee52580b7ba"), true, true, true, new Guid("17996ef3-d75d-4660-855c-c2a013041f5e"), "Permissions", true, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("26f81b8c-23ca-4e8c-a7d5-ff521aa3a7c4"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "AQAAAAIAAYagAAAAEDeFf8Y3TUY7IDvaP04NWdHYm41py2+qMl4Y6zezCiCflcL1JHP1IpOebJWaSBGy7w==", "+48 321 654 987", new Guid("285710e0-b17d-4372-ac0e-ba1c350fa413") },
                    { new Guid("377a3576-01f6-4d0f-b526-809df29c449e"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "boss", "AQAAAAIAAYagAAAAEBwlz9s9MPknlHchQ2XRNUeG3hfhkV3cuXoCprDKsBo9sQbKTLHbcrlGxAjch4lSLQ==", "123 456 789", new Guid("17996ef3-d75d-4660-855c-c2a013041f5e") },
                    { new Guid("386a9595-2d97-4bcf-8d5d-193c97371fb1"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "AQAAAAIAAYagAAAAEP5tKnLwHlO8BC7R1L8IxeQrXutX5E8OoXMUO1iKGMOEZsQ7Znjyeos099HEZEkabA==", "+48 312645978", new Guid("285710e0-b17d-4372-ac0e-ba1c350fa413") },
                    { new Guid("56fbcd8f-7da1-4328-883c-518f83b2ba45"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "AQAAAAIAAYagAAAAEDDjafDyTJo7lZfqRHAtBtFUXzuljt2/qdHnqwQlMwqftoQ4QjN0EFOYpgkp6HZ9/A==", "987654321", new Guid("285710e0-b17d-4372-ac0e-ba1c350fa413") },
                    { new Guid("e4044fcd-09fa-4b71-bc9f-2c8876e3dff8"), "", "admin", "", "admin", "AQAAAAIAAYagAAAAEDljw4sISwsWP8r8gR9SW6Tl4LsyIVsZ/wUOFbRcZpERwtGWB8Z+NeOdvEgZq6zRXQ==", "", new Guid("78de5652-3818-496c-bff3-7d341c7aec1c") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("01fd8d9d-b1de-48c4-b501-25d1b31ea7d8"), false, false, true, null, "InspectionTasks", true, new Guid("386a9595-2d97-4bcf-8d5d-193c97371fb1") },
                    { new Guid("230dad86-8ea9-4492-9ead-62f143cad6c4"), false, false, true, null, "PropertyManagers", false, new Guid("386a9595-2d97-4bcf-8d5d-193c97371fb1") },
                    { new Guid("32ea8334-98cf-4d36-b1af-431f5eb0a2fa"), false, false, true, null, "InspectionTasks", true, new Guid("56fbcd8f-7da1-4328-883c-518f83b2ba45") },
                    { new Guid("3c9f88ac-6087-4cfd-8584-8c3f94d82919"), false, false, true, null, "Buildings", false, new Guid("26f81b8c-23ca-4e8c-a7d5-ff521aa3a7c4") },
                    { new Guid("462afa39-52a8-49d4-8885-a5177561fd45"), false, false, true, null, "RealProperties", false, new Guid("386a9595-2d97-4bcf-8d5d-193c97371fb1") },
                    { new Guid("4dd91f9e-3af6-46f8-83dd-8004dada068b"), false, false, true, null, "RealProperties", false, new Guid("26f81b8c-23ca-4e8c-a7d5-ff521aa3a7c4") },
                    { new Guid("4e9ee777-0456-414f-af33-eec110902b1f"), false, false, true, null, "BuildingAddresses", false, new Guid("26f81b8c-23ca-4e8c-a7d5-ff521aa3a7c4") },
                    { new Guid("5a706e53-9877-44e1-b626-4ec36ce6d398"), false, false, true, null, "PropertyManagers", false, new Guid("26f81b8c-23ca-4e8c-a7d5-ff521aa3a7c4") },
                    { new Guid("5adc9a5f-09da-4187-8e92-8232ad7daef3"), false, false, true, null, "Buildings", false, new Guid("386a9595-2d97-4bcf-8d5d-193c97371fb1") },
                    { new Guid("7545d1ce-4aae-4dc4-ac50-a70ad13bf401"), false, false, true, null, "BuildingAddresses", false, new Guid("56fbcd8f-7da1-4328-883c-518f83b2ba45") },
                    { new Guid("8c1e85ca-62dd-4545-8473-8618664ead08"), false, false, true, null, "Users", false, new Guid("56fbcd8f-7da1-4328-883c-518f83b2ba45") },
                    { new Guid("b79cad47-a245-4665-b649-245561dacc1e"), false, false, true, null, "RealProperties", false, new Guid("56fbcd8f-7da1-4328-883c-518f83b2ba45") },
                    { new Guid("b83526a9-65be-4003-891a-b5d9a11ccdd4"), true, true, true, null, "PersonalProtocols", true, new Guid("386a9595-2d97-4bcf-8d5d-193c97371fb1") },
                    { new Guid("c1dd4c6c-d94a-4a08-9a71-59a1eac32a67"), false, false, true, null, "PropertyManagers", false, new Guid("56fbcd8f-7da1-4328-883c-518f83b2ba45") },
                    { new Guid("c8d639b0-c81d-4d63-bf38-12006ee69017"), false, false, true, null, "Users", false, new Guid("26f81b8c-23ca-4e8c-a7d5-ff521aa3a7c4") },
                    { new Guid("cc9e682b-71e0-417e-ae4c-c5fb449543d6"), false, false, true, null, "Users", false, new Guid("386a9595-2d97-4bcf-8d5d-193c97371fb1") },
                    { new Guid("d4a276d5-3666-4d8b-b32c-fd2f10f41a50"), false, false, true, null, "Buildings", false, new Guid("56fbcd8f-7da1-4328-883c-518f83b2ba45") },
                    { new Guid("e7d05963-2e80-48ef-894d-101852b1d83b"), false, false, true, null, "BuildingAddresses", false, new Guid("386a9595-2d97-4bcf-8d5d-193c97371fb1") },
                    { new Guid("e91e7d66-3836-4fb6-9fb5-23a486e6dc2d"), true, true, true, null, "PersonalProtocols", true, new Guid("56fbcd8f-7da1-4328-883c-518f83b2ba45") },
                    { new Guid("f083276b-8e32-4a81-9ae0-1170d5410058"), true, true, true, null, "PersonalProtocols", true, new Guid("26f81b8c-23ca-4e8c-a7d5-ff521aa3a7c4") },
                    { new Guid("f6957675-5bc7-4285-9dd0-c9967f6626dd"), false, false, true, null, "InspectionTasks", true, new Guid("26f81b8c-23ca-4e8c-a7d5-ff521aa3a7c4") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("01fd8d9d-b1de-48c4-b501-25d1b31ea7d8"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("06f8eee3-2a97-451c-b3eb-3e65a4d42b64"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("185b3978-dbbf-47a7-9b5d-b65d0b8b18e1"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("230dad86-8ea9-4492-9ead-62f143cad6c4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("32ea8334-98cf-4d36-b1af-431f5eb0a2fa"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("358bd333-e751-449d-b724-266d07436edd"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3c9f88ac-6087-4cfd-8584-8c3f94d82919"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3dc2cd3d-47d6-4d30-ba43-e754ef7599bc"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("462afa39-52a8-49d4-8885-a5177561fd45"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4dd91f9e-3af6-46f8-83dd-8004dada068b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4e9ee777-0456-414f-af33-eec110902b1f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("504f890c-cda2-4008-ad49-1097906ec93c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("526afc3d-64fa-4727-ab9f-db513f705ae9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5a706e53-9877-44e1-b626-4ec36ce6d398"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5adc9a5f-09da-4187-8e92-8232ad7daef3"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7545d1ce-4aae-4dc4-ac50-a70ad13bf401"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7586dc7a-fa97-4725-82f2-e340254a4570"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7ab2e5e3-e66d-4226-8b62-23783f75bf60"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8c1e85ca-62dd-4545-8473-8618664ead08"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9cfb6852-c3f9-4bb0-becd-b1cd7b408cb9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b79cad47-a245-4665-b649-245561dacc1e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b83526a9-65be-4003-891a-b5d9a11ccdd4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c1dd4c6c-d94a-4a08-9a71-59a1eac32a67"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c8d639b0-c81d-4d63-bf38-12006ee69017"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("cc9e682b-71e0-417e-ae4c-c5fb449543d6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d1b53e0b-ab4a-4c27-930a-099c2cccc9f5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d4a276d5-3666-4d8b-b32c-fd2f10f41a50"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d76959c5-16a4-4ba5-a649-76b4cd51d32a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e2af1d75-08d6-48b1-86da-5424f4ea3c1d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e63d55eb-dafd-44a0-8183-d96e1e6488a2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e7119637-0d5c-4223-94ed-78125da5d4af"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e7d05963-2e80-48ef-894d-101852b1d83b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e91e7d66-3836-4fb6-9fb5-23a486e6dc2d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ed1c3653-1949-4846-9b13-3ee52580b7ba"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f083276b-8e32-4a81-9ae0-1170d5410058"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f6957675-5bc7-4285-9dd0-c9967f6626dd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("377a3576-01f6-4d0f-b526-809df29c449e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e4044fcd-09fa-4b71-bc9f-2c8876e3dff8"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("17996ef3-d75d-4660-855c-c2a013041f5e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("78de5652-3818-496c-bff3-7d341c7aec1c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("26f81b8c-23ca-4e8c-a7d5-ff521aa3a7c4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("386a9595-2d97-4bcf-8d5d-193c97371fb1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("56fbcd8f-7da1-4328-883c-518f83b2ba45"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("285710e0-b17d-4372-ac0e-ba1c350fa413"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("674870f0-b39f-43dd-bcd2-b3f2f0bb2452"), "Szef" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("95a14e4e-5a9c-4f59-897a-9ffe8f053672"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("f224a458-dcbf-430b-9739-a272db5b8fe4"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("1a0e6f35-c395-4122-a444-67b7c28fd63b"), true, true, true, new Guid("674870f0-b39f-43dd-bcd2-b3f2f0bb2452"), "RealProperties", true, null },
                    { new Guid("34c3762f-8905-416c-9d2f-d000ae3317af"), true, true, true, new Guid("674870f0-b39f-43dd-bcd2-b3f2f0bb2452"), "BuildingAddresses", true, null },
                    { new Guid("3dde2c01-3777-4a07-917b-d0caabee973d"), true, true, true, new Guid("674870f0-b39f-43dd-bcd2-b3f2f0bb2452"), "InspectionTasks", true, null },
                    { new Guid("46c4d209-a68d-467f-9d2a-e0e1992a0eb4"), true, true, true, new Guid("95a14e4e-5a9c-4f59-897a-9ffe8f053672"), "Permissions", true, null },
                    { new Guid("681f04db-628f-4ec4-97d3-007de489c69f"), true, true, true, new Guid("674870f0-b39f-43dd-bcd2-b3f2f0bb2452"), "AllInspectionProtocols", true, null },
                    { new Guid("6debf06e-f310-4cdd-8c4d-1985adbdd38c"), true, true, true, new Guid("674870f0-b39f-43dd-bcd2-b3f2f0bb2452"), "Users", true, null },
                    { new Guid("7da85c2d-cb61-4ce3-ba1f-a199c826a67f"), true, true, true, new Guid("95a14e4e-5a9c-4f59-897a-9ffe8f053672"), "Users", true, null },
                    { new Guid("8afbbc04-3b36-4196-a85b-a28352bab172"), true, true, true, new Guid("95a14e4e-5a9c-4f59-897a-9ffe8f053672"), "Roles", true, null },
                    { new Guid("91118a63-2e23-4320-b0df-54b4dfcaf28b"), true, true, true, new Guid("674870f0-b39f-43dd-bcd2-b3f2f0bb2452"), "PersonalProtocols", true, null },
                    { new Guid("a74f7a64-40aa-4f96-a5fa-7125b286cc27"), true, true, true, new Guid("674870f0-b39f-43dd-bcd2-b3f2f0bb2452"), "Permissions", true, null },
                    { new Guid("afdbf3a1-f259-4f69-9d78-a35a3fe62732"), true, true, true, new Guid("674870f0-b39f-43dd-bcd2-b3f2f0bb2452"), "Buildings", true, null },
                    { new Guid("c5ce62d7-97d9-4a4f-b2dd-59c26b2ec85b"), true, true, true, new Guid("f224a458-dcbf-430b-9739-a272db5b8fe4"), "PersonalProtocols", true, null },
                    { new Guid("c729ebda-578c-446c-a843-2e3192ca0abf"), true, true, true, new Guid("674870f0-b39f-43dd-bcd2-b3f2f0bb2452"), "Roles", true, null },
                    { new Guid("dd509f9c-a240-447c-b1e6-747aa6fd9ace"), true, true, true, new Guid("674870f0-b39f-43dd-bcd2-b3f2f0bb2452"), "PropertyManagers", true, null },
                    { new Guid("f3aad585-f2a4-42a1-bb69-ae49aff567af"), false, false, true, new Guid("f224a458-dcbf-430b-9739-a272db5b8fe4"), "InspectionTasks", true, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("4f08cc14-1181-4343-a6da-41ddb71c8377"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "boss", "AQAAAAIAAYagAAAAEJg0oWoNU5jc8XhnSYJOT4pmwz3kf6+1zl4hyFeh5NZhQScOWwSdTGKjXtCf7xPfMQ==", "123 456 789", new Guid("674870f0-b39f-43dd-bcd2-b3f2f0bb2452") },
                    { new Guid("74cbd864-03b1-44d8-bc5d-36959921297e"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "AQAAAAIAAYagAAAAEFwRGPUK+BjglP2KAcx5nFqHyzmnovpq08BBDs2JAOk1NSaDZedZaIFvz0v6YYycVg==", "+48 321 654 987", new Guid("f224a458-dcbf-430b-9739-a272db5b8fe4") },
                    { new Guid("c3930eb7-c7aa-4c53-9d3e-863e7173a12a"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "AQAAAAIAAYagAAAAEH4DH2BIBpwuODJcrhDiy6K8WXalowYQOjufWFy30CQ9NpxMAG37Br9Jskwv0sg2uQ==", "+48 312645978", new Guid("f224a458-dcbf-430b-9739-a272db5b8fe4") },
                    { new Guid("f387f845-13bf-4e19-a09d-b43e226ba95b"), "", "admin", "", "admin", "AQAAAAIAAYagAAAAEGOIc8FoEVTKWKHhXnijhzbk7FlRMCTwVFfp9coaSaRUX33xXHANIAMZShCAgTxqGw==", "", new Guid("95a14e4e-5a9c-4f59-897a-9ffe8f053672") },
                    { new Guid("fffbf755-8169-46f0-8b36-d3666ffed5ff"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "AQAAAAIAAYagAAAAEF0bjbyA6qg1V/F68F56dA6FE5aVlkSdjB0gAPHjzisGECT1pWB0LXPtFQyCqey8dg==", "987654321", new Guid("f224a458-dcbf-430b-9739-a272db5b8fe4") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("92d02646-2a08-490b-9598-a974f529400f"), true, true, true, null, "PersonalProtocols", true, new Guid("fffbf755-8169-46f0-8b36-d3666ffed5ff") },
                    { new Guid("a05031f1-5a5f-485b-bac7-1392592a3c0c"), false, false, true, null, "InspectionTasks", true, new Guid("c3930eb7-c7aa-4c53-9d3e-863e7173a12a") },
                    { new Guid("bf3bfd43-1bf8-4df5-acef-fe7605686ff1"), true, true, true, null, "PersonalProtocols", true, new Guid("c3930eb7-c7aa-4c53-9d3e-863e7173a12a") },
                    { new Guid("fc53dd59-0ac6-4d0a-b98b-a54ac0cfec57"), false, false, true, null, "InspectionTasks", true, new Guid("fffbf755-8169-46f0-8b36-d3666ffed5ff") }
                });
        }
    }
}
