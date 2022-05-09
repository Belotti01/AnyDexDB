namespace AnyDexDB.Tables {
	[Table("user")]
	public partial class User : IdentityUser<ulong> {
		[Required, MinLength(4), MaxLength(4)]
		[Display(Name = "Tag", ResourceType = typeof(Localization))]
		public int Tag { get; set; }
		[Display(Name = "Full Name", ResourceType = typeof(Localization), ShortName = "Name")]
		public string? FullName { get; set; }
		[Required]
		[Display(Name = "Bio", ResourceType = typeof(Localization))]
		public string Bio { get; set; } = string.Empty;

		[NotNull]
		public virtual ICollection<AccountAction>? AccountActions { get; set; }
		[NotNull]
		public virtual ICollection<Bookmark>? Bookmarks { get; set; }
		[NotNull]
		public virtual ICollection<CategoryRating>? CategoryRatings { get; set; }
		[NotNull]
		public virtual ICollection<LearningPath>? LearningPaths { get; set; }
		[NotNull]
		public virtual ICollection<Notification>? Notifications { get; set; }
		[NotNull]
		public virtual ICollection<Progress>? Progresses { get; set; }
		[NotNull]
		public virtual ICollection<QuizRating>? QuizRatings { get; set; }
		[NotNull]
		public virtual ICollection<QuizResult>? QuizResults { get; set; }
		[NotNull]
		public virtual ICollection<Quiz>? Quizzes { get; set; }
		[NotNull]
		public virtual ICollection<Rating>? Ratings { get; set; }
	}
}
