namespace AnyDexDB.Tables {
	[Table("category_rating")]
	public partial class CategoryRating {
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public ulong Id { get; set; }
		[Required, ForeignKey("user")]
		public ulong UserId { get; set; }
		[Required, ForeignKey("category")]
		public ulong CategoryId { get; set; }
		[Required, ForeignKey("resource")]
		public ulong ResourceId { get; set; }
		[Required]
		public byte Rating { get; set; }
		[NotNull]
		public virtual Category? Category { get; set; }
		[NotNull]
		public virtual Resource? Resource { get; set; }
		[NotNull]
		public virtual User? User { get; set; }
	}
}
