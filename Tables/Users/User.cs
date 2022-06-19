namespace AnyDexDB.Tables {
	[Table("user")]
	public partial class User : IdentityUser<int>, IIdentifiable<int> {
		[MaxLength(255)]
		public string? FullName { get; set; }
		[MaxLength(1000)]
		public string Bio { get; set; } = "";
		[Required(AllowEmptyStrings = true)]
		// The UrlAttribute breaks the EditForms, as empty strings are still validated
		// [Url, DisplayFormat(ConvertEmptyStringToNull = true)]
		public string? ProfilePicture { get; set; } = "";
		public string? Location { get; set; } = "";
		public DateTime UtcRegistrationDate { get; init; } = DateTime.UtcNow;

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
		public virtual ICollection<QuizResult>? QuizResults { get; set; }
		[NotNull]
		public virtual ICollection<Quiz>? Quizzes { get; set; }
		[NotNull]
		public virtual ICollection<ResourceRating>? ResourceRatings { get; set; }
		[NotNull]
		public virtual ICollection<MaterialRating>? MaterialRatings { get; set; }
		[NotNull]
		public virtual ICollection<QuizRating>? QuizRatings { get; set; }

	}
}
