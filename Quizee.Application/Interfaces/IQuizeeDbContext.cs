using Microsoft.EntityFrameworkCore;
using Quizee.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Quizee.Application.Interfaces
{
    public interface IQuizeeDbContext
    {
        DbSet<Answer> Answers { get; set; }
        DbSet<Question> Questions { get; set; }
        DbSet<QuestionType> QuestionTypes { get; set; }
        DbSet<Quiz> Quizzes { get; set; }
        DbSet<User> Users { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
