using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ezbooking.Migrations
{
    /// <inheritdoc />
    public partial class Init6st : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ThoiGianSuDungThietBis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ThietBiId = table.Column<int>(type: "INTEGER", nullable: true),
                    ThoiGianBatDau = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ThoiGianKetThuc = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThoiGianSuDungThietBis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ThoiGianSuDungThietBis_ThietBis_ThietBiId",
                        column: x => x.ThietBiId,
                        principalTable: "ThietBis",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ThoiGianSuDungThietBis_ThietBiId",
                table: "ThoiGianSuDungThietBis",
                column: "ThietBiId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ThoiGianSuDungThietBis");
        }
    }
}
