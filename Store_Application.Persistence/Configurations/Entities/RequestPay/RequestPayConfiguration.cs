using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Persistence.Configurations.Entities.RequestPay
{
    public class RequestPayConfiguration : IEntityTypeConfiguration<Domain.Entities.Finance.RequestPay>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Finance.RequestPay> builder)
        {
            builder.HasOne(rp => rp.User)
                .WithMany(u => u.RequestPays)
                .HasForeignKey(rp => rp.UserId);

        }
    }
}
