using Color = System.Drawing.Color;

namespace AnyDexDB.Tables {
	public enum MaterialType {
		Book,
		Ebook,
		Course,
		Video,
		Article,
		Other
	}

	public static class MaterialTypeExtensions {
		/// <summary>
		/// Get the name of the specified <paramref name="type"/>.
		/// </summary>
		/// <param name="type"> The status to convert to text. </param>
		/// <returns> The english name of the specified <paramref name="type"/>. </returns>
		public static string ToText(this MaterialType type) {
			// Using a switch is much faster than using Enum.ToString()
			string unlocalizedName = type switch {
				MaterialType.Book => "Book",
				MaterialType.Ebook => "E-Book",
				MaterialType.Video => "Video",
				MaterialType.Article => "Article",
				MaterialType.Course => "Course",
				_ => "Other"
			};

			return unlocalizedName;
		}

		public static string GetHexColor(this MaterialType type) {
			return type switch {
				MaterialType.Book => "#EDAF19",
				MaterialType.Ebook => "#F46302",
				MaterialType.Course => "#F46302",
				MaterialType.Video => "#00d659",
				MaterialType.Article => "#0F569A",
				MaterialType.Other => "#444444",
				_ => "#000000"
			};
		}
	}
}
