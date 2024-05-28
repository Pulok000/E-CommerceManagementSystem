﻿// <auto-generated />
using System;
using E_CommerceManageMentSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace E_CommerceManageMentSystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240528080746_Updated product model")]
    partial class Updatedproductmodel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("E_CommerceManageMentSystem.Models.Address", b =>
                {
                    b.Property<int>("AddressID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("E_CommerceManageMentSystem.Models.CartItem", b =>
                {
                    b.Property<int>("CartItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CartID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("VariantID")
                        .HasColumnType("int");

                    b.HasKey("CartItemID");

                    b.HasIndex("CartID");

                    b.HasIndex("VariantID");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("E_CommerceManageMentSystem.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("E_CommerceManageMentSystem.Models.Discount", b =>
                {
                    b.Property<int>("DiscountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("DiscountPercentage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DiscountID");

                    b.HasIndex("ProductID");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("E_CommerceManageMentSystem.Models.Inventory", b =>
                {
                    b.Property<int>("InventoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ReorderLevel")
                        .HasColumnType("int");

                    b.Property<int>("StockLevel")
                        .HasColumnType("int");

                    b.Property<int>("VariantID")
                        .HasColumnType("int");

                    b.HasKey("InventoryID");

                    b.HasIndex("VariantID")
                        .IsUnique();

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("E_CommerceManageMentSystem.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("E_CommerceManageMentSystem.Models.OrderItem", b =>
                {
                    b.Property<int>("OrderItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("VariantID")
                        .HasColumnType("int");

                    b.HasKey("OrderItemID");

                    b.HasIndex("OrderID");

                    b.HasIndex("VariantID");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("E_CommerceManageMentSystem.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProDuctPictureURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("E_CommerceManageMentSystem.Models.ProductPromotion", b =>
                {
                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("PromotionID")
                        .HasColumnType("int");

                    b.HasKey("ProductID", "PromotionID");

                    b.HasIndex("PromotionID");

                    b.ToTable("ProductPromotions");
                });

            modelBuilder.Entity("E_CommerceManageMentSystem.Models.Promotion", b =>
                {
                    b.Property<int>("PromotionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("DiscountAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("PromotionID");

                    b.ToTable("Promotions");
                });

            modelBuilder.Entity("E_CommerceManageMentSystem.Models.ShoppingCart", b =>
                {
                    b.Property<int>("CartID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.HasKey("CartID");

                    b.HasIndex("CustomerID")
                        .IsUnique();

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("E_CommerceManageMentSystem.Models.Variant", b =>
                {
                    b.Property<int>("VariantID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VariantID");

                    b.HasIndex("ProductID");

                    b.ToTable("Variants");
                });

            modelBuilder.Entity("E_CommerceManageMentSystem.Models.Address", b =>
                {
                    b.HasOne("E_CommerceManageMentSystem.Models.Customer", "Customer")
                        .WithMany("Addresses")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("E_CommerceManageMentSystem.Models.CartItem", b =>
                {
                    b.HasOne("E_CommerceManageMentSystem.Models.ShoppingCart", "ShoppingCart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_CommerceManageMentSystem.Models.Variant", "Variant")
                        .WithMany()
                        .HasForeignKey("VariantID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ShoppingCart");

                    b.Navigation("Variant");
                });

            modelBuilder.Entity("E_CommerceManageMentSystem.Models.Discount", b =>
                {
                    b.HasOne("E_CommerceManageMentSystem.Models.Product", "Product")
                        .WithMany("Discounts")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("E_CommerceManageMentSystem.Models.Inventory", b =>
                {
                    b.HasOne("E_CommerceManageMentSystem.Models.Variant", "Variant")
                        .WithOne("Inventory")
                        .HasForeignKey("E_CommerceManageMentSystem.Models.Inventory", "VariantID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Variant");
                });

            modelBuilder.Entity("E_CommerceManageMentSystem.Models.Order", b =>
                {
                    b.HasOne("E_CommerceManageMentSystem.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("E_CommerceManageMentSystem.Models.OrderItem", b =>
                {
                    b.HasOne("E_CommerceManageMentSystem.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_CommerceManageMentSystem.Models.Variant", "Variant")
                        .WithMany()
                        .HasForeignKey("VariantID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Variant");
                });

            modelBuilder.Entity("E_CommerceManageMentSystem.Models.ProductPromotion", b =>
                {
                    b.HasOne("E_CommerceManageMentSystem.Models.Product", "Product")
                        .WithMany("ProductPromotions")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_CommerceManageMentSystem.Models.Promotion", "Promotion")
                        .WithMany("ProductPromotions")
                        .HasForeignKey("PromotionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Promotion");
                });

            modelBuilder.Entity("E_CommerceManageMentSystem.Models.ShoppingCart", b =>
                {
                    b.HasOne("E_CommerceManageMentSystem.Models.Customer", "Customer")
                        .WithOne("ShoppingCart")
                        .HasForeignKey("E_CommerceManageMentSystem.Models.ShoppingCart", "CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("E_CommerceManageMentSystem.Models.Variant", b =>
                {
                    b.HasOne("E_CommerceManageMentSystem.Models.Product", "Product")
                        .WithMany("Variants")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("E_CommerceManageMentSystem.Models.Customer", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Orders");

                    b.Navigation("ShoppingCart");
                });

            modelBuilder.Entity("E_CommerceManageMentSystem.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("E_CommerceManageMentSystem.Models.Product", b =>
                {
                    b.Navigation("Discounts");

                    b.Navigation("ProductPromotions");

                    b.Navigation("Variants");
                });

            modelBuilder.Entity("E_CommerceManageMentSystem.Models.Promotion", b =>
                {
                    b.Navigation("ProductPromotions");
                });

            modelBuilder.Entity("E_CommerceManageMentSystem.Models.ShoppingCart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("E_CommerceManageMentSystem.Models.Variant", b =>
                {
                    b.Navigation("Inventory");
                });
#pragma warning restore 612, 618
        }
    }
}
