namespace AnyDexDB.Tables {
	public partial class ResourceRelation {
		public ulong Id { get; set; }
		public byte Type { get; set; }
		public ulong ResourceId { get; set; }
		public ulong RelatedResourceId { get; set; }

		public virtual Resource RelatedResource { get; set; }
		public virtual Resource Resource { get; set; }
	}
}
