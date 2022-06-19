namespace AnyDexDB.Tables {
	[Table("account_action")]
	public partial class AccountAction {
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public ulong Id { get; set; }
		[ForeignKey("user"), Required]
		public ulong UserId { get; set; }
		[Required, MaxLength(64)]
		public string? Name { get; set; }
		[Required]
		public DateTime Date { get; set; } = DateTime.Now;
		public string? Location { get; set; }
		public string? Ip { get; set; }

		[NotNull]
		public virtual User? User { get; set; }
	}
}
