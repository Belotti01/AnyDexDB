namespace AnyDexDB.Tables {
	[Table("progress")]
	public partial class Progress {
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Display(Name = "ID", ResourceType = typeof(Localization))]
		public ulong Id { get; set; }
		[Required, ForeignKey("user")]
		[Display(Name = "User ID", ResourceType = typeof(Localization))]
		public ulong UserId { get; set; }
		[Required, ForeignKey("resource")]
		[Display(Name = "Resource ID", ResourceType = typeof(Localization))]
		public ulong ResourceId { get; set; }
		[Required]
		[Display(Name = "Progress", ResourceType = typeof(Localization))]
		public uint Value { get; set; } = 0;
		[Display(Name = "Start Date", ResourceType = typeof(Localization))]
		public DateTime? StartDate { get; set; }
		[Display(Name = "End Date", ResourceType = typeof(Localization))]
		public DateTime? EndDate { get; set; }
		[Required]
		[Display(Name = "Private", ResourceType = typeof(Localization))]
		public bool? IsPrivate { get; set; }
		[Required]
		[Display(Name = "Status", ResourceType = typeof(Localization))]
		public ProgressStatus Status { get; set; } = ProgressStatus.None;
		
		[NotNull]
		[Display(Name = "Resource", ResourceType = typeof(Localization))]
		public virtual Resource? Resource { get; set; }
		[NotNull]
		[Display(Name = "User", ResourceType = typeof(Localization))]
		public virtual User? User { get; set; }
	}
}
