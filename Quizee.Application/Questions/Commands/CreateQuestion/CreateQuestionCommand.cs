using MediatR;
using Quizee.Application.Interfaces;
using Quizee.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Quizee.Application.Questions.Commands.CreateQuestion
{
    public class CreateQuestionCommand : IRequest
    {
        public int QuestionId { get; set; }

        public int QuestionTypeId { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public string EssayAnswer { get; set; }

        public int AnswerId { get; set; }

        public class Handler : IRequestHandler<CreateQuestionCommand, Unit>
        {
            private readonly IQuizeeDbContext _context;
            private readonly IMediator _mediator;

            public Handler(IQuizeeDbContext context, IMediator mediator)
            {
                _context = context;
                _mediator = mediator;
            }

            public async Task<Unit> Handle(CreateQuestionCommand command, CancellationToken cancellationToken)
            {
                var entity = new Question
                {
                    QuestionId = command.QuestionId,
                    QuestionTypeId = command.QuestionTypeId,
                    Title = command.Title,
                    Body = command.Body,
                    EssayAnswer = command.EssayAnswer,
                    AnswerId = command.AnswerId
                };

                _context.Questions.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                await _mediator.Publish(new QuestionCreated { });

                return Unit.Value;
            }
        }
    }
}
