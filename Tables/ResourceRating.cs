using AnyDexDB.Tables.Data;

namespace AnyDexDB.Tables {
	[Table("resource_rating")]
	public partial class ResourceRating : RatingBase {
		[Required, ForeignKey("resource")]
		public ulong ResourceId { get; set; }
		[NotNull]
		public virtual Resource? Resource { get; set; }
	}
}
