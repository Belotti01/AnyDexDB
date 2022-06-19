namespace AnyDexDB.Tables {
	[Table("learning_step")]
	public partial class LearningStep {
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		[Required, ForeignKey("learning_path")]
		public int LearningPathId { get; set; }
		[Required, ForeignKey("resource")]
		public int ResourceId { get; set; }
		[Required]
		public string? Title { get; set; }
		[Required]
		public string Description { get; set; } = string.Empty;

		[NotNull]
		public virtual LearningPath? LearningPath { get; set; }
		[NotNull]
		public virtual Resource? Resource { get; set; }
	}
}
