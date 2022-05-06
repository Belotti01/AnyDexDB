namespace AnyDexDB.Tables {
	[Table("category_rating")]
	public partial class CategoryRating {
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column("id"), Display(Name = "ID", ResourceType = typeof(Localization))]
		public ulong Id { get; set; }
		[Required, ForeignKey("user")]
		[Column("user_id"), Display(Name = "User ID", ResourceType = typeof(Localization))]
		public ulong UserId { get; set; }
		[Required, ForeignKey("category")]
		[Column("category"), Display(Name = "Category ID", ResourceType = typeof(Localization))]
		public ulong CategoryId { get; set; }
		[Required, ForeignKey("resource")]
		[Column("resource_id"), Display(Name = "Resource ID", ResourceType = typeof(Localization))]
		public ulong ResourceId { get; set; }
		[Required]
		[Column("rating"), Display(Name = "Rating", ResourceType = typeof(Localization))]
		public byte Rating { get; set; }
		[NotNull]
		[Display(Name = "Category", ResourceType = typeof(Localization))]
		public virtual Category? Category { get; set; }
		[NotNull]
		[Display(Name = "Resource", ResourceType = typeof(Localization))]
		public virtual Resource? Resource { get; set; }
		[NotNull]
		[Display(Name = "User", ResourceType = typeof(Localization))]
		public virtual User? User { get; set; }
	}
}
