﻿// <auto-generated />
using System;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ProwitechDbContext))]
    partial class ProwitechDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("Infrastructure.Models.Domain.FullAddress", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BuildingAddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LocalNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StaircaseNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BuildingAddressId");

                    b.ToTable("FullAddresses");
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.Local", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BuildingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FullAddressId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BuildingId");

                    b.HasIndex("FullAddressId");

                    b.ToTable("Locals");
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
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

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
                            Id = new Guid("0c5dfa11-b44b-4213-9bee-bb21dceb515a"),
                            Create = true,
                            Delete = true,
                            Name = "Role",
                            Read = true,
                            RoleId = new Guid("9c4ea6ed-536d-438a-89d0-b4cc34fc8890"),
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("647332b5-d48b-4f9a-831a-09e14b29b46d"),
                            Create = true,
                            Delete = true,
                            Name = "Użytkownicy",
                            Read = true,
                            RoleId = new Guid("9c4ea6ed-536d-438a-89d0-b4cc34fc8890"),
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("5a8eb5ab-8de2-4717-b73b-2a939f52c47a"),
                            Create = true,
                            Delete = true,
                            Name = "Role",
                            Read = true,
                            RoleId = new Guid("39f60509-938b-456b-ba97-42de725d7f5f"),
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("d209c7ed-83ef-4108-9162-d2d36803eda8"),
                            Create = true,
                            Delete = true,
                            Name = "Użytkownicy",
                            Read = true,
                            RoleId = new Guid("39f60509-938b-456b-ba97-42de725d7f5f"),
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("ee77d507-3f87-41a8-96d2-5f8051b9427f"),
                            Create = false,
                            Delete = false,
                            Name = "Role",
                            Read = false,
                            RoleId = new Guid("3bc258d8-7757-4b5a-8cf4-310bde3ee014"),
                            Update = false
                        },
                        new
                        {
                            Id = new Guid("aa21f059-ca7e-4f4a-b63f-34681307f10e"),
                            Create = false,
                            Delete = false,
                            Name = "Użytkownicy",
                            Read = false,
                            RoleId = new Guid("3bc258d8-7757-4b5a-8cf4-310bde3ee014"),
                            Update = false
                        },
                        new
                        {
                            Id = new Guid("9ce17fb3-f4ce-431c-ab7c-73c817aafdff"),
                            Create = false,
                            Delete = false,
                            Name = "Role",
                            Read = false,
                            RoleId = new Guid("dee9b56e-f750-4083-9803-797a7484d968"),
                            Update = false
                        },
                        new
                        {
                            Id = new Guid("8d47d0ad-e7ba-43c1-bd66-61694c910aa0"),
                            Create = false,
                            Delete = false,
                            Name = "Użytkownicy",
                            Read = false,
                            RoleId = new Guid("dee9b56e-f750-4083-9803-797a7484d968"),
                            Update = false
                        },
                        new
                        {
                            Id = new Guid("87152692-cd3c-4ec4-b533-036a487cb61a"),
                            Name = "Role",
                            Read = true,
                            UserId = new Guid("44a8b70e-a33c-4781-9483-5050b41be7f3")
                        },
                        new
                        {
                            Id = new Guid("be7c3d11-29ce-41d0-adb9-2de9cf152944"),
                            Name = "Użytkownicy",
                            Read = true,
                            UserId = new Guid("44a8b70e-a33c-4781-9483-5050b41be7f3")
                        },
                        new
                        {
                            Id = new Guid("5a766df3-f9a3-4179-8c2e-56dac6dcb475"),
                            Name = "Użytkownicy",
                            Read = true,
                            Update = true,
                            UserId = new Guid("1409b4f5-2271-40ca-bb12-3cac65631c87")
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
                            Id = new Guid("9c4ea6ed-536d-438a-89d0-b4cc34fc8890"),
                            Name = "Administrator"
                        },
                        new
                        {
                            Id = new Guid("39f60509-938b-456b-ba97-42de725d7f5f"),
                            Name = "Szef"
                        },
                        new
                        {
                            Id = new Guid("3bc258d8-7757-4b5a-8cf4-310bde3ee014"),
                            Name = "Pracownik"
                        },
                        new
                        {
                            Id = new Guid("dee9b56e-f750-4083-9803-797a7484d968"),
                            Name = "Praktykant"
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
                            Id = new Guid("5be3b827-bc59-4ea6-96d4-3a0a7f7454fe"),
                            Email = "",
                            FirstName = "admin",
                            LastName = "",
                            Login = "admin",
                            Password = "admin",
                            PhoneNumber = "",
                            RoleId = new Guid("9c4ea6ed-536d-438a-89d0-b4cc34fc8890")
                        },
                        new
                        {
                            Id = new Guid("fa2e26f7-83ad-4ce2-9254-57e8d72e2e89"),
                            Email = "k.tumiel@gmail.com",
                            FirstName = "Krzysztof",
                            LastName = "Tumiel",
                            Login = "k.tumiel",
                            Password = "",
                            PhoneNumber = "123 456 789",
                            RoleId = new Guid("39f60509-938b-456b-ba97-42de725d7f5f")
                        },
                        new
                        {
                            Id = new Guid("0e0c73a6-d936-4b6f-abb9-10e45b2c39df"),
                            Email = "j.kowalski@gmail.com",
                            FirstName = "Jan",
                            LastName = "Kowalski",
                            Login = "w1",
                            Password = "",
                            PhoneNumber = "+48 321 654 987",
                            RoleId = new Guid("3bc258d8-7757-4b5a-8cf4-310bde3ee014")
                        },
                        new
                        {
                            Id = new Guid("44a8b70e-a33c-4781-9483-5050b41be7f3"),
                            Email = "z.pietka@gmail.com",
                            FirstName = "Zdzisław",
                            LastName = "Piętka",
                            Login = "w2",
                            Password = "",
                            PhoneNumber = "987654321",
                            RoleId = new Guid("3bc258d8-7757-4b5a-8cf4-310bde3ee014")
                        },
                        new
                        {
                            Id = new Guid("1409b4f5-2271-40ca-bb12-3cac65631c87"),
                            Email = "m.wioslo@gmail.com",
                            FirstName = "Marek",
                            LastName = "Wiosło",
                            Login = "w3",
                            Password = "",
                            PhoneNumber = "+48 312645978",
                            RoleId = new Guid("3bc258d8-7757-4b5a-8cf4-310bde3ee014")
                        },
                        new
                        {
                            Id = new Guid("726fb755-5552-46bd-b011-e84adcb1d640"),
                            Email = "b.smyk@gmail.com",
                            FirstName = "Bartosz",
                            LastName = "Smyk",
                            Login = "a1",
                            Password = "",
                            PhoneNumber = "213-546-879",
                            RoleId = new Guid("dee9b56e-f750-4083-9803-797a7484d968")
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

            modelBuilder.Entity("Infrastructure.Models.Domain.FullAddress", b =>
                {
                    b.HasOne("Infrastructure.Models.Domain.BuildingAddress", "BuildingAddress")
                        .WithMany()
                        .HasForeignKey("BuildingAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BuildingAddress");
                });

            modelBuilder.Entity("Infrastructure.Models.Domain.Local", b =>
                {
                    b.HasOne("Infrastructure.Models.Domain.Building", "Building")
                        .WithMany("Locals")
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.Models.Domain.FullAddress", "FullAddress")
                        .WithMany()
                        .HasForeignKey("FullAddressId");

                    b.Navigation("Building");

                    b.Navigation("FullAddress");
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
                    b.HasOne("Infrastructure.Models.Domain.FullAddress", "FullAddress")
                        .WithMany()
                        .HasForeignKey("FullAddressId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("FullAddress");
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
