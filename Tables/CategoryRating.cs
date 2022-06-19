namespace AnyDexDB.Tables {
	[Table("category_rating")]
	public partial class CategoryRating : Data.RatingBase<Category> {
		public override ulong TargetId { get; set; }
	}
}
