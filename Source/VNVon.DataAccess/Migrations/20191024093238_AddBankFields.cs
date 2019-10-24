using Microsoft.EntityFrameworkCore.Migrations;

namespace VNVon.DataAccess.Migrations
{
    public partial class AddBankFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ChiTietTaiKhoan",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdNganHang",
                table: "User",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SoTaiKhoanNganHang",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenChiNhanh",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenChuTaiKhoan",
                table: "User",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChiTietTaiKhoan",
                table: "User");

            migrationBuilder.DropColumn(
                name: "IdNganHang",
                table: "User");

            migrationBuilder.DropColumn(
                name: "SoTaiKhoanNganHang",
                table: "User");

            migrationBuilder.DropColumn(
                name: "TenChiNhanh",
                table: "User");

            migrationBuilder.DropColumn(
                name: "TenChuTaiKhoan",
                table: "User");
        }
    }
}
