namespace AnyDexDB.Tables {
	[Table("progress")]
	public partial class Progress {
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public ulong Id { get; set; }
		[Required, ForeignKey("user")]
		public ulong UserId { get; set; }
		[Required, ForeignKey("resource")]
		public ulong ResourceId { get; set; }
		[Required]
		public uint Value { get; set; } = 0;
		public DateTime? StartDate { get; set; }
		public DateTime? EndDate { get; set; }
		[Required]
		public bool? IsPrivate { get; set; }
		[Required]
		public ProgressStatus Status { get; set; } = ProgressStatus.None;
		
		[NotNull]
		public virtual Resource? Resource { get; set; }
		[NotNull]
		public virtual User? User { get; set; }
	}
}
