using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ezbooking.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBenhNhanDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BacSiKTVs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TenBacSiKTV = table.Column<string>(type: "TEXT", nullable: true),
                    DiaChi = table.Column<string>(type: "TEXT", nullable: true),
                    SoDienThoai = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    TrangThai = table.Column<string>(type: "TEXT", nullable: true),
                    IsKtv = table.Column<bool>(type: "INTEGER", nullable: false),
                    GioBatDau = table.Column<TimeOnly>(type: "TEXT", nullable: false),
                    GioKetThuc = table.Column<TimeOnly>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BacSiKTVs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BenhNhans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TenBenhNhan = table.Column<string>(type: "TEXT", nullable: true),
                    DiaChi = table.Column<string>(type: "TEXT", nullable: true),
                    SoDienThoai = table.Column<string>(type: "TEXT", nullable: true),
                    GioBenhNhanVao = table.Column<string>(type: "TEXT", nullable: true),
                    SoNgayDieuTri = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BenhNhans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ThietBis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TenThietBi = table.Column<string>(type: "TEXT", nullable: true),
                    MoTa = table.Column<string>(type: "TEXT", nullable: true),
                    HinhAnh = table.Column<string>(type: "TEXT", nullable: true),
                    SoLuong = table.Column<int>(type: "INTEGER", nullable: false),
                    ThoiGianCachNhau = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThietBis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DichVuKTs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TenDichVu = table.Column<string>(type: "TEXT", nullable: true),
                    ChiPhi = table.Column<int>(type: "INTEGER", nullable: false),
                    ThoiGian = table.Column<int>(type: "INTEGER", nullable: false),
                    LoaiDichVu = table.Column<int>(type: "INTEGER", nullable: false),
                    ThietBiId = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DichVuKTs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DichVuKTs_ThietBis_ThietBiId",
                        column: x => x.ThietBiId,
                        principalTable: "ThietBis",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateTable(
                name: "BacSiKTVDichVuKT",
                columns: table => new
                {
                    BacSiKTVsId = table.Column<int>(type: "INTEGER", nullable: false),
                    DichVuKTsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BacSiKTVDichVuKT", x => new { x.BacSiKTVsId, x.DichVuKTsId });
                    table.ForeignKey(
                        name: "FK_BacSiKTVDichVuKT_BacSiKTVs_BacSiKTVsId",
                        column: x => x.BacSiKTVsId,
                        principalTable: "BacSiKTVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BacSiKTVDichVuKT_DichVuKTs_DichVuKTsId",
                        column: x => x.DichVuKTsId,
                        principalTable: "DichVuKTs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "ThoiGianBieus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ThoiGianBatDau = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ThoiGianKetThuc = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DichVuKTId = table.Column<int>(type: "INTEGER", nullable: true),
                    BacSiKTVId = table.Column<int>(type: "INTEGER", nullable: true),
                    BenhNhanId = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: false),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThoiGianBieus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ThoiGianBieus_BacSiKTVs_BacSiKTVId",
                        column: x => x.BacSiKTVId,
                        principalTable: "BacSiKTVs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ThoiGianBieus_BenhNhans_BenhNhanId",
                        column: x => x.BenhNhanId,
                        principalTable: "BenhNhans",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ThoiGianBieus_DichVuKTs_DichVuKTId",
                        column: x => x.DichVuKTId,
                        principalTable: "DichVuKTs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BacSiKTVDichVuKT_DichVuKTsId",
                table: "BacSiKTVDichVuKT",
                column: "DichVuKTsId");

            migrationBuilder.CreateIndex(
                name: "IX_BenhNhanDichVuKT_DichVuKTsId",
                table: "BenhNhanDichVuKT",
                column: "DichVuKTsId");

            migrationBuilder.CreateIndex(
                name: "IX_DichVuKTs_ThietBiId",
                table: "DichVuKTs",
                column: "ThietBiId");

            migrationBuilder.CreateIndex(
                name: "IX_ThoiGianBieus_BacSiKTVId",
                table: "ThoiGianBieus",
                column: "BacSiKTVId");

            migrationBuilder.CreateIndex(
                name: "IX_ThoiGianBieus_BenhNhanId",
                table: "ThoiGianBieus",
                column: "BenhNhanId");

            migrationBuilder.CreateIndex(
                name: "IX_ThoiGianBieus_DichVuKTId",
                table: "ThoiGianBieus",
                column: "DichVuKTId");

            migrationBuilder.CreateIndex(
                name: "IX_ThoiGianSuDungThietBis_ThietBiId",
                table: "ThoiGianSuDungThietBis",
                column: "ThietBiId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BacSiKTVDichVuKT");

            migrationBuilder.DropTable(
                name: "BenhNhanDichVuKT");

            migrationBuilder.DropTable(
                name: "ThoiGianBieus");

            migrationBuilder.DropTable(
                name: "ThoiGianSuDungThietBis");

            migrationBuilder.DropTable(
                name: "BacSiKTVs");

            migrationBuilder.DropTable(
                name: "BenhNhans");

            migrationBuilder.DropTable(
                name: "DichVuKTs");

            migrationBuilder.DropTable(
                name: "ThietBis");
        }
    }
}
