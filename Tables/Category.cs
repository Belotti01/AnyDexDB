namespace AnyDexDB.Tables {
	[Table("category")]
	public partial class Category : EntityBase {
		public Category() {
			CategoryRatings = new HashSet<CategoryRating>();
		}

		[Required]
		public string? Name { get; set; }
		public string Description { get; set; } = string.Empty;

		public virtual ICollection<CategoryRating> CategoryRatings { get; set; }
	}
}
