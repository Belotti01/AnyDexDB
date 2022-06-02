using NL.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyDexDB.Testing {
	internal class ResourceGenerator : BaseGenerator<Resource> {
		private readonly int amount;

		public ResourceGenerator(int number) {
			amount = number;
		}

		internal override void GenerateData(AnyDexDb db) {
			for(int i = 0; i < amount; i++) {
				db.Add(GenerateResource());
			}

			db.SaveChanges();
		}

		private Resource GenerateResource() {
			return new() {
				Title = NLRandom.RandomLetterOrNumbers(10),
				Description = NLRandom.RandomLetterOrNumbers(64),
			};
		}
	}
}
