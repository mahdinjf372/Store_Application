using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Persistence.Configurations.Entities.BrandSlider
{
    public class BrandSliderConfiguration : IEntityTypeConfiguration<Domain.Entities.Site.BrandSlider>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Site.BrandSlider> builder)
        {

            builder.Property(s => s.Title).HasMaxLength(200);
        }
    }
}
