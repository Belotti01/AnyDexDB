using AnyDexDB.Tables.Data;

namespace AnyDexDB.Tables {
	[Table("material_rating")]
	public partial class MaterialRating : RatingBase {
		[Required, ForeignKey("material")]
		public ulong MaterialId{ get; set; }

		[NotNull]
		public virtual Material? Material { get; set; }
	}
}
