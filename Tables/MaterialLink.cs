namespace AnyDexDB.Tables {
	[Table("material_link")]
	public partial class MaterialLink {
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column("id"), Display(Name = "ID", ResourceType = typeof(Localization))]
		public ulong Id { get; set; }
		[Required, ForeignKey("material")]
		[Display(Name = "Material ID", ResourceType = typeof(Localization))]
		public ulong MaterialId { get; set; }
		[Required, Url]
		[Display(Name = "Link", ResourceType = typeof(Localization))]
		public string? Link { get; set; }
		[Required]
		[Display(Name = "Description", ResourceType = typeof(Localization))]
		public string Description { get; set; } = string.Empty;
		[Display(Name = "Release Date", ResourceType = typeof(Localization))]
		public DateTime? ReleaseDate { get; set; }

		[NotNull]
		[Display(Name = "Material", ResourceType = typeof(Localization))]
		public virtual Material? Material { get; set; }
	}
}
