using Microsoft.EntityFrameworkCore.Migrations;

namespace VNVon.DataAccess.Migrations
{
    public partial class Newmoneyfields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "SoDuKhaDung",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "SoTienDaGui",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "SoTienDaRut",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "SoTienDangDauTu",
                table: "User",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SoDuKhaDung",
                table: "User");

            migrationBuilder.DropColumn(
                name: "SoTienDaGui",
                table: "User");

            migrationBuilder.DropColumn(
                name: "SoTienDaRut",
                table: "User");

            migrationBuilder.DropColumn(
                name: "SoTienDangDauTu",
                table: "User");
        }
    }
}
