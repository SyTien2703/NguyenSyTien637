﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NguyenSyTien637.Data;

#nullable disable

namespace NguyenSyTien637.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240106070005_Create_table_SinhVien")]
    partial class Create_table_SinhVien
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("NguyenSyTien637.Models.SinhVien", b =>
                {
                    b.Property<string>("SinhVienId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SinhVienId");

                    b.ToTable("SinhViens");
                });
#pragma warning restore 612, 618
        }
    }
}
