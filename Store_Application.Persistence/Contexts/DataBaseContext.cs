using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Store_Application.Domain;
using Store_Application.Domain.Entities.User;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Common.Roles;
using Store_Application.Domain.Entities.Product;
using Store_Application.Domain.Entities.Site;
using Store_Application.Domain.Entities.Cart;
using Store_Application.Domain.Entities.Order;
using Store_Application.Domain.Entities.Finance;

namespace Store_Application.Persistence.Contexts
{
    public class DataBaseContext : DbContext, IDataBaseContext
    {
        public DataBaseContext(DbContextOptions options) : base(options)
        {
        }

        #region User

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        #endregion

        #region Product

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<ProductSlider> ProductSliders { get; set; }


        #endregion

        #region Site

        public DbSet<MainSlider> MainSlides { get; set; }
        public DbSet<BrandSlider> BrandSlides { get; set; }
        public DbSet<Advertising> Advertisings { get; set; }

        #endregion

        #region Cart

        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

        #endregion

        #region Order

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        #endregion

        #region Finance

        public DbSet<RequestPay> RequestPays { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            ConfigurationEntities(modelBuilder);

            ApplyRelations(modelBuilder);

            ApplyQueryFilters(modelBuilder);

            SeedData(modelBuilder);
        }

        private void ApplyQueryFilters(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasQueryFilter(u => !u.isRemoved);
            modelBuilder.Entity<Role>().HasQueryFilter(r => !r.isRemoved);
            modelBuilder.Entity<Category>().HasQueryFilter(c => !c.isRemoved);
            modelBuilder.Entity<Product>().HasQueryFilter(p => !p.isRemoved);
            modelBuilder.Entity<Feature>().HasQueryFilter(p => !p.isRemoved);
            modelBuilder.Entity<ProductImage>().HasQueryFilter(p => !p.isRemoved);
            modelBuilder.Entity<Brand>().HasQueryFilter(p => !p.isRemoved);
            modelBuilder.Entity<Slider>().HasQueryFilter(p => !p.isRemoved);
            modelBuilder.Entity<ProductSlider>().HasQueryFilter(p => !p.isRemoved);
            modelBuilder.Entity<ProductFeature>().HasQueryFilter(p => !p.isRemoved);
            modelBuilder.Entity<MainSlider>().HasQueryFilter(s => !s.isRemoved);
            modelBuilder.Entity<BrandSlider>().HasQueryFilter(s => !s.isRemoved);
            modelBuilder.Entity<Advertising>().HasQueryFilter(s => !s.isRemoved);
            modelBuilder.Entity<Cart>().HasQueryFilter(s => !s.isRemoved);
            modelBuilder.Entity<CartItem>().HasQueryFilter(s => !s.isRemoved);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(new List<Role>
            {
                new Role { Id = 1, Name = nameof(UserRoles.Admin) },
                new Role { Id = 2, Name = nameof(UserRoles.Operator) },
                new Role { Id = 3, Name = nameof(UserRoles.Customer) }
            });

            modelBuilder.Entity<Brand>().HasData(new Brand { Id = 1, Title = "بدون برند", InsertTime = DateTime.Now });

            modelBuilder.Entity<Slider>().HasData(new List<Slider>
            {
                new Slider { Id = 1, Title = "پیشنهاد لحظه ای", InsertTime=DateTime.Now },
                new Slider { Id = 2, Title = "دوربین", InsertTime=DateTime.Now },
                new Slider { Id = 3, Title = "موبایل", InsertTime=DateTime.Now },
                new Slider { Id = 4, Title = "لپ تاپ", InsertTime=DateTime.Now },
            });

        }

        private void ConfigurationEntities(ModelBuilder modelBuilder)
        {
            #region User

            modelBuilder.Entity<User>()
                 .HasKey(u => u.Id);

            modelBuilder.Entity<User>()
                .Property(u => u.FullName)
                .HasMaxLength(200);

            modelBuilder.Entity<User>()
                .Property(u => u.age)
                .HasDefaultValue(null);

            modelBuilder.Entity<User>()
                .Property(u => u.Email)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(u => u.Password)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(u => u.ActiveCode)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(u => u.isActive)
                .HasDefaultValue(false);

            modelBuilder.Entity<User>()
                .Property(u => u.RoleId)
                .HasDefaultValue(false);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            #endregion

            #region Role

            modelBuilder.Entity<Role>()
                .HasKey(r => r.Id);

            #endregion

            #region Category

            modelBuilder.Entity<Category>()
                .HasKey(u => u.Id);

            #endregion

            #region Brand

            modelBuilder.Entity<Brand>()
                .HasKey(u => u.Id);

            #endregion

            #region Feature

            modelBuilder.Entity<Feature>()
                .HasKey(u => u.Id);

            #endregion

            #region Product

            modelBuilder.Entity<Product>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasDefaultValue(0);

            modelBuilder.Entity<Product>()
                .Property(p => p.DiscountAmount)
                .HasDefaultValue(0);

            modelBuilder.Entity<Product>()
                .Property(p => p.Inventory)
                .HasDefaultValue(0);

            modelBuilder.Entity<Product>()
                .Property(p => p.Displayed)
                .HasDefaultValue(true);

            #endregion

            #region MainSlider

            modelBuilder.Entity<MainSlider>()
                .Property(s => s.Title).HasMaxLength(200);

            #endregion

            #region BrandSlider

            modelBuilder.Entity<BrandSlider>()
                .Property(s => s.Title).HasMaxLength(200);

            #endregion

            #region Advertising

            modelBuilder.Entity<Advertising>()
                .Property(a => a.Title).HasMaxLength(200);

            #endregion

            #region CartItem

            modelBuilder.Entity<CartItem>()
                .HasKey(pf => pf.Id);

            #endregion

            #region Order

            modelBuilder.Entity<Order>()
                .HasOne(p => p.User)
                .WithMany(p => p.Orders)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Order>()
                .HasOne(p => p.RequestPay)
                .WithMany(p => p.Orders)
                .OnDelete(DeleteBehavior.NoAction);


            #endregion

        }

        private void ApplyRelations(ModelBuilder modelBuilder)
        {

            #region User-Role

            modelBuilder.Entity<User>()
                            .HasOne(u => u.Role)
                            .WithMany(r => r.Users)
                            .HasForeignKey(u => u.RoleId)
                            .IsRequired();

            #endregion

            #region Product-ProductImage-Image

            modelBuilder.Entity<Product>()
                .HasMany(p => p.Images)
                .WithOne(i => i.Product);

            modelBuilder.Entity<ProductImage>()
                .HasOne(pi => pi.Product)
                .WithMany(p => p.Images)
                .HasForeignKey(pi => pi.ProductId);

            #endregion

            #region Product-Brand

            modelBuilder.Entity<Product>()
                 .HasOne(p => p.Brand)
                 .WithMany(b => b.Product)
                 .HasForeignKey(p => p.BrandId);

            #endregion

            #region Product-Category

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .IsRequired();

            #endregion

            #region Product-productFeature-Feature

            modelBuilder.Entity<ProductFeature>()
                .HasKey(pf => pf.Id);


            modelBuilder.Entity<ProductFeature>()
                .HasOne(pf => pf.Product)
                .WithMany(p => p.Features)
                .HasForeignKey(pf => pf.ProductId);

            modelBuilder.Entity<ProductFeature>()
                .HasOne(pf => pf.Feature)
                .WithMany(f => f.Values)
                .HasForeignKey(pf => pf.FeatureId);

            #endregion

            #region Category-Category

            modelBuilder.Entity<Category>()
                .HasOne(c => c.ParentCategory)
                .WithMany(c => c.SubCategories)
                .HasForeignKey(c => c.ParentCategoryId);

            #endregion

            #region Product-productSliders-slider

            modelBuilder.Entity<ProductSlider>()
                .HasOne(ps => ps.Product)
                .WithMany(p => p.ProductSliders)
                .HasForeignKey(pi => pi.ProductId);

            modelBuilder.Entity<ProductSlider>()
                .HasOne(ps => ps.Slider)
                .WithMany(p => p.ProductSliders)
                .HasForeignKey(pi => pi.SliderId);

            #endregion

            #region Product-CartItem-Cart

            modelBuilder.Entity<CartItem>()
                .HasOne(ci => ci.Product)
                .WithMany(p => p.CartItems)
                .HasForeignKey(ci => ci.ProductId);

            modelBuilder.Entity<CartItem>()
                .HasOne(ci => ci.Cart)
                .WithMany(c => c.CartItems)
                .HasForeignKey(ci => ci.CartId);

            #endregion

            #region Cart-User

            modelBuilder.Entity<Cart>()
                .HasOne(c => c.User)
                .WithMany(u => u.Carts)
                .HasForeignKey(c => c.UserId);

            #endregion

            #region Product-OrderDetail-Order

            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Product)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(ci => ci.ProductId);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(od => od.OrderId);

            #endregion

            #region Order-User

            modelBuilder.Entity<Order>()
                .HasOne(o => o.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.UserId);

            #endregion

            #region Order-RequestPay-User

            modelBuilder.Entity<Order>()
                .HasOne(o => o.RequestPay)
                .WithMany(rp => rp.Orders)
                .HasForeignKey(o => o.RequestPayId);

            modelBuilder.Entity<RequestPay>()
                .HasOne(rp => rp.User)
                .WithMany(u => u.RequestPays)
                .HasForeignKey(rp => rp.UserId);

            #endregion

        }

    }
}
