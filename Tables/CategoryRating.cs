namespace AnyDexDB.Tables {
	[Table("category_rating")]
    public partial class CategoryRating {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id"), Display(Name = "ID", ResourceType = typeof(Localization))]
        public ulong Id { get; set; }
        public ulong UserId { get; set; }
        public ulong CategoryId { get; set; }
        public ulong ResourceId { get; set; }
        public byte Rating { get; set; }

        [NotNull]
        public virtual Category? Category { get; set; }
        [NotNull]
        public virtual Resource? Resource { get; set; }
        [NotNull]
        public virtual User? User { get; set; }
    }
}
