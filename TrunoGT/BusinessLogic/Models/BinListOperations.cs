using BusinessLogic.IModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
	public class BinListOperaions:IListOperations
	{

		private List<BinaryNode> binFiles = new List<BinaryNode>();

		public List<BinaryNode> BinFiles
		{
			get { return binFiles; }
			set { binFiles = value; }
		}
		public List<BinaryNode> GetList()
		{
			return BinFiles;
		}

		public void addNewElement(string filepath)
		{
			FileInfo fileInf = new FileInfo(filepath);
			if (fileInf.Exists)
			{
				BinFiles.Add(new BinaryNode(fileInf.FullName, fileInf.Length.ToString(), fileInf.CreationTime.ToString()));
			}
		}
		public void deleteElement(int index)
		{
			if (index > 0 && BinFiles != null)
			{
				BinFiles.RemoveAt(index);
			}

		}
		public  void editElement(int index, string newPath, string newSize, string newDate)
		{
			if (BinFiles != null)
			{
				BinFiles[index].Filepath = newPath;
				BinFiles[index].Size = newSize;
				BinFiles[index].Createdate = newDate;
			}

		}
	}
}
