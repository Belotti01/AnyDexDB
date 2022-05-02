namespace AnyDexDB.Tables {
	public partial class Quiz {
		public Quiz() {
			Quizquestions = new HashSet<QuizQuestion>();
			Quizratings = new HashSet<QuizRating>();
			Quizresults = new HashSet<QuizResult>();
			Resourcequizzes = new HashSet<ResourceQuiz>();
		}

		public ulong Id { get; set; }
		public ulong CreatorId { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public ulong IsPublic { get; set; }
		public DateTime ReleaseDate { get; set; }

		public virtual User Creator { get; set; }
		public virtual ICollection<QuizQuestion> Quizquestions { get; set; }
		public virtual ICollection<QuizRating> Quizratings { get; set; }
		public virtual ICollection<QuizResult> Quizresults { get; set; }
		public virtual ICollection<ResourceQuiz> Resourcequizzes { get; set; }
	}
}
