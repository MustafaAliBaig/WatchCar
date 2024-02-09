using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WatchCar.Migrations
{
    /// <inheritdoc />
    public partial class SeedWatchCarTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "NewToy",
                columns: new[] { "CarId", "Color", "CreatedDate", "IsDeleted", "Name", "Rate", "UpdatedDate", "lenght" },
                values: new object[,]
                {
                    { 1, "White", new DateTime(2024, 2, 7, 1, 58, 50, 32, DateTimeKind.Local).AddTicks(1275), false, "Honda", 20000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 2, "White", new DateTime(2024, 2, 7, 1, 58, 50, 32, DateTimeKind.Local).AddTicks(1317), false, "Toyota", 23000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 3, "Black", new DateTime(2024, 2, 7, 1, 58, 50, 32, DateTimeKind.Local).AddTicks(1319), false, "Honda Civic", 10000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 4, "Gold", new DateTime(2024, 2, 7, 1, 58, 50, 32, DateTimeKind.Local).AddTicks(1321), false, "BMW", 30000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 5, "Blue", new DateTime(2024, 2, 7, 1, 58, 50, 32, DateTimeKind.Local).AddTicks(1323), false, "Ferari", 40000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 }
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
        }
    }
}
