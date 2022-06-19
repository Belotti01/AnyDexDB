namespace AnyDexDB.Tables {
	[Table("quiz_answer")]
	public partial class QuizAnswer : EntityBase {
		[Required]
		public string? Answer { get; set; }
		[Required]
		public bool? IsCorrect { get; set; }
		[Required]
		public ulong QuizQuestionId { get; set; }

		[NotNull]
        public virtual QuizQuestion? QuizQuestion { get; set; }
	}
}
