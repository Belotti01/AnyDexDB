namespace AnyDexDB.Tables {
	[Table("material")]
	public partial class Material {
		public Material() {
			MaterialLinks = new HashSet<MaterialLink>();
		}

		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Display(Name = "ID", ResourceType = typeof(Localization))]
		public ulong Id { get; set; }
		[Required, ForeignKey("resource")]
		[Display(Name = "Resource Id", ResourceType = typeof(Localization))]
		public ulong ResourceId { get; set; }
		[Required]
		[Display(Name = "Title", ResourceType = typeof(Localization))]
		public string? Title { get; set; }
		[Required]
		[Display(Name = "Description", ShortName = "Info", ResourceType = typeof(Localization))]
		public string Description { get; set; } = string.Empty;
		[Required]
		[Display(Name = "Length", ResourceType = typeof(Localization))]
		public uint Length { get; set; } = 0;
		[Display(Name = "Type", ResourceType = typeof(Localization))]
		public MaterialType Type { get; set; }
		[Display(Name = "Owner", ResourceType = typeof(Localization))]
		public string? Owner { get; set; }

		[NotNull]
		public virtual Resource? Resource { get; set; }
		public virtual ICollection<MaterialLink> MaterialLinks { get; set; }
	}
}
