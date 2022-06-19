namespace AnyDexDB.Tables {
	[Table("quiz_result")]
	public partial class QuizResult {
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public ulong Id { get; set; }
		[Required, ForeignKey("user")]
		public ulong UserId { get; set; }
		[Required, ForeignKey("quiz")]
		public ulong QuizId { get; set; }
		[Required]
		public DateTime Date { get; set; } = DateTime.Now;
		[Required]
		public byte Score { get; set; }

		[NotNull]
		public virtual Quiz? Quiz { get; set; }
		[NotNull]
		public virtual User? User { get; set; }
	}
}
