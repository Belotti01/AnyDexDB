namespace AnyDexDB.Tables.Data {
	public abstract class CommentBase<TTarget, TSelf> where TSelf : CommentBase<TTarget, TSelf> {
		public CommentBase() {
			ChildComments = new HashSet<TSelf>();
		}


		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public ulong Id { get; set; }
		[Required, ForeignKey("user")]
		public ulong UserId { get; set; }
		// Require the ForeignKeyAttribute
		public abstract ulong ParentCommentId { get; set; }
		public abstract ulong TargetId { get; set; }

		public bool IsSpoiler { get; set; } = false;
		public bool IsNsfw { get; set; } = false;
		public bool IsHidden { get; set; } = false;
		[Required]
		public string Content { get; set; } = "";

		[NotNull]
		public virtual User? User { get; set; }
		public virtual ICollection<TSelf> ChildComments { get; set; }
		public virtual TSelf? ParentComment { get; set; }
		[NotNull]
		public virtual TTarget? Target { get; set; }
	}
}
