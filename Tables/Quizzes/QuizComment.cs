using AnyDexDB.Tables.Data;

namespace AnyDexDB.Tables {
	[Table("quiz_comment")]
	public partial class QuizComment : CommentBase<Quiz, QuizComment> {
		[ForeignKey("quiz_comment")]
		public override ulong ParentCommentId { get; set; }
		[ForeignKey("quiz")]
		public override ulong TargetId { get; set; }
	}
}
