using AnyDexDB.Testing;

namespace AnyDexDB {
	internal static class Program {
		internal static void Main(string[] args) {
			DummyGenerator.GenerateData();
			DummyGenerator.LogData();
		}
	}
}
