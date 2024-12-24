using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductsCatalog.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "ProductUpdateLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 24, 1, 38, 14, 540, DateTimeKind.Local).AddTicks(1565),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 12, 23, 21, 40, 3, 750, DateTimeKind.Local).AddTicks(7954));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 24, 1, 38, 14, 536, DateTimeKind.Local).AddTicks(8806),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 12, 23, 21, 40, 3, 747, DateTimeKind.Local).AddTicks(9941));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "952625cb-623b-4f8e-a426-c9e14ffe41bc", "9e9ef764-d672-42d8-99ee-93c2410d8ae0", "Admin", "ADMIN" },
                    { "ea3206f7-8571-4e45-b209-e593236f3420", "df2d8409-cg61-4aac-ae65-b26fbbab77f2", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "952625cb-623b-4f8e-a426-c9e14ffe41bc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea3206f7-8571-4e45-b209-e593236f3420");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "ProductUpdateLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 23, 21, 40, 3, 750, DateTimeKind.Local).AddTicks(7954),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 12, 24, 1, 38, 14, 540, DateTimeKind.Local).AddTicks(1565));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 23, 21, 40, 3, 747, DateTimeKind.Local).AddTicks(9941),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 12, 24, 1, 38, 14, 536, DateTimeKind.Local).AddTicks(8806));
        }
    }
}
