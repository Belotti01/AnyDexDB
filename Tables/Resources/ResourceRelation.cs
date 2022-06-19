namespace AnyDexDB.Tables {
	[Table("resource_relation")]
	public partial class ResourceRelation : EntityBase {
		public byte Type { get; set; }
		[Required, ForeignKey("resource")]
		public int ResourceId { get; set; }
		[Required, ForeignKey("resource")]
		public int RelatedResourceId { get; set; }

		[NotNull, JsonIgnore]
		public virtual Resource? Resource { get; set; }
		[NotNull, JsonIgnore]
		public virtual Resource? RelatedResource { get; set; }
	}
}
