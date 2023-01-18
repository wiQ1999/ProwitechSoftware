using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class inspectionprotocolinneuwaginullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0121c463-8d68-4642-8d0c-6ef43582ecbe"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3bd24489-0d88-402f-aa0e-09c817453d34"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("429c9b29-d931-4f31-90de-515a8e6d2409"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5d6a288c-d19d-4f65-a329-33bd1633dbbb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("769dc45b-7b8d-4bc8-a14a-f48c3c2377eb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("80c5fef8-8dd4-4075-b928-8ea5f50ab69b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a4eb82d0-0e52-40c3-930f-f53cf8cf6a06"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b5598a5b-bf2d-42e0-8018-c9f4f1dff513"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c56efdc1-39e9-46ac-90a3-7953983f0f05"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c63451fd-43ad-4567-b0ef-247227b743aa"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d2a2de05-4ad6-4bf4-afb7-c136a6faf4a1"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("e56e9de0-4c51-4987-9906-1f17f9a90347"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f45a0704-2d96-4d42-8b9c-2888b77e2471"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0a99d6d7-d83e-4462-8499-5cfb0851ce41"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("21d8200b-2842-4934-8a8a-3f1520cf58e1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("db3c6ee3-c6fc-483a-9aa4-1fdcb95b1b91"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6a65b949-2315-47c9-ad95-346da2d53f12"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dd568b8e-b7da-4f14-955f-c5eac50cc0bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8aaf9a0d-e8e9-487d-a709-f5a1f8071c9d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("912a150c-d0f8-4dbb-8665-1ae96fa1b6f9"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20775d77-1fa9-4203-80bc-27dd8851653f"));

            migrationBuilder.AlterColumn<string>(
                name: "Inne_uwagi",
                table: "InspectionProtocols",
                type: "nvarchar(600)",
                maxLength: 600,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(600)",
                oldMaxLength: 600);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("abcf595e-2378-4215-9299-807716bad115"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("ba219fa8-f1fc-4bb7-8319-86a50ed088ce"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("e33600b1-699e-410e-9661-d962e17325f8"), "Szef" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("4ffa01a0-3e44-4468-924d-1b0d89691153"), true, true, true, new Guid("ba219fa8-f1fc-4bb7-8319-86a50ed088ce"), "Users", true, null },
                    { new Guid("580f179d-e78d-4634-8a92-fe8ed36b25dd"), false, false, false, new Guid("abcf595e-2378-4215-9299-807716bad115"), "Permissions", false, null },
                    { new Guid("90d06d73-f49c-4ca8-adca-016eb8f788fb"), true, true, true, new Guid("e33600b1-699e-410e-9661-d962e17325f8"), "Users", true, null },
                    { new Guid("9c8f5a1d-2d10-4ee6-9735-c898bd91c416"), true, true, true, new Guid("ba219fa8-f1fc-4bb7-8319-86a50ed088ce"), "Permissions", true, null },
                    { new Guid("b3f396eb-191d-4f11-8eaf-9c30b07881cb"), false, false, true, new Guid("abcf595e-2378-4215-9299-807716bad115"), "Users", false, null },
                    { new Guid("c76e8cc3-ff1c-4ee9-aa32-4d4ecb18bb5b"), false, false, true, new Guid("abcf595e-2378-4215-9299-807716bad115"), "Roles", false, null },
                    { new Guid("c95b1cfa-0fb8-4c15-97de-56329f76ffc8"), true, true, true, new Guid("e33600b1-699e-410e-9661-d962e17325f8"), "Permissions", true, null },
                    { new Guid("d803e085-b5de-4692-bb3c-4c78abbaf52b"), true, true, true, new Guid("e33600b1-699e-410e-9661-d962e17325f8"), "Roles", true, null },
                    { new Guid("dc1113fc-e883-414d-a77c-83eb894e3de7"), true, true, true, new Guid("ba219fa8-f1fc-4bb7-8319-86a50ed088ce"), "Roles", true, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("030b7529-173c-41a8-953d-75ba46b7fc21"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "AQAAAAIAAYagAAAAEK7Kb0PcAeO2mQ0L0AoIoAt6jR7tHhdrrJ+LWNYUcX878dwEA6h8FRJFSIOby03FZw==", "+48 312645978", new Guid("abcf595e-2378-4215-9299-807716bad115") },
                    { new Guid("14ca932b-054f-4173-ab10-8956410ae79c"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "AQAAAAIAAYagAAAAENfKgZ9nQkgsmnX2Xa7To9XE5VKjj5wILfZAzDiFdTc1zUaofgDQ9VNRpf2D8OF+gw==", "+48 321 654 987", new Guid("abcf595e-2378-4215-9299-807716bad115") },
                    { new Guid("20ea52be-3fd0-4548-a698-806c22af5b39"), "", "admin", "", "admin", "AQAAAAIAAYagAAAAEESuTM1eV/m1ty2wRtD6HftVhsOkqoSpb6joUyBN5zknmnICtOy0TsGIOppEcO/TXw==", "", new Guid("ba219fa8-f1fc-4bb7-8319-86a50ed088ce") },
                    { new Guid("9af3b628-e119-45bd-b875-05ea98563ecf"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "AQAAAAIAAYagAAAAEIaLX27x4J5ZTxVyfIKIKNES4i4wDjtJBI0Ne8fvbHh0oQ5rSUznQqnWhb93UW6jbQ==", "987654321", new Guid("abcf595e-2378-4215-9299-807716bad115") },
                    { new Guid("db789183-4bd0-4d3c-af40-548ac88fbdeb"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "boss", "AQAAAAIAAYagAAAAEKma5iPJGJK5PpCF+tjUD7Rp9IXs6FdL9fYiMQBmWas0GKzEzEeSToWzJcCWMLBQAQ==", "123 456 789", new Guid("e33600b1-699e-410e-9661-d962e17325f8") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("103f90c5-d696-4093-91e8-3704a37c61ce"), true, null, null, null, "Roles", true, new Guid("030b7529-173c-41a8-953d-75ba46b7fc21") },
                    { new Guid("4346b665-ca09-4cd9-8d4a-aa9067c6f4cd"), null, null, false, null, "Roles", null, new Guid("9af3b628-e119-45bd-b875-05ea98563ecf") },
                    { new Guid("a2d5536b-e127-4c94-a036-81745c63538a"), null, null, false, null, "Users", null, new Guid("9af3b628-e119-45bd-b875-05ea98563ecf") },
                    { new Guid("a4132b1e-f8ce-4700-9e07-6a6652ae9c06"), true, true, null, null, "Users", true, new Guid("030b7529-173c-41a8-953d-75ba46b7fc21") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("103f90c5-d696-4093-91e8-3704a37c61ce"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4346b665-ca09-4cd9-8d4a-aa9067c6f4cd"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4ffa01a0-3e44-4468-924d-1b0d89691153"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("580f179d-e78d-4634-8a92-fe8ed36b25dd"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("90d06d73-f49c-4ca8-adca-016eb8f788fb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9c8f5a1d-2d10-4ee6-9735-c898bd91c416"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a2d5536b-e127-4c94-a036-81745c63538a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a4132b1e-f8ce-4700-9e07-6a6652ae9c06"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b3f396eb-191d-4f11-8eaf-9c30b07881cb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c76e8cc3-ff1c-4ee9-aa32-4d4ecb18bb5b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c95b1cfa-0fb8-4c15-97de-56329f76ffc8"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d803e085-b5de-4692-bb3c-4c78abbaf52b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("dc1113fc-e883-414d-a77c-83eb894e3de7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("14ca932b-054f-4173-ab10-8956410ae79c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("20ea52be-3fd0-4548-a698-806c22af5b39"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("db789183-4bd0-4d3c-af40-548ac88fbdeb"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ba219fa8-f1fc-4bb7-8319-86a50ed088ce"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e33600b1-699e-410e-9661-d962e17325f8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("030b7529-173c-41a8-953d-75ba46b7fc21"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9af3b628-e119-45bd-b875-05ea98563ecf"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("abcf595e-2378-4215-9299-807716bad115"));

            migrationBuilder.AlterColumn<string>(
                name: "Inne_uwagi",
                table: "InspectionProtocols",
                type: "nvarchar(600)",
                maxLength: 600,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(600)",
                oldMaxLength: 600,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("20775d77-1fa9-4203-80bc-27dd8851653f"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("6a65b949-2315-47c9-ad95-346da2d53f12"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("dd568b8e-b7da-4f14-955f-c5eac50cc0bb"), "Szef" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("0121c463-8d68-4642-8d0c-6ef43582ecbe"), true, true, true, new Guid("6a65b949-2315-47c9-ad95-346da2d53f12"), "Roles", true, null },
                    { new Guid("769dc45b-7b8d-4bc8-a14a-f48c3c2377eb"), false, false, false, new Guid("20775d77-1fa9-4203-80bc-27dd8851653f"), "Permissions", false, null },
                    { new Guid("80c5fef8-8dd4-4075-b928-8ea5f50ab69b"), true, true, true, new Guid("dd568b8e-b7da-4f14-955f-c5eac50cc0bb"), "Roles", true, null },
                    { new Guid("a4eb82d0-0e52-40c3-930f-f53cf8cf6a06"), true, true, true, new Guid("6a65b949-2315-47c9-ad95-346da2d53f12"), "Users", true, null },
                    { new Guid("b5598a5b-bf2d-42e0-8018-c9f4f1dff513"), false, false, true, new Guid("20775d77-1fa9-4203-80bc-27dd8851653f"), "Roles", false, null },
                    { new Guid("c63451fd-43ad-4567-b0ef-247227b743aa"), false, false, true, new Guid("20775d77-1fa9-4203-80bc-27dd8851653f"), "Users", false, null },
                    { new Guid("d2a2de05-4ad6-4bf4-afb7-c136a6faf4a1"), true, true, true, new Guid("6a65b949-2315-47c9-ad95-346da2d53f12"), "Permissions", true, null },
                    { new Guid("e56e9de0-4c51-4987-9906-1f17f9a90347"), true, true, true, new Guid("dd568b8e-b7da-4f14-955f-c5eac50cc0bb"), "Permissions", true, null },
                    { new Guid("f45a0704-2d96-4d42-8b9c-2888b77e2471"), true, true, true, new Guid("dd568b8e-b7da-4f14-955f-c5eac50cc0bb"), "Users", true, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("0a99d6d7-d83e-4462-8499-5cfb0851ce41"), "", "admin", "", "admin", "AQAAAAIAAYagAAAAEK0/uJTjFgEVBhCOR7z2fpDJz4PyMHYtv6iIfrD8YNs5NnfHanVjqq6wLy1SJBUDmA==", "", new Guid("6a65b949-2315-47c9-ad95-346da2d53f12") },
                    { new Guid("21d8200b-2842-4934-8a8a-3f1520cf58e1"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "AQAAAAIAAYagAAAAEGYhjSmk2FBayRXsR/z3q4DE4u0cHuQwHUu41wGRllmUOlV+qN/IEVou6i13sv25xQ==", "+48 321 654 987", new Guid("20775d77-1fa9-4203-80bc-27dd8851653f") },
                    { new Guid("8aaf9a0d-e8e9-487d-a709-f5a1f8071c9d"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "AQAAAAIAAYagAAAAEIeDjBTzRBSzN/T6MkjdcHeQhdYHidoJ/sHZiwLVSe3UMubyRLIr3pozyC09q5immQ==", "987654321", new Guid("20775d77-1fa9-4203-80bc-27dd8851653f") },
                    { new Guid("912a150c-d0f8-4dbb-8665-1ae96fa1b6f9"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "AQAAAAIAAYagAAAAEORz6pgWpZR7xP7/TqIw6vDtfmTecLsZH5azAyufkkzNMge+M8YFs9N8kVNtnDOrpA==", "+48 312645978", new Guid("20775d77-1fa9-4203-80bc-27dd8851653f") },
                    { new Guid("db3c6ee3-c6fc-483a-9aa4-1fdcb95b1b91"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "boss", "AQAAAAIAAYagAAAAEL15rbVeeBcG3d8pTfnueiffuqADQhlkJnlEp49zW1Ts5KPEFG00aYKWWqUl4/WdWA==", "123 456 789", new Guid("dd568b8e-b7da-4f14-955f-c5eac50cc0bb") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("3bd24489-0d88-402f-aa0e-09c817453d34"), true, true, null, null, "Users", true, new Guid("912a150c-d0f8-4dbb-8665-1ae96fa1b6f9") },
                    { new Guid("429c9b29-d931-4f31-90de-515a8e6d2409"), null, null, false, null, "Users", null, new Guid("8aaf9a0d-e8e9-487d-a709-f5a1f8071c9d") },
                    { new Guid("5d6a288c-d19d-4f65-a329-33bd1633dbbb"), true, null, null, null, "Roles", true, new Guid("912a150c-d0f8-4dbb-8665-1ae96fa1b6f9") },
                    { new Guid("c56efdc1-39e9-46ac-90a3-7953983f0f05"), null, null, false, null, "Roles", null, new Guid("8aaf9a0d-e8e9-487d-a709-f5a1f8071c9d") }
                });
        }
    }
}
