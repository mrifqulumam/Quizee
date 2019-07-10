using Quizee.Domain.Entities;

namespace Quizee.Persistence.Extensions
{
    internal static class QuestionExtensions
    {
        public static Question AddAnswers(this Question question, params Answer[] answers)
        {
            foreach (var answer in answers)
            {
                question.Answers.Add(answer);
            }

            return question;
        }
    }
}
