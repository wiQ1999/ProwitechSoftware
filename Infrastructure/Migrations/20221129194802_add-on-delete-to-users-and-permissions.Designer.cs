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
    [Migration("20221129194802_add-on-delete-to-users-and-permissions")]
    partial class addondeletetousersandpermissions
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
                            Id = new Guid("f2f8f2a8-6130-4b20-8dcf-db17aa31d193"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("ab2094a8-20c1-4523-8c5c-0bcdceebf692"),
                            Source = "Roles",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("6d4ddd78-8e35-4df0-b0b7-2a4eec2d1d1f"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("ab2094a8-20c1-4523-8c5c-0bcdceebf692"),
                            Source = "Users",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("006708ed-9f9e-49b3-ae5a-26f9c66a7685"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("ab2094a8-20c1-4523-8c5c-0bcdceebf692"),
                            Source = "Permissions",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("70c606c5-9527-48f2-a534-1eaec1134da4"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("0a5d88aa-c8a0-4f88-9bc0-ddca8c867613"),
                            Source = "Roles",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("9887634c-e710-4ed9-aab7-74857f32f264"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("0a5d88aa-c8a0-4f88-9bc0-ddca8c867613"),
                            Source = "Users",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("cf722225-b07d-4606-bd83-8321c9432dc5"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("0a5d88aa-c8a0-4f88-9bc0-ddca8c867613"),
                            Source = "Permissions",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("30f0d4a1-bc1a-43cd-978f-89770a8e7592"),
                            Create = false,
                            Delete = false,
                            Read = true,
                            RoleId = new Guid("68e410da-4162-40e9-9659-d495a1bda4a6"),
                            Source = "Roles",
                            Update = false
                        },
                        new
                        {
                            Id = new Guid("fe8efacf-2718-4047-b635-8aaa4361fa9e"),
                            Create = false,
                            Delete = false,
                            Read = true,
                            RoleId = new Guid("68e410da-4162-40e9-9659-d495a1bda4a6"),
                            Source = "Users",
                            Update = false
                        },
                        new
                        {
                            Id = new Guid("5c5230d9-0f47-464b-b790-ac8f4ac6b74e"),
                            Create = false,
                            Delete = false,
                            Read = false,
                            RoleId = new Guid("68e410da-4162-40e9-9659-d495a1bda4a6"),
                            Source = "Permissions",
                            Update = false
                        },
                        new
                        {
                            Id = new Guid("305789b5-ebe9-4833-b1bf-53b392d2ecd9"),
                            Read = false,
                            Source = "Roles",
                            UserId = new Guid("6bb5ca6e-9728-4087-a765-df7c6f5cdff8")
                        },
                        new
                        {
                            Id = new Guid("fa136fdb-bff4-4a62-8985-26fdd6c66471"),
                            Read = false,
                            Source = "Users",
                            UserId = new Guid("6bb5ca6e-9728-4087-a765-df7c6f5cdff8")
                        },
                        new
                        {
                            Id = new Guid("6aa479f5-973b-4086-89d7-ac8dfbd53960"),
                            Create = true,
                            Source = "Roles",
                            Update = true,
                            UserId = new Guid("1a75760f-eea9-4271-aa74-91003b8ee567")
                        },
                        new
                        {
                            Id = new Guid("1ef9f2e8-8661-43d3-a69c-20f32ddf1820"),
                            Create = true,
                            Delete = true,
                            Source = "Users",
                            Update = true,
                            UserId = new Guid("1a75760f-eea9-4271-aa74-91003b8ee567")
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
                            Id = new Guid("ab2094a8-20c1-4523-8c5c-0bcdceebf692"),
                            Name = "Administrator"
                        },
                        new
                        {
                            Id = new Guid("0a5d88aa-c8a0-4f88-9bc0-ddca8c867613"),
                            Name = "Szef"
                        },
                        new
                        {
                            Id = new Guid("68e410da-4162-40e9-9659-d495a1bda4a6"),
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
                            Id = new Guid("4ef086d0-4618-43bb-a1e6-3b288eb5fe71"),
                            Email = "",
                            FirstName = "admin",
                            LastName = "",
                            Login = "admin",
                            Password = "admin",
                            PhoneNumber = "",
                            RoleId = new Guid("ab2094a8-20c1-4523-8c5c-0bcdceebf692")
                        },
                        new
                        {
                            Id = new Guid("22ea0197-0e00-48ef-83db-1aeba8a4aced"),
                            Email = "k.tumiel@gmail.com",
                            FirstName = "Krzysztof",
                            LastName = "Tumiel",
                            Login = "k.tumiel",
                            Password = "",
                            PhoneNumber = "123 456 789",
                            RoleId = new Guid("0a5d88aa-c8a0-4f88-9bc0-ddca8c867613")
                        },
                        new
                        {
                            Id = new Guid("f1728813-9fba-494c-911f-1313e5150198"),
                            Email = "j.kowalski@gmail.com",
                            FirstName = "Jan",
                            LastName = "Kowalski",
                            Login = "w1",
                            Password = "",
                            PhoneNumber = "+48 321 654 987",
                            RoleId = new Guid("68e410da-4162-40e9-9659-d495a1bda4a6")
                        },
                        new
                        {
                            Id = new Guid("6bb5ca6e-9728-4087-a765-df7c6f5cdff8"),
                            Email = "z.pietka@gmail.com",
                            FirstName = "Zdzisław",
                            LastName = "Piętka",
                            Login = "w2",
                            Password = "",
                            PhoneNumber = "987654321",
                            RoleId = new Guid("68e410da-4162-40e9-9659-d495a1bda4a6")
                        },
                        new
                        {
                            Id = new Guid("1a75760f-eea9-4271-aa74-91003b8ee567"),
                            Email = "m.wioslo@gmail.com",
                            FirstName = "Marek",
                            LastName = "Wiosło",
                            Login = "w3",
                            Password = "",
                            PhoneNumber = "+48 312645978",
                            RoleId = new Guid("68e410da-4162-40e9-9659-d495a1bda4a6")
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
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.SetNull);

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
