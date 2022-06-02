using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace AnyDexDB {
	public partial class AnyDexDb {
		public ILogger Logger { get; protected set; }

		/// <summary>
		/// Method called upon object creation.
		/// </summary>
		[MemberNotNull(nameof(Logger))]
		protected virtual void Initialize() {
			var loggerFactory = new LoggerFactory();
			Logger = loggerFactory.CreateLogger<AnyDexDb>();
			SavedChanges += OnChangesApplied;
		}


		#region Events & Logging

		private void OnChangesApplied(object? sender, SavedChangesEventArgs e) {
			int savedEntities = e.EntitiesSavedCount;
			Logger.Log(LogLevel.Information, "{result} changes have been applied to the Database.", savedEntities);
		}

		#endregion
	}
}
