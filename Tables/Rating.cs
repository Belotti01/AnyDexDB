namespace AnyDexDB.Tables {
	public partial class Rating {
		public ulong Id { get; set; }
		public ulong UserId { get; set; }
		public ulong ResourceId { get; set; }
		public byte Rating1 { get; set; }

		public virtual Resource Resource { get; set; }
		public virtual User User { get; set; }
	}
}
