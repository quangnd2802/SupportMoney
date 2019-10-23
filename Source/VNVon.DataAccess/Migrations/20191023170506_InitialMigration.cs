using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VNVon.DataAccess.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThanhPho = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Domain",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VieLinhVuc = table.Column<string>(name: "Vie.LinhVuc", nullable: true),
                    EnLinhVuc = table.Column<string>(name: "En.LinhVuc", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domain", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaNhanTen = table.Column<string>(name: "CaNhan.Ten", nullable: true),
                    CaNhanCmnd = table.Column<string>(name: "CaNhan.Cmnd", nullable: true),
                    CaNhanNgayCap = table.Column<DateTime>(name: "CaNhan.NgayCap", nullable: true),
                    CaNhanNoiCap = table.Column<string>(name: "CaNhan.NoiCap", nullable: true),
                    CaNhanIdGioiTinh = table.Column<int>(name: "CaNhan.IdGioiTinh", nullable: false),
                    CaNhanNgaySinh = table.Column<DateTime>(name: "CaNhan.NgaySinh", nullable: true),
                    CaNhanMaSoThue = table.Column<string>(name: "CaNhan.MaSoThue", nullable: true),
                    CaNhanSoDiDong = table.Column<string>(name: "CaNhan.SoDiDong", nullable: true),
                    CaNhanSoCoDinh = table.Column<string>(name: "CaNhan.SoCoDinh", nullable: true),
                    CaNhanEmail = table.Column<string>(name: "CaNhan.Email", nullable: true),
                    CaNhanIdThanhPho = table.Column<int>(name: "CaNhan.IdThanhPho", nullable: false),
                    CaNhanDiaChiNha = table.Column<string>(name: "CaNhan.DiaChiNha", nullable: true),
                    CaNhanViTriTrongCongTy = table.Column<string>(name: "CaNhan.ViTriTrongCongTy", nullable: true),
                    UserType = table.Column<int>(nullable: false),
                    Username = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true),
                    CongTyTen = table.Column<string>(name: "CongTy.Ten", nullable: true),
                    CongTyIdLinhVuc = table.Column<int>(name: "CongTy.IdLinhVuc", nullable: false),
                    CongTySoDangKyKinhDoanh = table.Column<string>(name: "CongTy.SoDangKyKinhDoanh", nullable: true),
                    CongTyNgayCapPhep = table.Column<DateTime>(name: "CongTy.NgayCapPhep", nullable: true),
                    CongTyDuocCapBoi = table.Column<string>(name: "CongTy.DuocCapBoi", nullable: true),
                    CongTyIdThanhPho = table.Column<int>(name: "CongTy.IdThanhPho", nullable: false),
                    CongTyDiaChiCongTy = table.Column<string>(name: "CongTy.DiaChiCongTy", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Domain");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
