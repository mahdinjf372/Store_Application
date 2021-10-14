using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Persistence.Configurations.Entities.MainSlider
{
    public class MainSliderConfiguration : IEntityTypeConfiguration<Domain.Entities.Site.MainSlider>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Site.MainSlider> builder)
        {
            builder.Property(s => s.Title).HasMaxLength(200);
        }
    }
}
