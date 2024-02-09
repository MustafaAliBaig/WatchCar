using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WatchCar.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
