using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyDexDB.Testing {
	internal abstract class BaseGenerator {
		internal abstract void GenerateData(AnyDexDb db);
	}
}
