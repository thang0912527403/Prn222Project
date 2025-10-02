using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Prn222Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class addproducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "IsActive", "IsDeleted", "ModifiedDate", "Name", "Price" },
                values: new object[,]
                {
                    { 2, "Gỗ tự nhiên chất lượng cao.", "/images/luoc_dang_ca_heo_go_bach_xanh.webp", true, false, new DateTime(2025, 9, 20, 2, 8, 19, 625, DateTimeKind.Local).AddTicks(2596), "Lược bán tròn bách xanh", 42000m },
                    { 3, "Gỗ tự nhiên chất lượng cao.", "/images/luoc_dang_ca_heo_go_bach_xanh.webp", true, false, new DateTime(2025, 9, 20, 2, 8, 19, 625, DateTimeKind.Local).AddTicks(2611), "Lược gỗ cá heo đàn hương", 42000m },
                    { 4, "Gỗ tự nhiên chất lượng cao.", "/images/luoc_dang_ca_heo_go_bach_xanh.webp", true, false, new DateTime(2025, 9, 20, 2, 8, 19, 625, DateTimeKind.Local).AddTicks(2614), "Giá đỡ điện thoại gỗ sồi nhỏ trắng", 42000m },
                    { 5, "Gỗ tự nhiên chất lượng cao.", "/images/luoc_dang_ca_heo_go_bach_xanh.webp", true, false, new DateTime(2025, 9, 20, 2, 8, 19, 625, DateTimeKind.Local).AddTicks(2616), "Giá đỡ điện thoại gỗ óc chó nhỏ nâu", 42000m },
                    { 6, "Gỗ tự nhiên chất lượng cao.", "/images/luoc_dang_ca_heo_go_bach_xanh.webp", true, false, new DateTime(2025, 9, 20, 2, 8, 19, 625, DateTimeKind.Local).AddTicks(2617), "Giá đỡ điện thoại to trắng gỗ sồi", 42000m },
                    { 7, "Gỗ tự nhiên chất lượng cao.", "/images/luoc_dang_ca_heo_go_bach_xanh.webp", true, false, new DateTime(2025, 9, 20, 2, 8, 19, 625, DateTimeKind.Local).AddTicks(2620), "Bàn chải masa", 42000m },
                    { 8, "Gỗ tự nhiên chất lượng cao.", "/images/luoc_dang_ca_heo_go_bach_xanh.webp", true, false, new DateTime(2025, 9, 20, 2, 8, 19, 625, DateTimeKind.Local).AddTicks(2622), "Túi đựng thìa đũa 3 món", 42000m },
                    { 9, "Gỗ tự nhiên chất lượng cao.", "/images/luoc_dang_ca_heo_go_bach_xanh.webp", true, false, new DateTime(2025, 9, 20, 2, 8, 19, 625, DateTimeKind.Local).AddTicks(2671), "Túi đựng thìa đũa 2 món trơn", 42000m },
                    { 10, "Gỗ tự nhiên chất lượng cao.", "/images/luoc_dang_ca_heo_go_bach_xanh.webp", true, false, new DateTime(2025, 9, 20, 2, 8, 19, 625, DateTimeKind.Local).AddTicks(2673), "Túi đựng thìa đũa 2 món cán bọc", 42000m },
                    { 11, "Gỗ tự nhiên chất lượng cao.", "/images/luoc_dang_ca_heo_go_bach_xanh.webp", true, false, new DateTime(2025, 9, 20, 2, 8, 19, 625, DateTimeKind.Local).AddTicks(2675), "Hộp đựng thìa đũa 2 món cán trơn", 42000m },
                    { 12, "Gỗ tự nhiên chất lượng cao.", "/images/luoc_dang_ca_heo_go_bach_xanh.webp", true, false, new DateTime(2025, 9, 20, 2, 8, 19, 625, DateTimeKind.Local).AddTicks(2676), "Hộp đựng thìa đũa 2 món cán bọc", 42000m },
                    { 13, "Gỗ tự nhiên chất lượng cao.", "/images/luoc_dang_ca_heo_go_bach_xanh.webp", true, false, new DateTime(2025, 9, 20, 2, 8, 19, 625, DateTimeKind.Local).AddTicks(2678), "Móc treo 12 con giáp", 42000m },
                    { 14, "Gỗ tự nhiên chất lượng cao.", "/images/luoc_dang_ca_heo_go_bach_xanh.webp", true, false, new DateTime(2025, 9, 20, 2, 8, 19, 625, DateTimeKind.Local).AddTicks(2680), "Quạt cầm tay", 42000m },
                    { 15, "Gỗ tự nhiên chất lượng cao.", "/images/luoc_dang_ca_heo_go_bach_xanh.webp", true, false, new DateTime(2025, 9, 20, 2, 8, 19, 625, DateTimeKind.Local).AddTicks(2682), "Rổ tre đan 2 lớp", 42000m },
                    { 16, "Gỗ tự nhiên chất lượng cao.", "/images/luoc_dang_ca_heo_go_bach_xanh.webp", true, false, new DateTime(2025, 9, 20, 2, 8, 19, 625, DateTimeKind.Local).AddTicks(2684), "Dép cói", 42000m },
                    { 17, "Gỗ tự nhiên chất lượng cao.", "/images/luoc_dang_ca_heo_go_bach_xanh.webp", true, false, new DateTime(2025, 9, 20, 2, 8, 19, 625, DateTimeKind.Local).AddTicks(2686), "Bình giữ nhiệt đan tre ", 42000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "IsActive", "IsDeleted", "ModifiedDate", "Name", "Price" },
                values: new object[] { 1, "Gỗ tự nhiên chất lượng cao.", "/images/luoc_dang_ca_heo_go_bach_xanh.webp", true, false, new DateTime(2025, 9, 19, 23, 16, 18, 850, DateTimeKind.Local).AddTicks(7649), "Lược dáng cá heo gỗ bách xanh", 42000m });
        }
    }
}
