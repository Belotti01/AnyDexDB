namespace AnyDexDB.Tables {
	[Table("quiz_question")]
	public partial class QuizQuestion : EntityBase {
		public QuizQuestion() {
			QuizAnswers = new HashSet<QuizAnswer>();
		}

		[Required, ForeignKey("quiz")]
		public ulong QuizId { get; set; }
		[Required]
		public string? Question { get; set; }
		public string? Hint { get; set; }
		public string? ImageUrl { get; set; }
		[Required]
		public bool? IsDisabled { get; set; } = false;

		[NotNull, JsonIgnore]
		public virtual Quiz? Quiz { get; set; }
		[JsonIgnore]
		public virtual ICollection<QuizAnswer> QuizAnswers { get; set; }
	}
}
