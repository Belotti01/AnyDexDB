namespace AnyDexDB.Tables {
	[Table("quiz")]
	public partial class Quiz {
		public Quiz() {
			QuizQuestions = new HashSet<QuizQuestion>();
			QuizRatings = new HashSet<QuizRating>();
			QuizResults = new HashSet<QuizResult>();
			ResourceQuizzes = new HashSet<ResourceQuiz>();
		}

		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column("id"), Display(Name = "ID", ResourceType = typeof(Localization))]
		public ulong Id { get; set; }
		[Required, ForeignKey("user")]
		[Column("creator_id"), Display(Name = "Creator ID", ResourceType = typeof(Localization))]
		public ulong CreatorId { get; set; }
		[Required]
		[Column("title"), Display(Name = "Title", ResourceType = typeof(Localization))]
		public string? Title { get; set; }
		[Column("description"), Display(Name = "Description", ShortName = "Info", ResourceType = typeof(Localization))]
		public string Description { get; set; } = string.Empty;
		[Required]
		[Column("is_public"), Display(Name = "Public", ResourceType = typeof(Localization))]
		public bool? IsPublic { get; set; }
		[Column("release_date"), Display(Name = "Release Date", ResourceType = typeof(Localization))]
		public DateTime ReleaseDate { get; set; }

		[NotNull]
		[Display(Name = "Creator", ResourceType = typeof(Localization))]
		public virtual User? Creator { get; set; }
		public virtual ICollection<QuizQuestion> QuizQuestions { get; set; }
		public virtual ICollection<QuizRating> QuizRatings { get; set; }
		public virtual ICollection<QuizResult> QuizResults { get; set; }
		public virtual ICollection<ResourceQuiz> ResourceQuizzes { get; set; }
	}
}
