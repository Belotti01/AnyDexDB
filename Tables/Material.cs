namespace AnyDexDB.Tables {
	[Table("material")]
    public partial class Material
    {
        public Material() {
            MaterialLinks = new HashSet<MaterialLink>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id"), Display(Name = "ID", ResourceType = typeof(Localization))]
        public ulong Id { get; set; }
        public ulong ResourceId { get; set; }
        public string? Title { get; set; }
        public string Description { get; set; } = string.Empty;
        public int Length { get; set; }
        public byte Type { get; set; }
        public string? Publisher { get; set; }

        [NotNull]
        public virtual Resource? Resource { get; set; }
        public virtual ICollection<MaterialLink> MaterialLinks { get; set; }
    }
}
