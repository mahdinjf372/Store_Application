using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Persistence.Configurations.Entities.Product
{
    public class ProductConfiguration : IEntityTypeConfiguration<Domain.Entities.Product.Product>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Product.Product> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Price)
                .HasDefaultValue(0);

            builder.Property(p => p.DiscountAmount)
                .HasDefaultValue(0);

            builder.Property(p => p.Inventory)
                .HasDefaultValue(0);

            builder.Property(p => p.Displayed)
                .HasDefaultValue(true);

            //relations
            builder.HasMany(p => p.Images)
                .WithOne(i => i.Product);

            builder.HasOne(p => p.Brand)
                .WithMany(b => b.Product)
                .HasForeignKey(p => p.BrandId);

            builder.HasOne(p => p.Category)
    .WithMany(c => c.Products)
    .IsRequired();
        }
    }
}
