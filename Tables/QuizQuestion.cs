namespace AnyDexDB.Tables {
	[Table("quiz_question")]
    public partial class QuizQuestion
    {
        public QuizQuestion()
        {
            QuizAnswers = new HashSet<QuizAnswer>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id"), Display(Name = "ID", ResourceType = typeof(Localization))]
        public ulong Id { get; set; }
        public ulong QuizId { get; set; }
        public string? Question { get; set; }
        public string? Hint { get; set; }
        public ulong IsDisabled { get; set; }

        [NotNull]
        public virtual Quiz? Quiz { get; set; }
        public virtual ICollection<QuizAnswer> QuizAnswers { get; set; }
    }
}
