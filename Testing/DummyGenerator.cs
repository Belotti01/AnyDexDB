namespace AnyDexDB.Testing {
	public static class DummyGenerator {
		// List of generators to invoke
		private static List<BaseGenerator> Generators { get; } = new() {
			new UserGenerator(5, 5, true),
			new ResourceGenerator(3)
		};

		public static void GenerateData(bool regenerateUsers = true) {
			using AnyDexDb db = new();

			foreach(var generator in Generators) {
				if(regenerateUsers || generator is not UserGenerator)
					generator.GenerateData(db);
			}

			db.SaveChanges();
		}
	}
}
