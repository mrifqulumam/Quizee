using System;
using System.Collections.Generic;

namespace Quizee.Domain.Entities
{
    public class Quiz
    {
        public int QuizId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime QuizStarted { get; set; }
        public DateTime QuizEnded { get; set; }

        public ICollection<Question> Questions { get; set; }

        public Quiz()
        {
            this.Questions = new HashSet<Question>();
        }
    }
}
