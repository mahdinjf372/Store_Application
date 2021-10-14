using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Persistence.Configurations.Entities.OrderDetail
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<Domain.Entities.Order.OrderDetail>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Order.OrderDetail> builder)
        {
            builder.HasOne(od => od.Product)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(ci => ci.ProductId);

            builder.HasOne(od => od.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(od => od.OrderId);
        }
    }
}
