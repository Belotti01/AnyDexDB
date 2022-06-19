namespace AnyDexDB.Tables {
	[Table("material_flag")]
	public class MaterialFlag {
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public ulong Id { get; set; }
		[Required, EnumDataType(typeof(Flag))]
		public Flag Flags { get; set; } = Flag.None;
		[Required, ForeignKey("material")]
		public ulong MaterialId { get; set; }
		[Required, ForeignKey("user")]
		public ulong UserId { get; set; }
		public DateOnly PublishDate { get; set; }
		public DateTime UtcFlagDate { get; set; } = DateTime.Now;


		[NotNull]
		public virtual User? User { get; set; }
		[NotNull]
		public virtual Material? Material { get; set; }
	}
}
