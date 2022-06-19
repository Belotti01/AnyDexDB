﻿namespace AnyDexDB.Tables.Data {
	public abstract class RatingBase<TTarget> : EntityBase where TTarget : IIdentifiable<int> {
		[Required]
		public abstract int TargetId { get; set; }
		[Required, ForeignKey("user")]
		public int UserId { get; set; }
		[Required]
		public byte Rating { get; set; }
		public string Review { get; set; } = "";

		[NotNull, JsonIgnore]
		public virtual User? User { get; set; }

		[NotNull, JsonIgnore]
		public virtual TTarget? Target { get; set; }
	}
}
