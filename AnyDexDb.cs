#nullable disable
using Microsoft.EntityFrameworkCore;

// LEAVE THIS FILE AS-IS
// This file was generated through Db-Scaffolding (Database-to-code conversion), and should
// NOT be edited (unless to edit the DB generation method or the DbSets).
// Expand this class in AnyDexDbExtensions.cs instead.

namespace AnyDexDB {
	public partial class AnyDexDb : IdentityDbContext<User, Role, ulong, UserClaim, UserRole, UserLogin, RoleClaim, UserToken> {

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
		public virtual DbSet<ResourceRating> ResourceRatings { get; set; }
		public virtual DbSet<MaterialRating> MaterialRatings { get; set; }
		public virtual DbSet<Resource> Resources { get; set; }
		public virtual DbSet<ResourceQuiz> ResourceQuizzes { get; set; }
		public virtual DbSet<ResourceRelation> ResourceRelations { get; set; }
		public virtual DbSet<ResourceComment> ResourceComments { get; set; }
		public virtual DbSet<MaterialComment> MaterialComments { get; set; }
		public virtual DbSet<QuizComment> QuizComments { get; set; }
		#endregion


		public AnyDexDb() 
			:base() {
			Initialize();
		}

		public AnyDexDb(DbContextOptions<AnyDexDb> options)
			: base(options) {
			Initialize();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
			if(!optionsBuilder.IsConfigured) {
				optionsBuilder.UseNpgsql("user id=postgres;host=localhost;port=5432;database=anydex;password=root");
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder) {
			base.OnModelCreating(modelBuilder);

			// Map the self-referencing many-to-many "Resource" table relationship
			modelBuilder.Entity<Resource>()
				.HasMany(x => x.RelatedResources)
				.WithOne(x => x.RelatedResource)
				.HasForeignKey(x => x.RelatedResourceId);

			modelBuilder.Entity<Resource>()
				.HasMany(x => x.RelatingResources)
				.WithOne(x => x.Resource)
				.HasForeignKey(x => x.ResourceId);

			// Set the name for ASP.NET Identity tables (setting the TableAttribute does not work)
			modelBuilder.Entity<User>().ToTable("user");
			modelBuilder.Entity<Role>().ToTable("role");
			modelBuilder.Entity<UserRole>().ToTable("user_role");
			modelBuilder.Entity<UserClaim>().ToTable("user_claim");
			modelBuilder.Entity<RoleClaim>().ToTable("role_claim");
			modelBuilder.Entity<UserLogin>().ToTable("user_login");
			modelBuilder.Entity<UserToken>().ToTable("user_token");
			modelBuilder.Entity<UserLogin>().ToTable("user_login");
		}
	}
}
