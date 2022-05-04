using System;
using System.Collections.Generic;

namespace AnyDexDB.Tables
{
    public partial class QuizResult
    {
        public ulong Id { get; set; }
        public ulong UserId { get; set; }
        public ulong QuizId { get; set; }
        public DateTime Date { get; set; }
        public byte Score { get; set; }

        public virtual Quiz Quiz { get; set; }
        public virtual User User { get; set; }
    }
}
