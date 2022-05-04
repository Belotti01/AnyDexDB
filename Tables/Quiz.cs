using System;
using System.Collections.Generic;

namespace AnyDexDB.Tables
{
    public partial class Quiz
    {
        public Quiz()
        {
            QuizQuestions = new HashSet<QuizQuestion>();
            QuizRatings = new HashSet<QuizRating>();
            QuizResults = new HashSet<QuizResult>();
            ResourceQuizzes = new HashSet<ResourceQuiz>();
        }

        public ulong Id { get; set; }
        public ulong CreatorId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ulong IsPublic { get; set; }
        public DateTime ReleaseDate { get; set; }

        public virtual User Creator { get; set; }
        public virtual ICollection<QuizQuestion> QuizQuestions { get; set; }
        public virtual ICollection<QuizRating> QuizRatings { get; set; }
        public virtual ICollection<QuizResult> QuizResults { get; set; }
        public virtual ICollection<ResourceQuiz> ResourceQuizzes { get; set; }
    }
}
