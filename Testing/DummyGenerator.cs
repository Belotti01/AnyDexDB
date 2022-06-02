namespace AnyDexDB.Testing {
	public static class DummyGenerator {

		public static void GenerateData(bool regenerateUsers = false) {
			using AnyDexDb db = new();

			if(regenerateUsers || !UserGenerator.HasData(db)) {
				UserGenerator users = new(10, 10, regenerateUsers);
				users.GenerateData(db);
			}

			if(!ResourceGenerator.HasData(db)) {
				ResourceGenerator resources = new(30);
				resources.GenerateData(db);
			}

			if(!MaterialGenerator.HasData(db)) {
				MaterialGenerator material = new(5);
				material.GenerateData(db);
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
