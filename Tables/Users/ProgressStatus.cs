namespace AnyDexDB.Tables {
	public enum ProgressStatus {
		None,
		OnGoing,
		Completed,
		OnHold,
		Dropped
	}

	public static class ProgressStatusExtensions {
		/// <summary>
		/// Localize the name of the specified <paramref name="status"/>.
		/// </summary>
		/// <param name="status"> The status to convert to text. </param>
		/// <returns> The localized name of the specified <paramref name="status"/>. </returns>
		public static string ToText(this ProgressStatus status) {
			// Using a switch is much faster than using Enum.ToString()
			string unlocalizedName = status switch {
				ProgressStatus.OnGoing => "Ongoing",
				ProgressStatus.Completed => "Completed",
				ProgressStatus.OnHold => "On Hold",
				ProgressStatus.Dropped => "Dropped",
				_ => "None"
			};

			return unlocalizedName;
			//return Localization.ResourceManager.GetString(unlocalizedName) ?? "";
		}
	}
}
