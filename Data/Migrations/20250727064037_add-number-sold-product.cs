using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prn222Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class addnumbersoldproduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberSold",
                table: "ProductVariants",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberSold",
                table: "ProductVariants");
        }
    }
}
