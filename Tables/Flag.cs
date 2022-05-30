using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyDexDB.Tables {
	[Flags]
	public enum Flag {
		None = 0,
		NSFW = 1,
		SensitiveContent = 2,
		Fraudolent = 4,
		Spam = 8,
		Duplicate = 16,
		Misinformation = 32
	}

	public static class FlagExtensions {
		private static readonly Flag[] _flags = Enum.GetValues<Flag>();

		public static IEnumerable<string> ToText(this Flag flag) {
			for(int i = 0; i < _flags.Length; i++) {
				if(flag.HasFlag(_flags[i])) {
					yield return GetText(i);
				}
			}
		}

		// Using the index as parameter rather than the flag to avoid errors due to the flag value being composite.
		private static string GetText(int flagIndex) {
			if(flagIndex >= _flags.Length) {
				return "Unknown";
			}

			return _flags[flagIndex] switch {
				Flag.None => "None",
				Flag.NSFW => "NSFW",
				Flag.SensitiveContent => "Sensitive Content",
				Flag.Fraudolent => "Fraudolent",
				Flag.Spam => "Spam",
				Flag.Duplicate => "Duplicate",
				Flag.Misinformation => "Misinformation",
				_ => "Unknown"
			};
		}
	}
}
