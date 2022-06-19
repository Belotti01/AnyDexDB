namespace AnyDexDB.Tables {
	[Table("account_action")]
	public partial class AccountAction : EntityBase {
		[ForeignKey("user"), Required]
		public int UserId { get; set; }
		[Required, MaxLength(64)]
		public string? Name { get; set; }
		[Required]
		public DateTime Date { get; set; } = DateTime.Now;
		public string? Location { get; set; }
		public string? Ip { get; set; }

		[NotNull, JsonIgnore]
		public virtual User? User { get; set; }
	}
}
