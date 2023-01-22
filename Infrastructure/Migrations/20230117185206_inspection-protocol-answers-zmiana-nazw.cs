using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class inspectionprotocolanswerszmiananazw : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("106c5e98-40e5-4087-8b56-c6b171be165a"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2a3b78f8-963e-4c2c-9342-15879bac9f81"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("3f47fce9-f319-42fb-9005-a3cf10ff33c9"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("4d6ed460-9fbd-43ff-ae89-2c9f01ab3ad4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("58a2b8f5-716e-4df5-843b-7a59ef890918"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b50eaa2e-c379-410f-a7e1-1a339a650872"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("cf78f95f-ad5f-4bf9-9e9f-2f4f4e8028f6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d6221b0d-3323-4c03-ad75-1cdb378f54ba"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("dae40c25-2d30-4539-99f2-4057529108f8"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("de654ea7-9c05-4cc6-87df-876a95ebc5ab"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("eaf16833-e5c6-424a-86c9-5b9237ed0f9e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("f4fc5a5f-0773-425f-a10e-81bd3af45831"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fbc4d37c-bd76-4729-a2ae-a488737d98ac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2a318f93-0663-48f5-86a0-f4e9652cbb78"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bab0423b-5b3b-4480-b8a9-a9c4a67a3d1e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb23019b-8700-4613-9715-8aad18f1da38"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ce1de054-950c-42c1-a674-da95acf541c3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d981b703-60bd-4958-bce8-65f548f82992"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0264fa38-e506-4a91-a192-6484709d9f7f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2feb9e44-2f54-4709-8777-1b390619a9d4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e1dba996-66aa-4284-ab24-d2a995457b32"));

            migrationBuilder.DropColumn(
                name: "A_Gazomierz_kurek_przed_gazomierzem",
                table: "InspectionProtocols");

            migrationBuilder.RenameColumn(
                name: "A_Wyniki_stan_szczelnosci",
                table: "InspectionProtocols",
                newName: "A35_Inne_uwagi");

            migrationBuilder.RenameColumn(
                name: "A_Wyniki_instalacja_wymaga_usuniecia_nieszczelnosci",
                table: "InspectionProtocols",
                newName: "A34_Propan_butan");

            migrationBuilder.RenameColumn(
                name: "A_Wentylacja_nawiew_lazienka",
                table: "InspectionProtocols",
                newName: "A33_Wyniki_instalacja_wymaga_usuniecia_nieszczelnosci");

            migrationBuilder.RenameColumn(
                name: "A_Wentylacja_nawiew_kuchnia",
                table: "InspectionProtocols",
                newName: "A31_Wentylacja_nawiew_Zet_w_pomieszczeniu_z_kotlem");

            migrationBuilder.RenameColumn(
                name: "A_Wentylacja_nawiew_Zet_w_pomieszczeniu_z_kotlem",
                table: "InspectionProtocols",
                newName: "A30_Wentylacja_nawiew_lazienka");

            migrationBuilder.RenameColumn(
                name: "A_Wentylacja_lazienka",
                table: "InspectionProtocols",
                newName: "A29_Wentylacja_nawiew_kuchnia");

            migrationBuilder.RenameColumn(
                name: "A_Wentylacja_kuchnia",
                table: "InspectionProtocols",
                newName: "A28_Wentylacja_inne_pomieszczenia");

            migrationBuilder.RenameColumn(
                name: "A_Wentylacja_inne_pomieszczenia",
                table: "InspectionProtocols",
                newName: "A27_Wentylacja_lazienka");

            migrationBuilder.RenameColumn(
                name: "A_Przewody_przebieg_inst_gaz_przez_pokoje",
                table: "InspectionProtocols",
                newName: "A32_Wyniki_stan_szczelnosci");

            migrationBuilder.RenameColumn(
                name: "A_Przewody_pion_inst_gaz_w_mieszkaniu",
                table: "InspectionProtocols",
                newName: "A25_Kubatura_warunku_techniczne");

            migrationBuilder.RenameColumn(
                name: "A_Propan_butan",
                table: "InspectionProtocols",
                newName: "A26_Wentylacja_kuchnia");

            migrationBuilder.RenameColumn(
                name: "A_Prawidlowosc_terma_gazowa_stan",
                table: "InspectionProtocols",
                newName: "A24_Prawidlowosc_kociol_co_z_kurkiem_i_rura");

            migrationBuilder.RenameColumn(
                name: "A_Prawidlowosc_terma_gazowa_rura_spalinowa",
                table: "InspectionProtocols",
                newName: "A23_Prawidlowosc_terma_gazowa_rura_spalinowa");

            migrationBuilder.RenameColumn(
                name: "A_Prawidlowosc_terma_gazowa_kurek_odcinajacy",
                table: "InspectionProtocols",
                newName: "A22_Prawidlowosc_terma_gazowa_kurek_odcinajacy");

            migrationBuilder.RenameColumn(
                name: "A_Prawidlowosc_kuchenka_gazowa_typ",
                table: "InspectionProtocols",
                newName: "A21_Prawidlowosc_terma_gazowa_stan");

            migrationBuilder.RenameColumn(
                name: "A_Prawidlowosc_kuchenka_gazowa_stan",
                table: "InspectionProtocols",
                newName: "A20_Prawidlowosc_gazowy_podgrzewacz_cwu_rura_spalinowa");

            migrationBuilder.RenameColumn(
                name: "A_Prawidlowosc_kuchenka_gazowa_podlaczenie_stan",
                table: "InspectionProtocols",
                newName: "A19_Prawidlowosc_gazowy_podgrzewacz_cwu_kurek_odcinajacy");

            migrationBuilder.RenameColumn(
                name: "A_Prawidlowosc_kuchenka_gazowa_podlaczenie_rodzaj",
                table: "InspectionProtocols",
                newName: "A18_Prawidlowosc_gazowy_podgrzewacz_cwu_stan");

            migrationBuilder.RenameColumn(
                name: "A_Prawidlowosc_kuchenka_gazowa_odleglosc_od_okna",
                table: "InspectionProtocols",
                newName: "A17_Prawidlowosc_kuchenka_gazowa_odleglosc_od_okna");

            migrationBuilder.RenameColumn(
                name: "A_Prawidlowosc_kuchenka_gazowa_kurek_odcinajacy",
                table: "InspectionProtocols",
                newName: "A16_Prawidlowosc_kuchenka_gazowa_kurek_odcinajacy");

            migrationBuilder.RenameColumn(
                name: "A_Prawidlowosc_kociol_co_z_kurkiek_i_rura",
                table: "InspectionProtocols",
                newName: "A15_Prawidlowosc_kuchenka_gazowa_podlaczenie_stan");

            migrationBuilder.RenameColumn(
                name: "A_Prawidlowosc_gazowy_podgrzewacz_cwu_stan",
                table: "InspectionProtocols",
                newName: "A14_Prawidlowosc_kuchenka_gazowa_podlaczenie_rodzaj");

            migrationBuilder.RenameColumn(
                name: "A_Prawidlowosc_gazowy_podgrzewacz_cwu_rura_spalinowa",
                table: "InspectionProtocols",
                newName: "A13_Prawidlowosc_kuchenka_gazowa_stan");

            migrationBuilder.RenameColumn(
                name: "A_Prawidlowosc_gazowy_podgrzewacz_cwu_kurek_odcinajacy",
                table: "InspectionProtocols",
                newName: "A12_Prawidlowosc_kuchenka_gazowa_typ");

            migrationBuilder.RenameColumn(
                name: "A_M_Przewody_sposob_prowadzenia",
                table: "InspectionProtocols",
                newName: "A11_Przewody_pion_inst_gaz_w_mieszkaniu");

            migrationBuilder.RenameColumn(
                name: "A_M_Przewody_rodzaj",
                table: "InspectionProtocols",
                newName: "A10_Przewody_przebieg_inst_gaz_przez_pokoje");

            migrationBuilder.RenameColumn(
                name: "A_M_Przewody_przebieg",
                table: "InspectionProtocols",
                newName: "A09_M_Przewody_sposob_prowadzenia");

            migrationBuilder.RenameColumn(
                name: "A_Kubatura_warunku_techniczne",
                table: "InspectionProtocols",
                newName: "A08_M_Przewody_przebieg");

            migrationBuilder.RenameColumn(
                name: "A_Inne_uwagi",
                table: "InspectionProtocols",
                newName: "A07_M_Przewody_rodzaj");

            migrationBuilder.RenameColumn(
                name: "A_Gazomierz_usytuowanie_w_stosunku_do_licznika_energii_elektr",
                table: "InspectionProtocols",
                newName: "A06_Gazomierz_kurek_przed_gazomierzem");

            migrationBuilder.RenameColumn(
                name: "A_Gazomierz_usytuowanie_w_stosunku_do_1_go_odbiornika",
                table: "InspectionProtocols",
                newName: "A05_Gazomierz_usytuowanie_w_stosunku_do_licznika_energii_elektr");

            migrationBuilder.RenameColumn(
                name: "A_Gazomierz_umiejscowienie",
                table: "InspectionProtocols",
                newName: "A04_Gazomierz_usytuowanie_w_stosunku_do_1_go_odbiornika");

            migrationBuilder.RenameColumn(
                name: "A_Gazomierz_szczelnosc",
                table: "InspectionProtocols",
                newName: "A01_Gazomierz_umiejscowienie");

            migrationBuilder.RenameColumn(
                name: "A_Gazomierz_szafka_wentylowana",
                table: "InspectionProtocols",
                newName: "A03_B_Gazomierz_szczelnosc");

            migrationBuilder.AddColumn<bool>(
                name: "A02_B_Gazomierz_szafka_wentylowana",
                table: "InspectionProtocols",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("ceb9fc7f-95e6-4a81-b8fa-6e8c3e3a4e92"), "Szef" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("cfefd84d-f096-4b24-91ae-a1b1bb16581c"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("d5cc066e-4a71-4d88-879a-798158d10c84"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("063d5905-f4a5-45a5-b85b-45a0294a164f"), true, true, true, new Guid("ceb9fc7f-95e6-4a81-b8fa-6e8c3e3a4e92"), "Permissions", true, null },
                    { new Guid("11afe799-9e17-4d4f-a3da-490247a8538e"), false, false, true, new Guid("d5cc066e-4a71-4d88-879a-798158d10c84"), "Users", false, null },
                    { new Guid("35bb6329-1c7e-410a-81c7-099967a64d42"), true, true, true, new Guid("ceb9fc7f-95e6-4a81-b8fa-6e8c3e3a4e92"), "Users", true, null },
                    { new Guid("36785f81-a225-4c1d-84b1-94249fa49dad"), true, true, true, new Guid("cfefd84d-f096-4b24-91ae-a1b1bb16581c"), "Users", true, null },
                    { new Guid("7b56b03c-e1d9-4bdd-aa05-1e304c7d6e23"), true, true, true, new Guid("cfefd84d-f096-4b24-91ae-a1b1bb16581c"), "Roles", true, null },
                    { new Guid("7c8a2268-2ed2-4175-8c4c-eb8692438a31"), true, true, true, new Guid("cfefd84d-f096-4b24-91ae-a1b1bb16581c"), "Permissions", true, null },
                    { new Guid("94d8fe9d-fdf1-4808-9ea3-513af517fec6"), true, true, true, new Guid("ceb9fc7f-95e6-4a81-b8fa-6e8c3e3a4e92"), "Roles", true, null },
                    { new Guid("b5fe3c13-e634-4c0d-974d-614a78e5cc03"), false, false, false, new Guid("d5cc066e-4a71-4d88-879a-798158d10c84"), "Permissions", false, null },
                    { new Guid("fd48eff5-79d8-4628-9e39-514848238a70"), false, false, true, new Guid("d5cc066e-4a71-4d88-879a-798158d10c84"), "Roles", false, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("1de43927-88d2-400d-b831-066e7a29d575"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "AQAAAAIAAYagAAAAEG2CznHU9xyfKaVMWPDkGtIthrwOsZ59eV73rVrVQmkQ1eZHscouD0wmV5Ygtn9hCw==", "+48 312645978", new Guid("d5cc066e-4a71-4d88-879a-798158d10c84") },
                    { new Guid("1e7e4dcd-be6c-434e-9357-9267eee53153"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "boss", "AQAAAAIAAYagAAAAEHZzGi/Da2VA0eTkTdGj1raTbl8SDRGxvd8yPguzj+sx/6+l3r+44oK0zg6s+YBdAA==", "123 456 789", new Guid("ceb9fc7f-95e6-4a81-b8fa-6e8c3e3a4e92") },
                    { new Guid("4ae25211-a009-405f-b8db-9a7714121a3d"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "AQAAAAIAAYagAAAAEAfO5p9pfwmGTz2DbrHMQe4AzI1y+yYaMx3PFTcH/BpK+WbL1s+d4T0LfbwIrE50MA==", "+48 321 654 987", new Guid("d5cc066e-4a71-4d88-879a-798158d10c84") },
                    { new Guid("8f1747d9-e31e-4684-ac26-65eb88605cd3"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "AQAAAAIAAYagAAAAEHYPRR8LwKeHiMEuAtZWsgkX+hgyFPYt0Tpf2azy713UvIMN/jo7VAA9DjFZF383Sw==", "987654321", new Guid("d5cc066e-4a71-4d88-879a-798158d10c84") },
                    { new Guid("f5827526-9698-4018-85f2-8207fa8dd07a"), "", "admin", "", "admin", "AQAAAAIAAYagAAAAEAJNOFuN0SLtHsbiMuWDTZzCdVdGp4Y1p7KTE2yuU7kADNakDDOvbquiyKtclgQodw==", "", new Guid("cfefd84d-f096-4b24-91ae-a1b1bb16581c") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("272cac85-e238-4e30-8660-406e2987fd09"), true, null, null, null, "Roles", true, new Guid("1de43927-88d2-400d-b831-066e7a29d575") },
                    { new Guid("8df316f1-fe73-4cff-b0d8-23d009504900"), true, true, null, null, "Users", true, new Guid("1de43927-88d2-400d-b831-066e7a29d575") },
                    { new Guid("96060d18-fc6e-4feb-8e04-02ee4dbab310"), null, null, false, null, "Users", null, new Guid("8f1747d9-e31e-4684-ac26-65eb88605cd3") },
                    { new Guid("b1cf2db6-afc2-4d36-a0cf-299b2e782bb4"), null, null, false, null, "Roles", null, new Guid("8f1747d9-e31e-4684-ac26-65eb88605cd3") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("063d5905-f4a5-45a5-b85b-45a0294a164f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("11afe799-9e17-4d4f-a3da-490247a8538e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("272cac85-e238-4e30-8660-406e2987fd09"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("35bb6329-1c7e-410a-81c7-099967a64d42"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("36785f81-a225-4c1d-84b1-94249fa49dad"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7b56b03c-e1d9-4bdd-aa05-1e304c7d6e23"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("7c8a2268-2ed2-4175-8c4c-eb8692438a31"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8df316f1-fe73-4cff-b0d8-23d009504900"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("94d8fe9d-fdf1-4808-9ea3-513af517fec6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("96060d18-fc6e-4feb-8e04-02ee4dbab310"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b1cf2db6-afc2-4d36-a0cf-299b2e782bb4"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("b5fe3c13-e634-4c0d-974d-614a78e5cc03"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("fd48eff5-79d8-4628-9e39-514848238a70"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e7e4dcd-be6c-434e-9357-9267eee53153"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ae25211-a009-405f-b8db-9a7714121a3d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f5827526-9698-4018-85f2-8207fa8dd07a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ceb9fc7f-95e6-4a81-b8fa-6e8c3e3a4e92"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("cfefd84d-f096-4b24-91ae-a1b1bb16581c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1de43927-88d2-400d-b831-066e7a29d575"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f1747d9-e31e-4684-ac26-65eb88605cd3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d5cc066e-4a71-4d88-879a-798158d10c84"));

            migrationBuilder.DropColumn(
                name: "A02_B_Gazomierz_szafka_wentylowana",
                table: "InspectionProtocols");

            migrationBuilder.RenameColumn(
                name: "A35_Inne_uwagi",
                table: "InspectionProtocols",
                newName: "A_Wyniki_stan_szczelnosci");

            migrationBuilder.RenameColumn(
                name: "A34_Propan_butan",
                table: "InspectionProtocols",
                newName: "A_Wyniki_instalacja_wymaga_usuniecia_nieszczelnosci");

            migrationBuilder.RenameColumn(
                name: "A33_Wyniki_instalacja_wymaga_usuniecia_nieszczelnosci",
                table: "InspectionProtocols",
                newName: "A_Wentylacja_nawiew_lazienka");

            migrationBuilder.RenameColumn(
                name: "A32_Wyniki_stan_szczelnosci",
                table: "InspectionProtocols",
                newName: "A_Przewody_przebieg_inst_gaz_przez_pokoje");

            migrationBuilder.RenameColumn(
                name: "A31_Wentylacja_nawiew_Zet_w_pomieszczeniu_z_kotlem",
                table: "InspectionProtocols",
                newName: "A_Wentylacja_nawiew_kuchnia");

            migrationBuilder.RenameColumn(
                name: "A30_Wentylacja_nawiew_lazienka",
                table: "InspectionProtocols",
                newName: "A_Wentylacja_nawiew_Zet_w_pomieszczeniu_z_kotlem");

            migrationBuilder.RenameColumn(
                name: "A29_Wentylacja_nawiew_kuchnia",
                table: "InspectionProtocols",
                newName: "A_Wentylacja_lazienka");

            migrationBuilder.RenameColumn(
                name: "A28_Wentylacja_inne_pomieszczenia",
                table: "InspectionProtocols",
                newName: "A_Wentylacja_kuchnia");

            migrationBuilder.RenameColumn(
                name: "A27_Wentylacja_lazienka",
                table: "InspectionProtocols",
                newName: "A_Wentylacja_inne_pomieszczenia");

            migrationBuilder.RenameColumn(
                name: "A26_Wentylacja_kuchnia",
                table: "InspectionProtocols",
                newName: "A_Propan_butan");

            migrationBuilder.RenameColumn(
                name: "A25_Kubatura_warunku_techniczne",
                table: "InspectionProtocols",
                newName: "A_Przewody_pion_inst_gaz_w_mieszkaniu");

            migrationBuilder.RenameColumn(
                name: "A24_Prawidlowosc_kociol_co_z_kurkiem_i_rura",
                table: "InspectionProtocols",
                newName: "A_Prawidlowosc_terma_gazowa_stan");

            migrationBuilder.RenameColumn(
                name: "A23_Prawidlowosc_terma_gazowa_rura_spalinowa",
                table: "InspectionProtocols",
                newName: "A_Prawidlowosc_terma_gazowa_rura_spalinowa");

            migrationBuilder.RenameColumn(
                name: "A22_Prawidlowosc_terma_gazowa_kurek_odcinajacy",
                table: "InspectionProtocols",
                newName: "A_Prawidlowosc_terma_gazowa_kurek_odcinajacy");

            migrationBuilder.RenameColumn(
                name: "A21_Prawidlowosc_terma_gazowa_stan",
                table: "InspectionProtocols",
                newName: "A_Prawidlowosc_kuchenka_gazowa_typ");

            migrationBuilder.RenameColumn(
                name: "A20_Prawidlowosc_gazowy_podgrzewacz_cwu_rura_spalinowa",
                table: "InspectionProtocols",
                newName: "A_Prawidlowosc_kuchenka_gazowa_stan");

            migrationBuilder.RenameColumn(
                name: "A19_Prawidlowosc_gazowy_podgrzewacz_cwu_kurek_odcinajacy",
                table: "InspectionProtocols",
                newName: "A_Prawidlowosc_kuchenka_gazowa_podlaczenie_stan");

            migrationBuilder.RenameColumn(
                name: "A18_Prawidlowosc_gazowy_podgrzewacz_cwu_stan",
                table: "InspectionProtocols",
                newName: "A_Prawidlowosc_kuchenka_gazowa_podlaczenie_rodzaj");

            migrationBuilder.RenameColumn(
                name: "A17_Prawidlowosc_kuchenka_gazowa_odleglosc_od_okna",
                table: "InspectionProtocols",
                newName: "A_Prawidlowosc_kuchenka_gazowa_odleglosc_od_okna");

            migrationBuilder.RenameColumn(
                name: "A16_Prawidlowosc_kuchenka_gazowa_kurek_odcinajacy",
                table: "InspectionProtocols",
                newName: "A_Prawidlowosc_kuchenka_gazowa_kurek_odcinajacy");

            migrationBuilder.RenameColumn(
                name: "A15_Prawidlowosc_kuchenka_gazowa_podlaczenie_stan",
                table: "InspectionProtocols",
                newName: "A_Prawidlowosc_kociol_co_z_kurkiek_i_rura");

            migrationBuilder.RenameColumn(
                name: "A14_Prawidlowosc_kuchenka_gazowa_podlaczenie_rodzaj",
                table: "InspectionProtocols",
                newName: "A_Prawidlowosc_gazowy_podgrzewacz_cwu_stan");

            migrationBuilder.RenameColumn(
                name: "A13_Prawidlowosc_kuchenka_gazowa_stan",
                table: "InspectionProtocols",
                newName: "A_Prawidlowosc_gazowy_podgrzewacz_cwu_rura_spalinowa");

            migrationBuilder.RenameColumn(
                name: "A12_Prawidlowosc_kuchenka_gazowa_typ",
                table: "InspectionProtocols",
                newName: "A_Prawidlowosc_gazowy_podgrzewacz_cwu_kurek_odcinajacy");

            migrationBuilder.RenameColumn(
                name: "A11_Przewody_pion_inst_gaz_w_mieszkaniu",
                table: "InspectionProtocols",
                newName: "A_M_Przewody_sposob_prowadzenia");

            migrationBuilder.RenameColumn(
                name: "A10_Przewody_przebieg_inst_gaz_przez_pokoje",
                table: "InspectionProtocols",
                newName: "A_M_Przewody_rodzaj");

            migrationBuilder.RenameColumn(
                name: "A09_M_Przewody_sposob_prowadzenia",
                table: "InspectionProtocols",
                newName: "A_M_Przewody_przebieg");

            migrationBuilder.RenameColumn(
                name: "A08_M_Przewody_przebieg",
                table: "InspectionProtocols",
                newName: "A_Kubatura_warunku_techniczne");

            migrationBuilder.RenameColumn(
                name: "A07_M_Przewody_rodzaj",
                table: "InspectionProtocols",
                newName: "A_Inne_uwagi");

            migrationBuilder.RenameColumn(
                name: "A06_Gazomierz_kurek_przed_gazomierzem",
                table: "InspectionProtocols",
                newName: "A_Gazomierz_usytuowanie_w_stosunku_do_licznika_energii_elektr");

            migrationBuilder.RenameColumn(
                name: "A05_Gazomierz_usytuowanie_w_stosunku_do_licznika_energii_elektr",
                table: "InspectionProtocols",
                newName: "A_Gazomierz_usytuowanie_w_stosunku_do_1_go_odbiornika");

            migrationBuilder.RenameColumn(
                name: "A04_Gazomierz_usytuowanie_w_stosunku_do_1_go_odbiornika",
                table: "InspectionProtocols",
                newName: "A_Gazomierz_umiejscowienie");

            migrationBuilder.RenameColumn(
                name: "A03_B_Gazomierz_szczelnosc",
                table: "InspectionProtocols",
                newName: "A_Gazomierz_szafka_wentylowana");

            migrationBuilder.RenameColumn(
                name: "A01_Gazomierz_umiejscowienie",
                table: "InspectionProtocols",
                newName: "A_Gazomierz_szczelnosc");

            migrationBuilder.AddColumn<string>(
                name: "A_Gazomierz_kurek_przed_gazomierzem",
                table: "InspectionProtocols",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("ce1de054-950c-42c1-a674-da95acf541c3"), "Administrator" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("d981b703-60bd-4958-bce8-65f548f82992"), "Szef" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("e1dba996-66aa-4284-ab24-d2a995457b32"), "Pracownik" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("2a3b78f8-963e-4c2c-9342-15879bac9f81"), true, true, true, new Guid("d981b703-60bd-4958-bce8-65f548f82992"), "Roles", true, null },
                    { new Guid("3f47fce9-f319-42fb-9005-a3cf10ff33c9"), true, true, true, new Guid("ce1de054-950c-42c1-a674-da95acf541c3"), "Roles", true, null },
                    { new Guid("4d6ed460-9fbd-43ff-ae89-2c9f01ab3ad4"), false, false, false, new Guid("e1dba996-66aa-4284-ab24-d2a995457b32"), "Permissions", false, null },
                    { new Guid("b50eaa2e-c379-410f-a7e1-1a339a650872"), false, false, true, new Guid("e1dba996-66aa-4284-ab24-d2a995457b32"), "Roles", false, null },
                    { new Guid("d6221b0d-3323-4c03-ad75-1cdb378f54ba"), true, true, true, new Guid("ce1de054-950c-42c1-a674-da95acf541c3"), "Permissions", true, null },
                    { new Guid("dae40c25-2d30-4539-99f2-4057529108f8"), true, true, true, new Guid("d981b703-60bd-4958-bce8-65f548f82992"), "Users", true, null },
                    { new Guid("de654ea7-9c05-4cc6-87df-876a95ebc5ab"), true, true, true, new Guid("d981b703-60bd-4958-bce8-65f548f82992"), "Permissions", true, null },
                    { new Guid("eaf16833-e5c6-424a-86c9-5b9237ed0f9e"), true, true, true, new Guid("ce1de054-950c-42c1-a674-da95acf541c3"), "Users", true, null },
                    { new Guid("f4fc5a5f-0773-425f-a10e-81bd3af45831"), false, false, true, new Guid("e1dba996-66aa-4284-ab24-d2a995457b32"), "Users", false, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Login", "Password", "PhoneNumber", "RoleId" },
                values: new object[,]
                {
                    { new Guid("0264fa38-e506-4a91-a192-6484709d9f7f"), "z.pietka@gmail.com", "Zdzisław", "Piętka", "w2", "AQAAAAIAAYagAAAAEKGGwyQkd3ejD20mA1mKLf09+chd1tYdziwii24rlyrg8yFQSalZTwcpPPwLqOROug==", "987654321", new Guid("e1dba996-66aa-4284-ab24-d2a995457b32") },
                    { new Guid("2a318f93-0663-48f5-86a0-f4e9652cbb78"), "k.tumiel@gmail.com", "Krzysztof", "Tumiel", "boss", "AQAAAAIAAYagAAAAEIWVaCTHIM7O/3aStuBUi/HqVNciGV53RwOVMpwBF2EQz1KE/bY/56kTZp6kuvlbCQ==", "123 456 789", new Guid("d981b703-60bd-4958-bce8-65f548f82992") },
                    { new Guid("2feb9e44-2f54-4709-8777-1b390619a9d4"), "m.wioslo@gmail.com", "Marek", "Wiosło", "w3", "AQAAAAIAAYagAAAAEM7f/cNic3YsIh3p2S3VsX4X7ED5ljqoccwH88KocIha/Et43Ye4HTwO1UAfO8fO1g==", "+48 312645978", new Guid("e1dba996-66aa-4284-ab24-d2a995457b32") },
                    { new Guid("bab0423b-5b3b-4480-b8a9-a9c4a67a3d1e"), "j.kowalski@gmail.com", "Jan", "Kowalski", "w1", "AQAAAAIAAYagAAAAEP2mTnnb+mMQzZr/4bxPfxt3/Xgk9boyuINa/+v6mqgmzjr7cWN084fjCDtRTLrr1g==", "+48 321 654 987", new Guid("e1dba996-66aa-4284-ab24-d2a995457b32") },
                    { new Guid("cb23019b-8700-4613-9715-8aad18f1da38"), "", "admin", "", "admin", "AQAAAAIAAYagAAAAEF2tRrfxKyh/Vyv50F+Y7g+AQmgjYalzxHVkiQ9Nn0xrpmRKHJu18fXCEheVeXaCaw==", "", new Guid("ce1de054-950c-42c1-a674-da95acf541c3") }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Create", "Delete", "Read", "RoleId", "Source", "Update", "UserId" },
                values: new object[,]
                {
                    { new Guid("106c5e98-40e5-4087-8b56-c6b171be165a"), true, true, null, null, "Users", true, new Guid("2feb9e44-2f54-4709-8777-1b390619a9d4") },
                    { new Guid("58a2b8f5-716e-4df5-843b-7a59ef890918"), true, null, null, null, "Roles", true, new Guid("2feb9e44-2f54-4709-8777-1b390619a9d4") },
                    { new Guid("cf78f95f-ad5f-4bf9-9e9f-2f4f4e8028f6"), null, null, false, null, "Users", null, new Guid("0264fa38-e506-4a91-a192-6484709d9f7f") },
                    { new Guid("fbc4d37c-bd76-4729-a2ae-a488737d98ac"), null, null, false, null, "Roles", null, new Guid("0264fa38-e506-4a91-a192-6484709d9f7f") }
                });
        }
    }
}
