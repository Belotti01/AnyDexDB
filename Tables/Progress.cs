namespace AnyDexDB.Tables {
	public partial class Progress {
		public ulong Id { get; set; }
		public ulong UserId { get; set; }
		public ulong ResourceId { get; set; }
		public uint Value { get; set; }
		public DateTime? StartDate { get; set; }
		public DateTime? EndDate { get; set; }
		public ulong Private { get; set; }
		public sbyte Status { get; set; }

		public virtual Resource Resource { get; set; }
		public virtual User User { get; set; }
	}
}
