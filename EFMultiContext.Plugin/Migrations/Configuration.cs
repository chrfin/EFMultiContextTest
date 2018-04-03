using EFMultiContext.Plugin.Models;

namespace EFMultiContext.Plugin.Migrations
{
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;

	public sealed class Configuration : DbMigrationsConfiguration<EFMultiContext.Plugin.PluginDbContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = false;
		}

		protected override void Seed(EFMultiContext.Plugin.PluginDbContext context)
		{
			//  This method will be called after migrating to the latest version.

			if (!context.Items.Any())
			{
				var author = context.Users.FirstOrDefault();
				context.Items.Add(new PluginItem() { Name = "Item 1", Author = author });
			}
		}
	}
}