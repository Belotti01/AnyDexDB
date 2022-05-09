namespace AnyDexDB.Tables {
	[Table("quiz_question")]
	public partial class QuizQuestion {
		public QuizQuestion() {
			QuizAnswers = new HashSet<QuizAnswer>();
		}

		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Display(Name = "ID", ResourceType = typeof(Localization))]
		public ulong Id { get; set; }
		[Required, ForeignKey("quiz")]
		[Display(Name = "Quiz ID", ResourceType = typeof(Localization))]
		public ulong QuizId { get; set; }
		[Required]
		[Display(Name = "Question", ResourceType = typeof(Localization))]
		public string? Question { get; set; }
		[Display(Name = "Hint", ResourceType = typeof(Localization))]
		public string? Hint { get; set; }
		[Required]
		[Display(Name = "Disabled", ResourceType = typeof(Localization))]
		public bool? IsDisabled { get; set; } = false;

		[NotNull]
		[Display(Name = "Quiz", ResourceType = typeof(Localization))]
		public virtual Quiz? Quiz { get; set; }
		public virtual ICollection<QuizAnswer> QuizAnswers { get; set; }
	}
}
