﻿// <auto-generated />
using System;
using DEMO_TUTOR_MVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DEMO_TUTOR_MVC.Migrations
{
    [DbContext(typeof(DemoCode1stContext))]
    [Migration("20240321041959_a")]
    partial class a
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DEMO_TUTOR_MVC.Models.HoaDon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdKhachHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("KhachHangSdt")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<DateTime>("SellDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("KhachHangSdt");

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("DEMO_TUTOR_MVC.Models.HoaDonCT", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdHD")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdSp")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SanPhamId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("SellAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SellPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdHD");

                    b.HasIndex("SanPhamId");

                    b.ToTable("HoaDonCT");
                });

            modelBuilder.Entity("DEMO_TUTOR_MVC.Models.KhachHang", b =>
                {
                    b.Property<string>("Sdt")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("SDT");

                    b.Property<string>("Diachi")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("email");

                    b.Property<int?>("Point")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("point")
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("status")
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("Ten")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Sdt")
                        .HasName("PK__KhachHan__CA1930A46D87F0EB");

                    b.ToTable("KhachHang", (string)null);
                });

            modelBuilder.Entity("DEMO_TUTOR_MVC.Models.SanPham", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Tên SP");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("Stock")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable(" Sản Phẩm ", (string)null);
                });

            modelBuilder.Entity("DEMO_TUTOR_MVC.Models.HoaDon", b =>
                {
                    b.HasOne("DEMO_TUTOR_MVC.Models.KhachHang", "KhachHang")
                        .WithMany("HoaDons")
                        .HasForeignKey("KhachHangSdt")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHang");
                });

            modelBuilder.Entity("DEMO_TUTOR_MVC.Models.HoaDonCT", b =>
                {
                    b.HasOne("DEMO_TUTOR_MVC.Models.HoaDon", "HoaDon")
                        .WithMany("HoaDonCTs")
                        .HasForeignKey("IdHD")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_HD_HDCT");

                    b.HasOne("DEMO_TUTOR_MVC.Models.SanPham", "SanPham")
                        .WithMany("HoaDonCTs")
                        .HasForeignKey("SanPhamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HoaDon");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("DEMO_TUTOR_MVC.Models.HoaDon", b =>
                {
                    b.Navigation("HoaDonCTs");
                });

            modelBuilder.Entity("DEMO_TUTOR_MVC.Models.KhachHang", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("DEMO_TUTOR_MVC.Models.SanPham", b =>
                {
                    b.Navigation("HoaDonCTs");
                });
#pragma warning restore 612, 618
        }
    }
}
