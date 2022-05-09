namespace AnyDexDB.Tables {
	[Table("quiz_rating")]
	public partial class QuizRating {
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Display(Name = "ID", ResourceType = typeof(Localization))]
		public ulong Id { get; set; }
		[Required, ForeignKey("user")]
		[Display(Name = "User ID", ResourceType = typeof(Localization))]
		public ulong UserId { get; set; }
		[Required, ForeignKey("quiz")]
		[Display(Name = "Quiz ID", ResourceType = typeof(Localization))]
		public ulong QuizId { get; set; }
		[Required]
		[Display(Name = "Rating", ResourceType = typeof(Localization))]
		public byte Rating { get; set; }

		[NotNull]
		[Display(Name = "Quiz", ResourceType = typeof(Localization))]
		public virtual Quiz? Quiz { get; set; }
		[NotNull]
		[Display(Name = "User", ResourceType = typeof(Localization))]
		public virtual User? User { get; set; }
	}
}
