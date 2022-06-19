namespace AnyDexDB.Utils.Managers {
	internal interface IEntityManager<TEntity, TId> where TEntity : class {

		/// <summary>
		/// Attempt to insert the <paramref name="entity"/> into the database.
		/// </summary>
		/// <param name="entity"> The entity to insert. </param>
		/// <returns> <see langword="true"/> if the <paramref name="entity"/> has been inserted in the
		/// database, <see langword="false"/> otherwise. </returns>
		public bool TryAdd(TEntity entity);
		/// <summary>
		/// Attempt to remove the <paramref name="entity"/> from the database.
		/// </summary>
		/// <param name="entity"> The entity to remove. </param>
		/// <returns> <see langword="true"/> if the <paramref name="entity"/> has been remoed from the
		/// database, <see langword="false"/> otherwise. </returns>
		public bool TryRemove(TEntity entity);
		/// <summary>
		/// Check whether the <paramref name="entity"/> is present in the database.
		/// </summary>
		/// <param name="entity"> The entity to find. </param>
		/// <returns> <see langword="true"/> if the <paramref name="entity"/> is present in the
		/// database, <see langword="false"/> otherwise. </returns>
		public bool Exists(TEntity entity);
		/// <summary>
		/// Check whether the <typeparamref name="TEntity"/> with identifier <paramref name="id"/> is present in the 
		/// database.
		/// </summary>
		/// <param name="id"> The unique identifier of the entity to find. </param>
		/// <returns> <see langword="true"/> if the <typeparamref name="TEntity"/> is present in the
		/// database, <see langword="false"/> otherwise. </returns>
		public bool Exists(TId id);
		/// <summary>
		/// Search for a <typeparamref name="TEntity"/> identified by the <paramref name="id"/> value in the database.
		/// </summary>
		/// <param name="id"> The unique identifier of the entity to find. </param>
		/// <returns> The <typeparamref name="TEntity"/> found in the database, or <see langword="null"/> if none
		/// was found. </returns>
		public TEntity? Find(TId id);
		/// <summary>
		/// Search for a <typeparamref name="TEntity"/> identified by the <paramref name="id"/> value in the database.
		/// </summary>
		/// <param name="id"> The unique identifier of the entity to find. </param>
		/// <param name="entity"> The <typeparamref name="TEntity"/> found in the database, or <see langword="null"/> 
		/// if none was found. </param>
		/// <returns> <see langword="true"/> if the <paramref name="entity"/> has been retreved from the
		/// database, <see langword="false"/> otherwise. </returns>
		public bool TryFind(TId id, [NotNullWhen(true)] out TEntity? entity);

		/// <summary>
		/// Stop tracking all local changes made with this <see cref="IEntityManager{TEntity, TId}"/>.
		/// </summary>
		public void DropChanges();
		/// <summary>
		/// Apply all local changes made with this <see cref="IEntityManager{TEntity, TId}"/> onto the database.
		/// </summary>
		public bool SaveChanges();

	}
}
