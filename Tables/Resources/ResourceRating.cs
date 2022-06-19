﻿using AnyDexDB.Tables.Data;

namespace AnyDexDB.Tables {
	[Table("resource_rating")]
	public partial class ResourceRating : RatingBase<Resource> {
		[Required, ForeignKey("resource")]
		public override ulong TargetId { get; set; }
	}
}
