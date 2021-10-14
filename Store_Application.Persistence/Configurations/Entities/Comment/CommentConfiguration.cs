using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Persistence.Configurations.Entities.Comment
{
    public class CommentConfiguration : IEntityTypeConfiguration<Domain.Entities.Comment.Comment>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Comment.Comment> builder)
        {
            builder.Property(q => q.AdminIsRead)
                .HasDefaultValue(false);

            builder.Property(q => q.ConfirmedByAdmin)
                .HasDefaultValue(false);

            builder.Property(q => q.Rate)
                .HasDefaultValue(1);

            builder.HasOne(c => c.User)
                .WithMany(u => u.Comments)
                .HasForeignKey(c => c.UserId);

            builder.HasOne(c => c.Product)
                .WithMany(p => p.Comments)
                .HasForeignKey(c => c.ProductId);

            builder.HasMany(c => c.Likes)
                .WithOne(l => l.Comment)
                .HasForeignKey(l => l.CommentId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(c => c.Dislikes)
                .WithOne(l => l.Comment)
                .HasForeignKey(l => l.CommentId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
