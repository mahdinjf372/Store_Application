using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Persistence.Configurations.Entities.User
{
    public class UserConfiguration : IEntityTypeConfiguration<Domain.Entities.User.User>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.User.User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.FullName)
                .HasMaxLength(200);

            builder.Property(u => u.age)
                .HasDefaultValue(null);

            builder.Property(u => u.Email)
                .IsRequired();

            builder.Property(u => u.Password)
                .IsRequired();

            builder.Property(u => u.ActiveCode)
                .IsRequired();

            builder.Property(u => u.isActive)
                .HasDefaultValue(false);

            builder.HasIndex(u => u.Email)
                .IsUnique();

            builder.HasMany(c => c.Likes)
                .WithOne(l => l.User)
                .HasForeignKey(l => l.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(c => c.Dislikes)
                .WithOne(l => l.User)
                .HasForeignKey(l => l.UserId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
