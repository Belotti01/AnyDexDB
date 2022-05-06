namespace AnyDexDB.Tables {
	[Table("quiz_question")]
	public partial class QuizQuestion {
		public QuizQuestion() {
			QuizAnswers = new HashSet<QuizAnswer>();
		}

		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column("id"), Display(Name = "ID", ResourceType = typeof(Localization))]
		public ulong Id { get; set; }
		[Required, ForeignKey("quiz")]
		[Column("quiz_id"), Display(Name = "Quiz ID", ResourceType = typeof(Localization))]
		public ulong QuizId { get; set; }
		[Required]
		[Column("question"), Display(Name = "Question", ResourceType = typeof(Localization))]
		public string? Question { get; set; }
		[Column("hint"), Display(Name = "Hint", ResourceType = typeof(Localization))]
		public string? Hint { get; set; }
		[Required]
		[Column("is_disabled"), Display(Name = "Disabled", ResourceType = typeof(Localization))]
		public bool? IsDisabled { get; set; } = false;

		[NotNull]
		[Display(Name = "Quiz", ResourceType = typeof(Localization))]
		public virtual Quiz? Quiz { get; set; }
		public virtual ICollection<QuizAnswer> QuizAnswers { get; set; }
	}
}
