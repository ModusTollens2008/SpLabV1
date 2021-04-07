using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
	public class BinaryNode
	{
		private string filepath;
		private string size;
		private string createdate;


		public string Filepath
		{
			get { return filepath; }
			set { filepath = value; }
		}

		public string Size
		{
			get { return size; }
			set { size = value; }
		}
		public string Createdate
		{
			get { return createdate; }
			set { createdate = value; }
		}


		//public _Lastchange{get {return lastchange;} }
		public BinaryNode(string filepath, string size, string createdate)
		{
			this.Filepath = filepath;
			this.Size = size;
			this.Createdate = createdate;
		}

	}
}
