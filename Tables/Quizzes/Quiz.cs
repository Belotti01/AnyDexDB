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
		public ulong Id { get; set; }
		[Required, ForeignKey("user")]
		public ulong CreatorId { get; set; }
		[Required]
		public string? Title { get; set; }
		public string Description { get; set; } = string.Empty;
		[Required]
		public bool? IsPublic { get; set; }
		public DateTime ReleaseDate { get; set; }
		[Required]
		public string LanguageCode { get; set; } = "";

		[NotNull]
		public virtual User? Creator { get; set; }
		public virtual ICollection<QuizQuestion> QuizQuestions { get; set; }
		public virtual ICollection<QuizRating> QuizRatings { get; set; }
		public virtual ICollection<QuizResult> QuizResults { get; set; }
		public virtual ICollection<ResourceQuiz> ResourceQuizzes { get; set; }
	}
}
