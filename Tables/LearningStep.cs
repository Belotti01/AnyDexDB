namespace AnyDexDB.Tables {
	[Table("learning_step")]
    public partial class LearningStep {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id"), Display(Name = "ID", ResourceType = typeof(Localization))]
        public ulong Id { get; set; }
        public ulong LearningPathId { get; set; }
        public ulong ResourceId { get; set; }
        public string? Title { get; set; }
        public string Description { get; set; } = string.Empty;

        [NotNull]
        public virtual LearningPath? LearningPath { get; set; }
        [NotNull]
        public virtual Resource? Resource { get; set; }
    }
}
