using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Persistence.Configurations.Entities.Favorite
{
    public class FavoriteConfiguration : IEntityTypeConfiguration<Domain.Entities.Favorite.Favorite>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Favorite.Favorite> builder)
        {
            builder.HasOne(f => f.User)
                .WithMany(u => u.Favorites)
                .HasForeignKey(f => f.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(f => f.Product)
                .WithMany(p => p.Favorites)
                .HasForeignKey(f => f.ProductId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
