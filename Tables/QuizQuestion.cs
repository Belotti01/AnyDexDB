using System;
using System.Collections.Generic;

namespace AnyDexDB.Tables
{
    public partial class QuizQuestion
    {
        public QuizQuestion()
        {
            QuizAnswers = new HashSet<QuizAnswer>();
        }

        public ulong Id { get; set; }
        public ulong QuizId { get; set; }
        public string Question { get; set; }
        public string Hint { get; set; }
        public ulong IsDisabled { get; set; }

        public virtual Quiz Quiz { get; set; }
        public virtual ICollection<QuizAnswer> QuizAnswers { get; set; }
    }
}
