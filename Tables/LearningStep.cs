namespace AnyDexDB.Tables {
	[Table("learning_step")]
	public partial class LearningStep {
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column("id"), Display(Name = "ID", ResourceType = typeof(Localization))]
		public ulong Id { get; set; }
		[Required, ForeignKey("learning_path")]
		[Column("learning_path_id"), Display(Name = "Learning Path ID", ResourceType = typeof(Localization))]
		public ulong LearningPathId { get; set; }
		[Required, ForeignKey("resource")]
		[Column("resource_id"), Display(Name = "Resource ID", ResourceType = typeof(Localization))]
		public ulong ResourceId { get; set; }
		[Required]
		[Column("title"), Display(Name = "Title", ResourceType = typeof(Localization))]
		public string? Title { get; set; }
		[Required]
		[Column("description"), Display(Name = "Description", ShortName = "Info", ResourceType = typeof(Localization))]
		public string Description { get; set; } = string.Empty;

		[NotNull]
		[Display(Name = "Learning Path", ShortName = "Path", ResourceType = typeof(Localization))]
		public virtual LearningPath? LearningPath { get; set; }
		[NotNull]
		[Display(Name = "Resource", ResourceType = typeof(Localization))]
		public virtual Resource? Resource { get; set; }
	}
}
