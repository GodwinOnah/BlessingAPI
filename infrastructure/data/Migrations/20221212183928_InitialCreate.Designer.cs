﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using infrastructure.data;

#nullable disable

namespace infrastructure.data.Migrations
{
    [DbContext(typeof(storeProducts))]
    [Migration("20221212183928_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("core.Controllers.ProductBrand", b =>
                {
                    b.Property<int>("productId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("prodName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("productId");

                    b.ToTable("ProductBrands");
                });

            modelBuilder.Entity("core.Controllers.ProductType", b =>
                {
                    b.Property<int>("productId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("prodName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("productId");

                    b.ToTable("ProductTypes");
                });

            modelBuilder.Entity("core.Controllers.Products", b =>
                {
                    b.Property<int>("productId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("prodDescription")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("prodName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<string>("prodPicture")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("prodPrice")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("productBrandId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("productTypeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("productId");

                    b.HasIndex("productBrandId");

                    b.HasIndex("productTypeId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("core.Controllers.Products", b =>
                {
                    b.HasOne("core.Controllers.ProductBrand", "productBrand")
                        .WithMany()
                        .HasForeignKey("productBrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("core.Controllers.ProductType", "productType")
                        .WithMany()
                        .HasForeignKey("productTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("productBrand");

                    b.Navigation("productType");
                });
#pragma warning restore 612, 618
        }
    }
}