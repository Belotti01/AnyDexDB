namespace AnyDexDB.Tables {
	[Table("material_report")]
	public class MaterialReport : ReportBase<Material> {
		[Required, ForeignKey("material")]
		public override int TargetId { get; set; }
	}
}
