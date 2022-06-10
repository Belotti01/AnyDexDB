using AnyDexDB.Utils;

namespace AnyDexDB.Testing {
	internal class ResourceGenerator : BaseGenerator<Resource> {
		private readonly int amount;

		public ResourceGenerator(int number) {
			amount = number;
		}

		internal override void GenerateData(AnyDexDb db, bool forceRegenerate = false) {
			if(forceRegenerate) {
				db.Resources.RemoveRange(db.Resources);
			}

			for(int i = 0; i < amount; i++) {
				db.Add(GenerateResource());
			}

			db.SaveChanges();
		}

		private static Resource GenerateResource() {
			return new() {
				Title = Randomizer.RandomLetterOrNumbers(10),
				Description = Randomizer.RandomLetterOrNumbers(64),
				Creator = Randomizer.RandomLetterOrNumbers(32),
				Summary = Randomizer.RandomLetters(128),
				ReleaseDate = Randomizer.RandomDay()
			};
		}
	}
}
