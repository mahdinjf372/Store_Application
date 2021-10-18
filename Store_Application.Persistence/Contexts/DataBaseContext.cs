using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Store_Application.Domain.Entities.User;
using Store_Application.Application.Interfaces.Context;
using Store_Application.Domain.Entities.Product;
using Store_Application.Domain.Entities.Site;
using Store_Application.Domain.Entities.Cart;
using Store_Application.Domain.Entities.Order;
using Store_Application.Domain.Entities.Finance;
using Store_Application.Common.Security;
using Store_Application.Domain.Entities.Question;
using Store_Application.Domain.Entities.Comment;
using Store_Application.Domain.Entities.Compare;
using Store_Application.Domain.Entities.Favorite;
using Store_Application.Domain.Entities.Statistic;
using Store_Application.Persistence.Configurations.Entities.User;
using Store_Application.Persistence.Configurations.Entities.Role;
using Store_Application.Persistence.Configurations.Entities.UserRoles;
using Store_Application.Persistence.Configurations.Entities.Category;
using Store_Application.Persistence.Configurations.Entities.Brand;
using Store_Application.Persistence.Configurations.Entities.Feature;
using Store_Application.Persistence.Configurations.Entities.Product;
using Store_Application.Persistence.Configurations.Entities.MainSlider;
using Store_Application.Persistence.Configurations.Entities.BrandSlider;
using Store_Application.Persistence.Configurations.Entities.Advertising;
using Store_Application.Persistence.Configurations.Entities.CartItem;
using Store_Application.Persistence.Configurations.Entities.Question;
using Store_Application.Persistence.Configurations.Entities.Comment;
using Store_Application.Persistence.Configurations.Entities.ProductImage;
using Store_Application.Persistence.Configurations.Entities.ProductFeature;
using Store_Application.Persistence.Configurations.Entities.Cart;
using Store_Application.Persistence.Configurations.Entities.Compare;
using Store_Application.Persistence.Configurations.Entities.Favorite;
using Store_Application.Persistence.Configurations.Entities.OrderDetail;
using Store_Application.Persistence.Configurations.Entities.Order;
using Store_Application.Persistence.Configurations.Entities.ProductSlider;
using Store_Application.Persistence.Configurations.Entities.RequestPay;
using Store_Application.Persistence.Configurations.Entities.Tag;
using System.Linq;

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
        public DbSet<UserRoles> UserRoles { get; set; }

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
        public DbSet<Tag> Tags { get; set; }

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

        #region Question

        public DbSet<Question> Questions { get; set; }

        #endregion

        #region Comment

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Dislike> Dislikes { get; set; }

        #endregion

        #region Favorite

        public DbSet<Favorite> Favorites { get; set; }

        #endregion

        #region Compaire

        public DbSet<Compare> Compares { get; set; }

        #endregion

        #region Statistic

        public DbSet<SiteRequest> SiteRequests { get; set; }
        public DbSet<SearchKeyInfo> SearchKeysInfo { get; set; }

        #endregion

        //28

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigurationEntities(modelBuilder);

            ApplyQueryFilters(modelBuilder);

            SeedData(modelBuilder);

            SeedsTestData(modelBuilder);
        }

        private void ApplyQueryFilters(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasQueryFilter(u => !u.isRemoved);
            modelBuilder.Entity<Role>().HasQueryFilter(r => !r.isRemoved);
            modelBuilder.Entity<UserRoles>().HasQueryFilter(s => !s.isRemoved);
            modelBuilder.Entity<Category>().HasQueryFilter(c => !c.isRemoved);
            modelBuilder.Entity<Product>().HasQueryFilter(p => !p.isRemoved && p.Displayed);
            modelBuilder.Entity<Feature>().HasQueryFilter(f => !f.isRemoved);
            modelBuilder.Entity<ProductImage>().HasQueryFilter(pi => !pi.isRemoved);
            modelBuilder.Entity<Brand>().HasQueryFilter(b => !b.isRemoved);
            modelBuilder.Entity<Slider>().HasQueryFilter(s => !s.isRemoved);
            modelBuilder.Entity<ProductSlider>().HasQueryFilter(ps => !ps.isRemoved);
            modelBuilder.Entity<ProductFeature>().HasQueryFilter(pf => !pf.isRemoved);
            modelBuilder.Entity<MainSlider>().HasQueryFilter(ms => !ms.isRemoved);
            modelBuilder.Entity<BrandSlider>().HasQueryFilter(bs => !bs.isRemoved);
            modelBuilder.Entity<Advertising>().HasQueryFilter(a => !a.isRemoved);
            modelBuilder.Entity<Cart>().HasQueryFilter(c => !c.isRemoved);
            modelBuilder.Entity<CartItem>().HasQueryFilter(ci => !ci.isRemoved);
            modelBuilder.Entity<Question>().HasQueryFilter(q => !q.isRemoved);
            modelBuilder.Entity<Comment>().HasQueryFilter(c => !c.isRemoved);
            modelBuilder.Entity<Like>().HasQueryFilter(l => !l.isRemoved);
            modelBuilder.Entity<Dislike>().HasQueryFilter(d => !d.isRemoved);
            modelBuilder.Entity<Favorite>().HasQueryFilter(f => !f.isRemoved);
            modelBuilder.Entity<Compare>().HasQueryFilter(c => !c.isRemoved);
            modelBuilder.Entity<Tag>().HasQueryFilter(c => !c.isRemoved);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(new List<Role>
            {
                new Role { Id = (int)Domain.Enums.Roles.Admin, Name = nameof(Domain.Enums.Roles.Admin) },
                new Role { Id = (int)Domain.Enums.Roles.Operator, Name = nameof(Domain.Enums.Roles.Operator) },
                new Role { Id = (int)Domain.Enums.Roles.Customer, Name = nameof(Domain.Enums.Roles.Customer) }
            });

            modelBuilder.Entity<Brand>().HasData(new Brand { Id = 4, Title = "بدون برند", InsertTime = DateTime.Now });

            modelBuilder.Entity<Slider>().HasData(new List<Slider>
            {
                new Slider { Id = 1, Title = "پیشنهاد لحظه ای", InsertTime=DateTime.Now },
                new Slider { Id = 2, Title = "دوربین", InsertTime=DateTime.Now },
                new Slider { Id = 3, Title = "موبایل", InsertTime=DateTime.Now },
                new Slider { Id = 4, Title = "لپ تاپ", InsertTime=DateTime.Now },
            });

            modelBuilder.Entity<User>().HasData(new List<User>
            {
                new User {
                    Id = 1,
                    Username = "mahdinjf372" ,
                    InsertTime=DateTime.Now,
                    ActiveCode=Guid.NewGuid().ToString(),
                    Email="mahdinjf372@gmail.com",
                    FullName="مهدی نجفی پسند",
                    isActive = true,
                    Password = PasswordHelper.HashPassword("12345678")
                }
            });

            modelBuilder.Entity<UserRoles>().HasData(new List<UserRoles>
            {
                new UserRoles { Id = 1, InsertTime = DateTime.Now, UserId = 1, RoleId = (int)Domain.Enums.Roles.Admin},
                new UserRoles { Id = 2, InsertTime = DateTime.Now, UserId = 1, RoleId = (int)Domain.Enums.Roles.Customer},
                new UserRoles { Id = 3, InsertTime = DateTime.Now, UserId = 1, RoleId = (int)Domain.Enums.Roles.Operator},
            });
        }

        private void ConfigurationEntities(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdvertisingConfiguration());
            modelBuilder.ApplyConfiguration(new BrandConfiguration());
            modelBuilder.ApplyConfiguration(new BrandSliderConfiguration());
            modelBuilder.ApplyConfiguration(new CartConfiguration());
            modelBuilder.ApplyConfiguration(new CartItemConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
            modelBuilder.ApplyConfiguration(new CompareConfiguration());
            modelBuilder.ApplyConfiguration(new FavoriteConfiguration());
            modelBuilder.ApplyConfiguration(new FeatureConfiguration());
            modelBuilder.ApplyConfiguration(new MainSliderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductFeatureConfiguration());
            modelBuilder.ApplyConfiguration(new ProductImageConfiguration());
            modelBuilder.ApplyConfiguration(new ProductSliderConfiguration());
            modelBuilder.ApplyConfiguration(new QuestionConfiguration());
            modelBuilder.ApplyConfiguration(new RequestPayConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new TagConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserRolesConfiguration());
        }

        private void SeedsTestData(ModelBuilder modelBuilder)
        {

            #region Advertising

            modelBuilder.Entity<Advertising>().HasData(new List<Advertising>
            {
                new Advertising {
                    Id = 1,
                    Title = "بنر تستی 1",
                    LinkTo = "",
                    Description = "توضیحات بنر تستی 1",
                    ImageName = "topLeft1_default.jpg",
                    StartDate = DateTime.Now,
                    EndDate = new DateTime(2999,12,29),
                    InsertTime = DateTime.Now,
                    Place = Domain.Enums.AdvertisingPlaces.TopLeft1
                },
                new Advertising {
                    Id = 2,
                    Title = "بنر تستی 2",
                    LinkTo = "",
                    Description = "توضیحات بنر تستی 2",
                    ImageName = "topLeft2_default.jpg",
                    StartDate = DateTime.Now,
                    EndDate = new DateTime(2999,12,29),
                    InsertTime = DateTime.Now,
                    Place = Domain.Enums.AdvertisingPlaces.TopLeft2
                },
                new Advertising {
                    Id = 3,
                    Title = "بنر تستی 3",
                    LinkTo = "",
                    Description = "توضیحات بنر تستی 3",
                    ImageName = "topRight_default.jpg",
                    StartDate = DateTime.Now,
                    EndDate = new DateTime(2999,12,29),
                    InsertTime = DateTime.Now,
                    Place = Domain.Enums.AdvertisingPlaces.TopRight
                },
                new Advertising {
                    Id = 4,
                    Title = "بنر تستی 4",
                    LinkTo = "",
                    Description = "توضیحات بنر تستی 4",
                    ImageName = "bottomLong_default.jpg",
                    StartDate = DateTime.Now,
                    EndDate = new DateTime(2999,12,29),
                    InsertTime = DateTime.Now,
                    Place = Domain.Enums.AdvertisingPlaces.Long
                },
                new Advertising {
                    Id = 5,
                    Title = "بنر تستی 5",
                    LinkTo = "",
                    Description = "توضیحات بنر تستی 5",
                    ImageName = "bottom1_default.jpg",
                    StartDate = DateTime.Now,
                    EndDate = new DateTime(2999,12,29),
                    InsertTime = DateTime.Now,
                    Place = Domain.Enums.AdvertisingPlaces.Bottom1
                },
                new Advertising {
                    Id = 6,
                    Title = "بنر تستی 6",
                    LinkTo = "",
                    Description = "توضیحات بنر تستی 6",
                    ImageName = "bottom2_default.jpg",
                    StartDate = DateTime.Now,
                    EndDate = new DateTime(2999,12,29),
                    InsertTime = DateTime.Now,
                    Place = Domain.Enums.AdvertisingPlaces.Bottom2
                },
                new Advertising {
                    Id = 7,
                    Title = "بنر تستی 7",
                    LinkTo = "",
                    Description = "توضیحات بنر تستی 7",
                    ImageName = "bottom3_default.jpg",
                    StartDate = DateTime.Now,
                    EndDate = new DateTime(2999,12,29),
                    InsertTime = DateTime.Now,
                    Place = Domain.Enums.AdvertisingPlaces.Bottom3
                },
                new Advertising {
                    Id = 8,
                    Title = "بنر تستی 8",
                    LinkTo = "",
                    Description = "توضیحات بنر تستی 8",
                    ImageName = "bottom4_default.jpg",
                    StartDate = DateTime.Now,
                    EndDate = new DateTime(2999,12,29),
                    InsertTime = DateTime.Now,
                    Place = Domain.Enums.AdvertisingPlaces.Bottom4
                },
            });

            #endregion

            #region BrandSlides

            modelBuilder.Entity<BrandSlider>().HasData(new List<BrandSlider>
            {
                new BrandSlider{
                    Id=1,
                    Title="هواوی",
                    ImageName="huawei.png",
                    LinkTo = "",
                    InsertTime = DateTime.Now
                },
                new BrandSlider{
                    Id=2,
                    Title="سامسونگ",
                    ImageName="samsung.png",
                    LinkTo = "",
                    InsertTime = DateTime.Now
                },
                new BrandSlider{
                    Id=3,
                    Title="ای دیتا",
                    ImageName="adata.png",
                    LinkTo = "",
                    InsertTime = DateTime.Now
                },
                new BrandSlider{
                    Id=4,
                    Title="شهاب",
                    ImageName="shahab.png",
                    LinkTo = "",
                    InsertTime = DateTime.Now
                },
                new BrandSlider{
                    Id=5,
                    Title="نوکیا",
                    ImageName="nokia.png",
                    LinkTo = "",
                    InsertTime = DateTime.Now
                },
                new BrandSlider{
                    Id=6,
                    Title="پاناسونیک",
                    ImageName="panasonic.png",
                    LinkTo = "",
                    InsertTime = DateTime.Now
                },
                new BrandSlider{
                    Id=7,
                    Title="پارس خزر",
                    ImageName="parskhazar.png",
                    LinkTo = "",
                    InsertTime = DateTime.Now
                },
                new BrandSlider{
                    Id=8,
                    Title="ایکس ویژن",
                    ImageName="xvison.png",
                    LinkTo = "",
                    InsertTime = DateTime.Now
                },
            });

            #endregion

            #region Comments

            modelBuilder.Entity<Comment>().HasData(new List<Comment>
            {
                new Comment
                {
                    Id = 1,
                    Title = "دوست داشتنی",
                    Text = "محصول دوست داشتنی به نظر میاد",
                    IRecommended = true,
                    InsertTime = DateTime.Now,
                    ProductId = 1,
                    UserId = 1,
                    Rate = (byte) new Random().Next(1,5),
                    AdminIsRead = true,
                    ConfirmedByAdmin = true,
                },
                new Comment
                {
                    Id = 2,
                    Title = "قیمت",
                    Text = "به نظرم قیمتش خیلی بالاس و مناسب نیس",
                    IRecommended = false,
                    InsertTime = DateTime.Now,
                    ProductId = 1,
                    UserId = 2,
                    Rate = (byte) new Random().Next(1,5),
                    AdminIsRead = true,
                    ConfirmedByAdmin = true,
                },
                new Comment
                {
                    Id = 3,
                    Title = "بهتر از آیفون",
                    Text = "در کل سامسونگ کاربردی تر از آیفون هست ولی از نظر کیفیت تصویر و سرعت آیفون بهتره و کلاس!",
                    IRecommended = true,
                    InsertTime = DateTime.Now,
                    ProductId = 1,
                    UserId = 3,
                    Rate = (byte) new Random().Next(1,5),
                    AdminIsRead = true,
                    ConfirmedByAdmin = true,
                },
                new Comment
                {
                    Id = 4,
                    Title = "عالی و صدرصد بهتر از اپل",
                    Text = "عالییه بنظرمن اونایی که میرن پول گوشی های ایفون با اون قیمت رو میدن با استفاده از این گوشی باید نظرشونو عوض کنن",
                    IRecommended = true,
                    InsertTime = DateTime.Now,
                    ProductId = 1,
                    UserId = 4,
                    Rate = (byte) new Random().Next(1,5),
                    AdminIsRead = true,
                    ConfirmedByAdmin = true,
                },
                new Comment
                {
                    Id = 5,
                    Title = "زشته",
                    Text = "به نظرم طراحی خوبی نداره و زشته یکم",
                    IRecommended = false,
                    InsertTime = DateTime.Now,
                    ProductId = 2,
                    UserId = 3,
                    Rate = (byte) new Random().Next(1,5),
                    AdminIsRead = true,
                    ConfirmedByAdmin = true,
                },
                new Comment
                {
                    Id = 6,
                    Title = "خوبه",
                    Text = "به به عجب چیزیه من که نمیتون وارد شم",
                    IRecommended = true,
                    InsertTime = DateTime.Now,
                    ProductId = 2,
                    UserId = 5,
                    Rate = (byte) new Random().Next(1,5),
                    AdminIsRead = true,
                    ConfirmedByAdmin = true,
                },
                new Comment
                {
                    Id = 7,
                    Title = "خیلیم خوب نیس",
                    Text = "خیلیم خوب نیست به نظرم نمیصرفه",
                    IRecommended = false,
                    InsertTime = DateTime.Now,
                    ProductId = 2,
                    UserId = 2,
                    Rate = (byte) new Random().Next(1,5),
                    AdminIsRead = true,
                    ConfirmedByAdmin = true,
                },
                new Comment
                {
                    Id = 8,
                    Title = "عالیه",
                    Text = "عاااااااالیییییه بنظرم",
                    IRecommended = true,
                    InsertTime = DateTime.Now,
                    ProductId = 2,
                    UserId = 4,
                    Rate = (byte) new Random().Next(1,5),
                    AdminIsRead = true,
                    ConfirmedByAdmin = true,
                },
            });

            #endregion

            #region Likes-Dislikes

            modelBuilder.Entity<Like>().HasData(new List<Like>
            {
                new Like
                {
                    Id = 1,
                    CommentId= 1,
                    UserId = 2,
                    InsertTime = DateTime.Now
                },
                new Like
                {
                    Id = 2,
                    CommentId= 1,
                    UserId = 4,
                    InsertTime = DateTime.Now
                },
                new Like
                {
                    Id = 3,
                    CommentId= 1,
                    UserId = 2,
                    InsertTime = DateTime.Now
                },
                new Like
                {
                    Id = 4,
                    CommentId= 1,
                    UserId = 3,
                    InsertTime = DateTime.Now
                },
                new Like
                {
                    Id = 5,
                    CommentId= 2,
                    UserId = 1,
                    InsertTime = DateTime.Now
                },
                new Like
                {
                    Id = 6,
                    CommentId= 2,
                    UserId = 3,
                    InsertTime = DateTime.Now
                },
                new Like
                {
                    Id = 7,
                    CommentId= 3,
                    UserId = 4,
                    InsertTime = DateTime.Now
                },
                new Like
                {
                    Id = 8,
                    CommentId= 3,
                    UserId = 1,
                    InsertTime = DateTime.Now
                },
            });

            modelBuilder.Entity<Dislike>().HasData(new List<Dislike>
            {
                new Dislike
                {
                    Id = 1,
                    CommentId= 1,
                    UserId = 5,
                    InsertTime = DateTime.Now
                },
                new Dislike
                {
                    Id = 2,
                    CommentId= 2,
                    UserId = 2,
                    InsertTime = DateTime.Now
                },
                new Dislike
                {
                    Id = 3,
                    CommentId= 2,
                    UserId = 4,
                    InsertTime = DateTime.Now
                },
                new Dislike
                {
                    Id = 4,
                    CommentId= 2,
                    UserId = 5,
                    InsertTime = DateTime.Now
                },
                new Dislike
                {
                    Id = 5,
                    CommentId = 3,
                    UserId = 2,
                    InsertTime = DateTime.Now
                },
                new Dislike
                {
                    Id = 6,
                    CommentId = 3,
                    UserId = 5,
                    InsertTime = DateTime.Now
                },
                new Dislike
                {
                    Id = 7,
                    CommentId = 3,
                    UserId = 3,
                    InsertTime = DateTime.Now
                },
            });

            #endregion

            #region Comments


            modelBuilder.Entity<Question>().HasData(new List<Question>
            {
                new Question
                {
                    Id = 1,
                    Text = "محصول دوست داشتنی به نظر میاد کسی ازش استفاده کرده؟",
                    ParentQuestionId = null,
                    InsertTime = DateTime.Now,
                    ProductId = 1,
                    UserId = 2,
                    AdminIsRead = true,
                    ConfirmedByAdmin = true,
                },
                new Question
                {
                    Id = 2,
                    Text = "باتریش چند ساعت و نگه میداره؟",
                    ParentQuestionId = null,
                    InsertTime = DateTime.Now,
                    ProductId = 1,
                    UserId = 1,
                    AdminIsRead = true,
                    ConfirmedByAdmin = true,
                },
                new Question
                {
                    Id = 3,
                    Text = "من دارمش راضیم ازش",
                    ParentQuestionId = 1,
                    InsertTime = DateTime.Now,
                    ProductId = 1,
                    UserId = 3,
                    AdminIsRead = true,
                    ConfirmedByAdmin = true,
                },
                new Question
                {
                    Id = 4,
                    Text = "میتونه اهنگ پخش کنه؟",
                    ParentQuestionId = null,
                    InsertTime = DateTime.Now,
                    ProductId = 2,
                    UserId = 4,
                    AdminIsRead = true,
                    ConfirmedByAdmin = true,
                },
                new Question
                {
                    Id = 5,
                    Text = "صفحش چند هرتزه؟",
                    ParentQuestionId = null,
                    InsertTime = DateTime.Now,
                    ProductId = 2,
                    UserId = 2,
                    AdminIsRead = true,
                    ConfirmedByAdmin = true,
                },
                new Question
                {
                    Id = 6,
                    Text = "تو سایت برندش نوشته 60 هرتز",
                    ParentQuestionId = 5,
                    InsertTime = DateTime.Now,
                    ProductId = 2,
                    UserId = 5,
                    AdminIsRead = true,
                    ConfirmedByAdmin = true,
                },
                new Question
                {
                    Id = 7,
                    Text = "با 10 تومن اینو بخرم یا اونو؟؟؟",
                    ParentQuestionId = null,
                    InsertTime = DateTime.Now,
                    ProductId = 2,
                    UserId = 1,
                    AdminIsRead = true,
                    ConfirmedByAdmin = true,
                },
                new Question
                {
                    Id = 8,
                    Text = "هیچکدومو",
                    ParentQuestionId = 7,
                    InsertTime = DateTime.Now,
                    ProductId = 2,
                    UserId = 4,
                    AdminIsRead = true,
                    ConfirmedByAdmin = true,
                },
            });

            #endregion

            #region Users

            modelBuilder.Entity<User>().HasData(new List<User>
            {
                new User {
                    Id = 2,
                    Username = "Sara" ,
                    InsertTime=DateTime.Now,
                    ActiveCode=Guid.NewGuid().ToString(),
                    Email="sara@gmail.com",
                    FullName="سارا",
                    isActive = true,
                    Password = PasswordHelper.HashPassword("12345678")
                },
                new User {
                    Id = 3,
                    Username = "Ali" ,
                    InsertTime=DateTime.Now,
                    ActiveCode=Guid.NewGuid().ToString(),
                    Email="ali@gmail.com",
                    FullName="علی",
                    isActive = true,
                    Password = PasswordHelper.HashPassword("12345678")
                },
                new User {
                    Id = 4,
                    Username = "mmd" ,
                    InsertTime=DateTime.Now,
                    ActiveCode=Guid.NewGuid().ToString(),
                    Email="mohammad@gmail.com",
                    FullName="محمد",
                    isActive = true,
                    Password = PasswordHelper.HashPassword("12345678")
                },
                new User {
                    Id = 5,
                    Username = "Ehsan" ,
                    InsertTime=DateTime.Now,
                    ActiveCode=Guid.NewGuid().ToString(),
                    Email="ehsan@gmail.com",
                    FullName="احسان",
                    isActive = true,
                    Password = PasswordHelper.HashPassword("12345678")
                },
            });

            #endregion

            #region UserRoles

            modelBuilder.Entity<UserRoles>().HasData(new List<UserRoles>
            {
                new UserRoles { Id = 4, InsertTime = DateTime.Now, UserId = 2, RoleId = (int)Domain.Enums.Roles.Operator},
                new UserRoles { Id = 5, InsertTime = DateTime.Now, UserId = 2, RoleId = (int)Domain.Enums.Roles.Customer},
                new UserRoles { Id = 6, InsertTime = DateTime.Now, UserId = 3, RoleId = (int)Domain.Enums.Roles.Customer},
                new UserRoles { Id = 7, InsertTime = DateTime.Now, UserId = 4, RoleId = (int)Domain.Enums.Roles.Customer},
                new UserRoles { Id = 8, InsertTime = DateTime.Now, UserId = 5, RoleId = (int)Domain.Enums.Roles.Customer},
            });

            #endregion

            #region Category

            modelBuilder.Entity<Category>().HasData(new List<Category>
            {
                new Category {
                    Id = 1,
                    InsertTime = DateTime.Now,
                    ParentCategoryId = null,
                    Title = "کالای دیجیتال"
                },
                new Category {
                    Id = 8,
                    InsertTime = DateTime.Now,
                    ParentCategoryId = 1,
                    Title = "لپ تاپ"
                },
                new Category {
                    Id = 11,
                    InsertTime = DateTime.Now,
                    ParentCategoryId = 8,
                    Title = "ایسوس"
                },
                new Category {
                    Id = 12,
                    InsertTime = DateTime.Now,
                    ParentCategoryId = 8,
                    Title = "اپل"
                },
                new Category {
                    Id = 13,
                    InsertTime = DateTime.Now,
                    ParentCategoryId = 8,
                    Title = "مایکروسافت"
                },
                new Category {
                    Id = 14,
                    InsertTime = DateTime.Now,
                    ParentCategoryId = 8,
                    Title = "ایسر"
                },


                new Category {
                    Id = 9,
                    InsertTime = DateTime.Now,
                    ParentCategoryId = 1,
                    Title = "موبایل"
                },
                new Category {
                    Id = 15,
                    InsertTime = DateTime.Now,
                    ParentCategoryId = 9,
                    Title = "اپل"
                },
                new Category {
                    Id = 16,
                    InsertTime = DateTime.Now,
                    ParentCategoryId = 9,
                    Title = "سامسونگ"
                },
                new Category {
                    Id = 17,
                    InsertTime = DateTime.Now,
                    ParentCategoryId = 9,
                    Title = "نوکیا"
                },
                new Category {
                    Id = 18,
                    InsertTime = DateTime.Now,
                    ParentCategoryId = 9,
                    Title = "شیاومی"
                },


                new Category {
                    Id = 10,
                    InsertTime = DateTime.Now,
                    ParentCategoryId = 1,
                    Title = "دوربین"
                },new Category {
                    Id = 19,
                    InsertTime = DateTime.Now,
                    ParentCategoryId = 10,
                    Title = "کنون"
                },
                new Category {
                    Id = 20,
                    InsertTime = DateTime.Now,
                    ParentCategoryId = 10,
                    Title = "سامسونگ"
                },
                new Category {
                    Id = 21,
                    InsertTime = DateTime.Now,
                    ParentCategoryId = 10,
                    Title = "متفرقه"
                },



                new Category {
                    Id = 2,
                    InsertTime = DateTime.Now,
                    ParentCategoryId = null,
                    Title = "آرایشی و بهداشتی"
                },
                new Category {
                    Id = 22,
                    InsertTime = DateTime.Now,
                    ParentCategoryId = 2,
                    Title = "لوازم آرایشی"
                },
                new Category {
                    Id = 23,
                    InsertTime = DateTime.Now,
                    ParentCategoryId = 22,
                    Title = "آرایش چشم و ابرو"
                },
                new Category {
                    Id = 24,
                    InsertTime = DateTime.Now,
                    ParentCategoryId = 22,
                    Title = "آرایش لب"
                },
                new Category {
                    Id = 25,
                    InsertTime = DateTime.Now,
                    ParentCategoryId = 22,
                    Title = "آرایش چشم"
                },

                new Category {
                    Id = 26,
                    InsertTime = DateTime.Now,
                    ParentCategoryId = 2,
                    Title = "لوازم شخصی برقی"
                },
                new Category {
                    Id = 27,
                    InsertTime = DateTime.Now,
                    ParentCategoryId = 26,
                    Title = "ماشین اصلاح صورت"
                },
                new Category {
                    Id = 28,
                    InsertTime = DateTime.Now,
                    ParentCategoryId = 26,
                    Title = "ماشین اصلاح سر"
                },
                new Category {
                    Id = 29,
                    InsertTime = DateTime.Now,
                    ParentCategoryId = 26,
                    Title = "سشوار"
                },







                new Category {
                    Id = 3,
                    InsertTime = DateTime.Now,
                    ParentCategoryId = null,
                    Title = "ابزار و اداری"
                },
                new Category {
                    Id = 4,
                    InsertTime = DateTime.Now,
                    ParentCategoryId = null,
                    Title = "مد و پوشاک"
                },
                new Category {
                    Id = 5,
                    InsertTime = DateTime.Now,
                    ParentCategoryId = null,
                    Title = "خانه و آشپزخانه"
                },
                new Category {
                    Id = 6,
                    InsertTime = DateTime.Now,
                    ParentCategoryId = null,
                    Title = "لوازم تحریر و هنر"
                },
                new Category {
                    Id = 7,
                    InsertTime = DateTime.Now,
                    ParentCategoryId = null,
                    Title = "کودک و نوزاد"
                },

            });

            #endregion

            #region MainSlider

            modelBuilder.Entity<MainSlider>().HasData(new List<MainSlider>
            {
                new MainSlider {
                    Id = 1,
                    InsertTime = DateTime.Now,
                    Title = "اسلایدر تستی 1",
                    ImageName = "a866effd8dc64a4e91a4a1a024629166.jpg",
                    LinkTo = null,
                },
                new MainSlider {
                    Id = 2,
                    InsertTime = DateTime.Now,
                    Title = "اسلایدر تستی 2",
                    ImageName = "7494777a77864093a32ee9984c0a6520.jpg",
                    LinkTo = null,
                },
                new MainSlider {
                    Id = 3,
                    InsertTime = DateTime.Now,
                    Title = "اسلایدر تستی 3",
                    ImageName = "6d9a11244f8f4bd8a614b81f2e702799.jpg",
                    LinkTo = null,
                },
            });

            #endregion

            #region Brands

            modelBuilder.Entity<Brand>().HasData(new List<Brand>
            {
                new Brand {
                    Id = 1,
                    InsertTime = DateTime.Now,
                    Title = "سامسونگ",
                },
                new Brand {
                    Id = 2,
                    InsertTime = DateTime.Now,
                    Title = "اپل",
                },
                new Brand {
                    Id = 3,
                    InsertTime = DateTime.Now,
                    Title = "نوکیا",
                },
            });

            #endregion

            #region Feature

            modelBuilder.Entity<Feature>().HasData(new List<Feature>
            {
                new Feature {
                    Id = 1,
                    InsertTime = DateTime.Now,
                    Title = "سیستم عامل",
                },
                new Feature {
                    Id = 2,
                    InsertTime = DateTime.Now,
                    Title = "رنگ",
                },
                new Feature {
                    Id = 3,
                    InsertTime = DateTime.Now,
                    Title = "ورژن سیستم عامل",
                },
                new Feature {
                    Id = 4,
                    InsertTime = DateTime.Now,
                    Title = "بلوتوث",
                },
                new Feature {
                    Id = 5,
                    InsertTime = DateTime.Now,
                    Title = "دوبین عقب",
                },
                new Feature {
                    Id = 6,
                    InsertTime = DateTime.Now,
                    Title = "دوربین جلو",
                },

            });

            #endregion

            #region Products
            string title1 = "سامسونگ مدل Galaxy Note 10 SM-N970F/DS دو سیم‌کارت ظرفیت 256 گیگابایت";
            string title2 = "اپل آیفون ایکس اس مکس – 256 گیگابایت – دو سیم کارت";
            string shortDescription = "اولین گوشی همراه سری گلکسی نوت در سال 2011 روانه بازار شد تا خانواده افسانه‌ای نوت را برای اولین بار به دنیا معرفی و تعریفی نو برای محصولات «فبلت‌» ارائه کند. حدود 8 سال پس از آن، سامسونگ برای عرضه عضو جدید خانواده نوت(Galaxy Note 10) با چالش‌های جدیدی مواجه است؛ این چالش‌ها ویژگی‌های مدرنی هستند که در محصولات رقیب دیده می‌شوند.گلکسی نوت‌ها به‌طور عمومی شبیه سری Galaxy S هستند؛ با این تفاوت که صفحه‌نمایش بزرگ‌تر و یک قلم دیجیتال S Pen دارند.گوشی موبایل Samsung Galaxy Note10 با دوربین سه گانه در قاب پشتی روانه بازار شده است؛ این سه سنسور با داشتن ویژگی‌هایی مانند لرزشگیر تصویر و قابلیت فیلم‌برداری 4K خروجی تصویر مطلوبی را برای جدیدترین عضو خانواده Note به همراه دارند.پردازش محاسبات در این تازه‌وارد از طریق تراشه‌ی Exynos 9825 انجام می‌شود که در رده تراشه‌های 7 نانومتری قرار می‌گیرد و با سرعت بالای خود، گلکسی نوت 10 را برای انجام کارهای بسیار سنگین کاربردی کرده است.تراشه‌ی گرافیکی Mali - G76 هم در اجرای بازی‌های سنگین و پردازش‌های گرافیکی، گلکسی نوت 10 را سربلند خواهد بود. صفحه‌نمایش سوپر آمولد با رزولوشن 1080 در 2280 و قابلیت نمایش 401 پیکسل در هر اینچ، تجربه‌ی تصویری شفاف و بسیار مطلوب را برای کاربران فراهم می‌کند.نسخه 256 گیگابایتی گوشی گلکسی نوت 10 با 8 گیگابایت رم عرضه شده است تا میزان مطلوبی از فضا و حافظه تصادفی را در اختیار کاربر قرار دهد.حسگر اثرانگشت زیرصفحه‌نمایش، حسگر فشارسنج و ژیروسکوپ تنها تعدادی از امکانات این دستگاه قدرتمند است و کار را برای رقبای این محصول بزرگ سخت کرده است.البته در این محصول خبری از سنسور عنبیه چشم و خروجی 3.5 میلی‌متری صدا نیست که دلیل آن را می‌توان در بزرگ شدن قاب و ظرافت در طراحی و ساخت جست‌وجو کرد. گفتنی است، باتری این محصول از نوع غیرقابل تعویض و لیتیوم‌یون با ظرفیت 3500 میلی‌آمپر ساعت است که از فناوری‌های شارژ سریع و شارژ بی‌سیم پشتیبانی می‌کند.این محصول قادر است دستگاه‌های دیگر را هم به‌صورت بی‌سیم شارژ کند و از این طریق نقش یک پاوربانک را هم ایفا کند.";
            string Description = "<h3 class=\"content-expert-title\" style=\"text-align:right;\">طراحی و ساخت؛ زیبای خاص</h3><p class=\"content-expert-title\" style=\"text-align:right;\">باید در همین ابتدا اعتراف کنیم Galaxy Note 10 یک گوشی بسیار زیباست. البته شاید این تعریف کمی شخصی به نظر برسد اما ظاهر این گوشی آن‌قدر زیباست که جایی را برای گله و شکایت باقی نمی‌گذارد. در این گوشی دوست‌داشتنی صفحه‌نمایش تقریباً تمام قاب جلویی را پوشانده است. این گوشی ابعاد بزرگی دارد و با صفحه‌نمایش 6.3 که تقریبا 0.2 اینچ بزرگتر از S10 است، در گروه فبلت‌ها جای می‌گیرد. اگر به دنبال خرید این گوشی هوشمند هستید، احتمالاً قبلاً هم گوشی بزرگی داشته‌اید و اندازه آن برایتان آزاردهنده نخواهد بود. اولین راه‌حل موفق برای ساده کردن فرمول زیبایی و کارایی بیشتر، تغییر مکان حسگر اثرانگشت در گلکسی نوت 10 است. با توجه به امنیت بالای این راه برای باز کردن گوشی، حذف آن چندان منطقی به نظر نمی‌رسد. در این گوشی خبری از حسگر اثرانگشت روی قاب جلویی نیست و در عوض این حسگر زیر صفحه‌نمایش قرار گرفته است تا Galaxy Note 10 از همه نظر به گوشی مدرن تبدیل شود. تفاوت دیگری که امسال گلکسی سری نوت با گلسی سری S &nbsp;داشته اند محل قرار گرفتن دوربین سلفی آن ها است. به طوری که دوربین سلفی در S10 در قسمت بالای سمت راست قرار گرفته و در نوت 10 در مرکز بالای صفحه نمایش تعبیه شده است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:44.36%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/84a990c5-6102-4bd2-b587-76be3df30835.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">صفحه‌نمایش؛ همان خیره‌کننده‌ی همیشگی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">مثل همیشه یکی از نقاط قوت گوشی سری محصولات Galaxy Note صفحه‌نمایش آن‌هاست. فناوری Super AMOLED به معنی تصاویر زنده و شفافیت خیره‌کننده در کنار پشتیبانی از نمایش ویدئوهای HDR است. گلکسی نوت 10 از یک صفحه نمایش 6.3 اینچی بهره می برد، که تقریبا تمام قاب جلویی را پوشانده است. سامسونگ مدت ها است که برای پرچمداران خود از صفحه نمایش هایی با لبه های منحنی شکل استفاده می کند؛ کاری که با تولید S8 آغاز کرد و گوشی Note 10 هم از این قاعده مستثنی نیست. انحنای لبه‌ها باعث می‌شود حس کنید فضای بسیار بیشتری در اختیار دارید. این نمایشگر، تراکم پیکسلی فوق‌العاده 401 در هر اینچ دارد روی نوت 10 قرار داده شده است؛ می‌توان این‌گونه در نظر گرفت که سامسونگ احتمالاً استفاده از تعداد پیکسل بالاتر را به علت مصرف باتری بیشتر و اندازه‌ی بزرگ‌تر را به علت بزرگ‌ترشدن سایز گوشی کنار گذاشته است.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.53%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/86e0699c-e0e0-401e-bdc3-84f3b5221258.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">به دلیل O شکل بودن بریدگی قسمت بالای آن، نام Infinity-O برای آن انتخاب شده است. نمایشگرهای Infinity در واقع از ویژگی های صفحه نمایش های سامسونگ است که بدون هیچ بریدگی یا Bezel تولید می شوند و برای اولین بار با به کار گیری در گوشی های&nbsp; Galaxy S8 و&nbsp; Galaxy S8+ معرفی شد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:49.3%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6154596f-bc8e-4019-b13f-1c8e4dd94aef.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نمایشگر نوت 10 هم از فناوری همیشه روشن سود می‌برد که با استفاده از بخش تنظیمات حالا می‌توانید شخصی‌سازی‌های بیشتری را برای آن در نظر بگیرید. سامسونگ موفق شده است برای این گوشی نسبت صفحه‌نمایش به بدنه 90.9 درصد را به دست آورد که برای یک گوشی امروزی هم میزان بسیار مطلوبی به‌حساب می‌آید. تراز سفیدی مناسب، نور کافی برای دیدن محتویات زیر نور‌های شدید، تراکم پیکسلی بالا که هنگام دیدن تصویر یا خواندن متن کمک می‌کند تا جزییات بیشتری را ببینید، از مشخصات نمایشگر نوت 10 هستند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.06%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/6e677979-65a3-4f8e-ba50-e80fbc53dbf5.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><h3 class=\"content-expert-title\" style=\"text-align:right;\">سخت‌افزار، سیستم‌عامل و کارایی</h3><p class=\"content-expert-title\" style=\"text-align:right;\">چیپست اگزونوس 9825 از چیپست‌های 7 نانومتری سامسونگ در قلب اس نوت 10 قرار گرفته است. چیپست 7 نانومتری به معنی قدرت بالا و مصرف بهینه باتری گوشی است. هرساله سخت‌افزارهای نسل جدیدتر برای گوشی‌های موبایل در نظر گرفته می‌شوند که این سخت‌افزار شامل چیپست هم می‌شود. واضح است که چیپست نسل جدید سامسونگ بسیار سریع است اما در عمل سرعت‌بالای آن را نمی‌توان انقلابی دانست. سری‌های قبلی محصولات گلکسی سامسونگ که از تراشه اگزونوس استفاده می‌کردند گاهی اوقات در زمان استفاده بسیار سنگین خاموش می‌شدند. به نظر می‌رسد در گلکسی جدید به خاطر وجود رم 8 گیگابیتی، خبری از این مشکل نباشد.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:48.68%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/c84c5779-be7e-4611-a384-c2b4f54c0d31.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\">نتیجه‌ی این لیست، سخت‌افزاری است که جای هیچ انتقادی را باقی نمی‌گذارد و در هر حالی بهترین بازده ممکن را دارد. سامسونگ در هر حالتی بهترین استفاده‌ی ممکن را از این سخت‌افزار کرده است. باید اطمینان داشته باشیم وقتی این سخت‌افزار برای پردازش واقعیت افزوده، فیلم‌برداری 2160 فریم بر ثانیه، تطبیق چهره و عنبیه برای بازکردن قفل گوشی طراحی و ساخته شده؛ دیگر در مورد بازی‌هایی که نهایتاً چند فریم خروجی دارند یا برنامه‌هایی که مقدار کمی از رم را اشغال می‌کنند، همچنین اجرای اندروید و رابط کاربری سامسونگ، هیچ مشکلی نخواهد داشت. پس خیالتان راحت باشد که هیچ عملیاتی وجود ندارد که گلکسی نوت 10 از پس انجام دادن آن برنیاید یا در انجام دادن آن کم‌کاری کند.</p><div class=\"content-expert-img mr-auto ml-auto image image_resized\" style=\"width:33.33%;\"><img class=\"w-100\" src=\"/images/page-single-product/tab-content/4c9c6d5a-7d86-4c77-a8ea-467358b61fba.jpeg\"></div><p class=\"content-expert-title\" style=\"text-align:right;\">&nbsp;</p><p class=\"content-expert-title\" style=\"text-align:right;\"><u>اندازه بزرگ‌تر در بیشتر گوشی‌های موبایل نوید باتری با ظرفیت بیشتر را می‌دهد؛ البته باتری در گوشی نوت 10 تفاوت چشمگیری را به خود ندیده است و ظرفیت آن برابر با 3500 میلی‌آمپر است که با توجه به چیپست مدرن این گوشی باید تا مدت‌زمان مطلوبی انرژی را در خود نگه دارد. البته رزولوشن بالای صفحه‌نمایش باعث شده است که باتری به میزان بیشتری مصرف شود و از باتری گوشی انتظار روشن نگه‌داشتن آن تا بیش از یک روز را نداشته باشیم. این گوشی مانند پاوربانکی پرقدرت امکان شارژ بی‌سیم دیگر دستگاه‌ها را دارد. اما این نکته را نباید فراموش کنیم که گلکسی نوت 10 شارژ بی‌سیم گوشی‌های دیگر را با سرعت بسیار بالا (با توان 9 واتی) انجام می‌دهد. همان‌طور که گفتیم این گوشی می‌تواند دیگر گوشی‌ها و گجت‌های دارای فناوری شارژ بی‌سیم را شارژ کند. یکی از ویژگی‌های خاص و البته دوست‌داشتنی در مورد گوشی‌های سامسونگ امکان صفحه‌نمایش همیشه روشن است. این امکان نوتیفیکیشن‌ها را بدون نیاز به باز کردن گوشی برای کاربر به نمایش در می‌آورد.</u></p>";
            string[] tags1 = { "سامسونگ", "samsung", "Galaxy", "Note", "256 گیگابایت", "Note_10", "Galaxy_Note_10", "موبایل", "گوشی", "mobile" };
            string[] tags2 = { "اپل", "آیفون", "apple", "iphone", "ایکس اس مکس", "256 گیگابایت", "xs_max", "موبایل", "گوشی", "mobile" };

            modelBuilder.Entity<Product>().HasData(new List<Product>
            {
                new Product {
                    Id = 1,
                    InsertTime = DateTime.Now,
                    Title = title1,
                    CategoryId = 11,
                    Price = 20000000,
                    DiscountAmount = 1000000,
                    Displayed = true,
                    Inventory = 15,
                    ShortDescription = shortDescription,
                    Description = Description,
                    BrandId = 1,
                    TagsForSearch = string.Join("-", tags1)
                },

                new Product {
                    Id = 2,
                    InsertTime = DateTime.Now,
                    Title = title2,
                    CategoryId = 13,
                    Price = 15000000,
                    DiscountAmount = 6500000,
                    Displayed = true,
                    Inventory = 5,
                    ShortDescription = shortDescription,
                    Description = Description,
                    BrandId = 2,
                    TagsForSearch = string.Join("-", tags2)
                },

                new Product {
                    Id = 3,
                    InsertTime = DateTime.Now,
                    Title = title1,
                    CategoryId = 11,
                    Price = 6000000,
                    DiscountAmount = 610000,
                    Displayed = true,
                    Inventory = 5,
                    ShortDescription = shortDescription,
                    Description = Description,
                    BrandId = 3,
                    TagsForSearch = string.Join("-", tags1)
                },

                new Product {
                    Id = 4,
                    InsertTime = DateTime.Now,
                    Title = title2,
                    CategoryId = 12,
                    Price = 1200000,
                    DiscountAmount = 5600000,
                    Displayed = true,
                    Inventory = 15,
                    ShortDescription = shortDescription,
                    Description = Description,
                    BrandId = 1,
                    TagsForSearch = string.Join("-", tags2)
                },

                new Product {
                    Id = 5,
                    InsertTime = DateTime.Now,
                    Title = title2,
                    CategoryId = 12,
                    Price = 1300000,
                    DiscountAmount = 100000,
                    Displayed = true,
                    Inventory = 5,
                    ShortDescription = shortDescription,
                    Description = Description,
                    BrandId = 1,
                    TagsForSearch = string.Join("-", tags2)
                },

                new Product {
                    Id = 6,
                    InsertTime = DateTime.Now,
                    Title = title1,
                    CategoryId = 13,
                    Price = 18800000,
                    DiscountAmount = 10000,
                    Displayed = true,
                    Inventory = 5,
                    ShortDescription = shortDescription,
                    Description = Description,
                    BrandId = 1,
                    TagsForSearch = string.Join("-", tags1)
                },

                new Product {
                    Id = 7,
                    InsertTime = DateTime.Now,
                    Title = title2,
                    CategoryId = 11,
                    Price = 22000000,
                    DiscountAmount = 1100000,
                    Displayed = true,
                    Inventory = 15,
                    ShortDescription = shortDescription,
                    Description = Description,
                    BrandId = 1,
                    TagsForSearch = string.Join("-", tags2)
                },

                new Product {
                    Id = 8,
                    InsertTime = DateTime.Now,
                    Title = title1,
                    CategoryId = 13,
                    Price = 16000000,
                    DiscountAmount = 6500000,
                    Displayed = true,
                    Inventory = 5,
                    ShortDescription = shortDescription,
                    Description = Description,
                    BrandId = 1,
                    TagsForSearch = string.Join("-", tags1)
                },

                new Product {
                    Id = 9,
                    InsertTime = DateTime.Now,
                    Title = title2,
                    CategoryId = 12,
                    Price = 1900000,
                    DiscountAmount = 800000,
                    Displayed = true,
                    Inventory = 5,
                    ShortDescription = shortDescription,
                    Description = Description,
                    BrandId = 1,
                    TagsForSearch = string.Join("-", tags2)
                },

                new Product {
                    Id = 10,
                    InsertTime = DateTime.Now,
                    Title = title2,
                    CategoryId = 14,
                    Price = 20000000,
                    DiscountAmount = 1000000,
                    Displayed = true,
                    Inventory = 14,
                    ShortDescription = shortDescription,
                    Description = Description,
                    BrandId = 1,
                    TagsForSearch = string.Join("-", tags2)
                },

                new Product {
                    Id = 11,
                    InsertTime = DateTime.Now,
                    Title = title1,
                    CategoryId = 14,
                    Price = 15000000,
                    DiscountAmount = 6500000,
                    Displayed = true,
                    Inventory = 5,
                    ShortDescription = shortDescription,
                    Description = Description,
                    BrandId = 1,
                    TagsForSearch = string.Join("-", tags1)
                },

                new Product {
                    Id = 12,
                    InsertTime = DateTime.Now,
                    Title = title2,
                    CategoryId = 12,
                    Price = 15000000,
                    DiscountAmount = 6500000,
                    Displayed = true,
                    Inventory = 5,
                    ShortDescription = shortDescription,
                    Description = Description,
                    BrandId = 1,
                    TagsForSearch = string.Join("-", tags2)
                },
            });
            #endregion

            #region ProductFetures

            modelBuilder.Entity<ProductSlider>().HasData(new List<ProductSlider>
            {
                                   new ProductSlider
                        {
                            Id =1,
                            InsertTime = DateTime.Now,
                            ProductId = 1,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.Suggestions
                        },
                        new ProductSlider
                        {
                            Id =2,
                            InsertTime = DateTime.Now,
                            ProductId = 1,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.Short
                        },
                        new ProductSlider
                        {
                            Id =3,
                            InsertTime = DateTime.Now,
                            ProductId = 1,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.LongTop
                        },
                        new ProductSlider
                        {
                            Id =4,
                            InsertTime = DateTime.Now,
                            ProductId = 1,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.LongBottom
                        },
                    new ProductSlider
                        {
                            Id =5,
                            InsertTime = DateTime.Now,
                            ProductId = 2,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.Suggestions
                        },
                        new ProductSlider
                        {
                            Id =6,
                            InsertTime = DateTime.Now,
                            ProductId = 2,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.Short
                        },
                        new ProductSlider
                        {
                            Id =7,
                            InsertTime = DateTime.Now,
                            ProductId = 2,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.LongTop
                        },
                        new ProductSlider
                        {
                            Id =8,
                            InsertTime = DateTime.Now,
                            ProductId = 2,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.LongBottom
                        },
                  new ProductSlider
                        {
                            Id =9,
                            InsertTime = DateTime.Now,
                            ProductId = 3,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.Suggestions
                        },
                        new ProductSlider
                        {
                            Id =10,
                            InsertTime = DateTime.Now,
                            ProductId = 3,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.Short
                        },
                        new ProductSlider
                        {
                            Id = 11,
                            InsertTime = DateTime.Now,
                            ProductId = 3,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.LongTop
                        },
                        new ProductSlider
                        {
                            Id =12,
                            InsertTime = DateTime.Now,
                            ProductId = 3,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.LongBottom
                        },
                             new ProductSlider
                        {
                            Id =13,
                            InsertTime = DateTime.Now,
                            ProductId = 4,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.Suggestions
                        },
                        new ProductSlider
                        {
                            Id =14,
                            InsertTime = DateTime.Now,
                            ProductId = 4,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.Short
                        },
                        new ProductSlider
                        {
                            Id =100,
                            InsertTime = DateTime.Now,
                            ProductId = 4,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.LongTop
                        },
                        new ProductSlider
                        {
                            Id =15,
                            InsertTime = DateTime.Now,
                            ProductId = 4,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.LongBottom
                        },
                  new ProductSlider
                        {
                            Id =16,
                            InsertTime = DateTime.Now,
                            ProductId = 5,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.Suggestions
                        },
                        new ProductSlider
                        {
                            Id =17,
                            InsertTime = DateTime.Now,
                            ProductId = 5,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.Short
                        },
                        new ProductSlider
                        {
                            Id =18,
                            InsertTime = DateTime.Now,
                            ProductId = 5,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.LongTop
                        },
                        new ProductSlider
                        {
                            Id =19,
                            InsertTime = DateTime.Now,
                            ProductId = 5,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.LongBottom
                        },
                    new ProductSlider
                        {
                            Id =20,
                            InsertTime = DateTime.Now,
                            ProductId = 6,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.Suggestions
                        },
                        new ProductSlider
                        {
                            Id =21,
                            InsertTime = DateTime.Now,
                            ProductId = 6,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.Short
                        },
                        new ProductSlider
                        {
                            Id = 22,
                            InsertTime = DateTime.Now,
                            ProductId = 6,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.LongTop
                        },
                        new ProductSlider
                        {
                            Id =23,
                            InsertTime = DateTime.Now,
                            ProductId = 6,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.LongBottom
                        },
                  new ProductSlider
                        {
                            Id =24,
                            InsertTime = DateTime.Now,
                            ProductId = 7,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.Suggestions
                        },
                        new ProductSlider
                        {
                            Id =25,
                            InsertTime = DateTime.Now,
                            ProductId = 7,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.Short
                        },
                        new ProductSlider
                        {
                            Id =26,
                            InsertTime = DateTime.Now,
                            ProductId = 7,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.LongTop
                        },
                        new ProductSlider
                        {
                            Id =27,
                            InsertTime = DateTime.Now,
                            ProductId = 7,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.LongBottom
                        },
                 new ProductSlider
                        {
                            Id =105,
                            InsertTime = DateTime.Now,
                            ProductId = 8,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.Suggestions
                        },
                        new ProductSlider
                        {
                            Id =28,
                            InsertTime = DateTime.Now,
                            ProductId = 8,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.Short
                        },
                        new ProductSlider
                        {
                            Id =29,
                            InsertTime = DateTime.Now,
                            ProductId = 8,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.LongTop
                        },
                        new ProductSlider
                        {
                            Id =30,
                            InsertTime = DateTime.Now,
                            ProductId = 8,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.LongBottom
                        },
                 new ProductSlider
                        {
                            Id =110,
                            InsertTime = DateTime.Now,
                            ProductId = 9,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.Suggestions
                        },
                        new ProductSlider
                        {
                            Id =32,
                            InsertTime = DateTime.Now,
                            ProductId = 9,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.Short
                        },
                        new ProductSlider
                        {
                            Id = 33,
                            InsertTime = DateTime.Now,
                            ProductId = 9,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.LongTop
                        },
                        new ProductSlider
                        {
                            Id =34,
                            InsertTime = DateTime.Now,
                            ProductId = 9,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.LongBottom
                        },
                  new ProductSlider
                        {
                            Id =35,
                            InsertTime = DateTime.Now,
                            ProductId = 10,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.Suggestions
                        },
                        new ProductSlider
                        {
                            Id =311,
                            InsertTime = DateTime.Now,
                            ProductId = 10,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.Short
                        },
                        new ProductSlider
                        {
                            Id =36,
                            InsertTime = DateTime.Now,
                            ProductId = 10,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.LongTop
                        },
                        new ProductSlider
                        {
                            Id =37,
                            InsertTime = DateTime.Now,
                            ProductId = 10,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.LongBottom
                        },
                     new ProductSlider
                        {
                            Id =40,
                            InsertTime = DateTime.Now,
                            ProductId = 11,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.Suggestions
                        },
                        new ProductSlider
                        {
                            Id =41,
                            InsertTime = DateTime.Now,
                            ProductId = 11,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.Short
                        },
                        new ProductSlider
                        {
                            Id =42,
                            InsertTime = DateTime.Now,
                            ProductId = 11,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.LongTop
                        },
                        new ProductSlider
                        {
                            Id =45,
                            InsertTime = DateTime.Now,
                            ProductId = 11,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.LongBottom
                        },
                 new ProductSlider
                        {
                            Id =50,
                            InsertTime = DateTime.Now,
                            ProductId = 12,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.Suggestions
                        },
                        new ProductSlider
                        {
                            Id =55,
                            InsertTime = DateTime.Now,
                            ProductId = 12,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.Short
                        },
                        new ProductSlider
                        {
                            Id = 56,
                            InsertTime = DateTime.Now,
                            ProductId = 12,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.LongTop
                        },
                        new ProductSlider
                        {
                            Id = 58,
                            InsertTime = DateTime.Now,
                            ProductId = 12,
                            EndDate = DateTime.Now,
                            SliderId =(int) Domain.Enums.ProductSliders.LongBottom
                        },
            });

            #endregion

            #region ProductImages

            modelBuilder.Entity<ProductImage>().HasData(new List<ProductImage>
            {
                 new ProductImage
                        {
                            Id=1,
                            InsertTime = DateTime.Now,
                            IsMainImage = true,
                            Name = "Samsung-S10Plus.jpg",
                            ProductId = 1
                        },
                        new ProductImage
                        {
                            Id=2,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-5.jpg",
                            ProductId = 1
                        },
                        new ProductImage
                        {
                            Id=3,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-6.jpg",
                            ProductId = 1
                        },
                        new ProductImage
                        {
                            Id=4,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-7.jpg",
                            ProductId = 1
                        },new ProductImage
                        {
                            Id=5,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-1.jpg",
                            ProductId = 1
                        },
                   new ProductImage
                        {
                            Id=6,
                            InsertTime = DateTime.Now,
                            IsMainImage = true,
                            Name = "iphone-xs-max-space.jpg",
                            ProductId = 2
                        },
                        new ProductImage
                        {
                            Id=7,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-5.jpg",
                            ProductId = 2
                        },
                        new ProductImage
                        {
                            Id=8,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-6.jpg",
                            ProductId = 2
                        },
                        new ProductImage
                        {
                            Id=9,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-7.jpg",
                            ProductId = 2
                        },new ProductImage
                        {
                            Id=10,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-1.jpg",
                            ProductId = 2
                        },
                new ProductImage
                        {
                            Id=11,
                            InsertTime = DateTime.Now,
                            IsMainImage = true,
                            Name = "honer.jpg",
                            ProductId = 3
                        },
                        new ProductImage
                        {
                            Id=12,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-5.jpg",
                            ProductId = 3
                        },
                        new ProductImage
                        {
                            Id=13,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-6.jpg",
                            ProductId = 3
                        },
                        new ProductImage
                        {
                            Id=14,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-7.jpg",
                            ProductId = 3
                        },new ProductImage
                        {
                            Id=15,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-1.jpg",
                            ProductId = 3
                        },
                 new ProductImage
                        {
                            Id=16,
                            InsertTime = DateTime.Now,
                            IsMainImage = true,
                            Name = "Samsung-S10Plus.jpg",
                            ProductId = 4
                        },
                        new ProductImage
                        {
                            Id=17,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-5.jpg",
                            ProductId = 4
                        },
                        new ProductImage
                        {
                            Id=18,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-6.jpg",
                            ProductId = 4
                        },
                        new ProductImage
                        {
                            Id=19,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-7.jpg",
                            ProductId = 4
                        },new ProductImage
                        {
                            Id=20,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-1.jpg",
                            ProductId = 4
                        },
                new ProductImage
                        {
                            Id=21,
                            InsertTime = DateTime.Now,
                            IsMainImage = true,
                            Name = "iphone-xs-max-space.jpg",
                            ProductId = 5
                        },
                        new ProductImage
                        {
                            Id=22,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-5.jpg",
                            ProductId = 5
                        },
                        new ProductImage
                        {
                            Id=23,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-6.jpg",
                            ProductId = 5
                        },
                        new ProductImage
                        {
                            Id=24,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-7.jpg",
                            ProductId = 5
                        },
                        new ProductImage
                        {
                            Id=25,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-1.jpg",
                            ProductId = 5
                        },
                new ProductImage
                        {
                            Id=26,
                            InsertTime = DateTime.Now,
                            IsMainImage = true,
                            Name = "honer.jpg",
                            ProductId = 6
                        },
                        new ProductImage
                        {
                            Id=27,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-5.jpg",
                            ProductId = 6
                        },
                        new ProductImage
                        {
                            Id=28,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-6.jpg",
                            ProductId = 6
                        },
                        new ProductImage
                        {
                            Id=29,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-7.jpg",
                            ProductId = 6
                        },new ProductImage
                        {
                            Id=30,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-1.jpg",
                            ProductId = 6
                        },
                  new ProductImage
                        {
                            Id=31,
                            InsertTime = DateTime.Now,
                            IsMainImage = true,
                            Name = "Samsung-S10Plus.jpg",
                            ProductId = 7
                        },
                        new ProductImage
                        {
                            Id=32,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-5.jpg",
                            ProductId = 7
                        },
                        new ProductImage
                        {
                            Id=33,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-6.jpg",
                            ProductId = 7
                        },
                        new ProductImage
                        {
                            Id=34,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-7.jpg",
                            ProductId = 7
                        },new ProductImage
                        {
                            Id=35,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-1.jpg",
                            ProductId = 7
                        },
                new ProductImage
                        {
                            Id=36,
                            InsertTime = DateTime.Now,
                            IsMainImage = true,
                            Name = "iphone-xs-max-space.jpg",
                            ProductId = 8
                        },
                        new ProductImage
                        {
                            Id=37,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-5.jpg",
                            ProductId = 8
                        },
                        new ProductImage
                        {
                            Id=38,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-6.jpg",
                            ProductId = 8
                        },
                        new ProductImage
                        {
                            Id=39,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-7.jpg",
                            ProductId = 8
                        },new ProductImage
                        {
                            Id=40,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-1.jpg",
                            ProductId = 8
                        },
                          new ProductImage
                        {
                            Id=41,
                            InsertTime = DateTime.Now,
                            IsMainImage = true,
                            Name = "honer.jpg",
                            ProductId = 9,
                        },
                        new ProductImage
                        {
                            Id=42,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-5.jpg",
                            ProductId = 9,
                        },
                        new ProductImage
                        {
                            Id=43,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-6.jpg",
                            ProductId = 9,
                        },
                        new ProductImage
                        {
                            Id=44,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-7.jpg",
                            ProductId = 9,
                        },new ProductImage
                        {
                            Id=45,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-1.jpg",
                            ProductId = 9,
                        },
                new ProductImage
                        {
                            Id=46,
                            InsertTime = DateTime.Now,
                            IsMainImage = true,
                            Name = "Samsung-S10Plus.jpg",
                            ProductId = 10
                        },
                        new ProductImage
                        {
                            Id=47,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-5.jpg",
                            ProductId = 10
                        },
                        new ProductImage
                        {
                            Id=48,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-6.jpg",
                            ProductId = 10
                        },
                        new ProductImage
                        {
                            Id=49,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-7.jpg",
                            ProductId = 10
                        },new ProductImage
                        {
                            Id=50,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-1.jpg",
                            ProductId = 10
                        },
                 new ProductImage
                        {
                            Id=51,
                            InsertTime = DateTime.Now,
                            IsMainImage = true,
                            Name = "iphone-xs-max-space.jpg",
                            ProductId = 11
                        },
                        new ProductImage
                        {
                            Id=52,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-5.jpg",
                            ProductId = 11
                        },
                        new ProductImage
                        {
                            Id=53,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-6.jpg",
                            ProductId = 11
                        },
                        new ProductImage
                        {
                            Id=54,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-7.jpg",
                            ProductId = 11
                        },new ProductImage
                        {
                            Id=55,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-1.jpg",
                            ProductId = 11
                        },
                new ProductImage
                        {
                            Id=60,
                            InsertTime = DateTime.Now,
                            IsMainImage = true,
                            Name = "honer.jpg",
                            ProductId = 12
                        },
                        new ProductImage
                        {
                            Id=61,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-5.jpg",
                            ProductId = 12
                        },
                        new ProductImage
                        {
                            Id=62,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-6.jpg",
                            ProductId = 12
                        },
                        new ProductImage
                        {
                            Id=63,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-7.jpg",
                            ProductId = 12
                        },new ProductImage
                        {
                            Id=64,
                            InsertTime = DateTime.Now,
                            IsMainImage = false,
                            Name = "product-img-note10-big-1.jpg",
                            ProductId = 12
                        },
            });

            #endregion

            #region ProductFetures

            modelBuilder.Entity<ProductFeature>().HasData(new List<ProductFeature>
            {

                        new ProductFeature
                        {
                            Id = 1,
                            FeatureId = 1,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 1,
                            Value = "اندروید"
                        },
                        new ProductFeature
                        {
                            Id = 2,
                            FeatureId = 2,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 1,
                            Value = "مشکی"
                        },
                        new ProductFeature
                        {
                            Id = 6,
                            FeatureId = 2,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 1,
                            Value = "مشکی"
                        },
                        new ProductFeature
                        {
                            Id = 3,
                            FeatureId = 3,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 1,
                            Value = "10"
                        },
                        new ProductFeature
                        {
                            Id = 4,
                            FeatureId = 1,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 12,
                            Value = "دارد"
                        },
                        new ProductFeature
                        {
                            Id = 5,
                            FeatureId = 5,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 1,
                            Value = "40"
                        },
                        new ProductFeature
                        {
                            Id = 7,
                            FeatureId = 6,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 1,
                            Value = "20"
                        },
                 new ProductFeature
                        {
                            Id = 8,
                            FeatureId = 1,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 2,
                            Value = "اندروید"
                        },
                        new ProductFeature
                        {
                            Id = 9,
                            FeatureId = 2,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 2,
                            Value = "مشکی"
                        },
                        new ProductFeature
                        {
                            Id = 10,
                            FeatureId = 2,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 2,
                            Value = "مشکی"
                        },
                        new ProductFeature
                        {
                            Id =11,
                            FeatureId = 3,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 2,
                            Value = "10"
                        },
                        new ProductFeature
                        {
                            Id = 12,
                            FeatureId = 1,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 2,
                            Value = "دارد"
                        },
                        new ProductFeature
                        {
                            Id = 13,
                            FeatureId = 5,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 2,
                            Value = "40"
                        },
                        new ProductFeature
                        {
                            Id = 14,
                            FeatureId = 6,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 2,
                            Value = "20"
                        },
                 new ProductFeature
                        {
                            Id = 15,
                            FeatureId = 1,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 3,
                            Value = "اندروید"
                        },
                        new ProductFeature
                        {
                            Id = 16,
                            FeatureId = 2,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 3,
                            Value = "مشکی"
                        },
                        new ProductFeature
                        {
                            Id = 17,
                            FeatureId = 2,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 3,
                            Value = "مشکی"
                        },
                        new ProductFeature
                        {
                            Id =18,
                            FeatureId = 3,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 3,
                            Value = "10"
                        },
                        new ProductFeature
                        {
                            Id = 19,
                            FeatureId = 1,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 3,
                            Value = "دارد"
                        },
                        new ProductFeature
                        {
                            Id = 20,
                            FeatureId = 5,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 3,
                            Value = "40"
                        },
                        new ProductFeature
                        {
                            Id = 21,
                            FeatureId = 6,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 3,
                            Value = "20"
                        },

                 new ProductFeature
                        {
                            Id = 25,
                            FeatureId = 1,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 4,
                            Value = "اندروید"
                        },
                        new ProductFeature
                        {
                            Id = 24,
                            FeatureId = 2,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 4,
                            Value = "مشکی"
                        },
                        new ProductFeature
                        {
                            Id = 26,
                            FeatureId = 2,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 4,
                            Value = "مشکی"
                        },
                        new ProductFeature
                        {
                            Id = 27,
                            FeatureId = 3,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 4,
                            Value = "10"
                        },
                        new ProductFeature
                        {
                            Id = 28,
                            FeatureId = 1,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 4,
                            Value = "دارد"
                        },
                        new ProductFeature
                        {
                            Id = 29,
                            FeatureId = 5,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 4,
                            Value = "40"
                        },
                        new ProductFeature
                        {
                            Id = 30,
                            FeatureId = 6,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 4,
                            Value = "20"
                        },
                  new ProductFeature
                        {
                            Id = 40,
                            FeatureId = 1,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 5,
                            Value = "اندروید"
                        },
                        new ProductFeature
                        {
                            Id = 41,
                            FeatureId = 2,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 5,
                            Value = "مشکی"
                        },
                        new ProductFeature
                        {
                            Id = 42,
                            FeatureId = 2,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 5,
                            Value = "مشکی"
                        },
                        new ProductFeature
                        {
                            Id =43,
                            FeatureId = 3,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 5,
                            Value = "10"
                        },
                        new ProductFeature
                        {
                            Id = 44,
                            FeatureId = 1,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 5,
                            Value = "دارد"
                        },
                        new ProductFeature
                        {
                            Id = 45,
                            FeatureId = 5,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 5,
                            Value = "40"
                        },
                        new ProductFeature
                        {
                            Id = 46,
                            FeatureId = 6,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 5,
                            Value = "20"
                        },

                 new ProductFeature
                        {
                            Id = 55,
                            FeatureId = 1,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 6,
                            Value = "اندروید"
                        },
                        new ProductFeature
                        {
                            Id = 56,
                            FeatureId = 2,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 6,
                            Value = "مشکی"
                        },
                        new ProductFeature
                        {
                            Id = 57,
                            FeatureId = 2,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 6,
                            Value = "مشکی"
                        },
                        new ProductFeature
                        {
                            Id =58,
                            FeatureId = 3,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 6,
                            Value = "10"
                        },
                        new ProductFeature
                        {
                            Id = 59,
                            FeatureId = 1,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 6,
                            Value = "دارد"
                        },
                        new ProductFeature
                        {
                            Id = 60,
                            FeatureId = 5,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 6,
                            Value = "40"
                        },
                        new ProductFeature
                        {
                            Id = 62,
                            FeatureId = 6,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 6,
                            Value = "20"
                        },
                  new ProductFeature
                        {
                            Id = 64,
                            FeatureId = 1,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 7,
                            Value = "اندروید"
                        },
                        new ProductFeature
                        {
                            Id = 65,
                            FeatureId = 2,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 7,
                            Value = "مشکی"
                        },
                        new ProductFeature
                        {
                            Id = 66,
                            FeatureId = 2,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 7,
                            Value = "مشکی"
                        },
                        new ProductFeature
                        {
                            Id = 67,
                            FeatureId = 3,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 7,
                            Value = "10"
                        },
                        new ProductFeature
                        {
                            Id = 68,
                            FeatureId = 1,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 7,
                            Value = "دارد"
                        },
                        new ProductFeature
                        {
                            Id = 69,
                            FeatureId = 5,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 7,
                            Value = "40"
                        },
                        new ProductFeature
                        {
                            Id = 70,
                            FeatureId = 6,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 7,
                            Value = "20"
                        },

                new ProductFeature
                        {
                            Id = 72,
                            FeatureId = 1,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 8,
                            Value = "اندروید"
                        },
                        new ProductFeature
                        {
                            Id = 73,
                            FeatureId = 2,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 8,
                            Value = "مشکی"
                        },
                        new ProductFeature
                        {
                            Id = 74,
                            FeatureId = 2,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 8,
                            Value = "مشکی"
                        },
                        new ProductFeature
                        {
                            Id =75,
                            FeatureId = 3,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 8,
                            Value = "10"
                        },
                        new ProductFeature
                        {
                            Id = 76,
                            FeatureId = 1,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 8,
                            Value = "دارد"
                        },
                        new ProductFeature
                        {
                            Id = 77,
                            FeatureId = 5,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 8,
                            Value = "40"
                        },
                        new ProductFeature
                        {
                            Id = 78,
                            FeatureId = 6,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 8,
                            Value = "20"
                        },

                new ProductFeature
                        {
                            Id = 80,
                            FeatureId = 1,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 9,
                            Value = "اندروید"
                        },
                        new ProductFeature
                        {
                            Id = 81,
                            FeatureId = 2,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 9,
                            Value = "مشکی"
                        },
                        new ProductFeature
                        {
                            Id = 82,
                            FeatureId = 2,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 9,
                            Value = "مشکی"
                        },
                        new ProductFeature
                        {
                            Id =83,
                            FeatureId = 3,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 9,
                            Value = "10"
                        },
                        new ProductFeature
                        {
                            Id = 84,
                            FeatureId = 1,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 9,
                            Value = "دارد"
                        },
                        new ProductFeature
                        {
                            Id = 85,
                            FeatureId = 5,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 9,
                            Value = "40"
                        },
                        new ProductFeature
                        {
                            Id = 86,
                            FeatureId = 6,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 9,
                            Value = "20"
                        },

                new ProductFeature
                        {
                            Id = 91,
                            FeatureId = 1,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 10,
                            Value = "اندروید"
                        },
                        new ProductFeature
                        {
                            Id = 92,
                            FeatureId = 2,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 10,
                            Value = "مشکی"
                        },
                        new ProductFeature
                        {
                            Id = 93,
                            FeatureId = 2,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 10,
                            Value = "مشکی"
                        },
                        new ProductFeature
                        {
                            Id = 94,
                            FeatureId = 3,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 10,
                            Value = "10"
                        },
                        new ProductFeature
                        {
                            Id = 95,
                            FeatureId = 1,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 10,
                            Value = "دارد"
                        },
                        new ProductFeature
                        {
                            Id = 96,
                            FeatureId = 5,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 10,
                            Value = "40"
                        },
                        new ProductFeature
                        {
                            Id = 97,
                            FeatureId = 6,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 10,
                            Value = "20"
                        },

                new ProductFeature
                        {
                            Id = 100,
                            FeatureId = 1,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 11,
                            Value = "اندروید"
                        },
                        new ProductFeature
                        {
                            Id = 101,
                            FeatureId = 2,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 11,
                            Value = "مشکی"
                        },
                        new ProductFeature
                        {
                            Id = 102,
                            FeatureId = 2,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 11,
                            Value = "مشکی"
                        },
                        new ProductFeature
                        {
                            Id =110,
                            FeatureId = 3,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 11,
                            Value = "10"
                        },
                        new ProductFeature
                        {
                            Id = 112,
                            FeatureId = 1,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 11,
                            Value = "دارد"
                        },
                        new ProductFeature
                        {
                            Id = 113,
                            FeatureId = 5,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 11,
                            Value = "40"
                        },
                        new ProductFeature
                        {
                            Id = 114,
                            FeatureId = 6,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 11,
                            Value = "20"
                        },

                new ProductFeature
                        {
                            Id = 115,
                            FeatureId = 1,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 12,
                            Value = "اندروید"
                        },
                        new ProductFeature
                        {
                            Id = 116,
                            FeatureId = 2,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 12,
                            Value = "مشکی"
                        },
                        new ProductFeature
                        {
                            Id = 117,
                            FeatureId = 2,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 12,
                            Value = "مشکی"
                        },
                        new ProductFeature
                        {
                            Id =118,
                            FeatureId = 3,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 12,
                            Value = "10"
                        },
                        new ProductFeature
                        {
                            Id = 119,
                            FeatureId = 1,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 12,
                            Value = "دارد"
                        },
                        new ProductFeature
                        {
                            Id = 120,
                            FeatureId = 5,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 12,
                            Value = "40"
                        },
                        new ProductFeature
                        {
                            Id = 121,
                            FeatureId = 6,
                            InsertTime = DateTime.Now,
                            isBold = true,
                            ProductId = 12,
                            Value = "20"
                        },
            });



            #endregion

            #region Tags
            List<Tag> tags = new List<Tag>();

            int id = 0;
            for (int i = 0; i < 10; i++)
            {
                id++;
                tags.Add(new Tag
                {
                    Id = id,
                    Title = tags1[i],
                    InsertTime = DateTime.Now,
                    ProductId = 1
                });
            }
            for (int i = 0; i < 10; i++)
            {
                id++;
                tags.Add(new Tag
                {
                    Id = id,
                    Title = tags2[i],
                    InsertTime = DateTime.Now,
                    ProductId = 2
                });
            }
            for (int i = 0; i < 10; i++)
            {
                id++;
                tags.Add(new Tag
                {
                    Id = id,
                    Title = tags1[i],
                    InsertTime = DateTime.Now,
                    ProductId = 3
                });
            }
            for (int i = 0; i < 10; i++)
            {
                id++;
                tags.Add(new Tag
                {
                    Id = id,
                    Title = tags2[i],
                    InsertTime = DateTime.Now,
                    ProductId = 4
                });
            }
            for (int i = 0; i < 10; i++)
            {
                id++;
                tags.Add(new Tag
                {
                    Id = id,
                    Title = tags2[i],
                    InsertTime = DateTime.Now,
                    ProductId = 5
                });
            }
            for (int i = 0; i < 10; i++)
            {
                id++;
                tags.Add(new Tag
                {
                    Id = id,
                    Title = tags1[i],
                    InsertTime = DateTime.Now,
                    ProductId = 6
                });
            }
            for (int i = 0; i < 10; i++)
            {
                id++;
                tags.Add(new Tag
                {
                    Id = id,
                    Title = tags2[i],
                    InsertTime = DateTime.Now,
                    ProductId = 7
                });
            }
            for (int i = 0; i < 10; i++)
            {
                id++;
                tags.Add(new Tag
                {
                    Id = id,
                    Title = tags1[i],
                    InsertTime = DateTime.Now,
                    ProductId = 8
                });
            }
            for (int i = 0; i < 10; i++)
            {
                id++;
                tags.Add(new Tag
                {
                    Id = id,
                    Title = tags2[i],
                    InsertTime = DateTime.Now,
                    ProductId = 9
                });
            }
            for (int i = 0; i < 10; i++)
            {
                id++;
                tags.Add(new Tag
                {
                    Id = id,
                    Title = tags2[i],
                    InsertTime = DateTime.Now,
                    ProductId = 10
                });
            }
            for (int i = 0; i < 10; i++)
            {
                id++;
                tags.Add(new Tag
                {
                    Id = id,
                    Title = tags1[i],
                    InsertTime = DateTime.Now,
                    ProductId = 11
                });
            }
            for (int i = 0; i < 10; i++)
            {
                id++;
                tags.Add(new Tag
                {
                    Id = id,
                    Title = tags2[i],
                    InsertTime = DateTime.Now,
                    ProductId = 12
                });
            }

            modelBuilder.Entity<Tag>().HasData(tags);

            #endregion
        }
    }
}
