namespace AnyDexDB.Tables {
	[Table("material_link")]
    public partial class MaterialLink {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id"), Display(Name = "ID", ResourceType = typeof(Localization))]
        public ulong Id { get; set; }
        public ulong MaterialId { get; set; }
        public string? Link { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime? ReleaseDate { get; set; }

        [NotNull]
        public virtual Material? Material { get; set; }
    }
}
