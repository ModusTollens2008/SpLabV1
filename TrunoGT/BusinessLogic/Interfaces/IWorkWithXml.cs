using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.IModels
{
	public interface IWorkWithXml
	{
		IEnumerable<DllNode> readFile(string fileName);
		void writeList(string fileName, List<DllNode> dllList);
	}
}
