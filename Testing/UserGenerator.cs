using System.Text;

namespace AnyDexDB.Testing {
	internal class UserGenerator : BaseGenerator<User> {
		private const string TEST_USERS_PASSWORD = "test";
		private const string USERNAME_CHARS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

		private readonly PasswordHasher<User> hasher = new();
		private readonly int testUsers, randomUsers;

		internal UserGenerator(int testUsersCount, int randomUsersCount) {
			testUsers = testUsersCount;
			randomUsers = randomUsersCount;
		}

		internal override void GenerateData(AnyDexDb db, bool forceRegenerate = false) {
			if(forceRegenerate) {
				db.Users.RemoveRange(db.Users);
			}
			db.AddRange(GenerateUsers(testUsers, randomUsers));
		}

		internal List<User> GenerateUsers(int testCount, int randomCount) {
			List<User> users = new(testCount + randomCount);

			for(int i = 0; i < testCount; i++) {
				users.Add(GenerateTestUser(i));
			}
			for(int i = 0; i < randomCount; i++) {
				users.Add(GenerateRandomUser());
			}

			return users;
		}

		private User GenerateTestUser(int number) {
			User user = new() {
				UserName = $"test{number + 1}",
				Email = $"test{number + 1}@test.com",
				NormalizedUserName = $"test{number + 1}@test.com",
				NormalizedEmail = $"test{number + 1}@test.com",
				SecurityStamp = Guid.NewGuid().ToString(),
				Bio = "GENERATED",
				EmailConfirmed = true,
				PhoneNumberConfirmed = true
			};
			user.PasswordHash = hasher.HashPassword(user, TEST_USERS_PASSWORD);

			return user;
		}

		private User GenerateRandomUser() {
			string username = GenerateRandomUsername(8);

			User user = new() {
				UserName = GenerateRandomUsername(8),
				Email = $"test-{username}@test.com",
				NormalizedUserName = $"test-{username}@test.com",
				NormalizedEmail = $"test-{username}@test.com",
				SecurityStamp = Guid.NewGuid().ToString(),
				Bio = "GENERATED",
				EmailConfirmed = true,
				PhoneNumberConfirmed = true
			};
			user.PasswordHash = hasher.HashPassword(user, TEST_USERS_PASSWORD);

			return user;
		}

		private static string GenerateRandomUsername(int length) {
			StringBuilder str = new();
			for(int i = 0; i < length; i++) {
				str.Append(USERNAME_CHARS[Random.Shared.Next(USERNAME_CHARS.Length - 1)]);
			}
			return str.ToString();
		}
	}
}
