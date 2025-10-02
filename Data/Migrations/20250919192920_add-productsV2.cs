using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Prn222Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class addproductsV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ModifiedDate", "Price" },
                values: new object[] { "Lược Gỗ Massage Da Đầu Thủ Công - Bí quyết chăm sóc sức khoẻ tự nhiên mỗi ngày!", new DateTime(2025, 9, 20, 2, 29, 19, 591, DateTimeKind.Local).AddTicks(9592), 40000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ModifiedDate", "Price" },
                values: new object[] { "Lược Gỗ Massage Da Đầu Thủ Công - Bí quyết chăm sóc sức khoẻ tự nhiên mỗi ngày!", new DateTime(2025, 9, 20, 2, 29, 19, 591, DateTimeKind.Local).AddTicks(9595), 50000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ModifiedDate", "Price" },
                values: new object[] { "Giá đỡ điện thoại gỗ - phụ kiện nhỏ gọn nhưng cực kỳ hữu ích cho bàn học, bàn làm việc và không gian sống của bạn.", new DateTime(2025, 9, 20, 2, 29, 19, 591, DateTimeKind.Local).AddTicks(9598), 50000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ModifiedDate", "Price" },
                values: new object[] { "Giá đỡ điện thoại gỗ - phụ kiện nhỏ gọn nhưng cực kỳ hữu ích cho bàn học, bàn làm việc và không gian sống của bạn.", new DateTime(2025, 9, 20, 2, 29, 19, 591, DateTimeKind.Local).AddTicks(9601), 63000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ModifiedDate", "Price" },
                values: new object[] { "Giá đỡ điện thoại gỗ - phụ kiện nhỏ gọn nhưng cực kỳ hữu ích cho bàn học, bàn làm việc và không gian sống của bạn.", new DateTime(2025, 9, 20, 2, 29, 19, 591, DateTimeKind.Local).AddTicks(9604), 75000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ModifiedDate", "Price" },
                values: new object[] { "Lược gỗ massage toàn thân - dụng cụ chăm sóc sức khỏe tự nhiên, giúp thư giãn và giảm căng thẳng hiệu quả.", new DateTime(2025, 9, 20, 2, 29, 19, 591, DateTimeKind.Local).AddTicks(9606), 50000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ModifiedDate", "Price" },
                values: new object[] { "Bộ thìa đũa gỗ kèm túi vải họa tiết Nhật Bản - lựa chọn hoàn hảo cho những ai yêu thích sự tiện lợi và lối sống xanh.", new DateTime(2025, 9, 20, 2, 29, 19, 591, DateTimeKind.Local).AddTicks(9609), 68000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ModifiedDate", "Price" },
                values: new object[] { "Bộ thìa đũa gỗ kèm túi vải họa tiết Nhật Bản - lựa chọn hoàn hảo cho những ai yêu thích sự tiện lợi và lối sống xanh.", new DateTime(2025, 9, 20, 2, 29, 19, 591, DateTimeKind.Local).AddTicks(9611), 43000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ModifiedDate", "Price" },
                values: new object[] { "Bộ thìa đũa gỗ kèm túi vải họa tiết Nhật Bản - lựa chọn hoàn hảo cho những ai yêu thích sự tiện lợi và lối sống xanh.", new DateTime(2025, 9, 20, 2, 29, 19, 591, DateTimeKind.Local).AddTicks(9616), 50000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ModifiedDate", "Price" },
                values: new object[] { "Bộ đũa muỗng gỗ kèm hộp đựng tiện lợi - giải pháp gọn gàng, vệ sinh và thân thiện môi trường cho bữa ăn mỗi ngày.", new DateTime(2025, 9, 20, 2, 29, 19, 591, DateTimeKind.Local).AddTicks(9618), 56000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "ModifiedDate", "Price" },
                values: new object[] { "Bộ đũa muỗng gỗ kèm hộp đựng tiện lợi - giải pháp gọn gàng, vệ sinh và thân thiện môi trường cho bữa ăn mỗi ngày.", new DateTime(2025, 9, 20, 2, 29, 19, 591, DateTimeKind.Local).AddTicks(9621), 69000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ModifiedDate", "Price" },
                values: new object[] { "Móc khóa 12 con giáp bằng gỗ 2025 là một phụ kiện thời trang độc đáo, mang đậm nét văn hóa và phong thủy Việt Nam.", new DateTime(2025, 9, 20, 2, 29, 19, 591, DateTimeKind.Local).AddTicks(9623), 79000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "ModifiedDate", "Price" },
                values: new object[] { "Quạt Cầm Tay Bằng Rơm Dệt Thủ Công Ba Tiêu Cổ Trang.", new DateTime(2025, 9, 20, 2, 29, 19, 591, DateTimeKind.Local).AddTicks(9625), 90000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "ModifiedDate", "Price" },
                values: new object[] { "Mây Tre Truyền Thống - Rổ Tre Đan Thủ Công 2 Lớp là sản phẩm lưu trữ hoàn hảo cho ngôi nhà của bạn.", new DateTime(2025, 9, 20, 2, 29, 19, 591, DateTimeKind.Local).AddTicks(9628), 103000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "ModifiedDate", "Price" },
                values: new object[] { "Dép Cói Thủ Công là sự kết hợp hoàn hảo giữa phong cách truyền thống và sự thoải mái hiện đại.", new DateTime(2025, 9, 20, 2, 29, 19, 591, DateTimeKind.Local).AddTicks(9631), 51000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "ModifiedDate", "Price" },
                values: new object[] { "BÌNH GIỮ NHIỆT ĐAN TRE - ĐẸP, BỀN, CHUẨN XANH!", new DateTime(2025, 9, 20, 2, 29, 19, 591, DateTimeKind.Local).AddTicks(9633), 45000m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "IsActive", "IsDeleted", "ModifiedDate", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Lược Gỗ Massage Da Đầu Thủ Công - Bí quyết chăm sóc sức khoẻ tự nhiên mỗi ngày!", "/images/luoc_dang_ca_heo_go_bach_xanh.webp", true, false, new DateTime(2025, 9, 20, 2, 29, 19, 591, DateTimeKind.Local).AddTicks(9573), "Lược dáng cá heo gỗ bách xanh", 40000m },
                    { 18, "Lược Gỗ Massage Da Đầu Thủ Công - Bí quyết chăm sóc sức khoẻ tự nhiên mỗi ngày!", "/images/luoc_dang_ca_heo_go_bach_xanh.webp", true, false, new DateTime(2025, 9, 20, 2, 29, 19, 591, DateTimeKind.Local).AddTicks(9636), "Lược bán tròn đàn hương", 45000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ModifiedDate", "Price" },
                values: new object[] { "Gỗ tự nhiên chất lượng cao.", new DateTime(2025, 9, 20, 2, 8, 19, 625, DateTimeKind.Local).AddTicks(2596), 42000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ModifiedDate", "Price" },
                values: new object[] { "Gỗ tự nhiên chất lượng cao.", new DateTime(2025, 9, 20, 2, 8, 19, 625, DateTimeKind.Local).AddTicks(2611), 42000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ModifiedDate", "Price" },
                values: new object[] { "Gỗ tự nhiên chất lượng cao.", new DateTime(2025, 9, 20, 2, 8, 19, 625, DateTimeKind.Local).AddTicks(2614), 42000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ModifiedDate", "Price" },
                values: new object[] { "Gỗ tự nhiên chất lượng cao.", new DateTime(2025, 9, 20, 2, 8, 19, 625, DateTimeKind.Local).AddTicks(2616), 42000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ModifiedDate", "Price" },
                values: new object[] { "Gỗ tự nhiên chất lượng cao.", new DateTime(2025, 9, 20, 2, 8, 19, 625, DateTimeKind.Local).AddTicks(2617), 42000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ModifiedDate", "Price" },
                values: new object[] { "Gỗ tự nhiên chất lượng cao.", new DateTime(2025, 9, 20, 2, 8, 19, 625, DateTimeKind.Local).AddTicks(2620), 42000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ModifiedDate", "Price" },
                values: new object[] { "Gỗ tự nhiên chất lượng cao.", new DateTime(2025, 9, 20, 2, 8, 19, 625, DateTimeKind.Local).AddTicks(2622), 42000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ModifiedDate", "Price" },
                values: new object[] { "Gỗ tự nhiên chất lượng cao.", new DateTime(2025, 9, 20, 2, 8, 19, 625, DateTimeKind.Local).AddTicks(2671), 42000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ModifiedDate", "Price" },
                values: new object[] { "Gỗ tự nhiên chất lượng cao.", new DateTime(2025, 9, 20, 2, 8, 19, 625, DateTimeKind.Local).AddTicks(2673), 42000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ModifiedDate", "Price" },
                values: new object[] { "Gỗ tự nhiên chất lượng cao.", new DateTime(2025, 9, 20, 2, 8, 19, 625, DateTimeKind.Local).AddTicks(2675), 42000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "ModifiedDate", "Price" },
                values: new object[] { "Gỗ tự nhiên chất lượng cao.", new DateTime(2025, 9, 20, 2, 8, 19, 625, DateTimeKind.Local).AddTicks(2676), 42000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ModifiedDate", "Price" },
                values: new object[] { "Gỗ tự nhiên chất lượng cao.", new DateTime(2025, 9, 20, 2, 8, 19, 625, DateTimeKind.Local).AddTicks(2678), 42000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "ModifiedDate", "Price" },
                values: new object[] { "Gỗ tự nhiên chất lượng cao.", new DateTime(2025, 9, 20, 2, 8, 19, 625, DateTimeKind.Local).AddTicks(2680), 42000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "ModifiedDate", "Price" },
                values: new object[] { "Gỗ tự nhiên chất lượng cao.", new DateTime(2025, 9, 20, 2, 8, 19, 625, DateTimeKind.Local).AddTicks(2682), 42000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "ModifiedDate", "Price" },
                values: new object[] { "Gỗ tự nhiên chất lượng cao.", new DateTime(2025, 9, 20, 2, 8, 19, 625, DateTimeKind.Local).AddTicks(2684), 42000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "ModifiedDate", "Price" },
                values: new object[] { "Gỗ tự nhiên chất lượng cao.", new DateTime(2025, 9, 20, 2, 8, 19, 625, DateTimeKind.Local).AddTicks(2686), 42000m });
        }
    }
}
