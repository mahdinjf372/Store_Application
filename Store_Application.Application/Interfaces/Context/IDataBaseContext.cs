using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store_Application.Domain.Entities.User;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using Store_Application.Domain.Entities.Product;
using Store_Application.Domain.Entities.Site;
using Store_Application.Domain.Entities.Finance;
using Store_Application.Domain.Entities.Order;
using Store_Application.Domain.Entities.Cart;

namespace Store_Application.Application.Interfaces.Context
{
    public interface IDataBaseContext
    {

        #region User

        DbSet<User> Users { get; set; }
        DbSet<Role> Roles { get; set; }

        #endregion

        #region Product

        DbSet<Category> Categories { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<ProductFeature> ProductFeatures { get; set; }
        DbSet<Feature> Features { get; set; }
        DbSet<ProductImage> ProductImages { get; set; }
        DbSet<Brand> Brands { get; set; }
        DbSet<Slider> Sliders { get; set; }
        DbSet<ProductSlider> ProductSliders { get; set; }

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

        int SaveChanges(bool acceptAllChangesOnSuccess);
        int SaveChanges();
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
