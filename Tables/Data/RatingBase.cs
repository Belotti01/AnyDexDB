namespace AnyDexDB.Tables.Data {
	public abstract class RatingBase<TTarget> where TTarget : class {
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public ulong Id { get; set; }
		[Required]
		public abstract ulong TargetId { get; set; }
		[Required, ForeignKey("user")]
		public ulong UserId { get; set; }
		[Required]
		public byte Rating { get; set; }
		public string Review { get; set; } = "";

		[NotNull, JsonIgnore]
		public virtual User? User { get; set; }

		[NotNull, JsonIgnore]
		public virtual TTarget? Target { get; set; }
	}
}
