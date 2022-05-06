using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
		/// Localize the name of the specified <paramref name="type"/>.
		/// </summary>
		/// <param name="type"> The status to convert to text. </param>
		/// <returns> The localized name of the specified <paramref name="type"/>. </returns>
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

			return Localization.ResourceManager.GetString(unlocalizedName) ?? "";
		}
	}
}
