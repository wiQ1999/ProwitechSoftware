using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class inspectionprotocolnameschangesandresidentnullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("147bb738-9ace-4ad5-b128-3db54cf788f8"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("168f4e76-fb4a-4615-968d-15bb01a8085d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("20dd3bb8-57a3-42ce-a85c-a29db560fd8c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("259bce47-1852-4ee2-99b5-b55e96f63a8c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("38486260-1416-4556-9c6b-ca4edd09dedb"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5cb6572f-152d-447e-94d5-89ac41be89c6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6a879044-9bf1-4edf-a232-ee0487ffcd9e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("87cc1abe-6bd2-45f0-9935-5d2ade5f1d23"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9eec2a4d-a5be-4cb5-8aaf-53917a41ff46"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("a26509d9-1dca-4a68-9e92-0a882398d93b"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c96c2035-2992-491b-b3ac-aacd12ffd671"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("cdf85870-bfd1-43d0-9b5c-5841d318ffb5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fce76b75-014c-414d-8273-a8a880ff002e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6cbab17b-ea1b-485a-b2af-0576d30ecb8f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d26cb31-6901-4f44-8fe1-a37fec361382"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e770e25d-7989-4634-b694-37d71a406b68"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("192a33ef-238b-49d3-be1b-55625a475ba6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7092e2fd-9edc-411c-bf28-5e970180cd89"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44624285-506f-4960-ba63-b0b5e7b0d71e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e063101a-1e50-4ff7-bbbd-3991ab4f9bd4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2b792843-b06e-4bc0-b773-f2724c06a835"));

            migrationBuilder.RenameColumn(
                name: "A35_Inne_uwagi",
                table: "InspectionProtocols",
                newName: "Inne_uwagi");

            migrationBuilder.RenameColumn(
                name: "A34_Propan_butan",
                table: "InspectionProtocols",
                newName: "B_A_34_Propan_butan");

            migrationBuilder.RenameColumn(
                name: "A33_Wyniki_instalacja_wymaga_usuniecia_nieszczelnosci",
                table: "InspectionProtocols",
                newName: "B_A_33_Wyniki_instalacja_wymaga_usuniecia_nieszczelnosci");

            migrationBuilder.RenameColumn(
                name: "A32_Wyniki_stan_szczelnosci",
                table: "InspectionProtocols",
                newName: "M_A_09_Przewody_sposob_prowadzenia");

            migrationBuilder.RenameColumn(
                name: "A31_Wentylacja_nawiew_Zet_w_pomieszczeniu_z_kotlem",
                table: "InspectionProtocols",
                newName: "B_A_31_Wentylacja_nawiew_Zet_w_pomieszczeniu_z_kotlem");

            migrationBuilder.RenameColumn(
                name: "A30_Wentylacja_nawiew_lazienka",
                table: "InspectionProtocols",
                newName: "B_A_30_Wentylacja_nawiew_lazienka");

            migrationBuilder.RenameColumn(
                name: "A29_Wentylacja_nawiew_kuchnia",
                table: "InspectionProtocols",
                newName: "B_A_29_Wentylacja_nawiew_kuchnia");

            migrationBuilder.RenameColumn(
                name: "A28_Wentylacja_inne_pomieszczenia",
                table: "InspectionProtocols",
                newName: "B_A_28_Wentylacja_inne_pomieszczenia");

            migrationBuilder.RenameColumn(
                name: "A27_Wentylacja_lazienka",
                table: "InspectionProtocols",
                newName: "B_A_27_Wentylacja_lazienka");

            migrationBuilder.RenameColumn(
                name: "A26_Wentylacja_kuchnia",
                table: "InspectionProtocols",
                newName: "B_A_26_Wentylacja_kuchnia");

            migrationBuilder.RenameColumn(
                name: "A25_Kubatura_warunku_techniczne",
                table: "InspectionProtocols",
                newName: "M_A_08_Przewody_przebieg");

            migrationBuilder.RenameColumn(
                name: "A24_Prawidlowosc_kociol_co_z_kurkiem_i_rura",
                table: "InspectionProtocols",
                newName: "M_A_07_Przewody_rodzaj");

            migrationBuilder.RenameColumn(
                name: "A23_Prawidlowosc_terma_gazowa_rura_spalinowa",
                table: "InspectionProtocols",
                newName: "A_32_Wyniki_stan_szczelnosci");

            migrationBuilder.RenameColumn(
                name: "A22_Prawidlowosc_terma_gazowa_kurek_odcinajacy",
                table: "InspectionProtocols",
                newName: "A_25_Kubatura_warunku_techniczne");

            migrationBuilder.RenameColumn(
                name: "A21_Prawidlowosc_terma_gazowa_stan",
                table: "InspectionProtocols",
                newName: "A_24_Prawidlowosc_kociol_co_z_kurkiem_i_rura");

            migrationBuilder.RenameColumn(
                name: "A20_Prawidlowosc_gazowy_podgrzewacz_cwu_rura_spalinowa",
                table: "InspectionProtocols",
                newName: "A_23_Prawidlowosc_terma_gazowa_rura_spalinowa");

            migrationBuilder.RenameColumn(
                name: "A19_Prawidlowosc_gazowy_podgrzewacz_cwu_kurek_odcinajacy",
                table: "InspectionProtocols",
                newName: "A_22_Prawidlowosc_terma_gazowa_kurek_odcinajacy");

            migrationBuilder.RenameColumn(
                name: "A18_Prawidlowosc_gazowy_podgrzewacz_cwu_stan",
                table: "InspectionProtocols",
                newName: "A_21_Prawidlowosc_terma_gazowa_stan");

            migrationBuilder.RenameColumn(
                name: "A17_Prawidlowosc_kuchenka_gazowa_odleglosc_od_okna",
                table: "InspectionProtocols",
                newName: "A_20_Prawidlowosc_gazowy_podgrzewacz_cwu_rura_spalinowa");

            migrationBuilder.RenameColumn(
                name: "A16_Prawidlowosc_kuchenka_gazowa_kurek_odcinajacy",
                table: "InspectionProtocols",
                newName: "A_19_Prawidlowosc_gazowy_podgrzewacz_cwu_kurek_odcinajacy");

            migrationBuilder.RenameColumn(
                name: "A15_Prawidlowosc_kuchenka_gazowa_podlaczenie_stan",
                table: "InspectionProtocols",
                newName: "A_18_Prawidlowosc_gazowy_podgrzewacz_cwu_stan");

            migrationBuilder.RenameColumn(
                name: "A14_Prawidlowosc_kuchenka_gazowa_podlaczenie_rodzaj",
                table: "InspectionProtocols",
                newName: "A_17_Prawidlowosc_kuchenka_gazowa_odleglosc_od_okna");

            migrationBuilder.RenameColumn(
                name: "A13_Prawidlowosc_kuchenka_gazowa_stan",
                table: "InspectionProtocols",
                newName: "A_16_Prawidlowosc_kuchenka_gazowa_kurek_odcinajacy");

            migrationBuilder.RenameColumn(
                name: "A12_Prawidlowosc_kuchenka_gazowa_typ",
                table: "InspectionProtocols",
                newName: "A_15_Prawidlowosc_kuchenka_gazowa_podlaczenie_stan");

            migrationBuilder.RenameColumn(
                name: "A11_Przewody_pion_inst_gaz_w_mieszkaniu",
                table: "InspectionProtocols",
                newName: "A_14_Prawidlowosc_kuchenka_gazowa_podlaczenie_rodzaj");

            migrationBuilder.RenameColumn(
                name: "A10_Przewody_przebieg_inst_gaz_przez_pokoje",
                table: "InspectionProtocols",
                newName: "A_13_Prawidlowosc_kuchenka_gazowa_stan");

            migrationBuilder.RenameColumn(
                name: "A09_M_Przewody_sposob_prowadzenia",
                table: "InspectionProtocols",
                newName: "A_12_Prawidlowosc_kuchenka_gazowa_typ");

            migrationBuilder.RenameColumn(
                name: "A08_M_Przewody_przebieg",
                table: "InspectionProtocols",
                newName: "A_11_Przewody_pion_inst_gaz_w_mieszkaniu");

            migrationBuilder.RenameColumn(
                name: "A07_M_Przewody_rodzaj",
                table: "InspectionProtocols",
                newName: "A_10_Przewody_przebieg_inst_gaz_przez_pokoje");

            migrationBuilder.RenameColumn(
                name: "A06_Gazomierz_kurek_przed_gazomierzem",
                table: "InspectionProtocols",
                newName: "A_06_Gazomierz_kurek_przed_gazomierzem");

            migrationBuilder.RenameColumn(
                name: "A05_Gazomierz_usytuowanie_w_stosunku_do_licznika_energii_elektr",
                table: "InspectionProtocols",
                newName: "A_05_Gazomierz_usytuowanie_w_stosunku_do_licznika_energii_elektr");

            migrationBuilder.RenameColumn(
                name: "A04_Gazomierz_usytuowanie_w_stosunku_do_1_go_odbiornika",
                table: "InspectionProtocols",
                newName: "A_04_Gazomierz_usytuowanie_w_stosunku_do_1_go_odbiornika");

            migrationBuilder.RenameColumn(
                name: "A03_B_Gazomierz_szczelnosc",
                table: "InspectionProtocols",
                newName: "B_A_03_Gazomierz_szczelnosc");

            migrationBuilder.RenameColumn(
                name: "A02_B_Gazomierz_szafka_wentylowana",
                table: "InspectionProtocols",
                newName: "B_A_02_Gazomierz_szafka_wentylowana");

            migrationBuilder.RenameColumn(
                name: "A01_Gazomierz_umiejscowienie",
                table: "InspectionProtocols",
                newName: "A_01_Gazomierz_umiejscowienie");

            migrationBuilder.AlterColumn<Guid>(
                name: "ResidentId",
                table: "InspectionProtocols",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "M_A_09_Przewody_sposob_prowadzenia",
                table: "InspectionProtocols",
                newName: "A32_Wyniki_stan_szczelnosci");

            migrationBuilder.RenameColumn(
                name: "M_A_08_Przewody_przebieg",
                table: "InspectionProtocols",
                newName: "A25_Kubatura_warunku_techniczne");

            migrationBuilder.RenameColumn(
                name: "M_A_07_Przewody_rodzaj",
                table: "InspectionProtocols",
                newName: "A24_Prawidlowosc_kociol_co_z_kurkiem_i_rura");

            migrationBuilder.RenameColumn(
                name: "Inne_uwagi",
                table: "InspectionProtocols",
                newName: "A35_Inne_uwagi");

            migrationBuilder.RenameColumn(
                name: "B_A_34_Propan_butan",
                table: "InspectionProtocols",
                newName: "A34_Propan_butan");

            migrationBuilder.RenameColumn(
                name: "B_A_33_Wyniki_instalacja_wymaga_usuniecia_nieszczelnosci",
                table: "InspectionProtocols",
                newName: "A33_Wyniki_instalacja_wymaga_usuniecia_nieszczelnosci");

            migrationBuilder.RenameColumn(
                name: "B_A_31_Wentylacja_nawiew_Zet_w_pomieszczeniu_z_kotlem",
                table: "InspectionProtocols",
                newName: "A31_Wentylacja_nawiew_Zet_w_pomieszczeniu_z_kotlem");

            migrationBuilder.RenameColumn(
                name: "B_A_30_Wentylacja_nawiew_lazienka",
                table: "InspectionProtocols",
                newName: "A30_Wentylacja_nawiew_lazienka");

            migrationBuilder.RenameColumn(
                name: "B_A_29_Wentylacja_nawiew_kuchnia",
                table: "InspectionProtocols",
                newName: "A29_Wentylacja_nawiew_kuchnia");

            migrationBuilder.RenameColumn(
                name: "B_A_28_Wentylacja_inne_pomieszczenia",
                table: "InspectionProtocols",
                newName: "A28_Wentylacja_inne_pomieszczenia");

            migrationBuilder.RenameColumn(
                name: "B_A_27_Wentylacja_lazienka",
                table: "InspectionProtocols",
                newName: "A27_Wentylacja_lazienka");

            migrationBuilder.RenameColumn(
                name: "B_A_26_Wentylacja_kuchnia",
                table: "InspectionProtocols",
                newName: "A26_Wentylacja_kuchnia");

            migrationBuilder.RenameColumn(
                name: "B_A_03_Gazomierz_szczelnosc",
                table: "InspectionProtocols",
                newName: "A03_B_Gazomierz_szczelnosc");

            migrationBuilder.RenameColumn(
                name: "B_A_02_Gazomierz_szafka_wentylowana",
                table: "InspectionProtocols",
                newName: "A02_B_Gazomierz_szafka_wentylowana");

            migrationBuilder.RenameColumn(
                name: "A_32_Wyniki_stan_szczelnosci",
                table: "InspectionProtocols",
                newName: "A23_Prawidlowosc_terma_gazowa_rura_spalinowa");

            migrationBuilder.RenameColumn(
                name: "A_25_Kubatura_warunku_techniczne",
                table: "InspectionProtocols",
                newName: "A22_Prawidlowosc_terma_gazowa_kurek_odcinajacy");

            migrationBuilder.RenameColumn(
                name: "A_24_Prawidlowosc_kociol_co_z_kurkiem_i_rura",
                table: "InspectionProtocols",
                newName: "A21_Prawidlowosc_terma_gazowa_stan");

            migrationBuilder.RenameColumn(
                name: "A_23_Prawidlowosc_terma_gazowa_rura_spalinowa",
                table: "InspectionProtocols",
                newName: "A20_Prawidlowosc_gazowy_podgrzewacz_cwu_rura_spalinowa");

            migrationBuilder.RenameColumn(
                name: "A_22_Prawidlowosc_terma_gazowa_kurek_odcinajacy",
                table: "InspectionProtocols",
                newName: "A19_Prawidlowosc_gazowy_podgrzewacz_cwu_kurek_odcinajacy");

            migrationBuilder.RenameColumn(
                name: "A_21_Prawidlowosc_terma_gazowa_stan",
                table: "InspectionProtocols",
                newName: "A18_Prawidlowosc_gazowy_podgrzewacz_cwu_stan");

            migrationBuilder.RenameColumn(
                name: "A_20_Prawidlowosc_gazowy_podgrzewacz_cwu_rura_spalinowa",
                table: "InspectionProtocols",
                newName: "A17_Prawidlowosc_kuchenka_gazowa_odleglosc_od_okna");

            migrationBuilder.RenameColumn(
                name: "A_19_Prawidlowosc_gazowy_podgrzewacz_cwu_kurek_odcinajacy",
                table: "InspectionProtocols",
                newName: "A16_Prawidlowosc_kuchenka_gazowa_kurek_odcinajacy");

            migrationBuilder.RenameColumn(
                name: "A_18_Prawidlowosc_gazowy_podgrzewacz_cwu_stan",
                table: "InspectionProtocols",
                newName: "A15_Prawidlowosc_kuchenka_gazowa_podlaczenie_stan");

            migrationBuilder.RenameColumn(
                name: "A_17_Prawidlowosc_kuchenka_gazowa_odleglosc_od_okna",
                table: "InspectionProtocols",
                newName: "A14_Prawidlowosc_kuchenka_gazowa_podlaczenie_rodzaj");

            migrationBuilder.RenameColumn(
                name: "A_16_Prawidlowosc_kuchenka_gazowa_kurek_odcinajacy",
                table: "InspectionProtocols",
                newName: "A13_Prawidlowosc_kuchenka_gazowa_stan");

            migrationBuilder.RenameColumn(
                name: "A_15_Prawidlowosc_kuchenka_gazowa_podlaczenie_stan",
                table: "InspectionProtocols",
                newName: "A12_Prawidlowosc_kuchenka_gazowa_typ");

            migrationBuilder.RenameColumn(
                name: "A_14_Prawidlowosc_kuchenka_gazowa_podlaczenie_rodzaj",
                table: "InspectionProtocols",
                newName: "A11_Przewody_pion_inst_gaz_w_mieszkaniu");

            migrationBuilder.RenameColumn(
                name: "A_13_Prawidlowosc_kuchenka_gazowa_stan",
                table: "InspectionProtocols",
                newName: "A10_Przewody_przebieg_inst_gaz_przez_pokoje");

            migrationBuilder.RenameColumn(
                name: "A_12_Prawidlowosc_kuchenka_gazowa_typ",
                table: "InspectionProtocols",
                newName: "A09_M_Przewody_sposob_prowadzenia");

            migrationBuilder.RenameColumn(
                name: "A_11_Przewody_pion_inst_gaz_w_mieszkaniu",
                table: "InspectionProtocols",
                newName: "A08_M_Przewody_przebieg");

            migrationBuilder.RenameColumn(
                name: "A_10_Przewody_przebieg_inst_gaz_przez_pokoje",
                table: "InspectionProtocols",
                newName: "A07_M_Przewody_rodzaj");

            migrationBuilder.RenameColumn(
                name: "A_06_Gazomierz_kurek_przed_gazomierzem",
                table: "InspectionProtocols",
                newName: "A06_Gazomierz_kurek_przed_gazomierzem");

            migrationBuilder.RenameColumn(
                name: "A_05_Gazomierz_usytuowanie_w_stosunku_do_licznika_energii_elektr",
                table: "InspectionProtocols",
                newName: "A05_Gazomierz_usytuowanie_w_stosunku_do_licznika_energii_elektr");

            migrationBuilder.RenameColumn(
                name: "A_04_Gazomierz_usytuowanie_w_stosunku_do_1_go_odbiornika",
                table: "InspectionProtocols",
                newName: "A04_Gazomierz_usytuowanie_w_stosunku_do_1_go_odbiornika");

            migrationBuilder.RenameColumn(
                name: "A_01_Gazomierz_umiejscowienie",
                table: "InspectionProtocols",
                newName: "A01_Gazomierz_umiejscowienie");

            migrationBuilder.AlterColumn<Guid>(
                name: "ResidentId",
                table: "InspectionProtocols",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("192a33ef-238b-49d3-be1b-55625a475ba6"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("2b792843-b06e-4bc0-b773-f2724c06a835"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("7092e2fd-9edc-411c-bf28-5e970180cd89"), "Szef" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("147bb738-9ace-4ad5-b128-3db54cf788f8"), false, false, false, new Guid("2b792843-b06e-4bc0-b773-f2724c06a835"), "Permissions", false, null },
                    { new Guid("168f4e76-fb4a-4615-968d-15bb01a8085d"), false, false, true, new Guid("2b792843-b06e-4bc0-b773-f2724c06a835"), "Roles", false, null },
                    { new Guid("5cb6572f-152d-447e-94d5-89ac41be89c6"), true, true, true, new Guid("7092e2fd-9edc-411c-bf28-5e970180cd89"), "Users", true, null },
                    { new Guid("87cc1abe-6bd2-45f0-9935-5d2ade5f1d23"), true, true, true, new Guid("192a33ef-238b-49d3-be1b-55625a475ba6"), "Roles", true, null },
                    { new Guid("9eec2a4d-a5be-4cb5-8aaf-53917a41ff46"), true, true, true, new Guid("7092e2fd-9edc-411c-bf28-5e970180cd89"), "Permissions", true, null },
                    { new Guid("a26509d9-1dca-4a68-9e92-0a882398d93b"), true, true, true, new Guid("192a33ef-238b-49d3-be1b-55625a475ba6"), "Permissions", true, null },
                    { new Guid("c96c2035-2992-491b-b3ac-aacd12ffd671"), true, true, true, new Guid("7092e2fd-9edc-411c-bf28-5e970180cd89"), "Roles", true, null },
                    { new Guid("cdf85870-bfd1-43d0-9b5c-5841d318ffb5"), false, false, true, new Guid("2b792843-b06e-4bc0-b773-f2724c06a835"), "Users", false, null },
                    { new Guid("fce76b75-014c-414d-8273-a8a880ff002e"), true, true, true, new Guid("192a33ef-238b-49d3-be1b-55625a475ba6"), "Users", true, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("44624285-506f-4960-ba63-b0b5e7b0d71e"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "AQAAAAIAAYagAAAAEOsY6lELapYVMINjZxo3eww/fMEo+FTjLWE4dkjr8tyB30cpNgrbGmn7nVBY50LBoQ==", "+48 312645978", new Guid("2b792843-b06e-4bc0-b773-f2724c06a835") },
                    { new Guid("6cbab17b-ea1b-485a-b2af-0576d30ecb8f"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "boss", "AQAAAAIAAYagAAAAEP6BVbPnFNoiInCZuSHJXGZUf3/w2nG3SiTHCA0mHI9XnxHFh2deNqtILBpczL8HBQ==", "123 456 789", new Guid("7092e2fd-9edc-411c-bf28-5e970180cd89") },
                    { new Guid("6d26cb31-6901-4f44-8fe1-a37fec361382"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "AQAAAAIAAYagAAAAEJBEMxdwwpGfVEEoTnwK+X1EfC1WWgFkhJpUsoM0hjM3Lf/K8GtAlMGVndxue5g9VQ==", "+48 321 654 987", new Guid("2b792843-b06e-4bc0-b773-f2724c06a835") },
                    { new Guid("e063101a-1e50-4ff7-bbbd-3991ab4f9bd4"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "AQAAAAIAAYagAAAAEPTnnRw5omQGOkx7tdntOwNuqUDhmmX3Nv0yqyzsS/kQVl6DnCjjFLQtiv5U9i+xow==", "987654321", new Guid("2b792843-b06e-4bc0-b773-f2724c06a835") },
                    { new Guid("e770e25d-7989-4634-b694-37d71a406b68"), "", "admin", "", "admin", "AQAAAAIAAYagAAAAEJHDt/vU2T1En1TvJ35JuToctve5n5k9VCjT7KKdEhNXBKvYfZsi2oC41HJBlPrNJA==", "", new Guid("192a33ef-238b-49d3-be1b-55625a475ba6") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("20dd3bb8-57a3-42ce-a85c-a29db560fd8c"), true, true, null, null, "Users", true, new Guid("44624285-506f-4960-ba63-b0b5e7b0d71e") },
                    { new Guid("259bce47-1852-4ee2-99b5-b55e96f63a8c"), null, null, false, null, "Roles", null, new Guid("e063101a-1e50-4ff7-bbbd-3991ab4f9bd4") },
                    { new Guid("38486260-1416-4556-9c6b-ca4edd09dedb"), true, null, null, null, "Roles", true, new Guid("44624285-506f-4960-ba63-b0b5e7b0d71e") },
                    { new Guid("6a879044-9bf1-4edf-a232-ee0487ffcd9e"), null, null, false, null, "Users", null, new Guid("e063101a-1e50-4ff7-bbbd-3991ab4f9bd4") }
                });
        }
    }
}
