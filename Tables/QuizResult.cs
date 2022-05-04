namespace AnyDexDB.Tables {
	[Table("quiz_result")]
    public partial class QuizResult {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id"), Display(Name = "ID", ResourceType = typeof(Localization))]
        public ulong Id { get; set; }
        public ulong UserId { get; set; }
        public ulong QuizId { get; set; }
        public DateTime Date { get; set; }
        public byte Score { get; set; }

        [NotNull]
        public virtual Quiz? Quiz { get; set; }
        [NotNull]
        public virtual User? User { get; set; }
    }
}
