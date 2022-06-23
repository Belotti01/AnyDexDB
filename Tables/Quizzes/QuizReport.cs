namespace AnyDexDB.Tables {
	[Table("quiz_report")]
	public class QuizReport : ReportBase<Quiz> {
		[Required, ForeignKey("quiz")]
		public override int TargetId { get; set; }
	}
}
