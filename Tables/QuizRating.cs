namespace AnyDexDB.Tables {
	[Table("quiz_rating")]
	public partial class QuizRating {
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public ulong Id { get; set; }
		[Required, ForeignKey("user")]
		public ulong UserId { get; set; }
		[Required, ForeignKey("quiz")]
		public ulong QuizId { get; set; }
		[Required]
		public byte Rating { get; set; }

		[NotNull]
		public virtual Quiz? Quiz { get; set; }
		[NotNull]
		public virtual User? User { get; set; }
	}
}
