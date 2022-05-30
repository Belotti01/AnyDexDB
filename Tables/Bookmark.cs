namespace AnyDexDB.Tables {
	[Table("bookmark")]
	public partial class Bookmark {
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public ulong Id { get; set; }
		[Required]
		public ulong UserId { get; set; }
		[Required]
		public ulong ResourceId { get; set; }
		[Required]
		public DateTime Date { get; set; } = DateTime.Now;

		[NotNull]
		public virtual Resource? Resource { get; set; }
		[NotNull]
		public virtual User? User { get; set; }
	}
}
