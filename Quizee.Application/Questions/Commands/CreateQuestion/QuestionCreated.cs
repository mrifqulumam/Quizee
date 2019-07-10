using MediatR;
using Northwind.Application.Interfaces;
using Quizee.Application.Notifications.Models;
using System.Threading;
using System.Threading.Tasks;

namespace Quizee.Application.Questions.Commands.CreateQuestion
{
    public class QuestionCreated : INotification
    {
        public int QuestionId { get; set; }

        public class QuestionCreatedHandler : INotificationHandler<QuestionCreated>
        {
            private readonly INotificationService _notification;

            public QuestionCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }

            public async Task Handle(QuestionCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
            }
        }
    }
}
