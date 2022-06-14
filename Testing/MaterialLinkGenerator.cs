using AnyDexDB.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyDexDB.Testing {
	internal class MaterialLinkGenerator : BaseGenerator<MaterialLink> {
		private readonly int amount;

		public MaterialLinkGenerator(int number) {
			amount = number;
		}

		internal override void GenerateData(AnyDexDb db, bool forceRegenerate = false) {
			if(forceRegenerate) {
				db.Materials.RemoveRange(db.Materials);
            }

			foreach(Material material in db.Materials) {
				if(!material.MaterialLinks.Any()) {
					for(int i = 0; i < amount; i++) {
						db.Add(GenerateMaterialLink(material.Id));
					}
				}
			}

			db.SaveChanges();
		}

		private MaterialLink GenerateMaterialLink(ulong materialId) {
			return new() {
				Description = Randomizer.LoremIpsium(5, 30),
				MaterialId = materialId,
				Link = "www.google.com",
				ReleaseDate = Randomizer.RandomDay()
			};
		}
	}
}
