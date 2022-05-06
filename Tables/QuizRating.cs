namespace AnyDexDB.Tables {
	[Table("quiz_rating")]
	public partial class QuizRating {
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column("id"), Display(Name = "ID", ResourceType = typeof(Localization))]
		public ulong Id { get; set; }
		[Required, ForeignKey("user")]
		[Column("user_id"), Display(Name = "User ID", ResourceType = typeof(Localization))]
		public ulong UserId { get; set; }
		[Required, ForeignKey("quiz")]
		[Column("quiz_id"), Display(Name = "Quiz ID", ResourceType = typeof(Localization))]
		public ulong QuizId { get; set; }
		[Required]
		[Column("rating"), Display(Name = "Rating", ResourceType = typeof(Localization))]
		public byte Rating { get; set; }

		[NotNull]
		[Display(Name = "Quiz", ResourceType = typeof(Localization))]
		public virtual Quiz? Quiz { get; set; }
		[NotNull]
		[Display(Name = "User", ResourceType = typeof(Localization))]
		public virtual User? User { get; set; }
	}
}
