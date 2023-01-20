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
    [Migration("20230118104636_inspection-protocol-names-changes-and-resident-nullable")]
    partial class inspectionprotocolnameschangesandresidentnullable
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

                    b.Property<string>("A_01_Gazomierz_umiejscowienie")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A_04_Gazomierz_usytuowanie_w_stosunku_do_1_go_odbiornika")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A_05_Gazomierz_usytuowanie_w_stosunku_do_licznika_energii_elektr")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A_06_Gazomierz_kurek_przed_gazomierzem")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A_10_Przewody_przebieg_inst_gaz_przez_pokoje")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A_11_Przewody_pion_inst_gaz_w_mieszkaniu")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A_12_Prawidlowosc_kuchenka_gazowa_typ")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A_13_Prawidlowosc_kuchenka_gazowa_stan")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A_14_Prawidlowosc_kuchenka_gazowa_podlaczenie_rodzaj")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A_15_Prawidlowosc_kuchenka_gazowa_podlaczenie_stan")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A_16_Prawidlowosc_kuchenka_gazowa_kurek_odcinajacy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A_17_Prawidlowosc_kuchenka_gazowa_odleglosc_od_okna")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A_18_Prawidlowosc_gazowy_podgrzewacz_cwu_stan")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A_19_Prawidlowosc_gazowy_podgrzewacz_cwu_kurek_odcinajacy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A_20_Prawidlowosc_gazowy_podgrzewacz_cwu_rura_spalinowa")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A_21_Prawidlowosc_terma_gazowa_stan")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A_22_Prawidlowosc_terma_gazowa_kurek_odcinajacy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A_23_Prawidlowosc_terma_gazowa_rura_spalinowa")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A_24_Prawidlowosc_kociol_co_z_kurkiem_i_rura")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A_25_Kubatura_warunku_techniczne")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("A_32_Wyniki_stan_szczelnosci")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("B_A_02_Gazomierz_szafka_wentylowana")
                        .HasColumnType("bit");

                    b.Property<bool>("B_A_03_Gazomierz_szczelnosc")
                        .HasColumnType("bit");

                    b.Property<bool>("B_A_26_Wentylacja_kuchnia")
                        .HasColumnType("bit");

                    b.Property<bool>("B_A_27_Wentylacja_lazienka")
                        .HasColumnType("bit");

                    b.Property<bool>("B_A_28_Wentylacja_inne_pomieszczenia")
                        .HasColumnType("bit");

                    b.Property<bool>("B_A_29_Wentylacja_nawiew_kuchnia")
                        .HasColumnType("bit");

                    b.Property<bool>("B_A_30_Wentylacja_nawiew_lazienka")
                        .HasColumnType("bit");

                    b.Property<bool>("B_A_31_Wentylacja_nawiew_Zet_w_pomieszczeniu_z_kotlem")
                        .HasColumnType("bit");

                    b.Property<bool>("B_A_33_Wyniki_instalacja_wymaga_usuniecia_nieszczelnosci")
                        .HasColumnType("bit");

                    b.Property<bool>("B_A_34_Propan_butan")
                        .HasColumnType("bit");

                    b.Property<string>("Inne_uwagi")
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

                    b.Property<string>("M_A_07_Przewody_rodzaj")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("M_A_08_Przewody_przebieg")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("M_A_09_Przewody_sposob_prowadzenia")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ResidentId")
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
                            Id = new Guid("0121c463-8d68-4642-8d0c-6ef43582ecbe"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("6a65b949-2315-47c9-ad95-346da2d53f12"),
                            Source = "Roles",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("a4eb82d0-0e52-40c3-930f-f53cf8cf6a06"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("6a65b949-2315-47c9-ad95-346da2d53f12"),
                            Source = "Users",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("d2a2de05-4ad6-4bf4-afb7-c136a6faf4a1"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("6a65b949-2315-47c9-ad95-346da2d53f12"),
                            Source = "Permissions",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("80c5fef8-8dd4-4075-b928-8ea5f50ab69b"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("dd568b8e-b7da-4f14-955f-c5eac50cc0bb"),
                            Source = "Roles",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("f45a0704-2d96-4d42-8b9c-2888b77e2471"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("dd568b8e-b7da-4f14-955f-c5eac50cc0bb"),
                            Source = "Users",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("e56e9de0-4c51-4987-9906-1f17f9a90347"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("dd568b8e-b7da-4f14-955f-c5eac50cc0bb"),
                            Source = "Permissions",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("b5598a5b-bf2d-42e0-8018-c9f4f1dff513"),
                            Create = false,
                            Delete = false,
                            Read = true,
                            RoleId = new Guid("20775d77-1fa9-4203-80bc-27dd8851653f"),
                            Source = "Roles",
                            Update = false
                        },
                        new
                        {
                            Id = new Guid("c63451fd-43ad-4567-b0ef-247227b743aa"),
                            Create = false,
                            Delete = false,
                            Read = true,
                            RoleId = new Guid("20775d77-1fa9-4203-80bc-27dd8851653f"),
                            Source = "Users",
                            Update = false
                        },
                        new
                        {
                            Id = new Guid("769dc45b-7b8d-4bc8-a14a-f48c3c2377eb"),
                            Create = false,
                            Delete = false,
                            Read = false,
                            RoleId = new Guid("20775d77-1fa9-4203-80bc-27dd8851653f"),
                            Source = "Permissions",
                            Update = false
                        },
                        new
                        {
                            Id = new Guid("c56efdc1-39e9-46ac-90a3-7953983f0f05"),
                            Read = false,
                            Source = "Roles",
                            UserId = new Guid("8aaf9a0d-e8e9-487d-a709-f5a1f8071c9d")
                        },
                        new
                        {
                            Id = new Guid("429c9b29-d931-4f31-90de-515a8e6d2409"),
                            Read = false,
                            Source = "Users",
                            UserId = new Guid("8aaf9a0d-e8e9-487d-a709-f5a1f8071c9d")
                        },
                        new
                        {
                            Id = new Guid("5d6a288c-d19d-4f65-a329-33bd1633dbbb"),
                            Create = true,
                            Source = "Roles",
                            Update = true,
                            UserId = new Guid("912a150c-d0f8-4dbb-8665-1ae96fa1b6f9")
                        },
                        new
                        {
                            Id = new Guid("3bd24489-0d88-402f-aa0e-09c817453d34"),
                            Create = true,
                            Delete = true,
                            Source = "Users",
                            Update = true,
                            UserId = new Guid("912a150c-d0f8-4dbb-8665-1ae96fa1b6f9")
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
                            Id = new Guid("6a65b949-2315-47c9-ad95-346da2d53f12"),
                            Name = "Administrator"
                        },
                        new
                        {
                            Id = new Guid("dd568b8e-b7da-4f14-955f-c5eac50cc0bb"),
                            Name = "Szef"
                        },
                        new
                        {
                            Id = new Guid("20775d77-1fa9-4203-80bc-27dd8851653f"),
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
                            Id = new Guid("0a99d6d7-d83e-4462-8499-5cfb0851ce41"),
                            Email = "",
                            FirstName = "admin",
                            LastName = "",
                            Login = "admin",
                            Password = "AQAAAAIAAYagAAAAEK0/uJTjFgEVBhCOR7z2fpDJz4PyMHYtv6iIfrD8YNs5NnfHanVjqq6wLy1SJBUDmA==",
                            PhoneNumber = "",
                            RoleId = new Guid("6a65b949-2315-47c9-ad95-346da2d53f12")
                        },
                        new
                        {
                            Id = new Guid("db3c6ee3-c6fc-483a-9aa4-1fdcb95b1b91"),
                            Email = "k.tumiel@gmail.com",
                            FirstName = "Krzysztof",
                            LastName = "Tumiel",
                            Login = "boss",
                            Password = "AQAAAAIAAYagAAAAEL15rbVeeBcG3d8pTfnueiffuqADQhlkJnlEp49zW1Ts5KPEFG00aYKWWqUl4/WdWA==",
                            PhoneNumber = "123 456 789",
                            RoleId = new Guid("dd568b8e-b7da-4f14-955f-c5eac50cc0bb")
                        },
                        new
                        {
                            Id = new Guid("21d8200b-2842-4934-8a8a-3f1520cf58e1"),
                            Email = "j.kowalski@gmail.com",
                            FirstName = "Jan",
                            LastName = "Kowalski",
                            Login = "w1",
                            Password = "AQAAAAIAAYagAAAAEGYhjSmk2FBayRXsR/z3q4DE4u0cHuQwHUu41wGRllmUOlV+qN/IEVou6i13sv25xQ==",
                            PhoneNumber = "+48 321 654 987",
                            RoleId = new Guid("20775d77-1fa9-4203-80bc-27dd8851653f")
                        },
                        new
                        {
                            Id = new Guid("8aaf9a0d-e8e9-487d-a709-f5a1f8071c9d"),
                            Email = "z.pietka@gmail.com",
                            FirstName = "Zdzisław",
                            LastName = "Piętka",
                            Login = "w2",
                            Password = "AQAAAAIAAYagAAAAEIeDjBTzRBSzN/T6MkjdcHeQhdYHidoJ/sHZiwLVSe3UMubyRLIr3pozyC09q5immQ==",
                            PhoneNumber = "987654321",
                            RoleId = new Guid("20775d77-1fa9-4203-80bc-27dd8851653f")
                        },
                        new
                        {
                            Id = new Guid("912a150c-d0f8-4dbb-8665-1ae96fa1b6f9"),
                            Email = "m.wioslo@gmail.com",
                            FirstName = "Marek",
                            LastName = "Wiosło",
                            Login = "w3",
                            Password = "AQAAAAIAAYagAAAAEORz6pgWpZR7xP7/TqIw6vDtfmTecLsZH5azAyufkkzNMge+M8YFs9N8kVNtnDOrpA==",
                            PhoneNumber = "+48 312645978",
                            RoleId = new Guid("20775d77-1fa9-4203-80bc-27dd8851653f")
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
                        .OnDelete(DeleteBehavior.SetNull);

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