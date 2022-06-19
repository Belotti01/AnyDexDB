using AnyDexDB.Tables.Data;

namespace AnyDexDB.Tables {
	[Table("quiz_rating")]
	public partial class QuizRating : RatingBase<Quiz> {
		[Required, ForeignKey("quiz")]
		public override int TargetId { get; set; }
	}
}
