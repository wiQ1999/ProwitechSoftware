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
    [Migration("20221014082428_building-address-change")]
    partial class buildingaddresschange
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
                        .HasColumnType("nvarchar(max)");

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
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double?>("Latitude")
                        .HasColumnType("float");

                    b.Property<double?>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("BuildingAddresses");
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.ContactInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FullAddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FullAddressId");

                    b.ToTable("ContactInfos");
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.FullAddress", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BuildingAddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("LocalInfoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BuildingAddressId");

                    b.HasIndex("LocalInfoId");

                    b.ToTable("FullAddresses");
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.Local", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BuildingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LocalInfoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BuildingId");

                    b.HasIndex("LocalInfoId");

                    b.ToTable("Locals");
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.LocalInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LocalNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StaircaseNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LocalInfos");
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

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Read")
                        .HasColumnType("bit");

                    b.Property<Guid?>("RoleId")
                        .HasColumnType("uniqueidentifier");

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
                            Id = new Guid("72cef907-1410-48a7-a623-3cf4d0cb33e2"),
                            Create = true,
                            Delete = true,
                            Name = "Role",
                            Read = true,
                            RoleId = new Guid("98e5e09f-4f4d-4076-b4b8-23f335cd0205"),
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("c65cdb65-a414-40bb-9d5e-9c9e01bec012"),
                            Create = true,
                            Delete = true,
                            Name = "Użytkownicy",
                            Read = true,
                            RoleId = new Guid("98e5e09f-4f4d-4076-b4b8-23f335cd0205"),
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("114183a3-3b33-418d-adba-d1831bdf51b5"),
                            Create = true,
                            Delete = true,
                            Name = "Role",
                            Read = true,
                            RoleId = new Guid("2437a73f-293e-4c29-b8e0-dc8dff0a1673"),
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("b47ad0a8-10ee-4aee-a509-e544e47ced7b"),
                            Create = true,
                            Delete = true,
                            Name = "Użytkownicy",
                            Read = true,
                            RoleId = new Guid("2437a73f-293e-4c29-b8e0-dc8dff0a1673"),
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("9285c37b-f3eb-4d69-9541-5bdc450bec4d"),
                            Create = false,
                            Delete = false,
                            Name = "Role",
                            Read = false,
                            RoleId = new Guid("1b2900a3-32ca-439e-b89e-2d562d1f982d"),
                            Update = false
                        },
                        new
                        {
                            Id = new Guid("fbb54224-f1b1-4650-bbd7-decc59b73048"),
                            Create = false,
                            Delete = false,
                            Name = "Użytkownicy",
                            Read = false,
                            RoleId = new Guid("1b2900a3-32ca-439e-b89e-2d562d1f982d"),
                            Update = false
                        },
                        new
                        {
                            Id = new Guid("d22fc7c2-485d-4c8e-94ae-a541468dad17"),
                            Create = false,
                            Delete = false,
                            Name = "Role",
                            Read = false,
                            RoleId = new Guid("7fb295a8-9b81-4649-a6b5-4a414843cb74"),
                            Update = false
                        },
                        new
                        {
                            Id = new Guid("21e61e4e-249b-40f4-9971-65188e70ab47"),
                            Create = false,
                            Delete = false,
                            Name = "Użytkownicy",
                            Read = false,
                            RoleId = new Guid("7fb295a8-9b81-4649-a6b5-4a414843cb74"),
                            Update = false
                        },
                        new
                        {
                            Id = new Guid("95304285-578f-45a6-973f-63b7765bed1a"),
                            Name = "Role",
                            Read = true,
                            UserId = new Guid("3d50d7cf-8e0d-4e85-8e34-fadb38d1ea41")
                        },
                        new
                        {
                            Id = new Guid("40995710-42a5-4535-b89b-bc5de6525c43"),
                            Name = "Użytkownicy",
                            Read = true,
                            UserId = new Guid("3d50d7cf-8e0d-4e85-8e34-fadb38d1ea41")
                        },
                        new
                        {
                            Id = new Guid("8b4315d0-46cc-47e3-85eb-f6184ce218f4"),
                            Name = "Użytkownicy",
                            Read = true,
                            Update = true,
                            UserId = new Guid("d566f586-0737-4f32-bd51-a2be611dc795")
                        });
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.Property", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FullAddressId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("FullAddressId");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.PropertyManager", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ContactInfoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContactInfoId");

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

                    b.Property<Guid?>("LocalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LocalId");

                    b.ToTable("Residents");
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("98e5e09f-4f4d-4076-b4b8-23f335cd0205"),
                            Name = "Administrator"
                        },
                        new
                        {
                            Id = new Guid("2437a73f-293e-4c29-b8e0-dc8dff0a1673"),
                            Name = "Szef"
                        },
                        new
                        {
                            Id = new Guid("1b2900a3-32ca-439e-b89e-2d562d1f982d"),
                            Name = "Pracownik"
                        },
                        new
                        {
                            Id = new Guid("7fb295a8-9b81-4649-a6b5-4a414843cb74"),
                            Name = "Praktykant"
                        });
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("09b85e27-5b85-4fb9-8725-4323de14404a"),
                            Email = "",
                            FirstName = "admin",
                            LastName = "",
                            Login = "admin",
                            Password = "admin",
                            PhoneNumber = "",
                            RoleId = new Guid("98e5e09f-4f4d-4076-b4b8-23f335cd0205")
                        },
                        new
                        {
                            Id = new Guid("86db0a4d-4164-495f-9eb5-b6043f55585e"),
                            Email = "k.tumiel@gmail.com",
                            FirstName = "Krzysztof",
                            LastName = "Tumiel",
                            Login = "k.tumiel",
                            Password = "",
                            PhoneNumber = "123 456 789",
                            RoleId = new Guid("2437a73f-293e-4c29-b8e0-dc8dff0a1673")
                        },
                        new
                        {
                            Id = new Guid("c5fb40f3-1191-49e7-91ec-3fa07471bd8b"),
                            Email = "j.kowalski@gmail.com",
                            FirstName = "Jan",
                            LastName = "Kowalski",
                            Login = "w1",
                            Password = "",
                            PhoneNumber = "+48 321 654 987",
                            RoleId = new Guid("1b2900a3-32ca-439e-b89e-2d562d1f982d")
                        },
                        new
                        {
                            Id = new Guid("3d50d7cf-8e0d-4e85-8e34-fadb38d1ea41"),
                            Email = "z.pietka@gmail.com",
                            FirstName = "Zdzisław",
                            LastName = "Piętka",
                            Login = "w2",
                            Password = "",
                            PhoneNumber = "987654321",
                            RoleId = new Guid("1b2900a3-32ca-439e-b89e-2d562d1f982d")
                        },
                        new
                        {
                            Id = new Guid("d566f586-0737-4f32-bd51-a2be611dc795"),
                            Email = "m.wioslo@gmail.com",
                            FirstName = "Marek",
                            LastName = "Wiosło",
                            Login = "w3",
                            Password = "",
                            PhoneNumber = "+48 312645978",
                            RoleId = new Guid("1b2900a3-32ca-439e-b89e-2d562d1f982d")
                        },
                        new
                        {
                            Id = new Guid("72b0214b-748d-4a2a-a3c9-609595f2ec37"),
                            Email = "b.smyk@gmail.com",
                            FirstName = "Bartosz",
                            LastName = "Smyk",
                            Login = "a1",
                            Password = "",
                            PhoneNumber = "213-546-879",
                            RoleId = new Guid("7fb295a8-9b81-4649-a6b5-4a414843cb74")
                        });
                });

            modelBuilder.Entity("PropertyResident", b =>
                {
                    b.Property<Guid>("PropertiesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ResidentsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PropertiesId", "ResidentsId");

                    b.HasIndex("ResidentsId");

                    b.ToTable("PropertyResident");
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
                        .HasForeignKey("PropertyManagerId");

                    b.Navigation("BuildingAddress");

                    b.Navigation("PropertyManager");
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.ContactInfo", b =>
                {
                    b.HasOne("Infrastructure.Models.Domain.FullAddress", "FullAddress")
                        .WithMany()
                        .HasForeignKey("FullAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FullAddress");
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.FullAddress", b =>
                {
                    b.HasOne("Infrastructure.Models.Domain.BuildingAddress", "BuildingAddress")
                        .WithMany()
                        .HasForeignKey("BuildingAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.Models.Domain.LocalInfo", "LocalInfo")
                        .WithMany()
                        .HasForeignKey("LocalInfoId");

                    b.Navigation("BuildingAddress");

                    b.Navigation("LocalInfo");
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.Local", b =>
                {
                    b.HasOne("Infrastructure.Models.Domain.Building", "Building")
                        .WithMany("Locals")
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.Models.Domain.LocalInfo", "LocalInfo")
                        .WithMany()
                        .HasForeignKey("LocalInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Building");

                    b.Navigation("LocalInfo");
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.Permission", b =>
                {
                    b.HasOne("Infrastructure.Models.Domain.Role", "Role")
                        .WithMany("Permissions")
                        .HasForeignKey("RoleId");

                    b.HasOne("Infrastructure.Models.Domain.User", "User")
                        .WithMany("Permissions")
                        .HasForeignKey("UserId");

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.Property", b =>
                {
                    b.HasOne("Infrastructure.Models.Domain.FullAddress", "FullAddress")
                        .WithMany()
                        .HasForeignKey("FullAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FullAddress");
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.PropertyManager", b =>
                {
                    b.HasOne("Infrastructure.Models.Domain.ContactInfo", "Contact")
                        .WithMany()
                        .HasForeignKey("ContactInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contact");
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.Resident", b =>
                {
                    b.HasOne("Infrastructure.Models.Domain.Local", null)
                        .WithMany("Residents")
                        .HasForeignKey("LocalId");
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.User", b =>
                {
                    b.HasOne("Infrastructure.Models.Domain.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("PropertyResident", b =>
                {
                    b.HasOne("Infrastructure.Models.Domain.Property", null)
                        .WithMany()
                        .HasForeignKey("PropertiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.Models.Domain.Resident", null)
                        .WithMany()
                        .HasForeignKey("ResidentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.Building", b =>
                {
                    b.Navigation("Locals");
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.Local", b =>
                {
                    b.Navigation("Residents");
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
