namespace AnyDexDB.Tables {
	[Table("progress")]
	public partial class Progress : EntityBase {
		[Required, ForeignKey("user")]
		public ulong UserId { get; set; }
		[Required, ForeignKey("material")]
		public ulong MaterialId { get; set; }
		[Required]
		public uint Value { get; set; } = 0;
		public DateTime? StartDate { get; set; }
		public DateTime? EndDate { get; set; }
		[Required]
		public bool? IsPrivate { get; set; }
		[Required]
		public ProgressStatus Status { get; set; } = ProgressStatus.None;
		
		[NotNull]
		public virtual Material? Material { get; set; }
		[NotNull]
		public virtual User? User { get; set; }
	}
}
