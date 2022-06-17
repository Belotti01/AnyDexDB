
namespace AnyDexDB.Utils {
	public static class Languages {
		private static readonly Dictionary<string, Language> _languages;
		public static readonly Language[] All = new Language[] { English, Italian, French };
		static Languages() {
			_languages = All
				.ToDictionary(x => x.Code);
		}

		public static Language FromCode(string code) {
			return _languages.ContainsKey(code) 
				? _languages[code] 
				: default;
		}

		public static readonly Language English	= new("en", "English");
		public static readonly Language Italian = new("it", "Italian");
		public static readonly Language French = new("fr", "French");
	}

	public readonly struct Language {
		/// <summary>
		/// The in-code rapresentation of the language.
		/// </summary>
		public string Code { get; }
		/// <summary>
		/// The displayable text rapresentation of the language.
		/// </summary>
		public string Text { get; }
		public Language(string code, string text) 
			=> (Code, Text) = (code, text);
	}
}
