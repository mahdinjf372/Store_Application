using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Application.Persistence.Configurations.Entities.Question
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Domain.Entities.Question.Question>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Question.Question> builder)
        {
            builder.Property(q => q.AdminIsRead)
                .HasDefaultValue(false);

            builder.Property(q => q.ConfirmedByAdmin)
                .HasDefaultValue(false);

            builder.HasOne(q => q.User)
                .WithMany(u => u.Questions)
                .HasForeignKey(q => q.UserId);

            builder.HasOne(q => q.Product)
                .WithMany(p => p.Questions)
                .HasForeignKey(q => q.ProductId);

            builder.HasOne(q => q.ParentQuestion)
                .WithMany(a => a.Answers)
                .HasForeignKey(q => q.ParentQuestionId);

        }
    }
}
