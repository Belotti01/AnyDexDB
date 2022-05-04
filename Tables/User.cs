namespace AnyDexDB.Tables {
	[Table("user")]
	public partial class User {
		public User() {
			Accountactions = new HashSet<AccountAction>();
			Bookmarks = new HashSet<Bookmark>();
			Categoryratings = new HashSet<CategoryRating>();
			Learningpaths = new HashSet<LearningPath>();
			Notifications = new HashSet<Notification>();
			Progresses = new HashSet<Progress>();
			Quizratings = new HashSet<QuizRating>();
			Quizresults = new HashSet<QuizResult>();
			Quizzes = new HashSet<Quiz>();
			Ratings = new HashSet<Rating>();
		}

		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column("id"), Display(Name = "ID", ResourceType = typeof(Localization))]
		public ulong Id { get; set; }
		[Required, MaxLength(32), MinLength(4)]
		[Column("id"), Display(Name = "ID", ResourceType = typeof(Localization))]
		public string? Username { get; set; }
		[Required, MinLength(4), MaxLength(4)]
		[Column("tag"), Display(Name = "Tag", ResourceType = typeof(Localization))]
		public int Tag { get; set; }
		[NotMapped]
		// Write-Only password
		public string Password { set => PasswordHash = Hashing.Sha512(value); }
		[Required, MaxLength(128)]
		[Column("password_hash")]
		// Read-Only SHA512-Hashed password
		public string? PasswordHash { get; protected set; }
		[Required]
		[Column("email"), Display(Name = "Email", ResourceType = typeof(Localization))]
		public string? Email { get; set; }
		[Column("full_name"), Display(Name = "Full Name", ResourceType = typeof(Localization), ShortName = "Name")]
		public string? FullName { get; set; }
		[Required]
		[Column("bio"), Display(Name = "Bio", ResourceType = typeof(Localization))]
		public string Bio { get; set; } = string.Empty;

		public virtual ICollection<AccountAction> Accountactions { get; set; }
		public virtual ICollection<Bookmark> Bookmarks { get; set; }
		public virtual ICollection<CategoryRating> Categoryratings { get; set; }
		public virtual ICollection<LearningPath> Learningpaths { get; set; }
		public virtual ICollection<Notification> Notifications { get; set; }
		public virtual ICollection<Progress> Progresses { get; set; }
		public virtual ICollection<QuizRating> Quizratings { get; set; }
		public virtual ICollection<QuizResult> Quizresults { get; set; }
		public virtual ICollection<Quiz> Quizzes { get; set; }
		public virtual ICollection<Rating> Ratings { get; set; }
	}
}
