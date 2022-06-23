using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyDexDB.Tables.Data {
	public abstract class ReportBase<TTarget> : EntityBase where TTarget : IIdentifiable<int> {
		[Required]
		abstract public int TargetId { get; set; }
		[Required, ForeignKey("user")]
		public int UserId { get; set; }

		public string Description { get; set; } = "";
		[Required, EnumDataType(typeof(Flag))]
		public Flag Flags { get; set; } = Flag.None;
		public DateTime UtcReportDate { get; set; }
		public bool IsArchived { get; set; } = false;

		[NotNull, JsonIgnore]
		public virtual TTarget? Target { get; set; }
		[NotNull, JsonIgnore]
		public virtual User? User { get; set; }
	}
}
