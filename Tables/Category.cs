namespace AnyDexDB.Tables
{
    public partial class Category
    {
        public Category()
        {
            CategoryRatings = new HashSet<CategoryRating>();
        }

        public ulong Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<CategoryRating> CategoryRatings { get; set; }
    }
}
