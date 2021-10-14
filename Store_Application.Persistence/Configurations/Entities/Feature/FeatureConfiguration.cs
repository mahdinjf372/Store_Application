using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Persistence.Configurations.Entities.Feature
{
    public class FeatureConfiguration : IEntityTypeConfiguration<Domain.Entities.Product.Feature>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Product.Feature> builder)
        {
            builder.HasKey(u => u.Id);
        }
    }
}
