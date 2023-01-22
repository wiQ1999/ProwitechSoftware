using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class userpasswordlengthchange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("a9a71591-a2f8-4a7b-afda-5e7fed17d121"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("afb52745-9b0e-40d2-b1b3-830d6e4dac7c"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("b26fd7d6-cfee-49ca-bfce-b16f669a6e8e"), "Szef" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("14b3d37c-4c71-48e3-a097-dcf1a93c187a"), true, true, true, new Guid("b26fd7d6-cfee-49ca-bfce-b16f669a6e8e"), "Roles", true, null },
                    { new Guid("3c0aca4a-322a-4d8a-94d9-11892e6964a7"), false, false, true, new Guid("afb52745-9b0e-40d2-b1b3-830d6e4dac7c"), "Roles", false, null },
                    { new Guid("403ab00d-7ada-471c-80cb-9649d35ff7d3"), true, true, true, new Guid("b26fd7d6-cfee-49ca-bfce-b16f669a6e8e"), "Users", true, null },
                    { new Guid("5fc7a591-3fb8-441d-a529-82ece5ecafe2"), true, true, true, new Guid("a9a71591-a2f8-4a7b-afda-5e7fed17d121"), "Roles", true, null },
                    { new Guid("6ab6d23f-6b4a-4b37-bacd-3088c84174f5"), true, true, true, new Guid("b26fd7d6-cfee-49ca-bfce-b16f669a6e8e"), "Permissions", true, null },
                    { new Guid("7ef1e75b-e931-477d-aa62-6b1e0c0ec09c"), false, false, false, new Guid("afb52745-9b0e-40d2-b1b3-830d6e4dac7c"), "Permissions", false, null },
                    { new Guid("89dfb983-5d0b-4a3a-9959-6bd9195f5c59"), false, false, true, new Guid("afb52745-9b0e-40d2-b1b3-830d6e4dac7c"), "Users", false, null },
                    { new Guid("8c65d9e6-02db-4aca-8759-ddde3783aae5"), true, true, true, new Guid("a9a71591-a2f8-4a7b-afda-5e7fed17d121"), "Users", true, null },
                    { new Guid("8d9a800c-ad03-4ff5-9f77-9c3b9a0a5e8c"), true, true, true, new Guid("a9a71591-a2f8-4a7b-afda-5e7fed17d121"), "Permissions", true, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("12bf46b3-18d2-4696-bf71-bedcd379c355"), "", "admin", "", "admin", "admin", "", new Guid("a9a71591-a2f8-4a7b-afda-5e7fed17d121") },
                    { new Guid("44ae24ce-581b-4501-8cbe-36b45a0d9b09"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "", "+48 321 654 987", new Guid("afb52745-9b0e-40d2-b1b3-830d6e4dac7c") },
                    { new Guid("9d9d793d-71d0-4d28-a740-b0e49799a8c2"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "k.tumiel", "", "123 456 789", new Guid("b26fd7d6-cfee-49ca-bfce-b16f669a6e8e") },
                    { new Guid("d38a07a1-3093-4817-8d35-4fc1c7313e53"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "", "987654321", new Guid("afb52745-9b0e-40d2-b1b3-830d6e4dac7c") },
                    { new Guid("fdb5a6f8-4077-475e-9205-cb499b379522"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "", "+48 312645978", new Guid("afb52745-9b0e-40d2-b1b3-830d6e4dac7c") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("9f0d6f74-7f72-47df-a906-0732134a585b"), true, true, null, null, "Users", true, new Guid("fdb5a6f8-4077-475e-9205-cb499b379522") },
                    { new Guid("afd1c69c-111d-4885-bd37-227447608c84"), true, null, null, null, "Roles", true, new Guid("fdb5a6f8-4077-475e-9205-cb499b379522") },
                    { new Guid("f2613ce9-c51e-46ad-bd22-817c8ff562f5"), null, null, false, null, "Users", null, new Guid("d38a07a1-3093-4817-8d35-4fc1c7313e53") },
                    { new Guid("fd57779f-51b0-4575-98f0-19c1ca87024b"), null, null, false, null, "Roles", null, new Guid("d38a07a1-3093-4817-8d35-4fc1c7313e53") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("14b3d37c-4c71-48e3-a097-dcf1a93c187a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3c0aca4a-322a-4d8a-94d9-11892e6964a7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("403ab00d-7ada-471c-80cb-9649d35ff7d3"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5fc7a591-3fb8-441d-a529-82ece5ecafe2"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6ab6d23f-6b4a-4b37-bacd-3088c84174f5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7ef1e75b-e931-477d-aa62-6b1e0c0ec09c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("89dfb983-5d0b-4a3a-9959-6bd9195f5c59"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8c65d9e6-02db-4aca-8759-ddde3783aae5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8d9a800c-ad03-4ff5-9f77-9c3b9a0a5e8c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9f0d6f74-7f72-47df-a906-0732134a585b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("afd1c69c-111d-4885-bd37-227447608c84"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f2613ce9-c51e-46ad-bd22-817c8ff562f5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fd57779f-51b0-4575-98f0-19c1ca87024b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("12bf46b3-18d2-4696-bf71-bedcd379c355"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44ae24ce-581b-4501-8cbe-36b45a0d9b09"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9d9d793d-71d0-4d28-a740-b0e49799a8c2"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a9a71591-a2f8-4a7b-afda-5e7fed17d121"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b26fd7d6-cfee-49ca-bfce-b16f669a6e8e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d38a07a1-3093-4817-8d35-4fc1c7313e53"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fdb5a6f8-4077-475e-9205-cb499b379522"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("afb52745-9b0e-40d2-b1b3-830d6e4dac7c"));

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

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
        }
    }
}
