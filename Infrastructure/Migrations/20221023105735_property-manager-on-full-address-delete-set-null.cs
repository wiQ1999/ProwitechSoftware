using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class propertymanageronfulladdressdeletesetnull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyManagers_FullAddresses_FullAddressId",
                table: "PropertyManagers");

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1b9ba2b8-4531-480d-9efe-26c7082b48f9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1fded999-67f0-4177-8085-35aef6c42c39"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2eb73469-fc14-4465-930d-b6c568916183"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("497d9b8d-8903-4e8d-8f22-27dc7e4b80d7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6ecac474-1cfd-4989-9d6b-9a8be0df3ae8"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("706ecfc7-84c2-4bdf-b75f-1837dc50f672"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("776a517c-70bb-450d-8ec9-5f60a2981f4f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7ad1aabb-9db4-4abc-9928-b8906e60418f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9ce60928-c46e-4f0b-b0d5-bdd14bf2dca7"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9d34aa7e-af09-430d-a88a-4f4b9e32c3b9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fd6b994c-8ff7-4756-9a02-ad1282e1ecb2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11ef09d1-aa9b-47c1-b5f1-61281e3945d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1be0a5aa-4acf-41ed-b9ad-a59465d3666c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e45f1049-effb-4409-8602-d468de61df53"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ed9b5bce-e82a-4307-bf61-adcc15055496"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0cb17b9c-bf1f-49c8-ab4c-584761d53c67"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("4265f5b7-c74e-43e0-8ec3-998ebd010a9e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f32717b6-ae57-41b7-950b-0845291a1600"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0657f743-44ea-465a-b6ce-fe02f9fbcce9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c28ab15f-92d8-4ed1-a0a7-7910e8a65211"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("51e271c3-017c-41a3-a8b0-df738292f739"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("39f60509-938b-456b-ba97-42de725d7f5f"), "Szef" },
                    { new Guid("3bc258d8-7757-4b5a-8cf4-310bde3ee014"), "Pracownik" },
                    { new Guid("9c4ea6ed-536d-438a-89d0-b4cc34fc8890"), "Administrator" },
                    { new Guid("dee9b56e-f750-4083-9803-797a7484d968"), "Praktykant" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("0c5dfa11-b44b-4213-9bee-bb21dceb515a"), true, true, "Role", true, new Guid("9c4ea6ed-536d-438a-89d0-b4cc34fc8890"), true, null },
                    { new Guid("5a8eb5ab-8de2-4717-b73b-2a939f52c47a"), true, true, "Role", true, new Guid("39f60509-938b-456b-ba97-42de725d7f5f"), true, null },
                    { new Guid("647332b5-d48b-4f9a-831a-09e14b29b46d"), true, true, "Użytkownicy", true, new Guid("9c4ea6ed-536d-438a-89d0-b4cc34fc8890"), true, null },
                    { new Guid("8d47d0ad-e7ba-43c1-bd66-61694c910aa0"), false, false, "Użytkownicy", false, new Guid("dee9b56e-f750-4083-9803-797a7484d968"), false, null },
                    { new Guid("9ce17fb3-f4ce-431c-ab7c-73c817aafdff"), false, false, "Role", false, new Guid("dee9b56e-f750-4083-9803-797a7484d968"), false, null },
                    { new Guid("aa21f059-ca7e-4f4a-b63f-34681307f10e"), false, false, "Użytkownicy", false, new Guid("3bc258d8-7757-4b5a-8cf4-310bde3ee014"), false, null },
                    { new Guid("d209c7ed-83ef-4108-9162-d2d36803eda8"), true, true, "Użytkownicy", true, new Guid("39f60509-938b-456b-ba97-42de725d7f5f"), true, null },
                    { new Guid("ee77d507-3f87-41a8-96d2-5f8051b9427f"), false, false, "Role", false, new Guid("3bc258d8-7757-4b5a-8cf4-310bde3ee014"), false, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("0e0c73a6-d936-4b6f-abb9-10e45b2c39df"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "", "+48 321 654 987", new Guid("3bc258d8-7757-4b5a-8cf4-310bde3ee014") },
                    { new Guid("1409b4f5-2271-40ca-bb12-3cac65631c87"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "", "+48 312645978", new Guid("3bc258d8-7757-4b5a-8cf4-310bde3ee014") },
                    { new Guid("44a8b70e-a33c-4781-9483-5050b41be7f3"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "", "987654321", new Guid("3bc258d8-7757-4b5a-8cf4-310bde3ee014") },
                    { new Guid("5be3b827-bc59-4ea6-96d4-3a0a7f7454fe"), "", "admin", "", "admin", "admin", "", new Guid("9c4ea6ed-536d-438a-89d0-b4cc34fc8890") },
                    { new Guid("726fb755-5552-46bd-b011-e84adcb1d640"), "b.smyk@gmail.com", "Bartosz", "Smyk", "a1", "", "213-546-879", new Guid("dee9b56e-f750-4083-9803-797a7484d968") },
                    { new Guid("fa2e26f7-83ad-4ce2-9254-57e8d72e2e89"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "k.tumiel", "", "123 456 789", new Guid("39f60509-938b-456b-ba97-42de725d7f5f") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[] { new Guid("5a766df3-f9a3-4179-8c2e-56dac6dcb475"), null, null, "Użytkownicy", true, null, true, new Guid("1409b4f5-2271-40ca-bb12-3cac65631c87") });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[] { new Guid("87152692-cd3c-4ec4-b533-036a487cb61a"), null, null, "Role", true, null, null, new Guid("44a8b70e-a33c-4781-9483-5050b41be7f3") });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Name", "Read", "RoleId", "Update", "UserId" },
                values: new object[] { new Guid("be7c3d11-29ce-41d0-adb9-2de9cf152944"), null, null, "Użytkownicy", true, null, null, new Guid("44a8b70e-a33c-4781-9483-5050b41be7f3") });

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyManagers_FullAddresses_FullAddressId",
                table: "PropertyManagers",
                column: "FullAddressId",
                principalTable: "FullAddresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyManagers_FullAddresses_FullAddressId",
                table: "PropertyManagers");

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0c5dfa11-b44b-4213-9bee-bb21dceb515a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5a766df3-f9a3-4179-8c2e-56dac6dcb475"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5a8eb5ab-8de2-4717-b73b-2a939f52c47a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("647332b5-d48b-4f9a-831a-09e14b29b46d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("87152692-cd3c-4ec4-b533-036a487cb61a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8d47d0ad-e7ba-43c1-bd66-61694c910aa0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9ce17fb3-f4ce-431c-ab7c-73c817aafdff"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("aa21f059-ca7e-4f4a-b63f-34681307f10e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("be7c3d11-29ce-41d0-adb9-2de9cf152944"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d209c7ed-83ef-4108-9162-d2d36803eda8"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ee77d507-3f87-41a8-96d2-5f8051b9427f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0e0c73a6-d936-4b6f-abb9-10e45b2c39df"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5be3b827-bc59-4ea6-96d4-3a0a7f7454fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("726fb755-5552-46bd-b011-e84adcb1d640"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa2e26f7-83ad-4ce2-9254-57e8d72e2e89"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("39f60509-938b-456b-ba97-42de725d7f5f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9c4ea6ed-536d-438a-89d0-b4cc34fc8890"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dee9b56e-f750-4083-9803-797a7484d968"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1409b4f5-2271-40ca-bb12-3cac65631c87"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44a8b70e-a33c-4781-9483-5050b41be7f3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3bc258d8-7757-4b5a-8cf4-310bde3ee014"));

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

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyManagers_FullAddresses_FullAddressId",
                table: "PropertyManagers",
                column: "FullAddressId",
                principalTable: "FullAddresses",
                principalColumn: "Id");
        }
    }
}
