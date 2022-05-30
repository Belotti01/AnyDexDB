namespace AnyDexDB.Tables {
	[Table("rating")]
	public partial class Rating {
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public ulong Id { get; set; }
		[Required, ForeignKey("user")]
		public ulong UserId { get; set; }
		[Required, ForeignKey("resource")]
		public ulong ResourceId { get; set; }
		[Required]
		public byte Score { get; set; }

		[NotNull]
		public virtual Resource? Resource { get; set; }
		[NotNull]
		public virtual User? User { get; set; }
	}
}
