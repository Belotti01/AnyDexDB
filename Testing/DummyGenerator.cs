namespace AnyDexDB.Testing {
	public static class DummyGenerator {

		public static void GenerateData(bool regenerateUsers = false, bool regenerateOthers = false) {
			using AnyDexDb db = new();

			if(regenerateUsers || !UserGenerator.HasData(db)) {
				UserGenerator users = new(10, 10);
				users.GenerateData(db, regenerateUsers);
			}

			if(regenerateOthers || !ResourceGenerator.HasData(db)) {
				ResourceGenerator resources = new(30);
				resources.GenerateData(db, regenerateOthers);
			}

			if(regenerateOthers || !MaterialGenerator.HasData(db)) {
				MaterialGenerator material = new(5);
				material.GenerateData(db, regenerateOthers);
			}

			db.SaveChanges();
		}

		public static void LogData() {
			using AnyDexDb db = new();
			Console.ForegroundColor = ConsoleColor.Green;

			Console.WriteLine($"Users: {db.Users.Count()}");
			Console.WriteLine($"Resources: {db.Resources.Count()}");
			Console.WriteLine($"Materials: {db.Materials.Count()}");

			Console.ResetColor();
		}
	}
}
