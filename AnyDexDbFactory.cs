using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace AnyDexDB {
	public static class AnyDexDbFactory {
		private static readonly DbContextOptions<AnyDexDb> options;

		static AnyDexDbFactory() {
			options = new() {
				// Eventual extensions go here
			};
		}

		public static AnyDexDb Create() {
			return new AnyDexDb(options);
		}

		public static async Task<AnyDexDb> CreateAsync() {
			return await Task.Run(Create);
		}
	}
}
