using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace AnyDexDB {
	/// <summary>
	/// Factory for <see cref="DbContext"/>s of type <see cref="AnyDexDb"/>.
	/// </summary>
	public class AnyDexDbFactory : IDbContextFactory<AnyDexDb> {
		private readonly DbContextOptions<AnyDexDb> contextCreationOptions;

		public AnyDexDbFactory() {
			contextCreationOptions = new() {
				// Eventual extensions go here
			};
		}
		public AnyDexDbFactory(DbContextOptions<AnyDexDb> options) {
			contextCreationOptions = options;
		}

		public AnyDexDb CreateDbContext() {
			return new AnyDexDb(contextCreationOptions);
		}
	}
}
