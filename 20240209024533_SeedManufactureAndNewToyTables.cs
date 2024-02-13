using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WatchCar.Migrations
{
    /// <inheritdoc />
    public partial class SeedManufactureAndNewToyTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "ManufacturerId", "Name" },
                values: new object[,]
                {
                    { 1, "Toyota" },
                    { 2, "Honda" },
                    { 3, "Volkswagen" },
                    { 4, "BMW" },
                    { 5, "Hyundi" }
                });

            migrationBuilder.InsertData(
                table: "NewToy",
                columns: new[] { "CarId", "Color", "CreatedDate", "IsDeleted", "ManufacturerId", "Name", "Rate", "UpdatedDate", "lenght" },
                values: new object[,]
                {
                    { 1, "White", new DateTime(2024, 2, 8, 18, 45, 33, 312, DateTimeKind.Local).AddTicks(2466), false, 1, "Corola", 20000.0, new DateTime(2024, 2, 8, 18, 45, 33, 312, DateTimeKind.Local).AddTicks(2525), 10 },
                    { 2, "White", new DateTime(2024, 2, 8, 18, 45, 33, 312, DateTimeKind.Local).AddTicks(2529), false, 2, "Civic", 23000.0, new DateTime(2024, 2, 8, 18, 45, 33, 312, DateTimeKind.Local).AddTicks(2530), 11 },
                    { 3, "Black", new DateTime(2024, 2, 8, 18, 45, 33, 312, DateTimeKind.Local).AddTicks(2533), false, 3, "Golf GT", 10000.0, new DateTime(2024, 2, 8, 18, 45, 33, 312, DateTimeKind.Local).AddTicks(2534), 9 },
                    { 4, "Gold", new DateTime(2024, 2, 8, 18, 45, 33, 312, DateTimeKind.Local).AddTicks(2570), false, 4, "BMW Series 3", 30000.0, new DateTime(2024, 2, 8, 18, 45, 33, 312, DateTimeKind.Local).AddTicks(2571), 8 },
                    { 5, "Blue", new DateTime(2024, 2, 8, 18, 45, 33, 312, DateTimeKind.Local).AddTicks(2573), false, 5, "Accent", 40000.0, new DateTime(2024, 2, 8, 18, 45, 33, 312, DateTimeKind.Local).AddTicks(2574), 12 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NewToy",
                keyColumn: "CarId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NewToy",
                keyColumn: "CarId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NewToy",
                keyColumn: "CarId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NewToy",
                keyColumn: "CarId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "NewToy",
                keyColumn: "CarId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 5);
        }
    }
}
