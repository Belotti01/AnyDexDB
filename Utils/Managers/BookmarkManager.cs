namespace AnyDexDB.Utils.Managers {
	public class BookmarkManager : EntityManager<Bookmark, ulong>{
		public Bookmark? Find(ulong userId, ulong resourceId) {
			return DbContext
				.Bookmarks
				.FirstOrDefault(x => x.UserId == userId && x.ResourceId == resourceId);
		}

		public bool TryFind(ulong userId, ulong resourceId, [NotNullWhen(true)] out Bookmark? bookmark) {
			bookmark = Find(userId, resourceId);
			return bookmark is not null;
		}

		public bool TryRemove(ulong userId, ulong resourceId) {
			Bookmark? bookmark = Find(userId, resourceId);
			if(bookmark is null) {
				return false;
			}
			DbContext.Remove(bookmark);
			return true;
		}

		public bool TryAdd(ulong userId, ulong resourceId) {
			Bookmark bookmark = new() {
				UserId = userId,
				ResourceId = resourceId,
				Date = DateTime.UtcNow,
			};

			return TryAdd(bookmark);
		}
	}
}
