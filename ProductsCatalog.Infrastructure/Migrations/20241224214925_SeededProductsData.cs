using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductsCatalog.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeededProductsData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductsImages_ImageID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ImageID",
                table: "Products");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "ProductUpdateLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 24, 23, 49, 24, 766, DateTimeKind.Local).AddTicks(5275),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 12, 24, 1, 38, 14, 540, DateTimeKind.Local).AddTicks(1565));

            migrationBuilder.AlterColumn<int>(
                name: "ImageID",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 24, 23, 49, 24, 763, DateTimeKind.Local).AddTicks(3980),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 12, 24, 1, 38, 14, 536, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryID", "CreatedByID", "CreatedOn", "CurrentTimeFiltered", "Description", "Duration", "ImageID", "Name", "Price", "StartDate" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2024, 12, 24, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4619), false, "A high-tech smartphone with a powerful processor.", 30, null, "Smartphone", 499.99m, new DateTime(2024, 12, 25, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4661) },
                    { 2, 1, null, new DateTime(2024, 12, 24, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4679), true, "A lightweight laptop for professionals.", 60, null, "Laptop", 999.99m, new DateTime(2024, 12, 25, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4681) },
                    { 3, 1, null, new DateTime(2024, 12, 24, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4686), false, "Wireless headphones with noise cancellation.", 45, null, "Headphones", 199.99m, new DateTime(2024, 12, 26, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4688) },
                    { 4, 2, null, new DateTime(2024, 12, 24, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4692), false, "A thrilling mystery novel.", 30, null, "Mystery Novel", 19.99m, new DateTime(2024, 12, 25, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4694) },
                    { 5, 2, null, new DateTime(2024, 12, 24, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4698), true, "A comprehensive science textbook.", 45, null, "Science Textbook", 49.99m, new DateTime(2024, 12, 25, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4700) },
                    { 6, 2, null, new DateTime(2024, 12, 24, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4705), false, "A cookbook with delicious recipes.", 60, null, "Cookbook", 29.99m, new DateTime(2024, 12, 26, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4706) },
                    { 7, 3, null, new DateTime(2024, 12, 24, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4710), true, "A comfortable cotton T-shirt.", 15, null, "T-shirt", 9.99m, new DateTime(2024, 12, 25, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4712) },
                    { 8, 3, null, new DateTime(2024, 12, 24, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4716), false, "Stylish and durable jeans.", 45, null, "Jeans", 49.99m, new DateTime(2024, 12, 26, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4718) },
                    { 9, 3, null, new DateTime(2024, 12, 24, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4723), true, "A warm winter jacket.", 60, null, "Jacket", 89.99m, new DateTime(2024, 12, 27, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4725) },
                    { 10, 4, null, new DateTime(2024, 12, 24, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4730), false, "A compact microwave oven.", 30, null, "Microwave", 99.99m, new DateTime(2024, 12, 25, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4732) },
                    { 11, 4, null, new DateTime(2024, 12, 24, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4737), false, "A powerful kitchen blender.", 45, null, "Blender", 59.99m, new DateTime(2024, 12, 26, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4739) },
                    { 12, 4, null, new DateTime(2024, 12, 24, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4743), true, "Energy-efficient air conditioner.", 60, null, "Air Conditioner", 299.99m, new DateTime(2024, 12, 27, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4745) },
                    { 13, 5, null, new DateTime(2024, 12, 24, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4750), false, "A high-quality football for matches.", 30, null, "Football", 25.99m, new DateTime(2024, 12, 25, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4752) },
                    { 14, 5, null, new DateTime(2024, 12, 24, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4756), false, "Lightweight and durable tennis racket.", 45, null, "Tennis Racket", 79.99m, new DateTime(2024, 12, 26, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4758) },
                    { 15, 5, null, new DateTime(2024, 12, 24, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4762), true, "A non-slip yoga mat for exercises.", 60, null, "Yoga Mat", 19.99m, new DateTime(2024, 12, 27, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4764) },
                    { 16, 6, null, new DateTime(2024, 12, 24, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4768), false, "A collectible action figure for kids.", 30, null, "Action Figure", 14.99m, new DateTime(2024, 12, 25, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4770) },
                    { 17, 6, null, new DateTime(2024, 12, 24, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4775), false, "A creative building block set.", 45, null, "Lego Set", 49.99m, new DateTime(2024, 12, 26, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4777) },
                    { 18, 6, null, new DateTime(2024, 12, 24, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4782), true, "A fun and engaging family board game.", 60, null, "Board Game", 29.99m, new DateTime(2024, 12, 27, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4783) },
                    { 19, 7, null, new DateTime(2024, 12, 24, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4787), false, "A wooden dining table for six.", 30, null, "Dining Table", 299.99m, new DateTime(2024, 12, 25, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4790) },
                    { 20, 7, null, new DateTime(2024, 12, 24, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4794), false, "An ergonomic chair for office use.", 45, null, "Office Chair", 149.99m, new DateTime(2024, 12, 26, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4796) },
                    { 21, 7, null, new DateTime(2024, 12, 24, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4800), true, "A spacious bookshelf for storage.", 60, null, "Bookshelf", 89.99m, new DateTime(2024, 12, 27, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4802) },
                    { 22, 8, null, new DateTime(2024, 12, 24, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4806), false, "A long-lasting matte lipstick.", 30, null, "Lipstick", 14.99m, new DateTime(2024, 12, 25, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4808) },
                    { 23, 8, null, new DateTime(2024, 12, 24, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4813), false, "A hydrating moisturizer for dry skin.", 45, null, "Moisturizer", 24.99m, new DateTime(2024, 12, 26, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4814) },
                    { 24, 8, null, new DateTime(2024, 12, 24, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4819), true, "A refreshing fragrance for daily use.", 60, null, "Perfume", 49.99m, new DateTime(2024, 12, 27, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4821) },
                    { 25, 9, null, new DateTime(2024, 12, 24, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4825), false, "A spiral notebook for taking notes.", 30, null, "Notebook", 4.99m, new DateTime(2024, 12, 25, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4827) },
                    { 26, 9, null, new DateTime(2024, 12, 24, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4858), false, "A pack of 10 high-quality pens.", 45, null, "Pen Set", 9.99m, new DateTime(2024, 12, 26, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4860) },
                    { 27, 9, null, new DateTime(2024, 12, 24, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4865), true, "An organizer planner for daily tasks.", 60, null, "Planner", 14.99m, new DateTime(2024, 12, 27, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4867) },
                    { 28, 10, null, new DateTime(2024, 12, 24, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4871), false, "A 5kg pack of premium rice.", 30, null, "Rice", 19.99m, new DateTime(2024, 12, 25, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4873) },
                    { 29, 10, null, new DateTime(2024, 12, 24, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4878), false, "A bottle of extra virgin olive oil.", 45, null, "Olive Oil", 9.99m, new DateTime(2024, 12, 26, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4879) },
                    { 30, 10, null, new DateTime(2024, 12, 24, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4884), true, "A 1kg pack of Arabica coffee beans.", 60, null, "Coffee Beans", 14.99m, new DateTime(2024, 12, 27, 23, 49, 24, 764, DateTimeKind.Local).AddTicks(4886) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ImageID",
                table: "Products",
                column: "ImageID",
                unique: true,
                filter: "[ImageID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductsImages_ImageID",
                table: "Products",
                column: "ImageID",
                principalTable: "ProductsImages",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductsImages_ImageID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ImageID",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "ProductUpdateLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 24, 1, 38, 14, 540, DateTimeKind.Local).AddTicks(1565),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 12, 24, 23, 49, 24, 766, DateTimeKind.Local).AddTicks(5275));

            migrationBuilder.AlterColumn<int>(
                name: "ImageID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 24, 1, 38, 14, 536, DateTimeKind.Local).AddTicks(8806),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 12, 24, 23, 49, 24, 763, DateTimeKind.Local).AddTicks(3980));

            migrationBuilder.CreateIndex(
                name: "IX_Products_ImageID",
                table: "Products",
                column: "ImageID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductsImages_ImageID",
                table: "Products",
                column: "ImageID",
                principalTable: "ProductsImages",
                principalColumn: "ID");
        }
    }
}
