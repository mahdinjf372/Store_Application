﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Persistence.Configurations.Entities.ProductImage
{
    public class ProductImageConfiguration : IEntityTypeConfiguration<Domain.Entities.Product.ProductImage>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Product.ProductImage> builder)
        {

            builder.HasOne(pi => pi.Product)
              .WithMany(p => p.Images)
              .HasForeignKey(pi => pi.ProductId);
        }
    }
}
