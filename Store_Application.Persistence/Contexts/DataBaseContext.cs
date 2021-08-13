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
            modelBuilder.Entity<User>().HasQueryFilter(u => u.isRemoved != true);
            modelBuilder.Entity<Role>().HasQueryFilter(r => r.isRemoved != true);
            modelBuilder.Entity<Category>().HasQueryFilter(c => c.isRemoved != true);

        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(new Role { Id = 1, Name = nameof(UserRoles.Admin) });
            modelBuilder.Entity<Role>().HasData(new Role { Id = 2, Name = nameof(UserRoles.Operator) });
            modelBuilder.Entity<Role>().HasData(new Role { Id = 3, Name = nameof(UserRoles.Customer) });

            modelBuilder.Entity<Brand>().HasData(new Brand { Id = 1, Title = "بدون برند",InsertTime = DateTime.Now });

        }

        private void ConfigurationEntities(ModelBuilder modelBuilder)
        {
            #region User

            modelBuilder.Entity<User>()
                .Property(u => u.FullName)
                .HasColumnName("نام کامل")
                .HasMaxLength(200);

            modelBuilder.Entity<User>()
                .Property(u => u.Phone)
                .HasColumnName("تلفن همراه");

            modelBuilder.Entity<User>()
                .Property(u => u.Address)
                .HasColumnName("آدرس");

            modelBuilder.Entity<User>()
                .Property(u => u.age)
                .HasColumnName("سن")
                .HasDefaultValue(null);

            modelBuilder.Entity<User>()
                .Property(u => u.Email)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(u => u.Password)
                .HasColumnName("کلمه عبور")
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(u => u.ActiveCode)
                .HasColumnName("کدفعالسازی")
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(u => u.isActive)
                .HasColumnName("وضعیت حساب")
                .HasDefaultValue(false);

            modelBuilder.Entity<User>()
                .Property(u => u.RoleId)
                .HasColumnName("نقش")
                .HasDefaultValue(false);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            #endregion

            #region Role

            modelBuilder.Entity<Role>()
                .Property(r => r.Name)
                .HasColumnName("نام نقش");

            #endregion

            #region Category

            modelBuilder.Entity<Category>()
                .Property(u => u.Title)
                .HasColumnName("نام دسته بندی");

            modelBuilder.Entity<Category>()
                .Property(u => u.ImageName)
                .HasColumnName("تصویر");

            #endregion

            #region Brand

            modelBuilder.Entity<Brand>()
                .Property(u => u.Title)
                .HasColumnName("نام برند");

            modelBuilder.Entity<Brand>()
                .Property(u => u.ImageName)
                .HasColumnName("تصویر برند");

            #endregion

            #region Feature

            modelBuilder.Entity<Feature>()
                .Property(u => u.Title)
                .HasColumnName("نام ویژگی");

            #endregion

            #region Product

            modelBuilder.Entity<Product>()
                .Property(p => p.Title)
                .HasColumnName("نام محصول");

            modelBuilder.Entity<Product>()
                .Property(p => p.ShortDescription)
                .HasColumnName("توضیح مختصر");

            modelBuilder.Entity<Product>()
                .Property(p => p.Description)
                .HasColumnName("توضیحات");

            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnName("قیمت")
                .HasDefaultValue(0);

            modelBuilder.Entity<Product>()
                .Property(p => p.DiscountAmount)
                .HasColumnName("مقدار تخفیف")
                .HasDefaultValue(0);

            modelBuilder.Entity<Product>()
                .Property(p => p.Inventory)
                .HasColumnName("موجودی")
                .HasDefaultValue(0);

            modelBuilder.Entity<Product>()
                .Property(p => p.Displayed)
                .HasColumnName("نمایش در فروشگاه")
                .HasDefaultValue(true);

            modelBuilder.Entity<Product>()
                .Property(p => p.CategoryId)
                .HasColumnName("دسته بندی");

            modelBuilder.Entity<Product>()
                .Property(p => p.BrandId)
                .HasColumnName("برند");

            #endregion
        }

        private void ApplyRelations(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId)
                .IsRequired();
               
            modelBuilder.Entity<Product>()
                .HasMany(p => p.Images)
                .WithOne(i => i.Product);

            modelBuilder.Entity<Product>()
                 .HasOne(p => p.Brand)
                 .WithMany(b => b.Product)
                 .HasForeignKey(p => p.BrandId);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .IsRequired();

            modelBuilder.Entity<ProductImage>()
                .HasOne(pi => pi.Product)
                .WithMany(p => p.Images)
                .HasForeignKey(pi => pi.ProductId);

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

            modelBuilder.Entity<Category>()
                .HasOne(c => c.ParentCategory)
                .WithMany(c => c.SubCategories)
                .HasForeignKey(c => c.ParentCategoryId);

        }


    }
}
