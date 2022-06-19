namespace AnyDexDB.Tables {
	[Table("material_flag")]
	public class MaterialFlag : EntityBase {
		[Required, EnumDataType(typeof(Flag))]
		public Flag Flags { get; set; } = Flag.None;
		[Required, ForeignKey("material")]
		public int MaterialId { get; set; }
		[Required, ForeignKey("user")]
		public int UserId { get; set; }
		public DateOnly PublishDate { get; set; }
		public DateTime UtcFlagDate { get; set; } = DateTime.Now;


		[NotNull, JsonIgnore]
		public virtual User? User { get; set; }
		[NotNull, JsonIgnore]
		public virtual Material? Material { get; set; }
	}
}
