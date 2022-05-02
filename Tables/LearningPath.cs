﻿namespace AnyDexDB.Tables {
	public partial class LearningPath {
		public LearningPath() {
			Learningsteps = new HashSet<LearningStep>();
		}

		public ulong Id { get; set; }
		public ulong UserId { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }

		public virtual User User { get; set; }
		public virtual ICollection<LearningStep> Learningsteps { get; set; }
	}
}
