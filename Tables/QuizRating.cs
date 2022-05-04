namespace AnyDexDB.Tables {
	[Table("quiz_rating")]
    public partial class QuizRating {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id"), Display(Name = "ID", ResourceType = typeof(Localization))]
        public ulong Id { get; set; }
        public ulong UserId { get; set; }
        public ulong QuizId { get; set; }
        public byte Rating { get; set; }

        [NotNull]
        public virtual Quiz? Quiz { get; set; }
        [NotNull]
        public virtual User? User { get; set; }
    }
}
