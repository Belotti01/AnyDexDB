using System.Text;

namespace AnyDexDB.Utils {
	public static class Randomizer {
		public static string LoremIpsium(int minLength, int maxLength) {
			int length = Random.Shared.Next(minLength, maxLength + 1);
			int maxStartIndex = Constants.LoremIpsium.Length - length - 1;
			int startIndex = Random.Shared.Next(0, maxStartIndex);

			return Constants.LoremIpsium[startIndex..(startIndex + length)];
		}

		public static char RandomLetter(bool randomCase = true) {
			char c = (char)Random.Shared.Next('A', 'Z' + 1);
			if(randomCase && Random.Shared.Next(2) == 1) {
				return char.ToLower(c);
			}
			return c;
		}

		public static DateTime RandomDay()
			=> RandomDay(new DateTime(1950, 1, 1), DateTime.Today);

		public static DateTime RandomDay(DateTime min, DateTime max) {
			int range = (max - min).Days;
			return min.AddDays(Random.Shared.Next(range));
		}

		public static string RandomLetters(int amount, bool randomCase = true) {
			StringBuilder sb = new(amount);
			for(int i = 0; i < amount; i++) {
				sb.Append(RandomLetter(randomCase));
			}

			return sb.ToString();
		}

		public static char RandomLetterOrNumber(bool randomCase) {
			char c = (char)Random.Shared.Next('A', 'Z' + 11);

			if(c > 'Z') {
				return (c - 'Z').ToString()[0];
			}
			
			if(randomCase && Random.Shared.Next(2) == 1) {
				return char.ToLower(c);
			}

			return c;
		}

		public static string RandomLetterOrNumbers(int amount, bool randomCase = true) {
			StringBuilder sb = new(amount);
			for(int i = 0; i < amount; i++) {
				sb.Append(RandomLetterOrNumber(randomCase));
			}

			return sb.ToString();
		}
	}
}
