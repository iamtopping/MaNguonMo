﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MaNguonMo.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20211122081950_Create_Table_KhachHang")]
    partial class Create_Table_KhachHang
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("DemoMVC.Models.Person", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Peoples");
                });

            modelBuilder.Entity("MaNguonMo.Models.Employee", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("MaNguonMo.Models.HoaDon", b =>
                {
                    b.Property<string>("HoaDonID")
                        .HasColumnType("TEXT");

                    b.Property<string>("KhachHangID")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("TEXT");

                    b.HasKey("HoaDonID");

                    b.HasIndex("KhachHangID");

                    b.ToTable("HoaDons");
                });

            modelBuilder.Entity("MaNguonMo.Models.KhachHang", b =>
                {
                    b.Property<string>("KhachHangID")
                        .HasColumnType("TEXT");

                    b.Property<int>("SDT")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TenKhachHang")
                        .HasColumnType("TEXT");

                    b.HasKey("KhachHangID");

                    b.ToTable("KhachHangs");
                });

            modelBuilder.Entity("MaNguonMo.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("MaNguonMo.Models.Person", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("MaNguonMo.Models.Product", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Quantity")
                        .HasColumnType("TEXT");

                    b.Property<string>("UnitPrice")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("MaNguonMo.Models.Student", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("MaNguonMo.Models.HoaDon", b =>
                {
                    b.HasOne("MaNguonMo.Models.KhachHang", "KhachHang")
                        .WithMany("HoaDons")
                        .HasForeignKey("KhachHangID");

                    b.Navigation("KhachHang");
                });

            modelBuilder.Entity("MaNguonMo.Models.KhachHang", b =>
                {
                    b.Navigation("HoaDons");
                });
#pragma warning restore 612, 618
        }
    }
}
