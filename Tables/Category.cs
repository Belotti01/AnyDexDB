namespace AnyDexDB.Tables {
	[Table("category")]
    public partial class Category
    {
        public Category() {
            CategoryRatings = new HashSet<CategoryRating>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id"), Display(Name = "ID", ResourceType = typeof(Localization))]
        public ulong Id { get; set; }
        [Required]
        [Column("name"), Display(Name = "Name", ResourceType = typeof(Localization))]
        public string? Name { get; set; }
        [Required]
        [Column("description"), Display(Name = "Description", ShortName = "Info", ResourceType = typeof(Localization))]
        public string Description { get; set; } = string.Empty;

        public virtual ICollection<CategoryRating> CategoryRatings { get; set; }
    }
}
