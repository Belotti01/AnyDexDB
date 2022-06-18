using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyDexDB.Tables.Data {
	public class RatingBase {
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public ulong Id { get; set; }
		[Required, ForeignKey("user")]
		public ulong UserId { get; set; }
		[Required]
		public byte Rating { get; set; }
		public string Review { get; set; } = "";

		[NotNull]
		public virtual User? User { get; set; }
	}
}
