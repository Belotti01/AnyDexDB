namespace AnyDexDB.Tables {
	[Table("material")]
	public partial class Material {
		public Material() {
			Progresses = new HashSet<Progress>();
			MaterialLinks = new HashSet<MaterialLink>();
			MaterialRatings = new HashSet<MaterialRating>();
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
		public DateTime? ReleaseDate { get; set; }
		public MaterialType Type { get; set; }
		public string? Owner { get; set; }

		[NotNull]
		public virtual Resource? Resource { get; set; }
		public virtual ICollection<Progress> Progresses { get; set; }
		public virtual ICollection<MaterialRating> MaterialRatings { get; set; }
		public virtual ICollection<MaterialLink> MaterialLinks { get; set; }
	}
}
