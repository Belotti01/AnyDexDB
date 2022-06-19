﻿namespace AnyDexDB.Tables {
	[Table("resource_relation")]
	public partial class ResourceRelation : EntityBase {
		public byte Type { get; set; }
		[Required, ForeignKey("resource")]
		public ulong ResourceId { get; set; }
		[Required, ForeignKey("resource")]
		public ulong RelatedResourceId { get; set; }

		[NotNull]
		public virtual Resource? Resource { get; set; }
		[NotNull]
		public virtual Resource? RelatedResource { get; set; }
	}
}
