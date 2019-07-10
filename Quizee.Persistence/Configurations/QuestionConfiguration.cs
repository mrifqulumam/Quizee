using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Quizee.Domain.Entities;

namespace Quizee.Persistence.Configurations
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.Property(e => e.QuestionId)
                .HasColumnName("QuestionID");

            builder.Property(e => e.QuestionTypeId)
                .HasColumnName("QuestionTypeID")
                .IsRequired();

            builder.Property(e => e.Title)
                .HasMaxLength(20);

            builder.Property(e => e.Body)
                .IsRequired();

            //builder.Property(e => e.EssayAnswer);

            //builder.Property(e => e.AnswerId);
        }
    }
}
