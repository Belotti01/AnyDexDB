namespace AnyDexDB.Tables {
	[Table("material_link")]
	public partial class MaterialLink : EntityBase {
		[Required, ForeignKey("material")]
		public ulong MaterialId { get; set; }
		[Required, Url]
		public string? Link { get; set; }
		[Required]
		public string Description { get; set; } = string.Empty;
		public DateTime? ReleaseDate { get; set; }

		[NotNull]
		public virtual Material? Material { get; set; }
	}
}
