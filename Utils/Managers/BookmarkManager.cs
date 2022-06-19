namespace AnyDexDB.Utils.Managers {
	public class BookmarkManager : EntityManager<Bookmark, int>{
		public Bookmark? Find(int userId, int resourceId) {
			return DbContext
				.Bookmarks
				.FirstOrDefault(x => x.UserId == userId && x.ResourceId == resourceId);
		}

		public bool TryFind(int userId, int resourceId, [NotNullWhen(true)] out Bookmark? bookmark) {
			bookmark = Find(userId, resourceId);
			return bookmark is not null;
		}

		public bool TryRemove(int userId, int resourceId) {
			Bookmark? bookmark = Find(userId, resourceId);
			if(bookmark is null) {
				return false;
			}
			DbContext.Remove(bookmark);
			return true;
		}

		public bool TryAdd(int userId, int resourceId) {
			Bookmark bookmark = new() {
				UserId = userId,
				ResourceId = resourceId,
				Date = DateTime.UtcNow,
			};

			return TryAdd(bookmark);
		}
	}
}
