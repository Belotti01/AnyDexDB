#nullable disable
using Microsoft.EntityFrameworkCore;

// LEAVE THIS FILE AS-IS
// This file was generated through Db-Scaffolding (Database-to-code conversion), and should
// NOT be edited. Expand this class in AnyDexDbExtensions.cs instead.

namespace AnyDexDB {
	public partial class AnyDexDb : DbContext {

		#region DbSets
		public virtual DbSet<AccountAction> AccountActions { get; set; }
		public virtual DbSet<Bookmark> Bookmarks { get; set; }
		public virtual DbSet<Category> Categories { get; set; }
		public virtual DbSet<CategoryRating> CategoryRatings { get; set; }
		public virtual DbSet<LearningPath> LearningPaths { get; set; }
		public virtual DbSet<LearningStep> LearningSteps { get; set; }
		public virtual DbSet<Material> Materials { get; set; }
		public virtual DbSet<MaterialLink> MaterialLinks { get; set; }
		public virtual DbSet<Notification> Notifications { get; set; }
		public virtual DbSet<Progress> Progress { get; set; }
		public virtual DbSet<Quiz> Quizzes { get; set; }
		public virtual DbSet<QuizAnswer> QuizAnswers { get; set; }
		public virtual DbSet<QuizQuestion> QuizQuestions { get; set; }
		public virtual DbSet<QuizRating> QuizRatings { get; set; }
		public virtual DbSet<QuizResult> QuizResults { get; set; }
		public virtual DbSet<Rating> Ratings { get; set; }
		public virtual DbSet<Resource> Resources { get; set; }
		public virtual DbSet<ResourceQuiz> ResourceQuizzes { get; set; }
		public virtual DbSet<ResourceRelation> ResourceRelations { get; set; }
		public virtual DbSet<User> Users { get; set; }
		#endregion


		public AnyDexDb() {
		}

		public AnyDexDb(DbContextOptions<AnyDexDb> options)
			: base(options) {
		}



		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
			if(!optionsBuilder.IsConfigured) {
				optionsBuilder.UseMySql("user id=root;host=localhost;database=anydex;password=root", ServerVersion.Parse("8.0.27-mysql"));
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder) {
			modelBuilder.UseCollation("utf8_general_ci")
				.HasCharSet("utf8");

			modelBuilder.Entity<AccountAction>(entity => {
				entity.ToTable("accountaction");

				entity.HasIndex(e => e.UserId, "fk_AccountAction_User1_idx");

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Date)
					.HasColumnType("timestamp")
					.HasColumnName("date")
					.HasDefaultValueSql("CURRENT_TIMESTAMP");

				entity.Property(e => e.Ip)
					.HasMaxLength(45)
					.HasColumnName("ip");

				entity.Property(e => e.Location)
					.HasColumnType("text")
					.HasColumnName("location");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(255)
					.HasColumnName("name");

				entity.Property(e => e.UserId).HasColumnName("user_id");

				entity.HasOne(d => d.User)
					.WithMany(p => p.Accountactions)
					.HasForeignKey(d => d.UserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("fk_AccountAction_User1");
			});

			modelBuilder.Entity<Bookmark>(entity => {
				entity.ToTable("bookmark");

				entity.HasIndex(e => e.ResourceId, "fk_Bookmark_Resource1_idx");

				entity.HasIndex(e => e.UserId, "fk_Bookmark_User1_idx");

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Date)
					.HasColumnType("timestamp")
					.HasColumnName("date")
					.HasDefaultValueSql("CURRENT_TIMESTAMP");

				entity.Property(e => e.ResourceId).HasColumnName("resource_id");

				entity.Property(e => e.UserId).HasColumnName("user_id");

				entity.HasOne(d => d.Resource)
					.WithMany(p => p.Bookmarks)
					.HasForeignKey(d => d.ResourceId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("fk_Bookmark_Resource1");

				entity.HasOne(d => d.User)
					.WithMany(p => p.Bookmarks)
					.HasForeignKey(d => d.UserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("fk_Bookmark_User1");
			});

			modelBuilder.Entity<Category>(entity => {
				entity.ToTable("category");

				entity.HasIndex(e => e.Name, "name_UNIQUE")
					.IsUnique();

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Description)
					.HasMaxLength(255)
					.HasColumnName("description");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(64)
					.HasColumnName("name");
			});

			modelBuilder.Entity<CategoryRating>(entity => {
				entity.ToTable("categoryrating");

				entity.HasIndex(e => e.CategoryId, "fk_CategoryRating_Category1_idx");

				entity.HasIndex(e => e.ResourceId, "fk_CategoryRating_Resource1");

				entity.HasIndex(e => e.UserId, "fk_CategoryRating_User1_idx");

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.CategoryId).HasColumnName("category_id");

				entity.Property(e => e.Rating).HasColumnName("rating");

				entity.Property(e => e.ResourceId).HasColumnName("resource_id");

				entity.Property(e => e.UserId).HasColumnName("user_id");

				entity.HasOne(d => d.Category)
					.WithMany(p => p.CategoryRatings)
					.HasForeignKey(d => d.CategoryId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("fk_CategoryRating_Category1");

				entity.HasOne(d => d.Resource)
					.WithMany(p => p.Categoryratings)
					.HasForeignKey(d => d.ResourceId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("fk_CategoryRating_Resource1");

				entity.HasOne(d => d.User)
					.WithMany(p => p.Categoryratings)
					.HasForeignKey(d => d.UserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("fk_CategoryRating_User1");
			});

			modelBuilder.Entity<LearningPath>(entity => {
				entity.ToTable("learningpath");

				entity.HasIndex(e => e.UserId, "fk_LearningPath_User1_idx");

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Description)
					.HasColumnType("text")
					.HasColumnName("description");

				entity.Property(e => e.Title)
					.IsRequired()
					.HasMaxLength(255)
					.HasColumnName("title");

				entity.Property(e => e.UserId).HasColumnName("user_id");

				entity.HasOne(d => d.User)
					.WithMany(p => p.Learningpaths)
					.HasForeignKey(d => d.UserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("fk_LearningPath_User1");
			});

			modelBuilder.Entity<LearningStep>(entity => {
				entity.ToTable("learningstep");

				entity.HasIndex(e => e.LearningPathId, "fk_LearningStep_LearningPath1_idx");

				entity.HasIndex(e => e.ResourceId, "fk_LearningStep_Resource1_idx");

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Description)
					.HasColumnType("text")
					.HasColumnName("description");

				entity.Property(e => e.LearningPathId).HasColumnName("learning_path_id");

				entity.Property(e => e.ResourceId).HasColumnName("resource_id");

				entity.Property(e => e.Title)
					.IsRequired()
					.HasMaxLength(255)
					.HasColumnName("title");

				entity.HasOne(d => d.LearningPath)
					.WithMany(p => p.LearningSteps)
					.HasForeignKey(d => d.LearningPathId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("fk_LearningStep_LearningPath1");

				entity.HasOne(d => d.Resource)
					.WithMany(p => p.Learningsteps)
					.HasForeignKey(d => d.ResourceId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("fk_LearningStep_Resource1");
			});

			modelBuilder.Entity<Material>(entity => {
				entity.ToTable("material");

				entity.HasIndex(e => e.ResourceId, "fk_Material_Resource1_idx");

				entity.Property(e => e.Id)
					.ValueGeneratedNever()
					.HasColumnName("id");

				entity.Property(e => e.Description)
					.HasColumnType("text")
					.HasColumnName("description");

				entity.Property(e => e.Length).HasColumnName("length");

				entity.Property(e => e.Publisher)
					.HasColumnType("text")
					.HasColumnName("publisher");

				entity.Property(e => e.ResourceId).HasColumnName("resource_id");

				entity.Property(e => e.Title)
					.IsRequired()
					.HasColumnType("text")
					.HasColumnName("title");

				entity.Property(e => e.Type).HasColumnName("type");

				entity.HasOne(d => d.Resource)
					.WithMany(p => p.Materials)
					.HasForeignKey(d => d.ResourceId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("fk_Material_Resource1");
			});

			modelBuilder.Entity<MaterialLink>(entity => {
				entity.ToTable("materiallink");

				entity.HasIndex(e => e.MaterialId, "fk_MaterialLink_Material1_idx");

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Description)
					.HasColumnType("text")
					.HasColumnName("description");

				entity.Property(e => e.Link)
					.IsRequired()
					.HasColumnType("text")
					.HasColumnName("link");

				entity.Property(e => e.MaterialId).HasColumnName("material_id");

				entity.Property(e => e.ReleaseDate)
					.HasColumnType("datetime")
					.HasColumnName("release_date");

				entity.HasOne(d => d.Material)
					.WithMany(p => p.MaterialLinks)
					.HasForeignKey(d => d.MaterialId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("fk_MaterialLink_Material1");
			});

			modelBuilder.Entity<Notification>(entity => {
				entity.ToTable("notification");

				entity.HasIndex(e => e.UserId, "fk_Notification_user1_idx");

				entity.Property(e => e.Id)
					.ValueGeneratedNever()
					.HasColumnName("id");

				entity.Property(e => e.Date)
					.HasColumnType("timestamp")
					.HasColumnName("date")
					.HasDefaultValueSql("CURRENT_TIMESTAMP");

				entity.Property(e => e.Description)
					.IsRequired()
					.HasColumnType("text")
					.HasColumnName("description");

				entity.Property(e => e.Link)
					.HasMaxLength(255)
					.HasColumnName("link");

				entity.Property(e => e.Title)
					.IsRequired()
					.HasMaxLength(255)
					.HasColumnName("title");

				entity.Property(e => e.UserId).HasColumnName("user_id");

				entity.HasOne(d => d.User)
					.WithMany(p => p.Notifications)
					.HasForeignKey(d => d.UserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("fk_Notification_user1");
			});

			modelBuilder.Entity<Progress>(entity => {
				entity.ToTable("progress");

				entity.HasIndex(e => e.ResourceId, "fk_Progress_Resource1_idx");

				entity.HasIndex(e => e.UserId, "fk_Progress_User1_idx");

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.EndDate)
					.HasColumnType("datetime")
					.HasColumnName("end_date");

				entity.Property(e => e.IsPrivate)
					.HasColumnType("bit(1)")
					.HasColumnName("is_private")
					.HasDefaultValueSql("b'0'");

				entity.Property(e => e.ResourceId).HasColumnName("resource_id");

				entity.Property(e => e.StartDate)
					.HasColumnType("datetime")
					.HasColumnName("start_date")
					.HasDefaultValueSql("CURRENT_TIMESTAMP");

				entity.Property(e => e.Status).HasColumnName("status");

				entity.Property(e => e.UserId).HasColumnName("user_id");

				entity.Property(e => e.Value).HasColumnName("value");

				entity.HasOne(d => d.Resource)
					.WithMany(p => p.Progresses)
					.HasForeignKey(d => d.ResourceId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("fk_Progress_Resource1");

				entity.HasOne(d => d.User)
					.WithMany(p => p.Progresses)
					.HasForeignKey(d => d.UserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("fk_Progress_User1");
			});

			modelBuilder.Entity<Quiz>(entity => {
				entity.ToTable("quiz");

				entity.HasIndex(e => e.CreatorId, "fk_Quiz_User1_idx");

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.CreatorId).HasColumnName("creator_id");

				entity.Property(e => e.Description)
					.HasColumnType("text")
					.HasColumnName("description");

				entity.Property(e => e.IsPublic)
					.HasColumnType("bit(1)")
					.HasColumnName("is_public")
					.HasDefaultValueSql("b'1'");

				entity.Property(e => e.ReleaseDate)
					.HasColumnType("timestamp")
					.HasColumnName("release_date")
					.HasDefaultValueSql("CURRENT_TIMESTAMP");

				entity.Property(e => e.Title)
					.IsRequired()
					.HasMaxLength(255)
					.HasColumnName("title");

				entity.HasOne(d => d.Creator)
					.WithMany(p => p.Quizzes)
					.HasForeignKey(d => d.CreatorId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("fk_Quiz_User1");
			});

			modelBuilder.Entity<QuizAnswer>(entity => {
				entity.ToTable("quizanswer");

				entity.HasIndex(e => e.QuizQuestionId, "fk_QuizAnswer_QuizQuestion1_idx");

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Answer)
					.IsRequired()
					.HasColumnType("text")
					.HasColumnName("answer");

				entity.Property(e => e.IsCorrect)
					.HasColumnType("bit(1)")
					.HasColumnName("is_right");

				entity.Property(e => e.QuizQuestionId).HasColumnName("quiz_question_id");

				entity.HasOne(d => d.QuizQuestion)
					.WithMany(p => p.QuizAnswers)
					.HasForeignKey(d => d.QuizQuestionId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("fk_QuizAnswer_QuizQuestion1");
			});

			modelBuilder.Entity<QuizQuestion>(entity => {
				entity.ToTable("quizquestion");

				entity.HasIndex(e => e.QuizId, "fk_QuizQuestion_Quiz1_idx");

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Hint)
					.HasColumnType("text")
					.HasColumnName("hint");

				entity.Property(e => e.IsDisabled)
					.HasColumnType("bit(1)")
					.HasColumnName("is_disabled")
					.HasDefaultValueSql("b'0'");

				entity.Property(e => e.Question)
					.IsRequired()
					.HasColumnType("text")
					.HasColumnName("question");

				entity.Property(e => e.QuizId).HasColumnName("quiz_id");

				entity.HasOne(d => d.Quiz)
					.WithMany(p => p.QuizQuestions)
					.HasForeignKey(d => d.QuizId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("fk_QuizQuestion_Quiz1");
			});

			modelBuilder.Entity<QuizRating>(entity => {
				entity.ToTable("quizrating");

				entity.HasIndex(e => e.QuizId, "fk_Rating_copy1_Quiz1_idx");

				entity.HasIndex(e => e.UserId, "fk_rating_user1_idx");

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.QuizId).HasColumnName("quiz_id");

				entity.Property(e => e.Rating).HasColumnName("rating");

				entity.Property(e => e.UserId).HasColumnName("user_id");

				entity.HasOne(d => d.Quiz)
					.WithMany(p => p.QuizRatings)
					.HasForeignKey(d => d.QuizId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("fk_Rating_copy1_Quiz1");

				entity.HasOne(d => d.User)
					.WithMany(p => p.Quizratings)
					.HasForeignKey(d => d.UserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("fk_rating_user10");
			});

			modelBuilder.Entity<QuizResult>(entity => {
				entity.ToTable("quizresult");

				entity.HasIndex(e => e.QuizId, "fk_QuizResult_Quiz1_idx");

				entity.HasIndex(e => e.UserId, "fk_QuizResult_User1_idx");

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Date)
					.HasColumnType("timestamp")
					.HasColumnName("date")
					.HasDefaultValueSql("CURRENT_TIMESTAMP");

				entity.Property(e => e.QuizId).HasColumnName("quiz_id");

				entity.Property(e => e.Score).HasColumnName("score");

				entity.Property(e => e.UserId).HasColumnName("user_id");

				entity.HasOne(d => d.Quiz)
					.WithMany(p => p.QuizResults)
					.HasForeignKey(d => d.QuizId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("fk_QuizResult_Quiz1");

				entity.HasOne(d => d.User)
					.WithMany(p => p.Quizresults)
					.HasForeignKey(d => d.UserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("fk_QuizResult_User1");
			});

			modelBuilder.Entity<Rating>(entity => {
				entity.ToTable("rating");

				entity.HasIndex(e => e.ResourceId, "fk_rating_resource1_idx");

				entity.HasIndex(e => e.UserId, "fk_rating_user1_idx");

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Score).HasColumnName("rating");

				entity.Property(e => e.ResourceId).HasColumnName("resource_id");

				entity.Property(e => e.UserId).HasColumnName("user_id");

				entity.HasOne(d => d.Resource)
					.WithMany(p => p.Ratings)
					.HasForeignKey(d => d.ResourceId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("fk_rating_resource1");

				entity.HasOne(d => d.User)
					.WithMany(p => p.Ratings)
					.HasForeignKey(d => d.UserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("fk_rating_user1");
			});

			modelBuilder.Entity<Resource>(entity => {
				entity.ToTable("resource");

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Creator)
					.HasColumnType("text")
					.HasColumnName("creator");

				entity.Property(e => e.Description)
					.HasColumnType("text")
					.HasColumnName("description");

				entity.Property(e => e.ReleaseDate)
					.HasColumnType("datetime")
					.HasColumnName("release_date");

				entity.Property(e => e.Title)
					.IsRequired()
					.HasColumnType("text")
					.HasColumnName("title");
			});

			modelBuilder.Entity<ResourceQuiz>(entity => {
				entity.ToTable("resourcequiz");

				entity.HasIndex(e => e.QuizId, "fk_ResourceQuiz_Quiz1_idx");

				entity.HasIndex(e => e.ResourceId, "fk_ResourceQuiz_Resource1_idx");

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.QuizId).HasColumnName("quiz_id");

				entity.Property(e => e.ResourceId).HasColumnName("resource_id");

				entity.HasOne(d => d.Quiz)
					.WithMany(p => p.ResourceQuizzes)
					.HasForeignKey(d => d.QuizId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("fk_ResourceQuiz_Quiz1");

				entity.HasOne(d => d.Resource)
					.WithMany(p => p.Resourcequizzes)
					.HasForeignKey(d => d.ResourceId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("fk_ResourceQuiz_Resource1");
			});

			modelBuilder.Entity<ResourceRelation>(entity => {
				entity.ToTable("resourcerelation");

				entity.HasIndex(e => e.ResourceId, "fk_ResourceRelation_Resource1_idx");

				entity.HasIndex(e => e.RelatedResourceId, "fk_ResourceRelation_Resource2_idx");

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.RelatedResourceId).HasColumnName("related_resource_id");

				entity.Property(e => e.ResourceId).HasColumnName("resource_id");

				entity.Property(e => e.Type).HasColumnName("type");

				entity.HasOne(d => d.RelatedResource)
					.WithMany(p => p.RelatedResources)
					.HasForeignKey(d => d.RelatedResourceId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("fk_ResourceRelation_Resource2");

				entity.HasOne(d => d.Resource)
					.WithMany(p => p.RelationResources)
					.HasForeignKey(d => d.ResourceId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("fk_ResourceRelation_Resource1");
			});

			modelBuilder.Entity<User>(entity => {
				entity.ToTable("user");

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Bio)
					.HasColumnType("text")
					.HasColumnName("bio");

				entity.Property(e => e.Email)
					.HasColumnType("text")
					.HasColumnName("email");

				entity.Property(e => e.FullName)
					.HasMaxLength(255)
					.HasColumnName("full_name");

				entity.Property(e => e.PasswordHash)
					.IsRequired()
					.HasMaxLength(128)
					.HasColumnName("password_hash");

				entity.Property(e => e.Tag).HasColumnName("tag");

				entity.Property(e => e.Username)
					.IsRequired()
					.HasMaxLength(32)
					.HasColumnName("username");
			});

			OnModelCreatingPartial(modelBuilder);
		}

		partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
	}
}
