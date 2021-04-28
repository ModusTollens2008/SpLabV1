using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.IModels
{
	public interface IWorkFile
	{
		void WriteBinFile(string filename, List<BinaryNode> binlist);
		IEnumerable<BinaryNode>ReadFromBin(string filepath);
		void WriteToBD(List<BinaryNode> binlist);
		List<BinaryNode> ReadFromBD();
	}
}
