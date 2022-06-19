namespace AnyDexDB.Tables {
	[Table("resource_quiz")]
	public partial class ResourceQuiz {
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public ulong Id { get; set; }
		[Required, ForeignKey("resource")]
		public ulong ResourceId { get; set; }
		[Required, ForeignKey("quiz")]
		public ulong QuizId { get; set; }

		[NotNull]
		public virtual Quiz? Quiz { get; set; }
		[NotNull]
		public virtual Resource? Resource { get; set; }
	}
}
