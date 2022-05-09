namespace AnyDexDB.Tables {
	[Table("notification")]
	public partial class Notification {
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Display(Name = "ID", ResourceType = typeof(Localization))]
		public ulong Id { get; set; }
		[Required, ForeignKey("user")]
		[Display(Name = "User ID", ResourceType = typeof(Localization))]
		public ulong UserId { get; set; }
		[Required]
		[Display(Name = "Title", ResourceType = typeof(Localization))]
		public string? Title { get; set; }
		[Required]
		[Display(Name = "Description", ResourceType = typeof(Localization))]
		public string Description { get; set; } = string.Empty;
		[Url]
		[Display(Name = "Link", ResourceType = typeof(Localization))]
		public string? Link { get; set; }
		[Required]
		[Display(Name = "Date", ResourceType = typeof(Localization))]
		public DateTime Date { get; set; } = DateTime.Now;

		[NotNull]
		[Display(Name = "User", ResourceType = typeof(Localization))]
		public virtual User? User { get; set; }
	}
}
