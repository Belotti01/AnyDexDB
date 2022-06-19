namespace AnyDexDB.Tables {
	[Table("bookmark")]
	public partial class Bookmark : EntityBase {
		[Required]
		public ulong UserId { get; set; }
		[Required]
		public ulong ResourceId { get; set; }
		[Required]
		public DateTime Date { get; set; } = DateTime.Now;

		[NotNull, JsonIgnore]
		public virtual Resource? Resource { get; set; }
		[NotNull, JsonIgnore]
		public virtual User? User { get; set; }
	}
}
