using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WatchCar.Migrations
{
    /// <inheritdoc />
    public partial class AddManufacturersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "NewToy",
                keyColumn: "CarId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 23, 39, 7, 176, DateTimeKind.Local).AddTicks(9818), new DateTime(2024, 2, 7, 23, 39, 7, 176, DateTimeKind.Local).AddTicks(9862) });

            migrationBuilder.UpdateData(
                table: "NewToy",
                keyColumn: "CarId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 23, 39, 7, 176, DateTimeKind.Local).AddTicks(9866), new DateTime(2024, 2, 7, 23, 39, 7, 176, DateTimeKind.Local).AddTicks(9867) });

            migrationBuilder.UpdateData(
                table: "NewToy",
                keyColumn: "CarId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 23, 39, 7, 176, DateTimeKind.Local).AddTicks(9869), new DateTime(2024, 2, 7, 23, 39, 7, 176, DateTimeKind.Local).AddTicks(9870) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "NewToy",
                keyColumn: "CarId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 23, 30, 46, 328, DateTimeKind.Local).AddTicks(84), new DateTime(2024, 2, 7, 23, 30, 46, 328, DateTimeKind.Local).AddTicks(127) });

            migrationBuilder.UpdateData(
                table: "NewToy",
                keyColumn: "CarId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 23, 30, 46, 328, DateTimeKind.Local).AddTicks(130), new DateTime(2024, 2, 7, 23, 30, 46, 328, DateTimeKind.Local).AddTicks(131) });

            migrationBuilder.UpdateData(
                table: "NewToy",
                keyColumn: "CarId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 23, 30, 46, 328, DateTimeKind.Local).AddTicks(133), new DateTime(2024, 2, 7, 23, 30, 46, 328, DateTimeKind.Local).AddTicks(134) });
        }
    }
}
