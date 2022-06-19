namespace AnyDexDB.Tables {
	[Table("quiz_result")]
	public partial class QuizResult : EntityBase {
		[Required, ForeignKey("user")]
		public int UserId { get; set; }
		[Required, ForeignKey("quiz")]
		public int QuizId { get; set; }
		[Required]
		public DateTime Date { get; set; } = DateTime.Now;
		[Required]
		public byte Score { get; set; }

		[NotNull, JsonIgnore]
		public virtual Quiz? Quiz { get; set; }
		[NotNull, JsonIgnore]
		public virtual User? User { get; set; }
	}
}
