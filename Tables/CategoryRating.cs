namespace AnyDexDB.Tables {
	[Table("category_rating")]
	public partial class CategoryRating : RatingBase<Category> {
		public override int TargetId { get; set; }
	}
}
