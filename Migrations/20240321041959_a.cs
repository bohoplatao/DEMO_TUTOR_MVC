using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DEMO_TUTOR_MVC.Migrations
{
    public partial class a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: " Sản Phẩm ",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TênSP = table.Column<string>(name: "Tên SP", type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ Sản Phẩm ", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    SDT = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Diachi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    point = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    status = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__KhachHan__CA1930A46D87F0EB", x => x.SDT);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SellDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    KhachHangSdt = table.Column<string>(type: "varchar(15)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_KhachHangSdt",
                        column: x => x.KhachHangSdt,
                        principalTable: "KhachHang",
                        principalColumn: "SDT",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonCT",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHD = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SellPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SellAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    SanPhamId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonCT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HD_HDCT",
                        column: x => x.IdHD,
                        principalTable: "HoaDon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonCT_ Sản Phẩm _SanPhamId",
                        column: x => x.SanPhamId,
                        principalTable: " Sản Phẩm ",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_KhachHangSdt",
                table: "HoaDon",
                column: "KhachHangSdt");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonCT_IdHD",
                table: "HoaDonCT",
                column: "IdHD");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonCT_SanPhamId",
                table: "HoaDonCT",
                column: "SanPhamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoaDonCT");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: " Sản Phẩm ");

            migrationBuilder.DropTable(
                name: "KhachHang");
        }
    }
}
