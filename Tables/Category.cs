namespace AnyDexDB.Tables {
	[Table("category")]
	public partial class Category {
		public Category() {
			CategoryRatings = new HashSet<CategoryRating>();
		}

		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public ulong Id { get; set; }
		[Required]
		public string? Name { get; set; }
		public string Description { get; set; } = string.Empty;

		public virtual ICollection<CategoryRating> CategoryRatings { get; set; }
	}
}
