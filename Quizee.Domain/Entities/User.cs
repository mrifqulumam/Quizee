using System.Collections.Generic;

namespace Quizee.Domain.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public ICollection<Quiz> Quizzes { get; set; }

        public User()
        {
            this.Quizzes = new HashSet<Quiz>();
        }
    }
}
