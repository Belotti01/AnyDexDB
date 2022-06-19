namespace AnyDexDB.Tables {
	[Table("category_rating")]
	public partial class CategoryRating : RatingBase<Category> {
		public override ulong TargetId { get; set; }
	}
}
