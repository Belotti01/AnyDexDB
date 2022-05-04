namespace AnyDexDB.Tables
{
    public partial class Bookmark
    {
        public ulong Id { get; set; }
        public ulong UserId { get; set; }
        public ulong ResourceId { get; set; }
        public DateTime Date { get; set; }

        public virtual Resource Resource { get; set; }
        public virtual User User { get; set; }
    }
}
