namespace AnyDexDB.Testing {
	internal abstract class BaseGenerator<TEntity> where TEntity : class {
		internal abstract void GenerateData(AnyDexDb db, bool forceRegenerate = false);
		internal static bool HasData(AnyDexDb db) {
			return db.Set<TEntity>().Any();
		}
	}
}
