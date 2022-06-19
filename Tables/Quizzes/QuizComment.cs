using AnyDexDB.Tables.Data;

namespace AnyDexDB.Tables {
	[Table("quiz_comment")]
	public partial class QuizComment : CommentBase<Quiz, QuizComment> {
		[ForeignKey("quiz_comment")]
		public override int ParentCommentId { get; set; }
		[ForeignKey("quiz")]
		public override int TargetId { get; set; }
	}
}
