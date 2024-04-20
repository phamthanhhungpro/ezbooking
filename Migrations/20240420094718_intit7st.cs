using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ezbooking.Migrations
{
    /// <inheritdoc />
    public partial class intit7st : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LoaiDichVu",
                table: "DichVuKTs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LoaiDichVu",
                table: "DichVuKTs");
        }
    }
}
