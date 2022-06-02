using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyDexDB.Testing {
	internal abstract class BaseGenerator<TEntity> where TEntity : class {
		internal abstract void GenerateData(AnyDexDb db);
		internal static bool HasData(AnyDexDb db) {
			return db.Set<TEntity>().Any();
		}
	}
}
