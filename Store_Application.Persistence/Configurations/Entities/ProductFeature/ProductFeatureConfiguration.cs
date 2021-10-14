using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Persistence.Configurations.Entities.ProductFeature
{
    public class ProductFeatureConfiguration : IEntityTypeConfiguration<Domain.Entities.Product.ProductFeature>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Product.ProductFeature> builder)
        {
            builder.HasKey(pf => pf.Id);


            builder.HasOne(pf => pf.Product)
                .WithMany(p => p.Features)
                .HasForeignKey(pf => pf.ProductId);

            builder.HasOne(pf => pf.Feature)
                .WithMany(f => f.Values)
                .HasForeignKey(pf => pf.FeatureId);
        }
    }
}
