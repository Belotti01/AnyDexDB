namespace AnyDexDB.Tables {
	public partial class Material {
		public Material() {
			MaterialLinks = new HashSet<MaterialLink>();
		}

		public ulong Id { get; set; }
		public ulong ResourceId { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public int Length { get; set; }
		public byte Type { get; set; }
		public string Publisher { get; set; }

		public virtual Resource Resource { get; set; }
		public virtual ICollection<MaterialLink> MaterialLinks { get; set; }
	}
}
