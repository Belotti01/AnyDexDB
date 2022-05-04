﻿namespace AnyDexDB.Tables {
	[Table("bookmark")]
    public partial class Bookmark {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id"), Display(Name = "ID", ResourceType = typeof(Localization))]
        public ulong Id { get; set; }
        [Required]
        [Column("user_id"), Display(Name = "User ID", ResourceType = typeof(Localization))]
        public ulong UserId { get; set; }
        [Required]
        [Column("resource_id"), Display(Name = "Resource ID", ResourceType = typeof(Localization))]
        public ulong ResourceId { get; set; }
        [Required]
        [Column("date"), Display(Name = "Bookmark Date", ShortName = "Date", ResourceType = typeof(Localization))]
        public DateTime Date { get; set; } = DateTime.Now;

        [NotNull]
        [Display(Name = "Resource", ResourceType = typeof(Localization))]
        public virtual Resource? Resource { get; set; }
        [NotNull]
        [Display(Name = "User", ResourceType = typeof(Localization))]
        public virtual User? User { get; set; }
    }
}
