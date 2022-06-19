namespace AnyDexDB.Tables {
	[Table("notification")]
	public partial class Notification : EntityBase {
		[Required, ForeignKey("user")]
		public ulong UserId { get; set; }
		[Required]
		public string? Title { get; set; }
		[Required]
		public string Description { get; set; } = string.Empty;
		[Url]
		public string? Link { get; set; }
		[Required]
		public DateTime Date { get; set; } = DateTime.Now;

		[NotNull]
		public virtual User? User { get; set; }
	}
}
