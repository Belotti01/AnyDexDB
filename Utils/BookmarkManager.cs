using System;
using System.Threading.Tasks;

namespace AnyDexDB.Utils {
	public class BookmarkManager {
		protected AnyDexDb _dbContext;

		public BookmarkManager(AnyDexDb db) {
			_dbContext = db;
		}

		public BookmarkManager() {
			_dbContext = new AnyDexDbFactory().CreateDbContext();
		}

		public Bookmark? Find(ulong userId, ulong resourceId) {
			return _dbContext
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
			_dbContext.Remove(bookmark);
			return true;
		}

		public async Task<bool> TryAddAsync(ulong userId, ulong resourceId) {
			Bookmark? bookmark = Find(userId, resourceId);
			if(bookmark is not null) {
				return false;
			}

			bookmark = new() {
				UserId = userId,
				ResourceId = resourceId,
				Date = DateTime.UtcNow,
			};
			await _dbContext.AddAsync(bookmark);

			return true;
		}

		public bool TryAdd(ulong userId, ulong resourceId) {
			Bookmark? bookmark = Find(userId, resourceId);
			if(bookmark is not null) {
				return false;
			}

			bookmark = new() {
				UserId = userId,
				ResourceId = resourceId,
				Date = DateTime.UtcNow,
			};
			_dbContext.Add(bookmark);

			return true;
		}

		public bool SaveChanges() {
			return _dbContext.SaveChanges() > 0;
		}
	}
}
