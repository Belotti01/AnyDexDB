using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyDexDB.Tables.Data {
	public interface IIdentifiable<TId> {

		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public TId Id { get; set; }
	}
}
