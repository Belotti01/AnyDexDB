namespace AnyDexDB.Tables {
	[Table("quiz_answer")]
	public partial class QuizAnswer {
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Display(Name = "ID", ResourceType = typeof(Localization))]
		public ulong Id { get; set; }
		[Required]
		[Display(Name = "Answer", ResourceType = typeof(Localization))]
		public string? Answer { get; set; }
		[Required]
		[Display(Name = "Correct", ResourceType = typeof(Localization))]
		public bool? IsCorrect { get; set; }
		[Required]
		[Display(Name = "Question ID", ResourceType = typeof(Localization))]
		public ulong QuizQuestionId { get; set; }

		[NotNull]
		[Display(Name = "Question", ResourceType = typeof(Localization))]
        public virtual QuizQuestion? QuizQuestion { get; set; }
	}
}
