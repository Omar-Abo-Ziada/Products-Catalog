using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductsCatalog.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedAdminUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ApplicationUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e8d727d7-27c8-4a68-8987-c4a45a9070f4", 0, "ae92b2cd-ec9f-4f13-b75d-0832fa0d6169", "omar@gmail.com", true, "Omar", "Ahmed", false, null, "OMAR@GMAIL.COM", "OMAR@GMAIL.COM", null, null, false, "92405ff6-884b-41dc-8dc5-5f1329669f44", false, "omar@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "952625cb-623b-4f8e-a426-c9e14ffe41bc", "e8d727d7-27c8-4a68-8987-c4a45a9070f4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "952625cb-623b-4f8e-a426-c9e14ffe41bc", "e8d727d7-27c8-4a68-8987-c4a45a9070f4" });

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: "e8d727d7-27c8-4a68-8987-c4a45a9070f4");
        }
    }
}
