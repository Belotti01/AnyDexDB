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

		public static Color GetColor(this MaterialType type) {
			return type switch {
				MaterialType.Book => Color.SandyBrown,
				MaterialType.Ebook => Color.Orange,
				MaterialType.Course => Color.IndianRed,
				MaterialType.Video => Color.Azure,
				MaterialType.Article => Color.Yellow,
				MaterialType.Other => Color.Green,
				_ => Color.Gray
			};
		}
	}
}
