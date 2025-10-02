using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prn222Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "IsActive", "IsDeleted", "ModifiedDate", "Name", "Price" },
                values: new object[] { 1, "Gỗ tự nhiên chất lượng cao.", "/images/luoc_dang_ca_heo_go_bach_xanh.webp", true, false, new DateTime(2025, 9, 19, 23, 16, 18, 850, DateTimeKind.Local).AddTicks(7649), "Lược dáng cá heo gỗ bách xanh", 42000m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
