using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace rest_api.Migrations
{
    /// <inheritdoc />
    public partial class add_data_to_db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "Count", "DateAdded", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("11111110-1111-1111-1111-111111111111"), 100, new DateTime(2026, 10, 22, 0, 0, 0, 0, DateTimeKind.Utc), "USB Flash Drive", 800.0 },
                    { new Guid("11111111-1111-1111-1111-111111111111"), 10, new DateTime(2026, 12, 22, 0, 0, 0, 0, DateTimeKind.Utc), "Laptop", 85000.0 },
                    { new Guid("11111111-1111-1111-1111-111111111112"), 10, new DateTime(2026, 10, 12, 0, 0, 0, 0, DateTimeKind.Utc), "Laptop", 85000.0 },
                    { new Guid("11111111-1111-1111-1111-111111111113"), 10, new DateTime(2026, 10, 20, 0, 0, 0, 0, DateTimeKind.Utc), "Laptop", 85000.0 },
                    { new Guid("11111111-1111-1111-1111-111111111119"), 12, new DateTime(2026, 10, 22, 0, 0, 0, 0, DateTimeKind.Utc), "Webcam", 4000.0 },
                    { new Guid("11111111-1111-1111-1111-411111111111"), 25, new DateTime(2026, 10, 22, 0, 0, 0, 0, DateTimeKind.Utc), "Smartphone", 45000.0 },
                    { new Guid("11111111-1111-1111-1511-111111111111"), 30, new DateTime(2026, 10, 22, 0, 0, 0, 0, DateTimeKind.Utc), "Headphones", 3500.0 },
                    { new Guid("11111111-1191-1111-1111-111111111111"), 8, new DateTime(2026, 10, 12, 0, 0, 0, 0, DateTimeKind.Utc), "Printer", 22000.0 },
                    { new Guid("11111111-5111-1111-1111-111111111111"), 40, new DateTime(2026, 10, 12, 0, 0, 0, 0, DateTimeKind.Utc), "Keyboard", 2500.0 },
                    { new Guid("11111111-8111-1111-1111-111111111111"), 15, new DateTime(2026, 10, 27, 0, 0, 0, 0, DateTimeKind.Utc), "Monitor", 18000.0 },
                    { new Guid("11171111-1111-1111-1111-111111111111"), 20, new DateTime(2026, 10, 24, 0, 0, 0, 0, DateTimeKind.Utc), "External Hard Drive", 9500.0 },
                    { new Guid("61111111-1111-1111-1111-111111111111"), 50, new DateTime(2026, 10, 22, 0, 0, 0, 0, DateTimeKind.Utc), "Mouse", 1200.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: new Guid("11111110-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111112"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111113"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111119"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-411111111111"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1511-111111111111"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1191-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: new Guid("11111111-5111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: new Guid("11111111-8111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: new Guid("11171111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: new Guid("61111111-1111-1111-1111-111111111111"));
        }
    }
}
