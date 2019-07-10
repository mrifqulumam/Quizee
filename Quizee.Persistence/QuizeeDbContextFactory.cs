using Microsoft.EntityFrameworkCore;
using Quizee.Persistence.Infrastructure;

namespace Quizee.Persistence
{
    public class QuizeeDbContextFactory : DesignTimeDbContextFactoryBase<QuizeeDbContext>
    {
        protected override QuizeeDbContext CreateNewInstance(DbContextOptions<QuizeeDbContext> options)
        {
            return new QuizeeDbContext(options);
        }
    }
}
