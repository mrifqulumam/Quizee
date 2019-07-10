using Quizee.Application.Notifications.Models;
using System.Threading.Tasks;

namespace Quizee.Application.Interfaces
{
    public interface INotificationService
    {
        Task SendAsync(Message message);
    }
}
