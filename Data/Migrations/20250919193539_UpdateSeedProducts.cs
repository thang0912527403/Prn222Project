using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prn222Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedDate",
                value: new DateTime(2025, 9, 20, 2, 35, 37, 241, DateTimeKind.Local).AddTicks(922));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "ModifiedDate" },
                values: new object[] { "/images/luoc_ban_tron_bach_xanh.PNG", new DateTime(2025, 9, 20, 2, 35, 37, 241, DateTimeKind.Local).AddTicks(940) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "ModifiedDate" },
                values: new object[] { "/images/luoc-go-ca-heo-dan-huong.PNG", new DateTime(2025, 9, 20, 2, 35, 37, 241, DateTimeKind.Local).AddTicks(942) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "ModifiedDate" },
                values: new object[] { "/images/gia-do-dt-go-soi-nho-trang.PNG", new DateTime(2025, 9, 20, 2, 35, 37, 241, DateTimeKind.Local).AddTicks(944) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrl", "ModifiedDate" },
                values: new object[] { "/images/gia-do-dt-go-oc-cho-nho-nau.PNG", new DateTime(2025, 9, 20, 2, 35, 37, 241, DateTimeKind.Local).AddTicks(946) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageUrl", "ModifiedDate" },
                values: new object[] { "/images/gia-do-dt-to-trang-go-soi.PNG", new DateTime(2025, 9, 20, 2, 35, 37, 241, DateTimeKind.Local).AddTicks(948) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageUrl", "ModifiedDate" },
                values: new object[] { "/images/ban-chai-masa.PNG", new DateTime(2025, 9, 20, 2, 35, 37, 241, DateTimeKind.Local).AddTicks(951) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageUrl", "ModifiedDate" },
                values: new object[] { "/images/tui-dung-thia-dua-3-mon.PNG", new DateTime(2025, 9, 20, 2, 35, 37, 241, DateTimeKind.Local).AddTicks(953) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImageUrl", "ModifiedDate" },
                values: new object[] { "/images/tui-dung-thia-dua-2-mon-tron.PNG", new DateTime(2025, 9, 20, 2, 35, 37, 241, DateTimeKind.Local).AddTicks(958) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrl", "ModifiedDate" },
                values: new object[] { "/images/tui-dung-thia-dua-2-mon-can-boc.PNG", new DateTime(2025, 9, 20, 2, 35, 37, 241, DateTimeKind.Local).AddTicks(960) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ImageUrl", "ModifiedDate" },
                values: new object[] { "/images/hop-dung-thia-dua-2-mon-can-tron.PNG", new DateTime(2025, 9, 20, 2, 35, 37, 241, DateTimeKind.Local).AddTicks(962) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ImageUrl", "ModifiedDate" },
                values: new object[] { "/images/hop-dung-thia-dua-2-mon-can-boc.PNG", new DateTime(2025, 9, 20, 2, 35, 37, 241, DateTimeKind.Local).AddTicks(963) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ImageUrl", "ModifiedDate" },
                values: new object[] { "/images/moc-treo-12-con-giap.PNG", new DateTime(2025, 9, 20, 2, 35, 37, 241, DateTimeKind.Local).AddTicks(966) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ImageUrl", "ModifiedDate" },
                values: new object[] { "/images/quat-cam-tay.PNG", new DateTime(2025, 9, 20, 2, 35, 37, 241, DateTimeKind.Local).AddTicks(968) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ImageUrl", "ModifiedDate" },
                values: new object[] { "/images/ro-tre-dan-2-lop.PNG", new DateTime(2025, 9, 20, 2, 35, 37, 241, DateTimeKind.Local).AddTicks(969) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ImageUrl", "ModifiedDate" },
                values: new object[] { "/images/dep-coi.PNG", new DateTime(2025, 9, 20, 2, 35, 37, 241, DateTimeKind.Local).AddTicks(971) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ImageUrl", "ModifiedDate", "Price" },
                values: new object[] { "/images/binh-giu-nhiet-dan-tre.PNG", new DateTime(2025, 9, 20, 2, 35, 37, 241, DateTimeKind.Local).AddTicks(973), 450000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "ModifiedDate",
                value: new DateTime(2025, 9, 20, 2, 35, 37, 241, DateTimeKind.Local).AddTicks(975));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedDate",
                value: new DateTime(2025, 9, 20, 2, 29, 19, 591, DateTimeKind.Local).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "ModifiedDate" },
                values: new object[] { "/images/luoc_dang_ca_heo_go_bach_xanh.webp", new DateTime(2025, 9, 20, 2, 29, 19, 591, DateTimeKind.Local).AddTicks(9592) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "ModifiedDate" },
                values: new object[] { "/images/luoc_dang_ca_heo_go_bach_xanh.webp", new DateTime(2025, 9, 20, 2, 29, 19, 591, DateTimeKind.Local).AddTicks(9595) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "ModifiedDate" },
                values: new object[] { "/images/luoc_dang_ca_heo_go_bach_xanh.webp", new DateTime(2025, 9, 20, 2, 29, 19, 591, DateTimeKind.Local).AddTicks(9598) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrl", "ModifiedDate" },
                values: new object[] { "/images/luoc_dang_ca_heo_go_bach_xanh.webp", new DateTime(2025, 9, 20, 2, 29, 19, 591, DateTimeKind.Local).AddTicks(9601) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageUrl", "ModifiedDate" },
                values: new object[] { "/images/luoc_dang_ca_heo_go_bach_xanh.webp", new DateTime(2025, 9, 20, 2, 29, 19, 591, DateTimeKind.Local).AddTicks(9604) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageUrl", "ModifiedDate" },
                values: new object[] { "/images/luoc_dang_ca_heo_go_bach_xanh.webp", new DateTime(2025, 9, 20, 2, 29, 19, 591, DateTimeKind.Local).AddTicks(9606) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageUrl", "ModifiedDate" },
                values: new object[] { "/images/luoc_dang_ca_heo_go_bach_xanh.webp", new DateTime(2025, 9, 20, 2, 29, 19, 591, DateTimeKind.Local).AddTicks(9609) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImageUrl", "ModifiedDate" },
                values: new object[] { "/images/luoc_dang_ca_heo_go_bach_xanh.webp", new DateTime(2025, 9, 20, 2, 29, 19, 591, DateTimeKind.Local).AddTicks(9611) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageUrl", "ModifiedDate" },
                values: new object[] { "/images/luoc_dang_ca_heo_go_bach_xanh.webp", new DateTime(2025, 9, 20, 2, 29, 19, 591, DateTimeKind.Local).AddTicks(9616) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ImageUrl", "ModifiedDate" },
                values: new object[] { "/images/luoc_dang_ca_heo_go_bach_xanh.webp", new DateTime(2025, 9, 20, 2, 29, 19, 591, DateTimeKind.Local).AddTicks(9618) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ImageUrl", "ModifiedDate" },
                values: new object[] { "/images/luoc_dang_ca_heo_go_bach_xanh.webp", new DateTime(2025, 9, 20, 2, 29, 19, 591, DateTimeKind.Local).AddTicks(9621) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ImageUrl", "ModifiedDate" },
                values: new object[] { "/images/luoc_dang_ca_heo_go_bach_xanh.webp", new DateTime(2025, 9, 20, 2, 29, 19, 591, DateTimeKind.Local).AddTicks(9623) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ImageUrl", "ModifiedDate" },
                values: new object[] { "/images/luoc_dang_ca_heo_go_bach_xanh.webp", new DateTime(2025, 9, 20, 2, 29, 19, 591, DateTimeKind.Local).AddTicks(9625) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ImageUrl", "ModifiedDate" },
                values: new object[] { "/images/luoc_dang_ca_heo_go_bach_xanh.webp", new DateTime(2025, 9, 20, 2, 29, 19, 591, DateTimeKind.Local).AddTicks(9628) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ImageUrl", "ModifiedDate" },
                values: new object[] { "/images/luoc_dang_ca_heo_go_bach_xanh.webp", new DateTime(2025, 9, 20, 2, 29, 19, 591, DateTimeKind.Local).AddTicks(9631) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ImageUrl", "ModifiedDate", "Price" },
                values: new object[] { "/images/luoc_dang_ca_heo_go_bach_xanh.webp", new DateTime(2025, 9, 20, 2, 29, 19, 591, DateTimeKind.Local).AddTicks(9633), 45000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "ModifiedDate",
                value: new DateTime(2025, 9, 20, 2, 29, 19, 591, DateTimeKind.Local).AddTicks(9636));
        }
    }
}
