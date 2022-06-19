namespace AnyDexDB.Tables {
	[Table("resource")]
	public partial class Resource {
		public Resource() {
			Bookmarks = new HashSet<Bookmark>();
			CategoryRatings = new HashSet<CategoryRating>();
			Learningsteps = new HashSet<LearningStep>();
			Materials = new HashSet<Material>();
			ResourceRatings = new HashSet<ResourceRating>();
			ResourceQuizzes = new HashSet<ResourceQuiz>();
			RelatingResources = new HashSet<ResourceRelation>();
			RelatedResources = new HashSet<ResourceRelation>();
		}

		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public ulong Id { get; set; }
		[Required]
		public string? Title { get; set; }
		[Required]
		public string Description { get; set; } = string.Empty;
		[Required]
		public string Summary { get; set; } = string.Empty;
		[Required]
		public string Creator { get; set; } = string.Empty;
		public string ImageUrl { get; set; } = string.Empty;
		public DateTime? ReleaseDate { get; set; }

		[JsonIgnore]
		public virtual ICollection<Bookmark> Bookmarks { get; set; }
		[JsonIgnore]
		public virtual ICollection<CategoryRating> CategoryRatings { get; set; }
		[JsonIgnore]
		public virtual ICollection<LearningStep> Learningsteps { get; set; }
		[JsonIgnore]
		public virtual ICollection<Material> Materials { get; set; }
		[JsonIgnore]
		public virtual ICollection<ResourceRating> ResourceRatings { get; set; }
		[JsonIgnore]
		public virtual ICollection<ResourceQuiz> ResourceQuizzes { get; set; }
		[JsonIgnore]
		public virtual ICollection<ResourceRelation> RelatingResources { get; set; }
		[JsonIgnore]
		public virtual ICollection<ResourceRelation> RelatedResources { get; set; }
	}
}
