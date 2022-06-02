using NL.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyDexDB.Testing {
	internal class MaterialGenerator : BaseGenerator<Material> {
		private int amount;

		public MaterialGenerator(int number) {
			amount = number;
		}

		internal override void GenerateData(AnyDexDb db) {
			foreach(Resource resource in db.Resources) {
				if(!resource.Materials.Any()) {
					for(int i = 0; i < amount; i++) {
						db.Add(GenerateMaterial(resource.Id));
					}
				}
			}

			db.SaveChanges();
		}

		private Material GenerateMaterial(ulong resourceId) {
			return new() {
				Title = NLRandom.RandomLetterOrNumbers(10),
				Description = NLRandom.RandomLetterOrNumbers(64),
				Length = (uint)Random.Shared.Next(1, 250),
				Type = (MaterialType)Random.Shared.Next(Enum.GetValues<MaterialType>().Length),
				ResourceId = resourceId
			};
		}
	}
}
