using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class inspectionprotocoladdmaxlength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "A35_Inne_uwagi",
                table: "InspectionProtocols",
                type: "nvarchar(600)",
                maxLength: 600,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "A32_Wyniki_stan_szczelnosci",
                table: "InspectionProtocols",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "A25_Kubatura_warunku_techniczne",
                table: "InspectionProtocols",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "A24_Prawidlowosc_kociol_co_z_kurkiem_i_rura",
                table: "InspectionProtocols",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "A23_Prawidlowosc_terma_gazowa_rura_spalinowa",
                table: "InspectionProtocols",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "A22_Prawidlowosc_terma_gazowa_kurek_odcinajacy",
                table: "InspectionProtocols",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "A21_Prawidlowosc_terma_gazowa_stan",
                table: "InspectionProtocols",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "A20_Prawidlowosc_gazowy_podgrzewacz_cwu_rura_spalinowa",
                table: "InspectionProtocols",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "A19_Prawidlowosc_gazowy_podgrzewacz_cwu_kurek_odcinajacy",
                table: "InspectionProtocols",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "A18_Prawidlowosc_gazowy_podgrzewacz_cwu_stan",
                table: "InspectionProtocols",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "A17_Prawidlowosc_kuchenka_gazowa_odleglosc_od_okna",
                table: "InspectionProtocols",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "A16_Prawidlowosc_kuchenka_gazowa_kurek_odcinajacy",
                table: "InspectionProtocols",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "A15_Prawidlowosc_kuchenka_gazowa_podlaczenie_stan",
                table: "InspectionProtocols",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "A14_Prawidlowosc_kuchenka_gazowa_podlaczenie_rodzaj",
                table: "InspectionProtocols",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "A13_Prawidlowosc_kuchenka_gazowa_stan",
                table: "InspectionProtocols",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "A12_Prawidlowosc_kuchenka_gazowa_typ",
                table: "InspectionProtocols",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "A11_Przewody_pion_inst_gaz_w_mieszkaniu",
                table: "InspectionProtocols",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "A10_Przewody_przebieg_inst_gaz_przez_pokoje",
                table: "InspectionProtocols",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "A09_M_Przewody_sposob_prowadzenia",
                table: "InspectionProtocols",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "A08_M_Przewody_przebieg",
                table: "InspectionProtocols",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "A07_M_Przewody_rodzaj",
                table: "InspectionProtocols",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "A06_Gazomierz_kurek_przed_gazomierzem",
                table: "InspectionProtocols",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "A05_Gazomierz_usytuowanie_w_stosunku_do_licznika_energii_elektr",
                table: "InspectionProtocols",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "A04_Gazomierz_usytuowanie_w_stosunku_do_1_go_odbiornika",
                table: "InspectionProtocols",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "A01_Gazomierz_umiejscowienie",
                table: "InspectionProtocols",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "A35_Inne_uwagi",
                table: "InspectionProtocols",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(600)",
                oldMaxLength: 600);

            migrationBuilder.AlterColumn<string>(
                name: "A32_Wyniki_stan_szczelnosci",
                table: "InspectionProtocols",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "A25_Kubatura_warunku_techniczne",
                table: "InspectionProtocols",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "A24_Prawidlowosc_kociol_co_z_kurkiem_i_rura",
                table: "InspectionProtocols",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "A23_Prawidlowosc_terma_gazowa_rura_spalinowa",
                table: "InspectionProtocols",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "A22_Prawidlowosc_terma_gazowa_kurek_odcinajacy",
                table: "InspectionProtocols",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "A21_Prawidlowosc_terma_gazowa_stan",
                table: "InspectionProtocols",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "A20_Prawidlowosc_gazowy_podgrzewacz_cwu_rura_spalinowa",
                table: "InspectionProtocols",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "A19_Prawidlowosc_gazowy_podgrzewacz_cwu_kurek_odcinajacy",
                table: "InspectionProtocols",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "A18_Prawidlowosc_gazowy_podgrzewacz_cwu_stan",
                table: "InspectionProtocols",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "A17_Prawidlowosc_kuchenka_gazowa_odleglosc_od_okna",
                table: "InspectionProtocols",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "A16_Prawidlowosc_kuchenka_gazowa_kurek_odcinajacy",
                table: "InspectionProtocols",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "A15_Prawidlowosc_kuchenka_gazowa_podlaczenie_stan",
                table: "InspectionProtocols",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "A14_Prawidlowosc_kuchenka_gazowa_podlaczenie_rodzaj",
                table: "InspectionProtocols",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "A13_Prawidlowosc_kuchenka_gazowa_stan",
                table: "InspectionProtocols",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "A12_Prawidlowosc_kuchenka_gazowa_typ",
                table: "InspectionProtocols",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "A11_Przewody_pion_inst_gaz_w_mieszkaniu",
                table: "InspectionProtocols",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "A10_Przewody_przebieg_inst_gaz_przez_pokoje",
                table: "InspectionProtocols",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "A09_M_Przewody_sposob_prowadzenia",
                table: "InspectionProtocols",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "A08_M_Przewody_przebieg",
                table: "InspectionProtocols",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "A07_M_Przewody_rodzaj",
                table: "InspectionProtocols",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "A06_Gazomierz_kurek_przed_gazomierzem",
                table: "InspectionProtocols",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "A05_Gazomierz_usytuowanie_w_stosunku_do_licznika_energii_elektr",
                table: "InspectionProtocols",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "A04_Gazomierz_usytuowanie_w_stosunku_do_1_go_odbiornika",
                table: "InspectionProtocols",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "A01_Gazomierz_umiejscowienie",
                table: "InspectionProtocols",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

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
    }
}
