using System.Collections.Generic;

namespace Quizee.Domain.Entities
{
    public class Question
    {
        public int QuestionId { get; set; }
        public int QuestionTypeId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string EssayAnswer { get; set; }
        public int AnswerId { get; set; }

        public ICollection<Answer> Answers { get; set; }

        public Question()
        {
            this.Answers = new HashSet<Answer>();
        }
    }
}
