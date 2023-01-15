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
    [Migration("20230114223636_user-password-length-change")]
    partial class userpasswordlengthchange
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
                            Id = new Guid("5fc7a591-3fb8-441d-a529-82ece5ecafe2"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("a9a71591-a2f8-4a7b-afda-5e7fed17d121"),
                            Source = "Roles",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("8c65d9e6-02db-4aca-8759-ddde3783aae5"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("a9a71591-a2f8-4a7b-afda-5e7fed17d121"),
                            Source = "Users",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("8d9a800c-ad03-4ff5-9f77-9c3b9a0a5e8c"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("a9a71591-a2f8-4a7b-afda-5e7fed17d121"),
                            Source = "Permissions",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("14b3d37c-4c71-48e3-a097-dcf1a93c187a"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("b26fd7d6-cfee-49ca-bfce-b16f669a6e8e"),
                            Source = "Roles",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("403ab00d-7ada-471c-80cb-9649d35ff7d3"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("b26fd7d6-cfee-49ca-bfce-b16f669a6e8e"),
                            Source = "Users",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("6ab6d23f-6b4a-4b37-bacd-3088c84174f5"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("b26fd7d6-cfee-49ca-bfce-b16f669a6e8e"),
                            Source = "Permissions",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("3c0aca4a-322a-4d8a-94d9-11892e6964a7"),
                            Create = false,
                            Delete = false,
                            Read = true,
                            RoleId = new Guid("afb52745-9b0e-40d2-b1b3-830d6e4dac7c"),
                            Source = "Roles",
                            Update = false
                        },
                        new
                        {
                            Id = new Guid("89dfb983-5d0b-4a3a-9959-6bd9195f5c59"),
                            Create = false,
                            Delete = false,
                            Read = true,
                            RoleId = new Guid("afb52745-9b0e-40d2-b1b3-830d6e4dac7c"),
                            Source = "Users",
                            Update = false
                        },
                        new
                        {
                            Id = new Guid("7ef1e75b-e931-477d-aa62-6b1e0c0ec09c"),
                            Create = false,
                            Delete = false,
                            Read = false,
                            RoleId = new Guid("afb52745-9b0e-40d2-b1b3-830d6e4dac7c"),
                            Source = "Permissions",
                            Update = false
                        },
                        new
                        {
                            Id = new Guid("fd57779f-51b0-4575-98f0-19c1ca87024b"),
                            Read = false,
                            Source = "Roles",
                            UserId = new Guid("d38a07a1-3093-4817-8d35-4fc1c7313e53")
                        },
                        new
                        {
                            Id = new Guid("f2613ce9-c51e-46ad-bd22-817c8ff562f5"),
                            Read = false,
                            Source = "Users",
                            UserId = new Guid("d38a07a1-3093-4817-8d35-4fc1c7313e53")
                        },
                        new
                        {
                            Id = new Guid("afd1c69c-111d-4885-bd37-227447608c84"),
                            Create = true,
                            Source = "Roles",
                            Update = true,
                            UserId = new Guid("fdb5a6f8-4077-475e-9205-cb499b379522")
                        },
                        new
                        {
                            Id = new Guid("9f0d6f74-7f72-47df-a906-0732134a585b"),
                            Create = true,
                            Delete = true,
                            Source = "Users",
                            Update = true,
                            UserId = new Guid("fdb5a6f8-4077-475e-9205-cb499b379522")
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
                            Id = new Guid("a9a71591-a2f8-4a7b-afda-5e7fed17d121"),
                            Name = "Administrator"
                        },
                        new
                        {
                            Id = new Guid("b26fd7d6-cfee-49ca-bfce-b16f669a6e8e"),
                            Name = "Szef"
                        },
                        new
                        {
                            Id = new Guid("afb52745-9b0e-40d2-b1b3-830d6e4dac7c"),
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
                            Id = new Guid("12bf46b3-18d2-4696-bf71-bedcd379c355"),
                            Email = "",
                            FirstName = "admin",
                            LastName = "",
                            Login = "admin",
                            Password = "admin",
                            PhoneNumber = "",
                            RoleId = new Guid("a9a71591-a2f8-4a7b-afda-5e7fed17d121")
                        },
                        new
                        {
                            Id = new Guid("9d9d793d-71d0-4d28-a740-b0e49799a8c2"),
                            Email = "k.tumiel@gmail.com",
                            FirstName = "Krzysztof",
                            LastName = "Tumiel",
                            Login = "k.tumiel",
                            Password = "",
                            PhoneNumber = "123 456 789",
                            RoleId = new Guid("b26fd7d6-cfee-49ca-bfce-b16f669a6e8e")
                        },
                        new
                        {
                            Id = new Guid("44ae24ce-581b-4501-8cbe-36b45a0d9b09"),
                            Email = "j.kowalski@gmail.com",
                            FirstName = "Jan",
                            LastName = "Kowalski",
                            Login = "w1",
                            Password = "",
                            PhoneNumber = "+48 321 654 987",
                            RoleId = new Guid("afb52745-9b0e-40d2-b1b3-830d6e4dac7c")
                        },
                        new
                        {
                            Id = new Guid("d38a07a1-3093-4817-8d35-4fc1c7313e53"),
                            Email = "z.pietka@gmail.com",
                            FirstName = "Zdzisław",
                            LastName = "Piętka",
                            Login = "w2",
                            Password = "",
                            PhoneNumber = "987654321",
                            RoleId = new Guid("afb52745-9b0e-40d2-b1b3-830d6e4dac7c")
                        },
                        new
                        {
                            Id = new Guid("fdb5a6f8-4077-475e-9205-cb499b379522"),
                            Email = "m.wioslo@gmail.com",
                            FirstName = "Marek",
                            LastName = "Wiosło",
                            Login = "w3",
                            Password = "",
                            PhoneNumber = "+48 312645978",
                            RoleId = new Guid("afb52745-9b0e-40d2-b1b3-830d6e4dac7c")
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
