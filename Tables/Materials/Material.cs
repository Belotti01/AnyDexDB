namespace AnyDexDB.Tables {
	[Table("material")]
	public partial class Material : EntityBase, IReportable<Material, MaterialReport>, IRateable<Material, MaterialRating> {
		public Material() {
			Progresses = new HashSet<Progress>();
			MaterialLinks = new HashSet<MaterialLink>();
		}

		[Required, ForeignKey("resource")]
		public int ResourceId { get; set; }
		[Required]
		public string? Title { get; set; }
		[Required]
		public string Description { get; set; } = string.Empty;
		[Required]
		public uint Length { get; set; } = 0;
		public DateTime? ReleaseDate { get; set; }
		public MaterialType Type { get; set; }
		public string? Owner { get; set; }

		[NotNull, JsonIgnore]
		public virtual Resource? Resource { get; set; }
		[JsonIgnore]
		public virtual ICollection<Progress> Progresses { get; set; }
		[JsonIgnore]
		public virtual ICollection<MaterialLink> MaterialLinks { get; set; }
	}
}
