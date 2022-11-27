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
                            Id = new Guid("28242013-b2e2-41ba-bf76-bd41d134dea2"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("704b2d55-84da-41b1-8cd9-df85e6b7df1a"),
                            Source = "Roles",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("639cb961-ec14-4214-b203-fe297584bd97"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("704b2d55-84da-41b1-8cd9-df85e6b7df1a"),
                            Source = "Users",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("83b78e8a-1058-4077-8e47-b7964675cc12"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("704b2d55-84da-41b1-8cd9-df85e6b7df1a"),
                            Source = "Permissions",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("d7e551a5-c64c-46a0-8ae8-9370ecf254dd"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("d44d49ea-d094-4845-aa0f-b653f1c1e673"),
                            Source = "Roles",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("5474da25-daa3-49bc-9157-358fcbe725b7"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("d44d49ea-d094-4845-aa0f-b653f1c1e673"),
                            Source = "Users",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("9f88b1c8-4906-4444-8a98-c940ef9a49c8"),
                            Create = true,
                            Delete = true,
                            Read = true,
                            RoleId = new Guid("d44d49ea-d094-4845-aa0f-b653f1c1e673"),
                            Source = "Permissions",
                            Update = true
                        },
                        new
                        {
                            Id = new Guid("672a24c1-7549-48e8-9648-0613335b12e3"),
                            Create = false,
                            Delete = false,
                            Read = true,
                            RoleId = new Guid("ef71e76d-6982-4e61-85bf-5586a9713b50"),
                            Source = "Roles",
                            Update = false
                        },
                        new
                        {
                            Id = new Guid("208fdebe-d86f-40d2-823b-3e371c0e6784"),
                            Create = false,
                            Delete = false,
                            Read = true,
                            RoleId = new Guid("ef71e76d-6982-4e61-85bf-5586a9713b50"),
                            Source = "Users",
                            Update = false
                        },
                        new
                        {
                            Id = new Guid("813c2dbd-0159-47e1-86d0-b1d490df264f"),
                            Create = false,
                            Delete = false,
                            Read = false,
                            RoleId = new Guid("ef71e76d-6982-4e61-85bf-5586a9713b50"),
                            Source = "Permissions",
                            Update = false
                        },
                        new
                        {
                            Id = new Guid("6eba63e5-6012-4db1-8efb-caa8b39fe8d5"),
                            Read = false,
                            Source = "Roles",
                            UserId = new Guid("58f488b6-f278-40b9-b4c5-60a168690f6f")
                        },
                        new
                        {
                            Id = new Guid("cdf7a2ea-bb08-4867-8e75-f1fb36db7276"),
                            Read = false,
                            Source = "Users",
                            UserId = new Guid("58f488b6-f278-40b9-b4c5-60a168690f6f")
                        },
                        new
                        {
                            Id = new Guid("f9e70775-8769-4a5e-a28e-605beebbc1d1"),
                            Create = true,
                            Source = "Roles",
                            Update = true,
                            UserId = new Guid("a76b4aa0-5f14-4c2d-9920-72fa03e14f49")
                        },
                        new
                        {
                            Id = new Guid("a962ad51-b45b-462e-8a7e-27a53044b012"),
                            Create = true,
                            Delete = true,
                            Source = "Users",
                            Update = true,
                            UserId = new Guid("a76b4aa0-5f14-4c2d-9920-72fa03e14f49")
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
                            Id = new Guid("704b2d55-84da-41b1-8cd9-df85e6b7df1a"),
                            Name = "Administrator"
                        },
                        new
                        {
                            Id = new Guid("d44d49ea-d094-4845-aa0f-b653f1c1e673"),
                            Name = "Szef"
                        },
                        new
                        {
                            Id = new Guid("ef71e76d-6982-4e61-85bf-5586a9713b50"),
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
                            Id = new Guid("4403b5dc-41f5-451d-a56c-56b41ee2f888"),
                            Email = "",
                            FirstName = "admin",
                            LastName = "",
                            Login = "admin",
                            Password = "admin",
                            PhoneNumber = "",
                            RoleId = new Guid("704b2d55-84da-41b1-8cd9-df85e6b7df1a")
                        },
                        new
                        {
                            Id = new Guid("65d80586-38ac-438b-8484-b40a42105e0b"),
                            Email = "k.tumiel@gmail.com",
                            FirstName = "Krzysztof",
                            LastName = "Tumiel",
                            Login = "k.tumiel",
                            Password = "",
                            PhoneNumber = "123 456 789",
                            RoleId = new Guid("d44d49ea-d094-4845-aa0f-b653f1c1e673")
                        },
                        new
                        {
                            Id = new Guid("0ce28c35-6eda-4f87-8377-3763d13f4277"),
                            Email = "j.kowalski@gmail.com",
                            FirstName = "Jan",
                            LastName = "Kowalski",
                            Login = "w1",
                            Password = "",
                            PhoneNumber = "+48 321 654 987",
                            RoleId = new Guid("ef71e76d-6982-4e61-85bf-5586a9713b50")
                        },
                        new
                        {
                            Id = new Guid("58f488b6-f278-40b9-b4c5-60a168690f6f"),
                            Email = "z.pietka@gmail.com",
                            FirstName = "Zdzisław",
                            LastName = "Piętka",
                            Login = "w2",
                            Password = "",
                            PhoneNumber = "987654321",
                            RoleId = new Guid("ef71e76d-6982-4e61-85bf-5586a9713b50")
                        },
                        new
                        {
                            Id = new Guid("a76b4aa0-5f14-4c2d-9920-72fa03e14f49"),
                            Email = "m.wioslo@gmail.com",
                            FirstName = "Marek",
                            LastName = "Wiosło",
                            Login = "w3",
                            Password = "",
                            PhoneNumber = "+48 312645978",
                            RoleId = new Guid("ef71e76d-6982-4e61-85bf-5586a9713b50")
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
