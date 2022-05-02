namespace AnyDexDB.Tables {
	public partial class ResourceQuiz {
		public ulong Id { get; set; }
		public ulong ResourceId { get; set; }
		public ulong QuizId { get; set; }

		public virtual Quiz Quiz { get; set; }
		public virtual Resource Resource { get; set; }
	}
}
