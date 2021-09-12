﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Store_Application.Persistence.Contexts;

namespace Store_Application.Persistence.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20210911202438_update-requestPay-tbl")]
    partial class updaterequestPaytbl
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0-rc.2.20475.6");

            modelBuilder.Entity("Store_Application.Domain.Entities.Cart.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<Guid>("BrowserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Finished")
                        .HasColumnType("bit");

                    b.Property<DateTime>("InsertTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("RemovedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("isRemoved")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("Store_Application.Domain.Entities.Cart.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<DateTime>("InsertTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("RemovedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isRemoved")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("Store_Application.Domain.Entities.Finance.RequestPay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Authority")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("InsertTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsPay")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("PayDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("RefId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("RemovedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("isRemoved")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RequestPays");
                });

            modelBuilder.Entity("Store_Application.Domain.Entities.Order.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InsertTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderState")
                        .HasColumnType("int");

                    b.Property<string>("PostCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceiverName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceiverPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RemovedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("RequestPayId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("isRemoved")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("RequestPayId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Store_Application.Domain.Entities.Order.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<DateTime>("InsertTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("RemovedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isRemoved")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Store_Application.Domain.Entities.Product.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("InsertTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("RemovedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isRemoved")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            InsertTime = new DateTime(2021, 9, 12, 0, 54, 37, 659, DateTimeKind.Local).AddTicks(9275),
                            Title = "بدون برند",
                            isRemoved = false
                        });
                });

            modelBuilder.Entity("Store_Application.Domain.Entities.Product.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InsertTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ParentCategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("RemovedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isRemoved")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ParentCategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Store_Application.Domain.Entities.Product.Feature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("InsertTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("RemovedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isRemoved")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Features");
                });

            modelBuilder.Entity("Store_Application.Domain.Entities.Product.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("DiscountAmount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(0m);

                    b.Property<bool>("Displayed")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime>("InsertTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Inventory")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<decimal>("Price")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(0m);

                    b.Property<DateTime?>("RemovedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isRemoved")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Store_Application.Domain.Entities.Product.ProductFeature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("FeatureId")
                        .HasColumnType("int");

                    b.Property<DateTime>("InsertTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("RemovedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isBold")
                        .HasColumnType("bit");

                    b.Property<bool>("isRemoved")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("FeatureId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductFeatures");
                });

            modelBuilder.Entity("Store_Application.Domain.Entities.Product.ProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("InsertTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsMainImage")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("RemovedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isRemoved")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("Store_Application.Domain.Entities.Product.ProductSlider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InsertTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("RemovedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("SliderId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isRemoved")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("SliderId");

                    b.ToTable("ProductSliders");
                });

            modelBuilder.Entity("Store_Application.Domain.Entities.Product.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("InsertTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("RemovedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isRemoved")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Sliders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            InsertTime = new DateTime(2021, 9, 12, 0, 54, 37, 665, DateTimeKind.Local).AddTicks(3366),
                            Title = "پیشنهاد لحظه ای",
                            isRemoved = false
                        },
                        new
                        {
                            Id = 2,
                            InsertTime = new DateTime(2021, 9, 12, 0, 54, 37, 665, DateTimeKind.Local).AddTicks(3464),
                            Title = "دوربین",
                            isRemoved = false
                        },
                        new
                        {
                            Id = 3,
                            InsertTime = new DateTime(2021, 9, 12, 0, 54, 37, 665, DateTimeKind.Local).AddTicks(3474),
                            Title = "موبایل",
                            isRemoved = false
                        },
                        new
                        {
                            Id = 4,
                            InsertTime = new DateTime(2021, 9, 12, 0, 54, 37, 665, DateTimeKind.Local).AddTicks(3479),
                            Title = "لپ تاپ",
                            isRemoved = false
                        });
                });

            modelBuilder.Entity("Store_Application.Domain.Entities.Site.Advertising", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InsertTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("LinkTo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Place")
                        .HasColumnType("int");

                    b.Property<DateTime?>("RemovedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isRemoved")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Advertisings");
                });

            modelBuilder.Entity("Store_Application.Domain.Entities.Site.BrandSlider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InsertTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("LinkTo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RemovedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isRemoved")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("BrandSlides");
                });

            modelBuilder.Entity("Store_Application.Domain.Entities.Site.MainSlider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InsertTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("LinkTo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RemovedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isRemoved")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("MainSlides");
                });

            modelBuilder.Entity("Store_Application.Domain.Entities.User.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("InsertTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RemovedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isRemoved")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            InsertTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Admin",
                            isRemoved = false
                        },
                        new
                        {
                            Id = 2,
                            InsertTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Operator",
                            isRemoved = false
                        },
                        new
                        {
                            Id = 3,
                            InsertTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Customer",
                            isRemoved = false
                        });
                });

            modelBuilder.Entity("Store_Application.Domain.Entities.User.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ActiveCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FullName")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("InsertTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RemovedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte?>("age")
                        .HasColumnType("tinyint");

                    b.Property<bool>("isActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<bool>("isRemoved")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Store_Application.Domain.Entities.Cart.Cart", b =>
                {
                    b.HasOne("Store_Application.Domain.Entities.User.User", "User")
                        .WithMany("Carts")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Store_Application.Domain.Entities.Cart.CartItem", b =>
                {
                    b.HasOne("Store_Application.Domain.Entities.Cart.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Store_Application.Domain.Entities.Product.Product", "Product")
                        .WithMany("CartItems")
                        .HasForeignKey("ProductId");

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Store_Application.Domain.Entities.Finance.RequestPay", b =>
                {
                    b.HasOne("Store_Application.Domain.Entities.User.User", "User")
                        .WithMany("RequestPays")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Store_Application.Domain.Entities.Order.Order", b =>
                {
                    b.HasOne("Store_Application.Domain.Entities.Finance.RequestPay", "RequestPay")
                        .WithMany("Orders")
                        .HasForeignKey("RequestPayId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Store_Application.Domain.Entities.User.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("RequestPay");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Store_Application.Domain.Entities.Order.OrderDetail", b =>
                {
                    b.HasOne("Store_Application.Domain.Entities.Order.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Store_Application.Domain.Entities.Product.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Store_Application.Domain.Entities.Product.Category", b =>
                {
                    b.HasOne("Store_Application.Domain.Entities.Product.Category", "ParentCategory")
                        .WithMany("SubCategories")
                        .HasForeignKey("ParentCategoryId");

                    b.Navigation("ParentCategory");
                });

            modelBuilder.Entity("Store_Application.Domain.Entities.Product.Product", b =>
                {
                    b.HasOne("Store_Application.Domain.Entities.Product.Brand", "Brand")
                        .WithMany("Product")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Store_Application.Domain.Entities.Product.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Store_Application.Domain.Entities.Product.ProductFeature", b =>
                {
                    b.HasOne("Store_Application.Domain.Entities.Product.Feature", "Feature")
                        .WithMany("Values")
                        .HasForeignKey("FeatureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Store_Application.Domain.Entities.Product.Product", "Product")
                        .WithMany("Features")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Feature");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Store_Application.Domain.Entities.Product.ProductImage", b =>
                {
                    b.HasOne("Store_Application.Domain.Entities.Product.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Store_Application.Domain.Entities.Product.ProductSlider", b =>
                {
                    b.HasOne("Store_Application.Domain.Entities.Product.Product", "Product")
                        .WithMany("ProductSliders")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Store_Application.Domain.Entities.Product.Slider", "Slider")
                        .WithMany("ProductSliders")
                        .HasForeignKey("SliderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Slider");
                });

            modelBuilder.Entity("Store_Application.Domain.Entities.User.User", b =>
                {
                    b.HasOne("Store_Application.Domain.Entities.User.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Store_Application.Domain.Entities.Cart.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("Store_Application.Domain.Entities.Finance.RequestPay", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Store_Application.Domain.Entities.Order.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("Store_Application.Domain.Entities.Product.Brand", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("Store_Application.Domain.Entities.Product.Category", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("Store_Application.Domain.Entities.Product.Feature", b =>
                {
                    b.Navigation("Values");
                });

            modelBuilder.Entity("Store_Application.Domain.Entities.Product.Product", b =>
                {
                    b.Navigation("CartItems");

                    b.Navigation("Features");

                    b.Navigation("Images");

                    b.Navigation("OrderDetails");

                    b.Navigation("ProductSliders");
                });

            modelBuilder.Entity("Store_Application.Domain.Entities.Product.Slider", b =>
                {
                    b.Navigation("ProductSliders");
                });

            modelBuilder.Entity("Store_Application.Domain.Entities.User.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Store_Application.Domain.Entities.User.User", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Orders");

                    b.Navigation("RequestPays");
                });
#pragma warning restore 612, 618
        }
    }
}
