namespace AnyDexDB.Tables {
	[Table("material")]
	public partial class Material {
		public Material() {
			MaterialLinks = new HashSet<MaterialLink>();
		}

		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column("id"), Display(Name = "ID", ResourceType = typeof(Localization))]
		public ulong Id { get; set; }
		[Required, ForeignKey("resource")]
		[Column("resource_id"), Display(Name = "Resource Id", ResourceType = typeof(Localization))]
		public ulong ResourceId { get; set; }
		[Required]
		[Column("title"), Display(Name = "Title", ResourceType = typeof(Localization))]
		public string? Title { get; set; }
		[Required]
		[Column("description"), Display(Name = "Description", ShortName = "Info", ResourceType = typeof(Localization))]
		public string Description { get; set; } = string.Empty;
		[Required]
		[Column("length"), Display(Name = "Length", ResourceType = typeof(Localization))]
		public uint Length { get; set; } = 0;
		[Column("length"), Display(Name = "Length", ResourceType = typeof(Localization))]
		public byte Type { get; set; }
		[Column("length"), Display(Name = "Length", ResourceType = typeof(Localization))]
		public string? Publisher { get; set; }

		[NotNull]
		public virtual Resource? Resource { get; set; }
		public virtual ICollection<MaterialLink> MaterialLinks { get; set; }
	}
}
