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
    [Migration("20230108134521_full-address-remove-indexes")]
    partial class fulladdressremoveindexes
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

                    b.Property<string>("A_Gazomierz_kurek_przed_gazomierzem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A_Gazomierz_szafka_wentylowana")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A_Gazomierz_szczelnosc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A_Gazomierz_umiejscowienie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A_Gazomierz_usytuowanie_w_stosunku_do_1_go_odbiornika")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A_Gazomierz_usytuowanie_w_stosunku_do_licznika_energii_elektr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A_Inne_uwagi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A_Kubatura_warunku_techniczne")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A_M_Przewody_przebieg")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A_M_Przewody_rodzaj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A_M_Przewody_sposob_prowadzenia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A_Prawidlowosc_gazowy_podgrzewacz_cwu_kurek_odcinajacy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A_Prawidlowosc_gazowy_podgrzewacz_cwu_rura_spalinowa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A_Prawidlowosc_gazowy_podgrzewacz_cwu_stan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A_Prawidlowosc_kociol_co_z_kurkiek_i_rura")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A_Prawidlowosc_kuchenka_gazowa_kurek_odcinajacy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A_Prawidlowosc_kuchenka_gazowa_odleglosc_od_okna")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A_Prawidlowosc_kuchenka_gazowa_podlaczenie_rodzaj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A_Prawidlowosc_kuchenka_gazowa_podlaczenie_stan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A_Prawidlowosc_kuchenka_gazowa_stan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A_Prawidlowosc_kuchenka_gazowa_typ")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A_Prawidlowosc_terma_gazowa_kurek_odcinajacy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A_Prawidlowosc_terma_gazowa_rura_spalinowa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A_Prawidlowosc_terma_gazowa_stan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("A_Propan_butan")
                        .HasColumnType("bit");

                    b.Property<string>("A_Przewody_pion_inst_gaz_w_mieszkaniu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("A_Przewody_przebieg_inst_gaz_przez_pokoje")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("A_Wentylacja_inne_pomieszczenia")
                        .HasColumnType("bit");

                    b.Property<bool>("A_Wentylacja_kuchnia")
                        .HasColumnType("bit");

                    b.Property<bool>("A_Wentylacja_lazienka")
                        .HasColumnType("bit");

                    b.Property<bool>("A_Wentylacja_nawiew_Zet_w_pomieszczeniu_z_kotlem")
                        .HasColumnType("bit");

                    b.Property<bool>("A_Wentylacja_nawiew_kuchnia")
                        .HasColumnType("bit");

                    b.Property<bool>("A_Wentylacja_nawiew_lazienka")
                        .HasColumnType("bit");

                    b.Property<bool>("A_Wyniki_instalacja_wymaga_usuniecia_nieszczelnosci")
                        .HasColumnType("bit");

                    b.Property<string>("A_Wyniki_stan_szczelnosci")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("InspectedPropertyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("InspectionDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("InspectionTaskId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ResidentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("InspectedPropertyId");

                    b.HasIndex("InspectionTaskId");

                    b.HasIndex("ResidentId");

                    b.ToTable("InspectionProtocols");
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.InspectionTask", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BuildingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DueStartDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("TaskDelegatorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BuildingId");

                    b.HasIndex("TaskDelegatorId");

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
                            Id = new Guid("086ecc39-0831-4258-88a9-ed3ef289cda2"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("09b195d4-c916-4df0-b045-00ef5c1f3f02"),
                            Source = "Roles",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("abcaf32a-b71d-4596-89f8-c8c6fb9c2018"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("09b195d4-c916-4df0-b045-00ef5c1f3f02"),
                            Source = "Users",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("a4762310-01f0-4426-b83b-b613775c68d1"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("09b195d4-c916-4df0-b045-00ef5c1f3f02"),
                            Source = "Permissions",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("b2056161-cc49-4a70-a1ec-a54e501ad280"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("a1fb663b-c77d-416d-a028-f95cccde8233"),
                            Source = "Roles",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("46099ff3-8ca5-4bff-89b2-fdd78694f8b4"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("a1fb663b-c77d-416d-a028-f95cccde8233"),
                            Source = "Users",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("a697b13a-94ae-4f63-ae13-7e59037ca7d0"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("a1fb663b-c77d-416d-a028-f95cccde8233"),
                            Source = "Permissions",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("680beffc-794d-4f8a-a2ec-db0192f4b7bb"),
                            Create = false,
                            Delete = false,
                            Read = true,
                            RoleId = new Guid("e16a381f-64d5-483f-9d27-c7d1c6d09490"),
                            Source = "Roles",
                            Update = false
                        },
                        new
                        {
                            Id = new Guid("9cc09d4b-1713-452c-bdb3-425cce258af9"),
                            Create = false,
                            Delete = false,
                            Read = true,
                            RoleId = new Guid("e16a381f-64d5-483f-9d27-c7d1c6d09490"),
                            Source = "Users",
                            Update = false
                        },
                        new
                        {
                            Id = new Guid("565353e6-b9ce-4470-886a-2f3751ed8f4a"),
                            Create = false,
                            Delete = false,
                            Read = false,
                            RoleId = new Guid("e16a381f-64d5-483f-9d27-c7d1c6d09490"),
                            Source = "Permissions",
                            Update = false
                        },
                        new
                        {
                            Id = new Guid("3e91ed8d-fadc-460e-abb8-08178048b67c"),
                            Read = false,
                            Source = "Roles",
                            UserId = new Guid("7c6b711f-308a-4be1-b02a-c0a3eba36625")
                        },
                        new
                        {
                            Id = new Guid("b433e09e-4348-43a6-b32b-afdad92abb7e"),
                            Read = false,
                            Source = "Users",
                            UserId = new Guid("7c6b711f-308a-4be1-b02a-c0a3eba36625")
                        },
                        new
                        {
                            Id = new Guid("061e4b2a-c7f2-4479-b7fd-97299a079062"),
                            Create = true,
                            Source = "Roles",
                            Update = true,
                            UserId = new Guid("826073a4-34be-4844-a213-5cac0df062bd")
                        },
                        new
                        {
                            Id = new Guid("c8ad6ab1-5405-470c-b94b-25d716ed0ac4"),
                            Create = true,
                            Delete = true,
                            Source = "Users",
                            Update = true,
                            UserId = new Guid("826073a4-34be-4844-a213-5cac0df062bd")
                        });
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.Property", b =>
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

                    b.ToTable("Properties");
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
                            Id = new Guid("09b195d4-c916-4df0-b045-00ef5c1f3f02"),
                            Name = "Administrator"
                        },
                        new
                        {
                            Id = new Guid("a1fb663b-c77d-416d-a028-f95cccde8233"),
                            Name = "Szef"
                        },
                        new
                        {
                            Id = new Guid("e16a381f-64d5-483f-9d27-c7d1c6d09490"),
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
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

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
                            Id = new Guid("09162196-1f86-419e-9197-fc4b574bdb8c"),
                            Email = "",
                            FirstName = "admin",
                            LastName = "",
                            Login = "admin",
                            Password = "admin",
                            PhoneNumber = "",
                            RoleId = new Guid("09b195d4-c916-4df0-b045-00ef5c1f3f02")
                        },
                        new
                        {
                            Id = new Guid("257306cb-0f7e-4774-894d-79f2a6ea97c6"),
                            Email = "k.tumiel@gmail.com",
                            FirstName = "Krzysztof",
                            LastName = "Tumiel",
                            Login = "k.tumiel",
                            Password = "",
                            PhoneNumber = "123 456 789",
                            RoleId = new Guid("a1fb663b-c77d-416d-a028-f95cccde8233")
                        },
                        new
                        {
                            Id = new Guid("56061c1a-8c17-4190-aec5-3a0ce4482504"),
                            Email = "j.kowalski@gmail.com",
                            FirstName = "Jan",
                            LastName = "Kowalski",
                            Login = "w1",
                            Password = "",
                            PhoneNumber = "+48 321 654 987",
                            RoleId = new Guid("e16a381f-64d5-483f-9d27-c7d1c6d09490")
                        },
                        new
                        {
                            Id = new Guid("7c6b711f-308a-4be1-b02a-c0a3eba36625"),
                            Email = "z.pietka@gmail.com",
                            FirstName = "Zdzisław",
                            LastName = "Piętka",
                            Login = "w2",
                            Password = "",
                            PhoneNumber = "987654321",
                            RoleId = new Guid("e16a381f-64d5-483f-9d27-c7d1c6d09490")
                        },
                        new
                        {
                            Id = new Guid("826073a4-34be-4844-a213-5cac0df062bd"),
                            Email = "m.wioslo@gmail.com",
                            FirstName = "Marek",
                            LastName = "Wiosło",
                            Login = "w3",
                            Password = "",
                            PhoneNumber = "+48 312645978",
                            RoleId = new Guid("e16a381f-64d5-483f-9d27-c7d1c6d09490")
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
                    b.HasOne("Infrastructure.Models.Domain.Property", "InspectedProperty")
                        .WithMany()
                        .HasForeignKey("InspectedPropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.Models.Domain.InspectionTask", "InspectionTask")
                        .WithMany("InspectionProtocols")
                        .HasForeignKey("InspectionTaskId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Infrastructure.Models.Domain.Resident", "Resident")
                        .WithMany()
                        .HasForeignKey("ResidentId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("InspectedProperty");

                    b.Navigation("InspectionTask");

                    b.Navigation("Resident");
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.InspectionTask", b =>
                {
                    b.HasOne("Infrastructure.Models.Domain.Building", "Building")
                        .WithMany()
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Infrastructure.Models.Domain.User", "TaskDelegator")
                        .WithMany()
                        .HasForeignKey("TaskDelegatorId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Building");

                    b.Navigation("TaskDelegator");
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

            modelBuilder.Entity("Infrastructure.Models.Domain.Property", b =>
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

            modelBuilder.Entity("Infrastructure.Models.Domain.PropertyManager", b =>
                {
                    b.HasOne("Infrastructure.Models.Domain.FullAddress", "FullAddress")
                        .WithMany()
                        .HasForeignKey("FullAddressId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("FullAddress");
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
