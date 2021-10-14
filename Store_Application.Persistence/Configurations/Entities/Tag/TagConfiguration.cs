using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Persistence.Configurations.Entities.Tag
{
    public class TagConfiguration : IEntityTypeConfiguration<Domain.Entities.Product.Tag>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Product.Tag> builder)
        {
            builder.HasOne(t => t.Product)
                .WithMany(p => p.Tags)
                .HasForeignKey(t => t.ProductId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
