namespace AnyDexDB.Tables {
	[Table("quiz_question")]
	public partial class QuizQuestion {
		public QuizQuestion() {
			QuizAnswers = new HashSet<QuizAnswer>();
		}

		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public ulong Id { get; set; }
		[Required, ForeignKey("quiz")]
		public ulong QuizId { get; set; }
		[Required]
		public string? Question { get; set; }
		public string? Hint { get; set; }
		[Required]
		public bool? IsDisabled { get; set; } = false;

		[NotNull]
		public virtual Quiz? Quiz { get; set; }
		public virtual ICollection<QuizAnswer> QuizAnswers { get; set; }
	}
}
