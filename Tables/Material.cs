namespace AnyDexDB.Tables {
	[Table("material")]
	public partial class Material {
		public Material() {
			MaterialLinks = new HashSet<MaterialLink>();
		}

		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public ulong Id { get; set; }
		[Required, ForeignKey("resource")]
		public ulong ResourceId { get; set; }
		[Required]
		public string? Title { get; set; }
		[Required]
		public string Description { get; set; } = string.Empty;
		[Required]
		public uint Length { get; set; } = 0;
		public MaterialType Type { get; set; }
		public string? Owner { get; set; }

		[NotNull]
		public virtual Resource? Resource { get; set; }
		public virtual ICollection<MaterialLink> MaterialLinks { get; set; }
	}
}
