﻿// <auto-generated />
using System;
using CompanyInfo.Entities.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CompanyInfo.Entities.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240529112951_createDb")]
    partial class createDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CompanyInfo.Entities.Models.Concrete.Birim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BirimAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Birimler");
                });

            modelBuilder.Entity("CompanyInfo.Entities.Models.Concrete.Kategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("KategoriAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kategoriler");
                });

            modelBuilder.Entity("CompanyInfo.Entities.Models.Concrete.Tedarikci", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SirketAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VergiNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tedarikciler");
                });

            modelBuilder.Entity("CompanyInfo.Entities.Models.Concrete.Urun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double?>("Adet")
                        .HasColumnType("float");

                    b.Property<int>("BirimId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<double?>("Fiyat")
                        .HasColumnType("float");

                    b.Property<string>("UrunAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrunKodu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BirimId");

                    b.ToTable("Urunler");
                });

            modelBuilder.Entity("KategoriUrun", b =>
                {
                    b.Property<int>("KategorilerId")
                        .HasColumnType("int");

                    b.Property<int>("UrunlerId")
                        .HasColumnType("int");

                    b.HasKey("KategorilerId", "UrunlerId");

                    b.HasIndex("UrunlerId");

                    b.ToTable("KategoriUrun");
                });

            modelBuilder.Entity("TedarikciUrun", b =>
                {
                    b.Property<int>("TedarikcilerId")
                        .HasColumnType("int");

                    b.Property<int>("UrunlerId")
                        .HasColumnType("int");

                    b.HasKey("TedarikcilerId", "UrunlerId");

                    b.HasIndex("UrunlerId");

                    b.ToTable("TedarikciUrun");
                });

            modelBuilder.Entity("CompanyInfo.Entities.Models.Concrete.Urun", b =>
                {
                    b.HasOne("CompanyInfo.Entities.Models.Concrete.Birim", "Birim")
                        .WithMany("Urunler")
                        .HasForeignKey("BirimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Birim");
                });

            modelBuilder.Entity("KategoriUrun", b =>
                {
                    b.HasOne("CompanyInfo.Entities.Models.Concrete.Kategori", null)
                        .WithMany()
                        .HasForeignKey("KategorilerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CompanyInfo.Entities.Models.Concrete.Urun", null)
                        .WithMany()
                        .HasForeignKey("UrunlerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TedarikciUrun", b =>
                {
                    b.HasOne("CompanyInfo.Entities.Models.Concrete.Tedarikci", null)
                        .WithMany()
                        .HasForeignKey("TedarikcilerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CompanyInfo.Entities.Models.Concrete.Urun", null)
                        .WithMany()
                        .HasForeignKey("UrunlerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CompanyInfo.Entities.Models.Concrete.Birim", b =>
                {
                    b.Navigation("Urunler");
                });
#pragma warning restore 612, 618
        }
    }
}
