﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotnet_api.Models;

namespace dotnet_api.Migrations
{
    [DbContext(typeof(AlacenaContext))]
    partial class AlacenaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("dotnet_api.Models.Categories", b =>
                {
                    b.Property<string>("idCategory")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("CategoriesXProductID")
                        .IsRequired()
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("category")
                        .HasColumnType("nvarchar(45)");

                    b.HasKey("idCategory");

                    b.HasIndex("CategoriesXProductID");

                    b.ToTable("CategoryList");
                });

            modelBuilder.Entity("dotnet_api.Models.CategoriesXProduct", b =>
                {
                    b.Property<string>("idCategoriesXProduct")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(45)");

                    b.HasKey("idCategoriesXProduct");

                    b.ToTable("CategoriesXProduct");
                });

            modelBuilder.Entity("dotnet_api.Models.Products", b =>
                {
                    b.Property<string>("idProducts")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("CategoriesXProductID")
                        .IsRequired()
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("TrademarksID")
                        .IsRequired()
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("barCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(300)");

                    b.Property<DateTime>("expirationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("nameProduct")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("idProducts");

                    b.HasIndex("CategoriesXProductID");

                    b.HasIndex("TrademarksID");

                    b.ToTable("ProductList");
                });

            modelBuilder.Entity("dotnet_api.Models.Trademarks", b =>
                {
                    b.Property<string>("idTrademarks")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("mark")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("idTrademarks");

                    b.ToTable("TrademarkList");
                });

            modelBuilder.Entity("dotnet_api.Models.Categories", b =>
                {
                    b.HasOne("dotnet_api.Models.CategoriesXProduct", "CategoriesXProduct")
                        .WithMany("Categories_idCategory")
                        .HasForeignKey("CategoriesXProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoriesXProduct");
                });

            modelBuilder.Entity("dotnet_api.Models.Products", b =>
                {
                    b.HasOne("dotnet_api.Models.CategoriesXProduct", "CategoriesXProduct")
                        .WithMany("Products_idProducts")
                        .HasForeignKey("CategoriesXProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dotnet_api.Models.Trademarks", "Trademarks")
                        .WithMany("Products_idProducts")
                        .HasForeignKey("TrademarksID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoriesXProduct");

                    b.Navigation("Trademarks");
                });

            modelBuilder.Entity("dotnet_api.Models.CategoriesXProduct", b =>
                {
                    b.Navigation("Categories_idCategory");

                    b.Navigation("Products_idProducts");
                });

            modelBuilder.Entity("dotnet_api.Models.Trademarks", b =>
                {
                    b.Navigation("Products_idProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
