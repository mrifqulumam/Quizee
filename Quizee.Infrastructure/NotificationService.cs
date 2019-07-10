using Quizee.Application.Interfaces;
using Quizee.Application.Notifications.Models;
using System.Threading.Tasks;

namespace Quizee.Infrastructure
{
    public class NotificationService : INotificationService
    {
        public Task SendAsync(Message message)
        {
            return Task.CompletedTask;
        }
    }
}
