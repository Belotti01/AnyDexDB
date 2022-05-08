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
		public virtual DbSet<Role> Roles { get; set; }
		public virtual DbSet<UserRole> UserRoles { get; set; }
		public virtual DbSet<UserClaim> UserClaims { get; set; }
		public virtual DbSet<UserLogin> UserLogins { get; set; }
		public virtual DbSet<RoleClaim> RoleClaims { get; set; }
		public virtual DbSet<UserToken> UserToken { get; set; }
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
			modelBuilder.Entity<Resource>()
				.HasMany(x => x.RelatedResources)
				.WithOne(x => x.RelatedResource)
				.HasForeignKey(x => x.RelatedResourceId);

			modelBuilder.Entity<Resource>()
				.HasMany(x => x.RelatingResources)
				.WithOne(x => x.Resource)
				.HasForeignKey(x => x.ResourceId);
		}
	}
}
