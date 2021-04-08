using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrunoGT.IViews
{
	interface IForm
	{
		string FilePath
		{
			 get; set;
		}
		event Action Save;
	}
}
