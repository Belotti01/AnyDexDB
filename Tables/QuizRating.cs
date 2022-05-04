using System;
using System.Collections.Generic;

namespace AnyDexDB.Tables
{
    public partial class QuizRating
    {
        public ulong Id { get; set; }
        public ulong UserId { get; set; }
        public ulong QuizId { get; set; }
        public byte Rating { get; set; }

        public virtual Quiz Quiz { get; set; }
        public virtual User User { get; set; }
    }
}
