namespace AnyDexDB.Tables {
	[Table("resource_quiz")]
	public partial class ResourceQuiz {
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column("id"), Display(Name = "ID", ResourceType = typeof(Localization))]
		public ulong Id { get; set; }
		[Required, ForeignKey("resource")]
		[Column("resource_id"), Display(Name = "Resource ID", ResourceType = typeof(Localization))]
		public ulong ResourceId { get; set; }
		[Required, ForeignKey("quiz")]
		[Column("quiz_id"), Display(Name = "Quiz ID", ResourceType = typeof(Localization))]
		public ulong QuizId { get; set; }

		[NotNull]
		[Display(Name = "Quiz", ResourceType = typeof(Localization))]
		public virtual Quiz? Quiz { get; set; }
		[NotNull]
		[Display(Name = "Resource", ResourceType = typeof(Localization))]
		public virtual Resource? Resource { get; set; }
	}
}
