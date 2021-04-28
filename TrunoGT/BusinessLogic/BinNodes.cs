namespace BusinessLogic
{
	using System;
	using System.Data.Entity;
	using System.Linq;

	public class BinNodes : DbContext
	{
		public BinNodes()
			: base("BinNodes1")
		{
			
		}
		public DbSet<BinaryNode> BinList { get; set; }

	}

}