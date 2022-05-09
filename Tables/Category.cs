namespace AnyDexDB.Tables {
	[Table("category")]
	public partial class Category {
		public Category() {
			CategoryRatings = new HashSet<CategoryRating>();
		}

		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Display(Name = "ID", ResourceType = typeof(Localization))]
		public ulong Id { get; set; }
		[Required]
		[Display(Name = "Name", ResourceType = typeof(Localization))]
		public string? Name { get; set; }
		[Required]
		[Display(Name = "Description", ShortName = "Info", ResourceType = typeof(Localization))]
		public string Description { get; set; } = string.Empty;

		public virtual ICollection<CategoryRating> CategoryRatings { get; set; }
	}
}
