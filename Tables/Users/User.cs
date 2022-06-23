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

		[NotNull, JsonIgnore]
		public virtual ICollection<AccountAction>? AccountActions { get; set; }
		[NotNull, JsonIgnore]
		public virtual ICollection<Bookmark>? Bookmarks { get; set; }
		[NotNull, JsonIgnore]
		public virtual ICollection<CategoryRating>? CategoryRatings { get; set; }
		[NotNull, JsonIgnore]
		public virtual ICollection<LearningPath>? LearningPaths { get; set; }
		[NotNull, JsonIgnore]
		public virtual ICollection<Notification>? Notifications { get; set; }
		[NotNull, JsonIgnore]
		public virtual ICollection<Progress>? Progresses { get; set; }
		[NotNull, JsonIgnore]
		public virtual ICollection<QuizResult>? QuizResults { get; set; }
		[NotNull, JsonIgnore]
		public virtual ICollection<Quiz>? Quizzes { get; set; }
		[NotNull, JsonIgnore]
		public virtual ICollection<ResourceRating>? ResourceRatings { get; set; }
		[NotNull, JsonIgnore]
		public virtual ICollection<MaterialRating>? MaterialRatings { get; set; }
		[NotNull, JsonIgnore]
		public virtual ICollection<QuizRating>? QuizRatings { get; set; }
		[NotNull, JsonIgnore]
		public virtual ICollection<ResourceReport>? ResourceReports { get; set; }
		[NotNull, JsonIgnore]
		public virtual ICollection<MaterialReport>? MaterialReports{ get; set; }
		[NotNull, JsonIgnore]
		public virtual ICollection<QuizReport>? QuizReports { get; set; }

	}
}
