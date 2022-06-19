using AnyDexDB.Tables.Data;

namespace AnyDexDB.Tables {
	[Table("material_comment")]
	public partial class MaterialComment : CommentBase<Quiz, MaterialComment> {
		[ForeignKey("material_comment")]
		public override int ParentCommentId { get; set; }
		[ForeignKey("material")]
		public override int TargetId { get; set; }
	}
}
