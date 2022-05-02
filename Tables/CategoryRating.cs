namespace AnyDexDB.Tables {
	public partial class CategoryRating {
		public ulong Id { get; set; }
		public ulong UserId { get; set; }
		public ulong CategoryId { get; set; }
		public ulong ResourceId { get; set; }
		public byte Rating { get; set; }

		public virtual Category Category { get; set; }
		public virtual Resource Resource { get; set; }
		public virtual User User { get; set; }
	}
}
