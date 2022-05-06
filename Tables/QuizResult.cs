namespace AnyDexDB.Tables {
	[Table("quiz_result")]
	public partial class QuizResult {
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column("id"), Display(Name = "ID", ResourceType = typeof(Localization))]
		public ulong Id { get; set; }
		[Required, ForeignKey("user")]
		[Column("user_id"), Display(Name = "User Id", ResourceType = typeof(Localization))]
		public ulong UserId { get; set; }
		[Required, ForeignKey("quiz")]
		[Column("quiz_id"), Display(Name = "Quiz Id", ResourceType = typeof(Localization))]
		public ulong QuizId { get; set; }
		[Required]
		[Column("date"), Display(Name = "Date", ResourceType = typeof(Localization))]
		public DateTime Date { get; set; } = DateTime.Now;
		[Required]
		[Column("score"), Display(Name = "Score", ResourceType = typeof(Localization))]
		public byte Score { get; set; }

		[NotNull]
		[Display(Name = "Quiz", ResourceType = typeof(Localization))]
		public virtual Quiz? Quiz { get; set; }
		[NotNull]
		[Display(Name = "User", ResourceType = typeof(Localization))]
		public virtual User? User { get; set; }
	}
}
