namespace AnyDexDB.Tables.Data {
	public abstract class CommentBase<TTarget, TSelf> : EntityBase where TSelf : CommentBase<TTarget, TSelf> {
		public CommentBase() {
			ChildComments = new HashSet<TSelf>();
		}


		[Required, ForeignKey("user")]
		public int UserId { get; set; }
		// Require the ForeignKeyAttribute
		public abstract int ParentCommentId { get; set; }
		public abstract int TargetId { get; set; }

		public bool IsSpoiler { get; set; } = false;
		public bool IsNsfw { get; set; } = false;
		public bool IsHidden { get; set; } = false;
		public bool IsDeleted { get; set; } = false;

		public DateTime UtcPostDate { get; set; }
		public DateTime UtcLastModifiedDate { get; set; }
		[Required]
		public string Content { get; set; } = "";

		[NotNull, JsonIgnore]
		public virtual User? User { get; set; }
		[JsonIgnore]
		public virtual ICollection<TSelf> ChildComments { get; set; }
		[JsonIgnore]
		public virtual TSelf? ParentComment { get; set; }
		[NotNull, JsonIgnore]
		public virtual TTarget? Target { get; set; }
	}
}
