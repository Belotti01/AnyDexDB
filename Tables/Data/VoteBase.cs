namespace AnyDexDB.Tables.Data {
	public abstract class VoteBase<TTarget> : EntityBase where TTarget : IIdentifiable<int> {
		[Required]
		public abstract int TargetId { get; set; }
		[Required, ForeignKey("user")]
		public int UserId { get; set; }
		[Required]
		public bool IsUpvote { get; set; }

		[NotNull, JsonIgnore]
		public virtual User? User { get; set; }

		[NotNull, JsonIgnore]
		public virtual TTarget? Target { get; set; }
	}
}
