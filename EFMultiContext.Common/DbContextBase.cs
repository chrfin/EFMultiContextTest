using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFMultiContext.Common
{
	public class DbContextBase : DbContext
	{
		public DbContextBase() : base(@"Data Source=.\SQLEXPRESS;Initial Catalog=EFMultiTest;Integrated Security=True") { }
	}
}