namespace AnyDexDB.Tables {
	[Table("resource")]
	public partial class Resource {
		public Resource() {
			Bookmarks = new HashSet<Bookmark>();
			Categoryratings = new HashSet<CategoryRating>();
			Learningsteps = new HashSet<LearningStep>();
			Materials = new HashSet<Material>();
			Progresses = new HashSet<Progress>();
			Ratings = new HashSet<Rating>();
			ResourceQuizzes = new HashSet<ResourceQuiz>();
			RelatingResources = new HashSet<ResourceRelation>();
			RelatedResources = new HashSet<ResourceRelation>();
		}

		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Display(Name = "ID", ResourceType = typeof(Localization))]
		public ulong Id { get; set; }
		[Required]
		[Display(Name = "Title", ResourceType = typeof(Localization))]
		public string? Title { get; set; }
		[Required]
		[Display(Name = "Description", ShortName = "Info", ResourceType = typeof(Localization))]
		public string Description { get; set; } = string.Empty;
		[Required]
		[Display(Name = "Summary", ResourceType = typeof(Localization))]
		public string Summary { get; set; } = string.Empty;
		[Required]
		[Display(Name = "Creator", ResourceType = typeof(Localization))]
		public string Creator { get; set; } = string.Empty;
		[Display(Name = "Release Date", ShortName = "Date", ResourceType = typeof(Localization))]
		public DateTime ReleaseDate { get; set; }

		public virtual ICollection<Bookmark> Bookmarks { get; set; }
		public virtual ICollection<CategoryRating> Categoryratings { get; set; }
		public virtual ICollection<LearningStep> Learningsteps { get; set; }
		public virtual ICollection<Material> Materials { get; set; }
		public virtual ICollection<Progress> Progresses { get; set; }
		public virtual ICollection<Rating> Ratings { get; set; }
		public virtual ICollection<ResourceQuiz> ResourceQuizzes { get; set; }
		public virtual ICollection<ResourceRelation> RelatingResources { get; set; }
		public virtual ICollection<ResourceRelation> RelatedResources { get; set; }
	}
}
