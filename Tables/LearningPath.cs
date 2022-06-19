namespace AnyDexDB.Tables {
	[Table("learning_path")]
	public partial class LearningPath {
		public LearningPath() {
			LearningSteps = new HashSet<LearningStep>();
		}

		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		[Required, ForeignKey("user")]
		public int UserId { get; set; }
		[Required]
		public string? Title { get; set; }
		[Required]
		public string Description { get; set; } = string.Empty;

		[NotNull]
		public virtual User? User { get; set; }
		public virtual ICollection<LearningStep> LearningSteps { get; set; }
	}
}
