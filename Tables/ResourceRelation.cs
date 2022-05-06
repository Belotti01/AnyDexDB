namespace AnyDexDB.Tables {
	[Table("resource_relation")]
	public partial class ResourceRelation {
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column("id"), Display(Name = "ID", ResourceType = typeof(Localization))]
		public ulong Id { get; set; }
		[Column("type"), Display(Name = "Type", ResourceType = typeof(Localization))]
		public byte Type { get; set; }
		[Required, ForeignKey("resource")]
		[Column("resource_id"), Display(Name = "Resource Id", ResourceType = typeof(Localization))]
		public ulong ResourceId { get; set; }
		[Required, ForeignKey("resource")]
		[Column("related_resource_id"), Display(Name = "Related Resource Id", ResourceType = typeof(Localization))]
		public ulong RelatedResourceId { get; set; }

		[NotNull]
		[Display(Name = "Resource", ResourceType = typeof(Localization))]
		public virtual Resource? Resource { get; set; }
		[NotNull]
		[Display(Name = "Related Resource", ResourceType = typeof(Localization))]
		public virtual Resource? RelatedResource { get; set; }
	}
}
