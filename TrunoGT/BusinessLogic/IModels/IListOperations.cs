using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.IModels
{
	interface IListOperations
	{

		void addNewElement(string filepath);
		void deleteElement(int index);
		void editElement(int index, string name, string version, string lastchange);

	}
}
