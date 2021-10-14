using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Persistence.Configurations.Entities.ProductSlider
{
    public class ProductSliderConfiguration : IEntityTypeConfiguration<Domain.Entities.Product.ProductSlider>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Product.ProductSlider> builder)
        {
            builder.HasOne(ps => ps.Product)
                .WithMany(p => p.ProductSliders)
                .HasForeignKey(pi => pi.ProductId);

            builder.HasOne(ps => ps.Slider)
                .WithMany(p => p.ProductSliders)
                .HasForeignKey(pi => pi.SliderId);
        }
    }
}
