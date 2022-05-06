namespace AnyDexDB.Tables {
	[Table("rating")]
	public partial class Rating {
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column("id"), Display(Name = "ID", ResourceType = typeof(Localization))]
		public ulong Id { get; set; }
		[Required, ForeignKey("user")]
		[Column("user_id"), Display(Name = "User ID", ResourceType = typeof(Localization))]
		public ulong UserId { get; set; }
		[Required, ForeignKey("resource")]
		[Column("resource_id"), Display(Name = "Resource ID", ResourceType = typeof(Localization))]
		public ulong ResourceId { get; set; }
		[Required]
		[Column("score"), Display(Name = "Rating", ResourceType = typeof(Localization))]
		public byte Score { get; set; }

		[NotNull]
		[Display(Name = "Resource", ResourceType = typeof(Localization))]
		public virtual Resource? Resource { get; set; }
		[NotNull]
		[Display(Name = "User", ResourceType = typeof(Localization))]
		public virtual User? User { get; set; }
	}
}
