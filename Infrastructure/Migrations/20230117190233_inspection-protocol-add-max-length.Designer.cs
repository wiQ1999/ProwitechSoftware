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
    [Migration("20230117190233_inspection-protocol-add-max-length")]
    partial class inspectionprotocoladdmaxlength
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
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("A02_B_Gazomierz_szafka_wentylowana")
                        .HasColumnType("bit");

                    b.Property<bool>("A03_B_Gazomierz_szczelnosc")
                        .HasColumnType("bit");

                    b.Property<string>("A04_Gazomierz_usytuowanie_w_stosunku_do_1_go_odbiornika")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A05_Gazomierz_usytuowanie_w_stosunku_do_licznika_energii_elektr")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A06_Gazomierz_kurek_przed_gazomierzem")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A07_M_Przewody_rodzaj")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A08_M_Przewody_przebieg")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A09_M_Przewody_sposob_prowadzenia")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A10_Przewody_przebieg_inst_gaz_przez_pokoje")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A11_Przewody_pion_inst_gaz_w_mieszkaniu")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A12_Prawidlowosc_kuchenka_gazowa_typ")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A13_Prawidlowosc_kuchenka_gazowa_stan")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A14_Prawidlowosc_kuchenka_gazowa_podlaczenie_rodzaj")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A15_Prawidlowosc_kuchenka_gazowa_podlaczenie_stan")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A16_Prawidlowosc_kuchenka_gazowa_kurek_odcinajacy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A17_Prawidlowosc_kuchenka_gazowa_odleglosc_od_okna")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A18_Prawidlowosc_gazowy_podgrzewacz_cwu_stan")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A19_Prawidlowosc_gazowy_podgrzewacz_cwu_kurek_odcinajacy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A20_Prawidlowosc_gazowy_podgrzewacz_cwu_rura_spalinowa")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A21_Prawidlowosc_terma_gazowa_stan")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A22_Prawidlowosc_terma_gazowa_kurek_odcinajacy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A23_Prawidlowosc_terma_gazowa_rura_spalinowa")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A24_Prawidlowosc_kociol_co_z_kurkiem_i_rura")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A25_Kubatura_warunku_techniczne")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

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
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("A33_Wyniki_instalacja_wymaga_usuniecia_nieszczelnosci")
                        .HasColumnType("bit");

                    b.Property<bool>("A34_Propan_butan")
                        .HasColumnType("bit");

                    b.Property<string>("A35_Inne_uwagi")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

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
                            Id = new Guid("87cc1abe-6bd2-45f0-9935-5d2ade5f1d23"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("192a33ef-238b-49d3-be1b-55625a475ba6"),
                            Source = "Roles",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("fce76b75-014c-414d-8273-a8a880ff002e"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("192a33ef-238b-49d3-be1b-55625a475ba6"),
                            Source = "Users",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("a26509d9-1dca-4a68-9e92-0a882398d93b"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("192a33ef-238b-49d3-be1b-55625a475ba6"),
                            Source = "Permissions",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("c96c2035-2992-491b-b3ac-aacd12ffd671"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("7092e2fd-9edc-411c-bf28-5e970180cd89"),
                            Source = "Roles",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("5cb6572f-152d-447e-94d5-89ac41be89c6"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("7092e2fd-9edc-411c-bf28-5e970180cd89"),
                            Source = "Users",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("9eec2a4d-a5be-4cb5-8aaf-53917a41ff46"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("7092e2fd-9edc-411c-bf28-5e970180cd89"),
                            Source = "Permissions",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("168f4e76-fb4a-4615-968d-15bb01a8085d"),
                            Create = false,
                            Delete = false,
                            Read = true,
                            RoleId = new Guid("2b792843-b06e-4bc0-b773-f2724c06a835"),
                            Source = "Roles",
                            Update = false
                        },
                        new
                        {
                            Id = new Guid("cdf85870-bfd1-43d0-9b5c-5841d318ffb5"),
                            Create = false,
                            Delete = false,
                            Read = true,
                            RoleId = new Guid("2b792843-b06e-4bc0-b773-f2724c06a835"),
                            Source = "Users",
                            Update = false
                        },
                        new
                        {
                            Id = new Guid("147bb738-9ace-4ad5-b128-3db54cf788f8"),
                            Create = false,
                            Delete = false,
                            Read = false,
                            RoleId = new Guid("2b792843-b06e-4bc0-b773-f2724c06a835"),
                            Source = "Permissions",
                            Update = false
                        },
                        new
                        {
                            Id = new Guid("259bce47-1852-4ee2-99b5-b55e96f63a8c"),
                            Read = false,
                            Source = "Roles",
                            UserId = new Guid("e063101a-1e50-4ff7-bbbd-3991ab4f9bd4")
                        },
                        new
                        {
                            Id = new Guid("6a879044-9bf1-4edf-a232-ee0487ffcd9e"),
                            Read = false,
                            Source = "Users",
                            UserId = new Guid("e063101a-1e50-4ff7-bbbd-3991ab4f9bd4")
                        },
                        new
                        {
                            Id = new Guid("38486260-1416-4556-9c6b-ca4edd09dedb"),
                            Create = true,
                            Source = "Roles",
                            Update = true,
                            UserId = new Guid("44624285-506f-4960-ba63-b0b5e7b0d71e")
                        },
                        new
                        {
                            Id = new Guid("20dd3bb8-57a3-42ce-a85c-a29db560fd8c"),
                            Create = true,
                            Delete = true,
                            Source = "Users",
                            Update = true,
                            UserId = new Guid("44624285-506f-4960-ba63-b0b5e7b0d71e")
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
                            Id = new Guid("192a33ef-238b-49d3-be1b-55625a475ba6"),
                            Name = "Administrator"
                        },
                        new
                        {
                            Id = new Guid("7092e2fd-9edc-411c-bf28-5e970180cd89"),
                            Name = "Szef"
                        },
                        new
                        {
                            Id = new Guid("2b792843-b06e-4bc0-b773-f2724c06a835"),
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
                            Id = new Guid("e770e25d-7989-4634-b694-37d71a406b68"),
                            Email = "",
                            FirstName = "admin",
                            LastName = "",
                            Login = "admin",
                            Password = "AQAAAAIAAYagAAAAEJHDt/vU2T1En1TvJ35JuToctve5n5k9VCjT7KKdEhNXBKvYfZsi2oC41HJBlPrNJA==",
                            PhoneNumber = "",
                            RoleId = new Guid("192a33ef-238b-49d3-be1b-55625a475ba6")
                        },
                        new
                        {
                            Id = new Guid("6cbab17b-ea1b-485a-b2af-0576d30ecb8f"),
                            Email = "k.tumiel@gmail.com",
                            FirstName = "Krzysztof",
                            LastName = "Tumiel",
                            Login = "boss",
                            Password = "AQAAAAIAAYagAAAAEP6BVbPnFNoiInCZuSHJXGZUf3/w2nG3SiTHCA0mHI9XnxHFh2deNqtILBpczL8HBQ==",
                            PhoneNumber = "123 456 789",
                            RoleId = new Guid("7092e2fd-9edc-411c-bf28-5e970180cd89")
                        },
                        new
                        {
                            Id = new Guid("6d26cb31-6901-4f44-8fe1-a37fec361382"),
                            Email = "j.kowalski@gmail.com",
                            FirstName = "Jan",
                            LastName = "Kowalski",
                            Login = "w1",
                            Password = "AQAAAAIAAYagAAAAEJBEMxdwwpGfVEEoTnwK+X1EfC1WWgFkhJpUsoM0hjM3Lf/K8GtAlMGVndxue5g9VQ==",
                            PhoneNumber = "+48 321 654 987",
                            RoleId = new Guid("2b792843-b06e-4bc0-b773-f2724c06a835")
                        },
                        new
                        {
                            Id = new Guid("e063101a-1e50-4ff7-bbbd-3991ab4f9bd4"),
                            Email = "z.pietka@gmail.com",
                            FirstName = "Zdzisław",
                            LastName = "Piętka",
                            Login = "w2",
                            Password = "AQAAAAIAAYagAAAAEPTnnRw5omQGOkx7tdntOwNuqUDhmmX3Nv0yqyzsS/kQVl6DnCjjFLQtiv5U9i+xow==",
                            PhoneNumber = "987654321",
                            RoleId = new Guid("2b792843-b06e-4bc0-b773-f2724c06a835")
                        },
                        new
                        {
                            Id = new Guid("44624285-506f-4960-ba63-b0b5e7b0d71e"),
                            Email = "m.wioslo@gmail.com",
                            FirstName = "Marek",
                            LastName = "Wiosło",
                            Login = "w3",
                            Password = "AQAAAAIAAYagAAAAEOsY6lELapYVMINjZxo3eww/fMEo+FTjLWE4dkjr8tyB30cpNgrbGmn7nVBY50LBoQ==",
                            PhoneNumber = "+48 312645978",
                            RoleId = new Guid("2b792843-b06e-4bc0-b773-f2724c06a835")
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
