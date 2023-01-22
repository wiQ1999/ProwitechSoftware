using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class userspasswordseedchange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("b93e2927-47d6-42c0-bf95-3a587b0e680c"), "Szef" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("c77232f3-7681-410d-8916-bcbf5250b833"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("fc433f74-7b14-4eb6-929f-15ea9f1ae786"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("156854ed-8cb3-4b5e-9236-1f10689d607b"), true, true, true, new Guid("b93e2927-47d6-42c0-bf95-3a587b0e680c"), "Permissions", true, null },
                    { new Guid("1bbbee29-8032-4cb0-95d8-523ea85c0d65"), true, true, true, new Guid("fc433f74-7b14-4eb6-929f-15ea9f1ae786"), "Permissions", true, null },
                    { new Guid("3842107c-ff76-4901-9884-0269c2bde4a8"), false, false, true, new Guid("c77232f3-7681-410d-8916-bcbf5250b833"), "Users", false, null },
                    { new Guid("59c85e18-91a0-4133-82be-5c8bed77d631"), false, false, false, new Guid("c77232f3-7681-410d-8916-bcbf5250b833"), "Permissions", false, null },
                    { new Guid("909a023f-4e71-4ec7-a667-f91a90b63c6a"), true, true, true, new Guid("b93e2927-47d6-42c0-bf95-3a587b0e680c"), "Roles", true, null },
                    { new Guid("be103e5a-4e5d-43c1-88d6-65fb8766e2ea"), false, false, true, new Guid("c77232f3-7681-410d-8916-bcbf5250b833"), "Roles", false, null },
                    { new Guid("cea5481a-523c-4bda-b6ff-4d04aa4be369"), true, true, true, new Guid("b93e2927-47d6-42c0-bf95-3a587b0e680c"), "Users", true, null },
                    { new Guid("d46f3e57-d352-4dff-bbf5-fa0187605bb1"), true, true, true, new Guid("fc433f74-7b14-4eb6-929f-15ea9f1ae786"), "Roles", true, null },
                    { new Guid("ff58a69b-fec5-4d40-a80b-8772c88f6837"), true, true, true, new Guid("fc433f74-7b14-4eb6-929f-15ea9f1ae786"), "Users", true, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("18aaf8d7-2b5a-4fe5-b14c-01f9cb29f0b9"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "AQAAAAIAAYagAAAAECOxSYhPtAPPNmdjnlVkLjvIXdqGujn7o2LRM2/d8Ayj9chrHOH9qe6G+o+P/9QwfQ==", "+48 312645978", new Guid("c77232f3-7681-410d-8916-bcbf5250b833") },
                    { new Guid("5050b5e1-9480-4bda-8250-3a60f2e75e78"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "AQAAAAIAAYagAAAAEODdVktzfP6To5AkFRNswjElhlcZzAq5j3EuDYtMbdk2Rv6/O5H3jHqsI0ZUnwWYWQ==", "+48 321 654 987", new Guid("c77232f3-7681-410d-8916-bcbf5250b833") },
                    { new Guid("a16e60d8-5e64-4c24-8d98-0c010431deac"), "", "admin", "", "admin", "AQAAAAIAAYagAAAAEEjDNYOizs2XqIILQxXvyluJs4nVo2vybTETSGjSO/S0nPXoDPbuDuSAlsUitDUNEA==", "", new Guid("fc433f74-7b14-4eb6-929f-15ea9f1ae786") },
                    { new Guid("afcae8be-7d40-47ec-b0e6-a12f9391b474"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "AQAAAAIAAYagAAAAEAabiO2crPNKtykkocch8mRrvtZGkCjRqDbNXBUMHlqkxHzLPpGkEzt8GI06aXaMiA==", "987654321", new Guid("c77232f3-7681-410d-8916-bcbf5250b833") },
                    { new Guid("ee499277-8a67-45c8-9b67-3465bc94c3bb"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "boss", "AQAAAAIAAYagAAAAEOLYItq3N8NHPyo/HHygC3E7k8e3otc8IvSYFmuO73BskrF5cHgEZKzhQwVynVCNww==", "123 456 789", new Guid("b93e2927-47d6-42c0-bf95-3a587b0e680c") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("0a6d0ab6-54cb-471c-b4f1-02c41004abf0"), null, null, false, null, "Users", null, new Guid("afcae8be-7d40-47ec-b0e6-a12f9391b474") },
                    { new Guid("10da4589-9144-47bd-8d85-29902a0ea7bf"), true, true, null, null, "Users", true, new Guid("18aaf8d7-2b5a-4fe5-b14c-01f9cb29f0b9") },
                    { new Guid("49f9632e-e526-4e07-ad20-e8d32e18bc9a"), true, null, null, null, "Roles", true, new Guid("18aaf8d7-2b5a-4fe5-b14c-01f9cb29f0b9") },
                    { new Guid("9bc215f2-525b-49b7-aa69-5672c320af59"), null, null, false, null, "Roles", null, new Guid("afcae8be-7d40-47ec-b0e6-a12f9391b474") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0a6d0ab6-54cb-471c-b4f1-02c41004abf0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("10da4589-9144-47bd-8d85-29902a0ea7bf"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("156854ed-8cb3-4b5e-9236-1f10689d607b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("1bbbee29-8032-4cb0-95d8-523ea85c0d65"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3842107c-ff76-4901-9884-0269c2bde4a8"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("49f9632e-e526-4e07-ad20-e8d32e18bc9a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("59c85e18-91a0-4133-82be-5c8bed77d631"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("909a023f-4e71-4ec7-a667-f91a90b63c6a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9bc215f2-525b-49b7-aa69-5672c320af59"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("be103e5a-4e5d-43c1-88d6-65fb8766e2ea"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("cea5481a-523c-4bda-b6ff-4d04aa4be369"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d46f3e57-d352-4dff-bbf5-fa0187605bb1"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ff58a69b-fec5-4d40-a80b-8772c88f6837"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5050b5e1-9480-4bda-8250-3a60f2e75e78"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a16e60d8-5e64-4c24-8d98-0c010431deac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ee499277-8a67-45c8-9b67-3465bc94c3bb"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b93e2927-47d6-42c0-bf95-3a587b0e680c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("fc433f74-7b14-4eb6-929f-15ea9f1ae786"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("18aaf8d7-2b5a-4fe5-b14c-01f9cb29f0b9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("afcae8be-7d40-47ec-b0e6-a12f9391b474"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c77232f3-7681-410d-8916-bcbf5250b833"));

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
    }
}
