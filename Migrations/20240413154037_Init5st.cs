using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ezbooking.Migrations
{
    /// <inheritdoc />
    public partial class Init5st : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "BenhNhanDichVuKT",
                columns: table => new
                {
                    BenhNhansId = table.Column<int>(type: "INTEGER", nullable: false),
                    DichVuKTsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BenhNhanDichVuKT", x => new { x.BenhNhansId, x.DichVuKTsId });
                    table.ForeignKey(
                        name: "FK_BenhNhanDichVuKT_BenhNhans_BenhNhansId",
                        column: x => x.BenhNhansId,
                        principalTable: "BenhNhans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BenhNhanDichVuKT_DichVuKTs_DichVuKTsId",
                        column: x => x.DichVuKTsId,
                        principalTable: "DichVuKTs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BenhNhanDichVuKT_DichVuKTsId",
                table: "BenhNhanDichVuKT",
                column: "DichVuKTsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BenhNhanDichVuKT");

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
    }
}
