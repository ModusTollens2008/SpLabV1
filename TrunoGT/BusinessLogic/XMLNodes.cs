namespace BusinessLogic
{
	using System;
	using System.Data.Entity;
	using System.Linq;

	public class XMLNodes : DbContext
	{
		public XMLNodes()
			: base("XMLNodes")
		{
		}
		public DbSet<DllNode> DllList { get; set; }
	}
}