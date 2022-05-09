namespace AnyDexDB.Tables {
	[Table("account_action")]
	public partial class AccountAction {
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Display(Name = "ID", ResourceType = typeof(Localization))]
		public ulong Id { get; set; }
		[ForeignKey("user"), Required]
		[Display(Name = "User ID", ResourceType = typeof(Localization))]
		public ulong UserId { get; set; }
		[Required, MaxLength(64)]
		[Display(Name = "Name", ResourceType = typeof(Localization))]
		public string? Name { get; set; }
		[Required]
		[Display(Name = "Date", ResourceType = typeof(Localization))]
		public DateTime Date { get; set; } = DateTime.Now;
		[Required]
		[Display(Name = "Location", ResourceType = typeof(Localization))]
		public string? Location { get; set; }
		[Display(Name = "IP Address", ShortName = "IP", ResourceType = typeof(Localization))]
		public string? Ip { get; set; }

		[NotNull]
		[Display(Name = "User", ResourceType = typeof(Localization))]
		public virtual User? User { get; set; }
	}
}
