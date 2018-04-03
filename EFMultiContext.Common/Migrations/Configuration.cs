using EFMultiContext.Common.Models;

namespace EFMultiContext.Common.Migrations
{
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;

	public sealed class Configuration : DbMigrationsConfiguration<CommonDbContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = false;
		}

		protected override void Seed(CommonDbContext context)
		{
			//  This method will be called after migrating to the latest version.
			if (!context.Users.Any())
				context.Users.AddOrUpdate(new User() { Name = "User 1", Age = 10 }, new User() { Name = "User 2", Age = 20 });
			foreach (var user in context.Users.Where(u => u.Age < 1).ToList())
			{
				user.Age = user.Id * 10;
			}
		}
	}
}