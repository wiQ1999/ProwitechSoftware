﻿// <auto-generated />
using System;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ProwitechDbContext))]
    [Migration("20230117185206_inspection-protocol-answers-zmiana-nazw")]
    partial class inspectionprotocolanswerszmiananazw
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Infrastructure.Models.Domain.Building", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BuildingAddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PropertyManagerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("BuildingAddressId");

                    b.HasIndex("PropertyManagerId");

                    b.ToTable("Buildings");
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.BuildingAddress", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BuildingNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CoordinateType")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double?>("Latitude")
                        .HasColumnType("float");

                    b.Property<double?>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("BuildingAddresses");
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.FullAddress", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BuildingAddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PropertyAddressId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BuildingAddressId");

                    b.HasIndex("PropertyAddressId");

                    b.ToTable("FullAddresses");
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.InspectionProtocol", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("A01_Gazomierz_umiejscowienie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("A02_B_Gazomierz_szafka_wentylowana")
                        .HasColumnType("bit");

                    b.Property<bool>("A03_B_Gazomierz_szczelnosc")
                        .HasColumnType("bit");

                    b.Property<string>("A04_Gazomierz_usytuowanie_w_stosunku_do_1_go_odbiornika")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A05_Gazomierz_usytuowanie_w_stosunku_do_licznika_energii_elektr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A06_Gazomierz_kurek_przed_gazomierzem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A07_M_Przewody_rodzaj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A08_M_Przewody_przebieg")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A09_M_Przewody_sposob_prowadzenia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A10_Przewody_przebieg_inst_gaz_przez_pokoje")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A11_Przewody_pion_inst_gaz_w_mieszkaniu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A12_Prawidlowosc_kuchenka_gazowa_typ")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A13_Prawidlowosc_kuchenka_gazowa_stan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A14_Prawidlowosc_kuchenka_gazowa_podlaczenie_rodzaj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A15_Prawidlowosc_kuchenka_gazowa_podlaczenie_stan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A16_Prawidlowosc_kuchenka_gazowa_kurek_odcinajacy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A17_Prawidlowosc_kuchenka_gazowa_odleglosc_od_okna")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A18_Prawidlowosc_gazowy_podgrzewacz_cwu_stan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A19_Prawidlowosc_gazowy_podgrzewacz_cwu_kurek_odcinajacy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A20_Prawidlowosc_gazowy_podgrzewacz_cwu_rura_spalinowa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A21_Prawidlowosc_terma_gazowa_stan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A22_Prawidlowosc_terma_gazowa_kurek_odcinajacy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A23_Prawidlowosc_terma_gazowa_rura_spalinowa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A24_Prawidlowosc_kociol_co_z_kurkiem_i_rura")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A25_Kubatura_warunku_techniczne")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("A26_Wentylacja_kuchnia")
                        .HasColumnType("bit");

                    b.Property<bool>("A27_Wentylacja_lazienka")
                        .HasColumnType("bit");

                    b.Property<bool>("A28_Wentylacja_inne_pomieszczenia")
                        .HasColumnType("bit");

                    b.Property<bool>("A29_Wentylacja_nawiew_kuchnia")
                        .HasColumnType("bit");

                    b.Property<bool>("A30_Wentylacja_nawiew_lazienka")
                        .HasColumnType("bit");

                    b.Property<bool>("A31_Wentylacja_nawiew_Zet_w_pomieszczeniu_z_kotlem")
                        .HasColumnType("bit");

                    b.Property<string>("A32_Wyniki_stan_szczelnosci")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("A33_Wyniki_instalacja_wymaga_usuniecia_nieszczelnosci")
                        .HasColumnType("bit");

                    b.Property<bool>("A34_Propan_butan")
                        .HasColumnType("bit");

                    b.Property<string>("A35_Inne_uwagi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("InspectedPropertyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("InspectionDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("InspectionPerformerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("InspectionTaskId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ResidentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("InspectedPropertyId");

                    b.HasIndex("InspectionPerformerId");

                    b.HasIndex("InspectionTaskId");

                    b.HasIndex("ResidentId");

                    b.ToTable("InspectionProtocols");
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.InspectionTask", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BuildingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DueStartDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EndDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("TaskDelegatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TaskPerformerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BuildingId");

                    b.HasIndex("TaskDelegatorId");

                    b.HasIndex("TaskPerformerId");

                    b.ToTable("InspectionTasks");
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.Permission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("Create")
                        .HasColumnType("bit");

                    b.Property<bool?>("Delete")
                        .HasColumnType("bit");

                    b.Property<bool?>("Read")
                        .HasColumnType("bit");

                    b.Property<Guid?>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Update")
                        .HasColumnType("bit");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("Permissions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7b56b03c-e1d9-4bdd-aa05-1e304c7d6e23"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("cfefd84d-f096-4b24-91ae-a1b1bb16581c"),
                            Source = "Roles",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("36785f81-a225-4c1d-84b1-94249fa49dad"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("cfefd84d-f096-4b24-91ae-a1b1bb16581c"),
                            Source = "Users",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("7c8a2268-2ed2-4175-8c4c-eb8692438a31"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("cfefd84d-f096-4b24-91ae-a1b1bb16581c"),
                            Source = "Permissions",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("94d8fe9d-fdf1-4808-9ea3-513af517fec6"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("ceb9fc7f-95e6-4a81-b8fa-6e8c3e3a4e92"),
                            Source = "Roles",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("35bb6329-1c7e-410a-81c7-099967a64d42"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("ceb9fc7f-95e6-4a81-b8fa-6e8c3e3a4e92"),
                            Source = "Users",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("063d5905-f4a5-45a5-b85b-45a0294a164f"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("ceb9fc7f-95e6-4a81-b8fa-6e8c3e3a4e92"),
                            Source = "Permissions",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("fd48eff5-79d8-4628-9e39-514848238a70"),
                            Create = false,
                            Delete = false,
                            Read = true,
                            RoleId = new Guid("d5cc066e-4a71-4d88-879a-798158d10c84"),
                            Source = "Roles",
                            Update = false
                        },
                        new
                        {
                            Id = new Guid("11afe799-9e17-4d4f-a3da-490247a8538e"),
                            Create = false,
                            Delete = false,
                            Read = true,
                            RoleId = new Guid("d5cc066e-4a71-4d88-879a-798158d10c84"),
                            Source = "Users",
                            Update = false
                        },
                        new
                        {
                            Id = new Guid("b5fe3c13-e634-4c0d-974d-614a78e5cc03"),
                            Create = false,
                            Delete = false,
                            Read = false,
                            RoleId = new Guid("d5cc066e-4a71-4d88-879a-798158d10c84"),
                            Source = "Permissions",
                            Update = false
                        },
                        new
                        {
                            Id = new Guid("b1cf2db6-afc2-4d36-a0cf-299b2e782bb4"),
                            Read = false,
                            Source = "Roles",
                            UserId = new Guid("8f1747d9-e31e-4684-ac26-65eb88605cd3")
                        },
                        new
                        {
                            Id = new Guid("96060d18-fc6e-4feb-8e04-02ee4dbab310"),
                            Read = false,
                            Source = "Users",
                            UserId = new Guid("8f1747d9-e31e-4684-ac26-65eb88605cd3")
                        },
                        new
                        {
                            Id = new Guid("272cac85-e238-4e30-8660-406e2987fd09"),
                            Create = true,
                            Source = "Roles",
                            Update = true,
                            UserId = new Guid("1de43927-88d2-400d-b831-066e7a29d575")
                        },
                        new
                        {
                            Id = new Guid("8df316f1-fe73-4cff-b0d8-23d009504900"),
                            Create = true,
                            Delete = true,
                            Source = "Users",
                            Update = true,
                            UserId = new Guid("1de43927-88d2-400d-b831-066e7a29d575")
                        });
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.PropertyAddress", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("StaircaseNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VenueNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PropertyAddresses");
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.PropertyManager", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FullAddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FullAddressId");

                    b.ToTable("PropertyManagers");
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.RealProperty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BuildingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PropertyAddressId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BuildingId");

                    b.HasIndex("PropertyAddressId");

                    b.ToTable("RealProperties");
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.Resident", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Residents");
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("cfefd84d-f096-4b24-91ae-a1b1bb16581c"),
                            Name = "Administrator"
                        },
                        new
                        {
                            Id = new Guid("ceb9fc7f-95e6-4a81-b8fa-6e8c3e3a4e92"),
                            Name = "Szef"
                        },
                        new
                        {
                            Id = new Guid("d5cc066e-4a71-4d88-879a-798158d10c84"),
                            Name = "Pracownik"
                        });
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<Guid?>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("Login")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f5827526-9698-4018-85f2-8207fa8dd07a"),
                            Email = "",
                            FirstName = "admin",
                            LastName = "",
                            Login = "admin",
                            Password = "AQAAAAIAAYagAAAAEAJNOFuN0SLtHsbiMuWDTZzCdVdGp4Y1p7KTE2yuU7kADNakDDOvbquiyKtclgQodw==",
                            PhoneNumber = "",
                            RoleId = new Guid("cfefd84d-f096-4b24-91ae-a1b1bb16581c")
                        },
                        new
                        {
                            Id = new Guid("1e7e4dcd-be6c-434e-9357-9267eee53153"),
                            Email = "k.tumiel@gmail.com",
                            FirstName = "Krzysztof",
                            LastName = "Tumiel",
                            Login = "boss",
                            Password = "AQAAAAIAAYagAAAAEHZzGi/Da2VA0eTkTdGj1raTbl8SDRGxvd8yPguzj+sx/6+l3r+44oK0zg6s+YBdAA==",
                            PhoneNumber = "123 456 789",
                            RoleId = new Guid("ceb9fc7f-95e6-4a81-b8fa-6e8c3e3a4e92")
                        },
                        new
                        {
                            Id = new Guid("4ae25211-a009-405f-b8db-9a7714121a3d"),
                            Email = "j.kowalski@gmail.com",
                            FirstName = "Jan",
                            LastName = "Kowalski",
                            Login = "w1",
                            Password = "AQAAAAIAAYagAAAAEAfO5p9pfwmGTz2DbrHMQe4AzI1y+yYaMx3PFTcH/BpK+WbL1s+d4T0LfbwIrE50MA==",
                            PhoneNumber = "+48 321 654 987",
                            RoleId = new Guid("d5cc066e-4a71-4d88-879a-798158d10c84")
                        },
                        new
                        {
                            Id = new Guid("8f1747d9-e31e-4684-ac26-65eb88605cd3"),
                            Email = "z.pietka@gmail.com",
                            FirstName = "Zdzisław",
                            LastName = "Piętka",
                            Login = "w2",
                            Password = "AQAAAAIAAYagAAAAEHYPRR8LwKeHiMEuAtZWsgkX+hgyFPYt0Tpf2azy713UvIMN/jo7VAA9DjFZF383Sw==",
                            PhoneNumber = "987654321",
                            RoleId = new Guid("d5cc066e-4a71-4d88-879a-798158d10c84")
                        },
                        new
                        {
                            Id = new Guid("1de43927-88d2-400d-b831-066e7a29d575"),
                            Email = "m.wioslo@gmail.com",
                            FirstName = "Marek",
                            LastName = "Wiosło",
                            Login = "w3",
                            Password = "AQAAAAIAAYagAAAAEG2CznHU9xyfKaVMWPDkGtIthrwOsZ59eV73rVrVQmkQ1eZHscouD0wmV5Ygtn9hCw==",
                            PhoneNumber = "+48 312645978",
                            RoleId = new Guid("d5cc066e-4a71-4d88-879a-798158d10c84")
                        });
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.Building", b =>
                {
                    b.HasOne("Infrastructure.Models.Domain.BuildingAddress", "BuildingAddress")
                        .WithMany()
                        .HasForeignKey("BuildingAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.Models.Domain.PropertyManager", "PropertyManager")
                        .WithMany("Buildings")
                        .HasForeignKey("PropertyManagerId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("BuildingAddress");

                    b.Navigation("PropertyManager");
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.FullAddress", b =>
                {
                    b.HasOne("Infrastructure.Models.Domain.BuildingAddress", "BuildingAddress")
                        .WithMany()
                        .HasForeignKey("BuildingAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.Models.Domain.PropertyAddress", "PropertyAddress")
                        .WithMany()
                        .HasForeignKey("PropertyAddressId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("BuildingAddress");

                    b.Navigation("PropertyAddress");
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.InspectionProtocol", b =>
                {
                    b.HasOne("Infrastructure.Models.Domain.RealProperty", "InspectedProperty")
                        .WithMany()
                        .HasForeignKey("InspectedPropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.Models.Domain.User", "InspectionPerformer")
                        .WithMany()
                        .HasForeignKey("InspectionPerformerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.Models.Domain.InspectionTask", "InspectionTask")
                        .WithMany("InspectionProtocols")
                        .HasForeignKey("InspectionTaskId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Infrastructure.Models.Domain.Resident", "Resident")
                        .WithMany()
                        .HasForeignKey("ResidentId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("InspectedProperty");

                    b.Navigation("InspectionPerformer");

                    b.Navigation("InspectionTask");

                    b.Navigation("Resident");
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.InspectionTask", b =>
                {
                    b.HasOne("Infrastructure.Models.Domain.Building", "Building")
                        .WithMany()
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("Infrastructure.Models.Domain.User", "TaskDelegator")
                        .WithMany()
                        .HasForeignKey("TaskDelegatorId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Infrastructure.Models.Domain.User", "TaskPerformer")
                        .WithMany()
                        .HasForeignKey("TaskPerformerId");

                    b.Navigation("Building");

                    b.Navigation("TaskDelegator");

                    b.Navigation("TaskPerformer");
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.Permission", b =>
                {
                    b.HasOne("Infrastructure.Models.Domain.Role", "Role")
                        .WithMany("Permissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Infrastructure.Models.Domain.User", "User")
                        .WithMany("Permissions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.PropertyManager", b =>
                {
                    b.HasOne("Infrastructure.Models.Domain.FullAddress", "FullAddress")
                        .WithMany()
                        .HasForeignKey("FullAddressId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("FullAddress");
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.RealProperty", b =>
                {
                    b.HasOne("Infrastructure.Models.Domain.Building", "Building")
                        .WithMany("Properties")
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.Models.Domain.PropertyAddress", "PropertyAddress")
                        .WithMany()
                        .HasForeignKey("PropertyAddressId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Building");

                    b.Navigation("PropertyAddress");
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.User", b =>
                {
                    b.HasOne("Infrastructure.Models.Domain.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.Building", b =>
                {
                    b.Navigation("Properties");
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.InspectionTask", b =>
                {
                    b.Navigation("InspectionProtocols");
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.PropertyManager", b =>
                {
                    b.Navigation("Buildings");
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.Role", b =>
                {
                    b.Navigation("Permissions");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.User", b =>
                {
                    b.Navigation("Permissions");
                });
#pragma warning restore 612, 618
        }
    }
}
