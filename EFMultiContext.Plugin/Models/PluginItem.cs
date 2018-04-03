using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFMultiContext.Common.Models;

namespace EFMultiContext.Plugin.Models
{
	public class PluginItem
	{
		[Key]
		public int Id { get; set; }

		public string Name { get; set; }

		public User Author { get; set; }
	}
}