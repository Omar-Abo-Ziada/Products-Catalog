using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductsCatalog.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class editedAdminPassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "ProductUpdateLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 25, 3, 12, 3, 531, DateTimeKind.Local).AddTicks(5425),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 12, 25, 3, 0, 6, 221, DateTimeKind.Local).AddTicks(7828));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 25, 3, 12, 3, 524, DateTimeKind.Local).AddTicks(3649),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 12, 25, 3, 0, 6, 217, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: "e8d727d7-27c8-4a68-8987-c4a45a9070f4",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { "AQAAAAIAAYagAAAAENsgpWCwz7CtTKEL1jOWkHkofVaw4ZlJ96lBdyOITIIwaDyqEWqO4fjqJw7WqvP9nQ==", "4a3a1b7b-9d80-435e-ac90-1ff6960d6e4c" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(2840), new DateTime(2024, 12, 26, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(2906) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(2922), new DateTime(2024, 12, 26, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(2925) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(2931), new DateTime(2024, 12, 27, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(2933) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(2938), new DateTime(2024, 12, 26, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(2941) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(2945), new DateTime(2024, 12, 26, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(2948) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(2953), new DateTime(2024, 12, 27, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(2955) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(2960), new DateTime(2024, 12, 26, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(2962) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(2968), new DateTime(2024, 12, 27, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(2975), new DateTime(2024, 12, 28, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(2977) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(2982), new DateTime(2024, 12, 26, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(2984) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(2988), new DateTime(2024, 12, 27, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(3023), new DateTime(2024, 12, 28, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(3027) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(3424), new DateTime(2024, 12, 26, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(3430) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(3439), new DateTime(2024, 12, 27, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(3443) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(3450), new DateTime(2024, 12, 28, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(3453) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(3460), new DateTime(2024, 12, 26, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(3464) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(3471), new DateTime(2024, 12, 27, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(3475) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(3482), new DateTime(2024, 12, 28, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(3485) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(3516), new DateTime(2024, 12, 26, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(3521) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(3529), new DateTime(2024, 12, 27, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(3533) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(3539), new DateTime(2024, 12, 28, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(3542) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(3549), new DateTime(2024, 12, 26, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(3559), new DateTime(2024, 12, 27, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(3563) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(3569), new DateTime(2024, 12, 28, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(3573) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(3579), new DateTime(2024, 12, 26, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(3582) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(3587), new DateTime(2024, 12, 27, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(3592) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(3623), new DateTime(2024, 12, 28, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(3626) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(3632), new DateTime(2024, 12, 26, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(3635) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(3642), new DateTime(2024, 12, 27, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(3645) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(3652), new DateTime(2024, 12, 28, 3, 12, 3, 527, DateTimeKind.Local).AddTicks(3656) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "ProductUpdateLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 25, 3, 0, 6, 221, DateTimeKind.Local).AddTicks(7828),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 12, 25, 3, 12, 3, 531, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 25, 3, 0, 6, 217, DateTimeKind.Local).AddTicks(9550),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 12, 25, 3, 12, 3, 524, DateTimeKind.Local).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: "e8d727d7-27c8-4a68-8987-c4a45a9070f4",
                columns: new[] { "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "92405ff6-884b-41dc-8dc5-5f1329669f44" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(195), new DateTime(2024, 12, 26, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(418) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(439), new DateTime(2024, 12, 26, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(441) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(446), new DateTime(2024, 12, 27, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(448) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(452), new DateTime(2024, 12, 26, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(459), new DateTime(2024, 12, 26, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(461) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(465), new DateTime(2024, 12, 27, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(467) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(471), new DateTime(2024, 12, 26, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(473) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(477), new DateTime(2024, 12, 27, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(480) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(485), new DateTime(2024, 12, 28, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(487) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(491), new DateTime(2024, 12, 26, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(493) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(498), new DateTime(2024, 12, 27, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(499) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(504), new DateTime(2024, 12, 28, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(506) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(510), new DateTime(2024, 12, 26, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(512) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(516), new DateTime(2024, 12, 27, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(518) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(607), new DateTime(2024, 12, 28, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(609) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(615), new DateTime(2024, 12, 26, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(617) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(621), new DateTime(2024, 12, 27, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(623) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(627), new DateTime(2024, 12, 28, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(629) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(634), new DateTime(2024, 12, 26, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(635) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(640), new DateTime(2024, 12, 27, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(642) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(646), new DateTime(2024, 12, 28, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(648) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(652), new DateTime(2024, 12, 26, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(654) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(659), new DateTime(2024, 12, 27, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(660) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(664), new DateTime(2024, 12, 28, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(666) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(670), new DateTime(2024, 12, 26, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(672) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(676), new DateTime(2024, 12, 27, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(678) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(684), new DateTime(2024, 12, 28, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(686) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(690), new DateTime(2024, 12, 26, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(692) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(696), new DateTime(2024, 12, 27, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(698) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CreatedOn", "StartDate" },
                values: new object[] { new DateTime(2024, 12, 25, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(702), new DateTime(2024, 12, 28, 3, 0, 6, 219, DateTimeKind.Local).AddTicks(704) });
        }
    }
}
