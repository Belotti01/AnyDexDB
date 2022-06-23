namespace AnyDexDB.Tables {
	[Table("resource_report")]
	public class ResourceReport : ReportBase<Resource> {
		[Required, ForeignKey("resource")]
		public override int TargetId { get; set; }
	}
}
