namespace AnyDexDB.Tables {
	[Table("user_role")]
	public class UserRole : IdentityUserRole<ulong> {
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column("id")]
		public ulong Id { get; set; }
	}
}
