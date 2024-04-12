using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ezbooking.Migrations
{
    /// <inheritdoc />
    public partial class Init2st : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdBacSiKTV",
                table: "ThoiGianBieus");

            migrationBuilder.DropColumn(
                name: "IdBenhNhan",
                table: "ThoiGianBieus");

            migrationBuilder.DropColumn(
                name: "IdDichVuKT",
                table: "ThoiGianBieus");

            migrationBuilder.DropColumn(
                name: "IdThietBi",
                table: "DichVuKTs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdBacSiKTV",
                table: "ThoiGianBieus",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdBenhNhan",
                table: "ThoiGianBieus",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdDichVuKT",
                table: "ThoiGianBieus",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdThietBi",
                table: "DichVuKTs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
