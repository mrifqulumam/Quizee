using System;
using System.Collections.Generic;
using System.Text;

namespace Quizee.Domain.Entities
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public int QuestionId { get; set; }
        public string AnswerName { get; set; }
    }
}
