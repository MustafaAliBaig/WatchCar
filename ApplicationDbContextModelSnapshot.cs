﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WatchCar.Data;

#nullable disable

namespace WatchCar.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WatchCar.Models.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarId"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("ManufacturerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("lenght")
                        .HasColumnType("int");

                    b.HasKey("CarId");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("NewToy");

                    b.HasData(
                        new
                        {
                            CarId = 1,
                            Color = "White",
                            CreatedDate = new DateTime(2024, 2, 8, 18, 45, 33, 312, DateTimeKind.Local).AddTicks(2466),
                            IsDeleted = false,
                            ManufacturerId = 1,
                            Name = "Corola",
                            Rate = 20000.0,
                            UpdatedDate = new DateTime(2024, 2, 8, 18, 45, 33, 312, DateTimeKind.Local).AddTicks(2525),
                            lenght = 10
                        },
                        new
                        {
                            CarId = 2,
                            Color = "White",
                            CreatedDate = new DateTime(2024, 2, 8, 18, 45, 33, 312, DateTimeKind.Local).AddTicks(2529),
                            IsDeleted = false,
                            ManufacturerId = 2,
                            Name = "Civic",
                            Rate = 23000.0,
                            UpdatedDate = new DateTime(2024, 2, 8, 18, 45, 33, 312, DateTimeKind.Local).AddTicks(2530),
                            lenght = 11
                        },
                        new
                        {
                            CarId = 3,
                            Color = "Black",
                            CreatedDate = new DateTime(2024, 2, 8, 18, 45, 33, 312, DateTimeKind.Local).AddTicks(2533),
                            IsDeleted = false,
                            ManufacturerId = 3,
                            Name = "Golf GT",
                            Rate = 10000.0,
                            UpdatedDate = new DateTime(2024, 2, 8, 18, 45, 33, 312, DateTimeKind.Local).AddTicks(2534),
                            lenght = 9
                        },
                        new
                        {
                            CarId = 4,
                            Color = "Gold",
                            CreatedDate = new DateTime(2024, 2, 8, 18, 45, 33, 312, DateTimeKind.Local).AddTicks(2570),
                            IsDeleted = false,
                            ManufacturerId = 4,
                            Name = "BMW Series 3",
                            Rate = 30000.0,
                            UpdatedDate = new DateTime(2024, 2, 8, 18, 45, 33, 312, DateTimeKind.Local).AddTicks(2571),
                            lenght = 8
                        },
                        new
                        {
                            CarId = 5,
                            Color = "Blue",
                            CreatedDate = new DateTime(2024, 2, 8, 18, 45, 33, 312, DateTimeKind.Local).AddTicks(2573),
                            IsDeleted = false,
                            ManufacturerId = 5,
                            Name = "Accent",
                            Rate = 40000.0,
                            UpdatedDate = new DateTime(2024, 2, 8, 18, 45, 33, 312, DateTimeKind.Local).AddTicks(2574),
                            lenght = 12
                        });
                });

            modelBuilder.Entity("WatchCar.Models.Manufacturer", b =>
                {
                    b.Property<int>("ManufacturerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ManufacturerId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ManufacturerId");

                    b.ToTable("Manufacturers");

                    b.HasData(
                        new
                        {
                            ManufacturerId = 1,
                            Name = "Toyota"
                        },
                        new
                        {
                            ManufacturerId = 2,
                            Name = "Honda"
                        },
                        new
                        {
                            ManufacturerId = 3,
                            Name = "Volkswagen"
                        },
                        new
                        {
                            ManufacturerId = 4,
                            Name = "BMW"
                        },
                        new
                        {
                            ManufacturerId = 5,
                            Name = "Hyundi"
                        });
                });

            modelBuilder.Entity("WatchCar.Models.Car", b =>
                {
                    b.HasOne("WatchCar.Models.Manufacturer", "Manufacturer")
                        .WithMany("Cars")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("WatchCar.Models.Manufacturer", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}