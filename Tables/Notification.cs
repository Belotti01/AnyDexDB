namespace AnyDexDB.Tables {
	[Table("notification")]
	public partial class Notification {
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column("id"), Display(Name = "ID", ResourceType = typeof(Localization))]
		public ulong Id { get; set; }
		[Required, ForeignKey("user")]
		[Column("user_id"), Display(Name = "User ID", ResourceType = typeof(Localization))]
		public ulong UserId { get; set; }
		[Required]
		[Column("title"), Display(Name = "Title", ResourceType = typeof(Localization))]
		public string? Title { get; set; }
		[Required]
		[Column("description"), Display(Name = "Description", ResourceType = typeof(Localization))]
		public string Description { get; set; } = string.Empty;
		[Url]
		[Column("link"), Display(Name = "Link", ResourceType = typeof(Localization))]
		public string? Link { get; set; }
		[Required]
		[Column("date"), Display(Name = "Date", ResourceType = typeof(Localization))]
		public DateTime Date { get; set; } = DateTime.Now;

		[NotNull]
		[Display(Name = "User", ResourceType = typeof(Localization))]
		public virtual User? User { get; set; }
	}
}
