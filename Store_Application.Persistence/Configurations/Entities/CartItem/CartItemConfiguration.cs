using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Persistence.Configurations.Entities.CartItem
{
    public class CartItemConfiguration : IEntityTypeConfiguration<Domain.Entities.Cart.CartItem>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Cart.CartItem> builder)
        {
            builder.HasKey(pf => pf.Id);

            builder.HasOne(ci => ci.Product)
                .WithMany(p => p.CartItems)
                .HasForeignKey(ci => ci.ProductId);

            builder.HasOne(ci => ci.Cart)
                .WithMany(c => c.CartItems)
                .HasForeignKey(ci => ci.CartId);
        }
    }
}
