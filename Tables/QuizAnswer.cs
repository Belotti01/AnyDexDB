namespace AnyDexDB.Tables {
	[Table("quiz_answer")]
	public partial class QuizAnswer {
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column("id"), Display(Name = "ID", ResourceType = typeof(Localization))]
		public ulong Id { get; set; }
		[Required]
		[Column("answer"), Display(Name = "Answer", ResourceType = typeof(Localization))]
		public string? Answer { get; set; }
		[Required]
		[Column("is_correct"), Display(Name = "Correct", ResourceType = typeof(Localization))]
		public bool? IsCorrect { get; set; }
		[Required]
		[Column("quiz_question_id"), Display(Name = "Question ID", ResourceType = typeof(Localization))]
		public ulong QuizQuestionId { get; set; }

		[NotNull]
		[Display(Name = "Question", ResourceType = typeof(Localization))]
        public virtual QuizQuestion? QuizQuestion { get; set; }
	}
}
