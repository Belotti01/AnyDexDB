namespace AnyDexDB.Testing {
	public static class DummyGenerator {
		// List of generators to invoke
		private static List<BaseGenerator> Generators { get; } = new() {
			new UserGenerator(5, 5, true)
		};

		public static void GenerateData() {
			using AnyDexDb db = new();

			foreach(var generator in Generators) {
				generator.GenerateData(db);
			}

			db.SaveChanges();
		}
	}
}
