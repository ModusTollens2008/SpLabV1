using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.IModels
{
	public interface IListXMLOperations
	{
		List<DllNode> GetList
		{
			get;
			set;
		}
		void addNewElement(string filepath);
		void deleteElement(int index);
		void editElement(int index, string name, string version, string lastchange);
	}
}
