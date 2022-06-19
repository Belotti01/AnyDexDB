using AnyDexDB.Tables.Data;

namespace AnyDexDB.Tables {
	[Table("material_rating")]
	public partial class MaterialRating : RatingBase<Material> {
		[Required, ForeignKey("material")]
		public override int TargetId { get; set; }
	}
}
