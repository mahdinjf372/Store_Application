using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Persistence.Configurations.Entities.Advertising
{
    public class AdvertisingConfiguration : IEntityTypeConfiguration<Domain.Entities.Site.Advertising>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Site.Advertising> builder)
        {
            builder.Property(a => a.Title).HasMaxLength(200);
        }
    }
}
