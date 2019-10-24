﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VNVon.DataAccess;

namespace VNVon.DataAccess.Migrations
{
    [DbContext(typeof(VNVonContext))]
    partial class VNVonContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VNVon.DataAccess.Models.Bank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MaNganHang")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNganHang")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Bank");
                });

            modelBuilder.Entity("VNVon.DataAccess.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ThanhPho")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("City");
                });

            modelBuilder.Entity("VNVon.DataAccess.Models.Domain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EnLinhVuc")
                        .HasColumnName("En.LinhVuc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VieLinhVuc")
                        .HasColumnName("Vie.LinhVuc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Domain");
                });

            modelBuilder.Entity("VNVon.DataAccess.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChiTietTaiKhoan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cmnd")
                        .HasColumnName("CaNhan.Cmnd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CongTyDiaChiCongTy")
                        .HasColumnName("CongTy.DiaChiCongTy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CongTyDuocCapBoi")
                        .HasColumnName("CongTy.DuocCapBoi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CongTyIdLinhVuc")
                        .HasColumnName("CongTy.IdLinhVuc")
                        .HasColumnType("int");

                    b.Property<int>("CongTyIdThanhPho")
                        .HasColumnName("CongTy.IdThanhPho")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CongTyNgayCapPhep")
                        .HasColumnName("CongTy.NgayCapPhep")
                        .HasColumnType("datetime2");

                    b.Property<string>("CongTySoDangKyKinhDoanh")
                        .HasColumnName("CongTy.SoDangKyKinhDoanh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CongTyTen")
                        .HasColumnName("CongTy.Ten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiaChiNha")
                        .HasColumnName("CaNhan.DiaChiNha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnName("CaNhan.Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GioiTinh")
                        .HasColumnName("CaNhan.IdGioiTinh")
                        .HasColumnType("int");

                    b.Property<int>("IdNganHang")
                        .HasColumnType("int");

                    b.Property<string>("MaSoThue")
                        .HasColumnName("CaNhan.MaSoThue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("NgayCap")
                        .HasColumnName("CaNhan.NgayCap")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnName("CaNhan.NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("NoiCap")
                        .HasColumnName("CaNhan.NoiCap")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("SoCoDinh")
                        .HasColumnName("CaNhan.SoCoDinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoDiDong")
                        .HasColumnName("CaNhan.SoDiDong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("SoDuKhaDung")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SoTaiKhoanNganHang")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("SoTienDaGui")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("SoTienDaRut")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("SoTienDangDauTu")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Ten")
                        .HasColumnName("CaNhan.Ten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenChiNhanh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenChuTaiKhoan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ThanhPho")
                        .HasColumnName("CaNhan.IdThanhPho")
                        .HasColumnType("int");

                    b.Property<int>("UserType")
                        .HasColumnName("UserType")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnName("Username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ViTriTrongCongTy")
                        .HasColumnName("CaNhan.ViTriTrongCongTy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
