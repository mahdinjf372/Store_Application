using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store_Application.Domain.Entities.User;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using Store_Application.Domain.Entities.Product;

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

        #endregion


        int SaveChanges(bool acceptAllChangesOnSuccess);
        int SaveChanges();
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
