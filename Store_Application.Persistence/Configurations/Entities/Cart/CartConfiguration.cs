using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Persistence.Configurations.Entities.Cart
{
    public class CartConfiguration : IEntityTypeConfiguration<Domain.Entities.Cart.Cart>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Cart.Cart> builder)
        {
            builder.HasOne(c => c.User)
                .WithMany(u => u.Carts)
                .HasForeignKey(c => c.UserId);
        }
    }
}
