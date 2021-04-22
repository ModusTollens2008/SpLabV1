using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models
{
	class UserContext : DbContext
	{
		public UserContext()
			: base("DbConnection4")
		{ }

		public DbSet<BinaryNode> BinNodes { get; set; }

	}
}
