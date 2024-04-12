﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ezbooking.Models;

#nullable disable

namespace ezbooking.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240412073928_Init3st")]
    partial class Init3st
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("BacSiKTVDichVuKT", b =>
                {
                    b.Property<int>("BacSiKTVsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DichVuKTsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("BacSiKTVsId", "DichVuKTsId");

                    b.HasIndex("DichVuKTsId");

                    b.ToTable("BacSiKTVDichVuKT");
                });

            modelBuilder.Entity("ezbooking.Models.BacSiKTV", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("DiaChi")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<TimeOnly>("GioBatDau")
                        .HasColumnType("TEXT");

                    b.Property<TimeOnly>("GioKetThuc")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(false);

                    b.Property<string>("SoDienThoai")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenBacSiKTV")
                        .HasColumnType("TEXT");

                    b.Property<string>("TrangThai")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("BacSiKTVs");
                });

            modelBuilder.Entity("ezbooking.Models.BenhNhan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("DiaChi")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(false);

                    b.Property<string>("SoDienThoai")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenBenhNhan")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("BenhNhans");
                });

            modelBuilder.Entity("ezbooking.Models.DichVuKT", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ChiPhi")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(false);

                    b.Property<string>("TenDichVu")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ThietBiId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ThoiGian")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ThietBiId");

                    b.ToTable("DichVuKTs");
                });

            modelBuilder.Entity("ezbooking.Models.ThietBi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("HinhAnh")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(false);

                    b.Property<string>("MoTa")
                        .HasColumnType("TEXT");

                    b.Property<int>("SoLuong")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TenThietBi")
                        .HasColumnType("TEXT");

                    b.Property<int>("ThoiGianCachNhau")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ThietBis");
                });

            modelBuilder.Entity("ezbooking.Models.ThoiGianBieu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BacSiKTVId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BenhNhanId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TEXT");

                    b.Property<int?>("DichVuKTId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("ThoiGianBatDau")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ThoiGianKetThuc")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BacSiKTVId");

                    b.HasIndex("BenhNhanId");

                    b.HasIndex("DichVuKTId");

                    b.ToTable("ThoiGianBieus");
                });

            modelBuilder.Entity("BacSiKTVDichVuKT", b =>
                {
                    b.HasOne("ezbooking.Models.BacSiKTV", null)
                        .WithMany()
                        .HasForeignKey("BacSiKTVsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ezbooking.Models.DichVuKT", null)
                        .WithMany()
                        .HasForeignKey("DichVuKTsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ezbooking.Models.DichVuKT", b =>
                {
                    b.HasOne("ezbooking.Models.ThietBi", "ThietBi")
                        .WithMany()
                        .HasForeignKey("ThietBiId");

                    b.Navigation("ThietBi");
                });

            modelBuilder.Entity("ezbooking.Models.ThoiGianBieu", b =>
                {
                    b.HasOne("ezbooking.Models.BacSiKTV", "BacSiKTV")
                        .WithMany()
                        .HasForeignKey("BacSiKTVId");

                    b.HasOne("ezbooking.Models.BenhNhan", "BenhNhan")
                        .WithMany()
                        .HasForeignKey("BenhNhanId");

                    b.HasOne("ezbooking.Models.DichVuKT", "DichVuKT")
                        .WithMany()
                        .HasForeignKey("DichVuKTId");

                    b.Navigation("BacSiKTV");

                    b.Navigation("BenhNhan");

                    b.Navigation("DichVuKT");
                });
#pragma warning restore 612, 618
        }
    }
}
