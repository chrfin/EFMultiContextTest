using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFMultiContext.Common;
using EFMultiContext.Common.Models;
using EFMultiContext.Plugin.Models;

namespace EFMultiContext.Plugin
{
	public class PluginDbContext : DbContextBase
	{
		public DbSet<User> Users { get; set; }
		public DbSet<PluginItem> Items { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Types<User>().Configure(c => c.Ignore(u => u.Age));
		}
	}
}