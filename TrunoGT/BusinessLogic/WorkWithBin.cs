using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
	class WorkWithBin
	{
		private List<BinaryNode> BinFiles = new List<BinaryNode>();
		public void AddFileWrite(string filepath)
		{
			FileInfo fileInf = new FileInfo(filepath);
			if (fileInf.Exists)
			{
				BinFiles.Add(new BinaryNode(fileInf.FullName, fileInf.Length.ToString(), fileInf.CreationTime.ToString()));
			}
		}
		public void DeleteFileWrite(int index)
		{
			if (index > 0 && BinFiles != null)
			{
				BinFiles.RemoveAt(index);
			}

		}
		public static void EditFileWrite(BinaryNode binnode, string newPath, string newSize, string newDate)
		{
			if (binnode != null)
			{
				binnode.Filepath = newPath;
				binnode.Size = newSize;
				binnode.Createdate = newDate;
			}

		}
	}
}
