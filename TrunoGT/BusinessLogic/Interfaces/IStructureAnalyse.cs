using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.IModels
{
	public interface IStructureAnalyse
	{
		
		int CheckStucture(string code);
		int CheckWhileDoStucture(string code);
	}
}
