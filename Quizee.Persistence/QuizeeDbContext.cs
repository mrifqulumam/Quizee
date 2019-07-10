using Microsoft.EntityFrameworkCore;
using Quizee.Application.Interfaces;
using Quizee.Domain.Entities;

namespace Quizee.Persistence
{
    public class QuizeeDbContext : DbContext, IQuizeeDbContext
    {
        public QuizeeDbContext(DbContextOptions<QuizeeDbContext> options)
            : base(options)
        {
        }

        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionType> QuestionTypes { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(QuizeeDbContext).Assembly);
        }
    }
}
