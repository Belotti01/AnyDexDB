using AnyDexDB.Testing;

namespace AnyDexDB {
	internal static class Program {
		internal static void Main(string[] args) {
			DummyGenerator.GenerateData(false);
			LogData();
		}

		private static void LogData() {
			using AnyDexDb db = new();
			Console.ForegroundColor = ConsoleColor.Green;

			Console.WriteLine($"Users: {db.Users.Count()}");

			Console.ResetColor();
		}
	}
}
