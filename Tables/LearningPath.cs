namespace AnyDexDB.Tables {
	[Table("learning_path")]
    public partial class LearningPath
    {
        public LearningPath()
        {
            LearningSteps = new HashSet<LearningStep>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id"), Display(Name = "ID", ResourceType = typeof(Localization))]
        public ulong Id { get; set; }
        public ulong UserId { get; set; }
        public string? Title { get; set; }
        public string Description { get; set; } = string.Empty;

        [NotNull]
        public virtual User? User { get; set; }
        public virtual ICollection<LearningStep> LearningSteps { get; set; }
    }
}
