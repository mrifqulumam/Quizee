using FluentValidation;

namespace Quizee.Application.Questions.Commands.CreateQuestion
{
    public class CreateQuestionCommandValidator : AbstractValidator<CreateQuestionCommand>
    {
        public CreateQuestionCommandValidator()
        {
            RuleFor(x => x.QuestionId).NotEmpty();
            RuleFor(x => x.Title).MaximumLength(20);
            RuleFor(x => x.Body).MinimumLength(10).NotEmpty();
            RuleFor(x => x.EssayAnswer).MinimumLength(10);
            RuleFor(x => x.QuestionTypeId).NotEmpty();
            RuleFor(x => x.AnswerId);
        }
    }
}
