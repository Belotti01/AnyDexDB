namespace AnyDexDB.Tables {
	[Table("resource_quiz")]
	public partial class ResourceQuiz : EntityBase {
		[Required, ForeignKey("resource")]
		public int ResourceId { get; set; }
		[Required, ForeignKey("quiz")]
		public int QuizId { get; set; }

		[NotNull, JsonIgnore]
		public virtual Quiz? Quiz { get; set; }
		[NotNull, JsonIgnore]
		public virtual Resource? Resource { get; set; }
	}
}
