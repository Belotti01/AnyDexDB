namespace AnyDexDB.Tables {
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

		public ulong Id { get; set; }
		public string Username { get; set; }
		public int Tag { get; set; }
		// Write-Only password
		public string Password { set => PasswordHash = Hashing.Sha512(value); }
		// Read-Only SHA512-Hashed password
		public string PasswordHash { get; protected set; }
		public string Email { get; set; }
		public string FullName { get; set; }
		public string Bio { get; set; }

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
