namespace AnyDexDB.Tables {
	[Table("bookmark")]
	public partial class Bookmark : EntityBase {
		[Required]
		public int UserId { get; set; }
		[Required]
		public int ResourceId { get; set; }
		[Required]
		public DateTime Date { get; set; } = DateTime.Now;

		[NotNull, JsonIgnore]
		public virtual Resource? Resource { get; set; }
		[NotNull, JsonIgnore]
		public virtual User? User { get; set; }
	}
}
