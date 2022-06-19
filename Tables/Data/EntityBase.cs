using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyDexDB.Tables.Data {
	public abstract class EntityBase : IIdentifiable<ulong> {
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public ulong Id { get; set; }
	}
}
