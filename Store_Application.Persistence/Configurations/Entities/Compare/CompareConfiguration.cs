using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Persistence.Configurations.Entities.Compare
{
    public class CompareConfiguration : IEntityTypeConfiguration<Domain.Entities.Compare.Compare>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Compare.Compare> builder)
        {
            builder.HasOne(c => c.User)
                .WithMany(u => u.Compares)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(c => c.Product)
                .WithMany(p => p.Compares)
                .HasForeignKey(c => c.ProductId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
