namespace AnyDexDB.Tables {
	[Table("quiz_answer")]
    public partial class QuizAnswer {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id"), Display(Name = "ID", ResourceType = typeof(Localization))]
        public ulong Id { get; set; }
        public string? Answer { get; set; }
        public ulong IsRight { get; set; }
        public ulong QuizQuestionId { get; set; }

        [NotNull]
        public virtual QuizQuestion? QuizQuestion { get; set; }
    }
}
