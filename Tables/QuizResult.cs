namespace AnyDexDB.Tables {
	[Table("quiz_result")]
	public partial class QuizResult {
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Display(Name = "ID", ResourceType = typeof(Localization))]
		public ulong Id { get; set; }
		[Required, ForeignKey("user")]
		[Display(Name = "User Id", ResourceType = typeof(Localization))]
		public ulong UserId { get; set; }
		[Required, ForeignKey("quiz")]
		[Display(Name = "Quiz Id", ResourceType = typeof(Localization))]
		public ulong QuizId { get; set; }
		[Required]
		[Display(Name = "Date", ResourceType = typeof(Localization))]
		public DateTime Date { get; set; } = DateTime.Now;
		[Required]
		[Display(Name = "Score", ResourceType = typeof(Localization))]
		public byte Score { get; set; }

		[NotNull]
		[Display(Name = "Quiz", ResourceType = typeof(Localization))]
		public virtual Quiz? Quiz { get; set; }
		[NotNull]
		[Display(Name = "User", ResourceType = typeof(Localization))]
		public virtual User? User { get; set; }
	}
}
