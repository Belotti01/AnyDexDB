using AnyDexDB.Tables.Data;

namespace AnyDexDB.Tables {
	[Table("quiz_rating")]
	public partial class QuizRating : RatingBase {
		[Required, ForeignKey("quiz")]
		public ulong QuizId { get; set; }

		[NotNull]
		public virtual Quiz? Quiz { get; set; }
	}
}
