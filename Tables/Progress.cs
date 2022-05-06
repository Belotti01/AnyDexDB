namespace AnyDexDB.Tables {
	[Table("progress")]
	public partial class Progress {
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column("id"), Display(Name = "ID", ResourceType = typeof(Localization))]
		public ulong Id { get; set; }
		[Required, ForeignKey("user")]
		[Column("user_id"), Display(Name = "User ID", ResourceType = typeof(Localization))]
		public ulong UserId { get; set; }
		[Required, ForeignKey("resource")]
		[Column("resource_id"), Display(Name = "Resource ID", ResourceType = typeof(Localization))]
		public ulong ResourceId { get; set; }
		[Required]
		[Column("value"), Display(Name = "Progress", ResourceType = typeof(Localization))]
		public uint Value { get; set; } = 0;
		[Column("start_date"), Display(Name = "Start Date", ResourceType = typeof(Localization))]
		public DateTime? StartDate { get; set; }
		[Column("end_date"), Display(Name = "End Date", ResourceType = typeof(Localization))]
		public DateTime? EndDate { get; set; }
		[Required]
		[Column("is_private"), Display(Name = "Private", ResourceType = typeof(Localization))]
		public bool? IsPrivate { get; set; }
		[Required]
		[Column("status"), Display(Name = "Status", ResourceType = typeof(Localization))]
		public ProgressStatus Status { get; set; } = ProgressStatus.None;
		
		[NotNull]
		[Display(Name = "Resource", ResourceType = typeof(Localization))]
		public virtual Resource? Resource { get; set; }
		[NotNull]
		[Display(Name = "User", ResourceType = typeof(Localization))]
		public virtual User? User { get; set; }
	}
}
