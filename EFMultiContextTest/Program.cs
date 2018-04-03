using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFMultiContext.Common;
using EFMultiContext.Plugin;

namespace EFMultiContextTest
{
	class Program
	{
		static void Main(string[] args)
		{
			Database.SetInitializer(new MigrateDatabaseToLatestVersion<CommonDbContext, EFMultiContext.Common.Migrations.Configuration>());
			Database.SetInitializer(new MigrateDatabaseToLatestVersion<PluginDbContext, EFMultiContext.Plugin.Migrations.Configuration>());

			using (var commonDb = new CommonDbContext())
			{
				Console.WriteLine($"Users: {commonDb.Users.Count()}");
				foreach (var user in commonDb.Users.ToList())
				{
					Console.WriteLine($"\t{user.Id}: {user.Name} | {user.Age}");
				}
			}

			using (var pluginDb = new PluginDbContext())
			{
				Console.WriteLine($"Items: {pluginDb.Items.Count()}");
				foreach (var item in pluginDb.Items.Include(i => i.Author).ToList())
				{
					Console.WriteLine($"\t{item.Id}: {item.Name} ({item.Author.Name} | {item.Author.Age})");
				}
			}

			Console.ReadLine();
		}
	}
}