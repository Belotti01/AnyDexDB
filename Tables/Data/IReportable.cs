using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyDexDB.Tables.Data {
	public interface IReportable<TSelf, TReport> 
		where TSelf : IIdentifiable<int> 
		where TReport : ReportBase<TSelf> {
		
		// Gets overridden internally by EF Core
		public virtual ICollection<TReport> Reports { 
			get => throw new NotImplementedException(); 
			set => throw new NotImplementedException(); 
		}
	}
}
