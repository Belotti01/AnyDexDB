namespace AnyDexDB.Utils.Managers {
	public class EntityManager<TEntity, TId> : IEntityManager<TEntity, TId>, IDisposable  where TEntity : class {
		protected AnyDexDb DbContext { get; private init; }



		public EntityManager(AnyDexDb dbContext) {
			DbContext = dbContext;
		}

		public EntityManager(AnyDexDbFactory dbContextFactory)
			: this(dbContextFactory.CreateDbContext()) { }

		public EntityManager() 
			:this(new AnyDexDbFactory()) { }



		public TEntity? Find(TId id)
			=> DbContext.Find<TEntity>(id);


		public bool TryFind(TId id, [NotNullWhen(true)] out TEntity? entity) {
			entity = Find(id);
			return entity is not null;
		}

		public bool SaveChanges() {
			int result = DbContext.SaveChanges();
			return result > 0;
		}

		public bool Exists(TId id) {
			var dbEntry = Find(id);
			return dbEntry is not null;
		}

		public bool Exists(TEntity entity) {
			var dbEntry = DbContext.Entry(entity);
			return dbEntry is not null;
		}

		public bool TryAdd(TEntity entity) {
			if(DbContext.Set<TEntity>().Contains(entity))
				return false;
				
			var dbEntry = DbContext.Add(entity);
			return dbEntry is not null;
		}

		public bool TryRemove(TEntity entity) {
			if(!DbContext.Set<TEntity>().Contains(entity))
				return false;
			
			var dbEntry = DbContext.Remove(entity);
			return dbEntry is not null;
		}
		public void DropChanges() {
			DbContext.ChangeTracker.Clear();
		}

		public void Dispose() {
			DbContext.Dispose();

			GC.SuppressFinalize(this);
		}
	}
}
