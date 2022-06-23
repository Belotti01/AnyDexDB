using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyDexDB.Tables.Data {
	public interface IIdentifiable<TId> {
		/// <summary>
		/// Unique identifier of this object in the the Database.
		/// </summary>
		/// <remarks>
		/// If not set (== <see langword="default"/>), this is automatically generated
		/// upon insertion into the Database.
		/// </remarks>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public TId Id { get; set; }
	}
}
