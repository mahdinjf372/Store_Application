using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Persistence.Configurations.Entities.Category
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Domain.Entities.Product.Category>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Product.Category> builder)
        {
            builder.HasKey(u => u.Id);

            builder.HasOne(c => c.ParentCategory)
                .WithMany(c => c.SubCategories)
                .HasForeignKey(c => c.ParentCategoryId);
        }
    }
}
