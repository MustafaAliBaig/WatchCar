﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WatchCar.Data;

#nullable disable

namespace WatchCar.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240207095850_SeedWatchCarTable")]
    partial class SeedWatchCarTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.ToTable("NewToy");

                    b.HasData(
                        new
                        {
                            CarId = 1,
                            Color = "White",
                            CreatedDate = new DateTime(2024, 2, 7, 1, 58, 50, 32, DateTimeKind.Local).AddTicks(1275),
                            IsDeleted = false,
                            Name = "Honda",
                            Rate = 20000.0,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            lenght = 10
                        },
                        new
                        {
                            CarId = 2,
                            Color = "White",
                            CreatedDate = new DateTime(2024, 2, 7, 1, 58, 50, 32, DateTimeKind.Local).AddTicks(1317),
                            IsDeleted = false,
                            Name = "Toyota",
                            Rate = 23000.0,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            lenght = 11
                        },
                        new
                        {
                            CarId = 3,
                            Color = "Black",
                            CreatedDate = new DateTime(2024, 2, 7, 1, 58, 50, 32, DateTimeKind.Local).AddTicks(1319),
                            IsDeleted = false,
                            Name = "Honda Civic",
                            Rate = 10000.0,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            lenght = 9
                        },
                        new
                        {
                            CarId = 4,
                            Color = "Gold",
                            CreatedDate = new DateTime(2024, 2, 7, 1, 58, 50, 32, DateTimeKind.Local).AddTicks(1321),
                            IsDeleted = false,
                            Name = "BMW",
                            Rate = 30000.0,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            lenght = 8
                        },
                        new
                        {
                            CarId = 5,
                            Color = "Blue",
                            CreatedDate = new DateTime(2024, 2, 7, 1, 58, 50, 32, DateTimeKind.Local).AddTicks(1323),
                            IsDeleted = false,
                            Name = "Ferari",
                            Rate = 40000.0,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            lenght = 12
                        });
                });
#pragma warning restore 612, 618
        }
    }
}