namespace AnyDexDB.Tables {
	[Table("learning_step")]
	public partial class LearningStep {
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Display(Name = "ID", ResourceType = typeof(Localization))]
		public ulong Id { get; set; }
		[Required, ForeignKey("learning_path")]
		[Display(Name = "Learning Path ID", ResourceType = typeof(Localization))]
		public ulong LearningPathId { get; set; }
		[Required, ForeignKey("resource")]
		[Display(Name = "Resource ID", ResourceType = typeof(Localization))]
		public ulong ResourceId { get; set; }
		[Required]
		[Display(Name = "Title", ResourceType = typeof(Localization))]
		public string? Title { get; set; }
		[Required]
		[Display(Name = "Description", ShortName = "Info", ResourceType = typeof(Localization))]
		public string Description { get; set; } = string.Empty;

		[NotNull]
		[Display(Name = "Learning Path", ShortName = "Path", ResourceType = typeof(Localization))]
		public virtual LearningPath? LearningPath { get; set; }
		[NotNull]
		[Display(Name = "Resource", ResourceType = typeof(Localization))]
		public virtual Resource? Resource { get; set; }
	}
}
