namespace AnyDexDB.Tables {
	public partial class QuizAnswer {
		public ulong Id { get; set; }
		public string Answer { get; set; }
		public ulong IsRight { get; set; }
		public ulong QuizQuestionId { get; set; }

		public virtual QuizQuestion QuizQuestion { get; set; }
	}
}
