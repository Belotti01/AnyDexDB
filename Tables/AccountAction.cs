namespace AnyDexDB.Tables {
	public partial class AccountAction {
		public ulong Id { get; set; }
		public ulong UserId { get; set; }
		public string Name { get; set; }
		public DateTime Date { get; set; }
		public string Location { get; set; }
		public string Ip { get; set; }

		public virtual User User { get; set; }
	}
}
