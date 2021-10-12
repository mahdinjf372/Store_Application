using System.Threading.Tasks;
using Store_Application.Domain.Entities.User;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using Store_Application.Domain.Entities.Product;
using Store_Application.Domain.Entities.Site;
using Store_Application.Domain.Entities.Finance;
using Store_Application.Domain.Entities.Order;
using Store_Application.Domain.Entities.Cart;
using Store_Application.Domain.Entities.Question;
using Store_Application.Domain.Entities.Comment;
using Store_Application.Domain.Entities.Compare;
using Store_Application.Domain.Entities.Favorite;
using Store_Application.Domain.Entities.Statistic;

namespace Store_Application.Application.Interfaces.Context
{
    public interface IDataBaseContext
    {

        #region User

        DbSet<User> Users { get; set; }
        DbSet<Role> Roles { get; set; }
        DbSet<UserRoles> UserRoles { get; set; }

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
        DbSet<Tag> Tags { get; set; }


        #endregion

        #region Site

        DbSet<MainSlider> MainSlides { get; set; }
        DbSet<BrandSlider> BrandSlides { get; set; }
        DbSet<Advertising> Advertisings { get; set; }

        #endregion

        #region Cart

        DbSet<Cart> Carts { get; set; }
        DbSet<CartItem> CartItems { get; set; }

        #endregion

        #region Order

        DbSet<Order> Orders { get; set; }
        DbSet<OrderDetail> OrderDetails { get; set; }

        #endregion

        #region Finance

        DbSet<RequestPay> RequestPays { get; set; }

        #endregion

        #region Question

        DbSet<Question> Questions { get; set; }

        #endregion

        #region Comment

        DbSet<Comment> Comments { get; set; }
        DbSet<Like> Likes { get; set; }
        DbSet<Dislike> Dislikes { get; set; }

        #endregion

        #region Favorite

        public DbSet<Favorite> Favorites { get; set; }

        #endregion

        #region Compaire

        public DbSet<Compare> Compares { get; set; }

        #endregion

        #region Statistic

        DbSet<SiteRequest> SiteRequests { get; set; }
        DbSet<SearchKeyInfo> SearchKeysInfo { get; set; }

        #endregion

        int SaveChanges(bool acceptAllChangesOnSuccess);
        int SaveChanges();
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
