using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WatchCar.Migrations
{
    /// <inheritdoc />
    public partial class CreateManufacturersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "NewToy",
                keyColumn: "CarId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 23, 45, 2, 675, DateTimeKind.Local).AddTicks(1431), new DateTime(2024, 2, 7, 23, 45, 2, 675, DateTimeKind.Local).AddTicks(1471) });

            migrationBuilder.UpdateData(
                table: "NewToy",
                keyColumn: "CarId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 23, 45, 2, 675, DateTimeKind.Local).AddTicks(1474), new DateTime(2024, 2, 7, 23, 45, 2, 675, DateTimeKind.Local).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "NewToy",
                keyColumn: "CarId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 23, 45, 2, 675, DateTimeKind.Local).AddTicks(1477), new DateTime(2024, 2, 7, 23, 45, 2, 675, DateTimeKind.Local).AddTicks(1478) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
