namespace AnyDexDB.Tables {
	[Table("progress")]
    public partial class Progress {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id"), Display(Name = "ID", ResourceType = typeof(Localization))]
        public ulong Id { get; set; }
        public ulong UserId { get; set; }
        public ulong ResourceId { get; set; }
        public uint Value { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public ulong Private { get; set; }
        public sbyte Status { get; set; }

        [NotNull]
        public virtual Resource? Resource { get; set; }
        [NotNull]
        public virtual User? User { get; set; }
    }
}
