using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Persistence.Configurations.Entities.Brand
{
    public class BrandConfiguration : IEntityTypeConfiguration<Domain.Entities.Product.Brand>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Product.Brand> builder)
        {
            builder.HasKey(u => u.Id);


        }
    }
}
