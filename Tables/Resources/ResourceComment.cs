using AnyDexDB.Tables.Data;

namespace AnyDexDB.Tables {
	[Table("resource_comment")]
	public partial class ResourceComment : CommentBase<Resource, ResourceComment> {
		[ForeignKey("resource_comment")]
		public override ulong ParentCommentId { get; set; }
		[ForeignKey("resource")]
		public override ulong TargetId { get; set; }
	}
}
