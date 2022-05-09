namespace AnyDexDB.Tables {
	[Table("learning_path")]
	public partial class LearningPath {
		public LearningPath() {
			LearningSteps = new HashSet<LearningStep>();
		}

		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Display(Name = "ID", ResourceType = typeof(Localization))]
		public ulong Id { get; set; }
		[Required, ForeignKey("user")]
		[Display(Name = "User Id", ResourceType = typeof(Localization))]
		public ulong UserId { get; set; }
		[Required]
		[Display(Name = "Title", ResourceType = typeof(Localization))]
		public string? Title { get; set; }
		[Required]
		[Display(Name = "Description", ShortName = "Info", ResourceType = typeof(Localization))]
		public string Description { get; set; } = string.Empty;

		[NotNull]
		[Display(Name = "User", ResourceType = typeof(Localization))]
		public virtual User? User { get; set; }
		public virtual ICollection<LearningStep> LearningSteps { get; set; }
	}
}
