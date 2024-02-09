using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WatchCar.Migrations
{
    /// <inheritdoc />
    public partial class SeedUpdatetoManufacturer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NewToy",
                keyColumn: "CarId",
                keyValue: 1);

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
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "NewToy",
                keyColumn: "CarId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 23, 19, 45, 725, DateTimeKind.Local).AddTicks(5787), new DateTime(2024, 2, 7, 23, 19, 45, 725, DateTimeKind.Local).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "NewToy",
                keyColumn: "CarId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 23, 19, 45, 725, DateTimeKind.Local).AddTicks(5832), new DateTime(2024, 2, 7, 23, 19, 45, 725, DateTimeKind.Local).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "NewToy",
                keyColumn: "CarId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 23, 19, 45, 725, DateTimeKind.Local).AddTicks(5835), new DateTime(2024, 2, 7, 23, 19, 45, 725, DateTimeKind.Local).AddTicks(5836) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "ManufacturerId", "Name" },
                values: new object[,]
                {
                    { 1, "Toyota" },
                    { 5, "Hyundi" }
                });

            migrationBuilder.UpdateData(
                table: "NewToy",
                keyColumn: "CarId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 22, 54, 48, 690, DateTimeKind.Local).AddTicks(3372), new DateTime(2024, 2, 7, 22, 54, 48, 690, DateTimeKind.Local).AddTicks(3373) });

            migrationBuilder.UpdateData(
                table: "NewToy",
                keyColumn: "CarId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 22, 54, 48, 690, DateTimeKind.Local).AddTicks(3376), new DateTime(2024, 2, 7, 22, 54, 48, 690, DateTimeKind.Local).AddTicks(3377) });

            migrationBuilder.UpdateData(
                table: "NewToy",
                keyColumn: "CarId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 22, 54, 48, 690, DateTimeKind.Local).AddTicks(3378), new DateTime(2024, 2, 7, 22, 54, 48, 690, DateTimeKind.Local).AddTicks(3379) });

            migrationBuilder.InsertData(
                table: "NewToy",
                columns: new[] { "CarId", "Color", "CreatedDate", "IsDeleted", "ManufacturerId", "Name", "Rate", "UpdatedDate", "lenght" },
                values: new object[,]
                {
                    { 1, "White", new DateTime(2024, 2, 7, 22, 54, 48, 690, DateTimeKind.Local).AddTicks(3330), false, 1, "Corola", 20000.0, new DateTime(2024, 2, 7, 22, 54, 48, 690, DateTimeKind.Local).AddTicks(3369), 10 },
                    { 5, "Blue", new DateTime(2024, 2, 7, 22, 54, 48, 690, DateTimeKind.Local).AddTicks(3381), false, 5, "Accent", 40000.0, new DateTime(2024, 2, 7, 22, 54, 48, 690, DateTimeKind.Local).AddTicks(3382), 12 }
                });
        }
    }
}
