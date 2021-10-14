using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Persistence.Configurations.Entities.Order
{
    public class OrderConfiguration : IEntityTypeConfiguration<Domain.Entities.Order.Order>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Order.Order> builder)
        {
            builder.HasOne(o => o.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(o => o.RequestPay)
                .WithMany(rp => rp.Orders)
                .HasForeignKey(o => o.RequestPayId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
