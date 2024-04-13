using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ezbooking.Migrations
{
    /// <inheritdoc />
    public partial class Init4st : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BenhNhanId",
                table: "DichVuKTs",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DichVuKTs_BenhNhanId",
                table: "DichVuKTs",
                column: "BenhNhanId");

            migrationBuilder.AddForeignKey(
                name: "FK_DichVuKTs_BenhNhans_BenhNhanId",
                table: "DichVuKTs",
                column: "BenhNhanId",
                principalTable: "BenhNhans",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DichVuKTs_BenhNhans_BenhNhanId",
                table: "DichVuKTs");

            migrationBuilder.DropIndex(
                name: "IX_DichVuKTs_BenhNhanId",
                table: "DichVuKTs");

            migrationBuilder.DropColumn(
                name: "BenhNhanId",
                table: "DichVuKTs");
        }
    }
}
