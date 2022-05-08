namespace AnyDexDB.Tables {
	[Table("user_login")]
	public class UserLogin : IdentityUserLogin<ulong> {
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column("id")]
		public ulong Id { get; set; }
	}
}
