using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{

    public class WorkWithFiles
    {
        private List<DllNode> Antonya = new List<DllNode>();
		private List<BinaryNode>BinFiles = new List<BinaryNode>();
		public void GetFileInfo(string filepath)
		{

		}
		public IEnumerable<BinaryNode> ReadFromBin(string filepath)
		{
			List<BinaryNode> p = new List<BinaryNode>();
			try
			{
				// создаем объект BinaryReader
				using (BinaryReader reader = new BinaryReader(File.Open(filepath, FileMode.Open)))
				{
					// пока не достигнут конец файла
					// считываем каждое значение из файла
					while (reader.PeekChar() > -1)
					{
						string BinFilepath = reader.ReadString();
						string BinSize = reader.ReadString();
						string BinDate = reader.ReadString();
						p.Add(new BinaryNode(BinFilepath, BinSize, BinDate));
					}
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			return p;
		}
		public void WriteBinFile(string filename)
		{
			try
			{
				// создаем объект BinaryWriter
				using (BinaryWriter writer = new BinaryWriter(File.Open(filename, FileMode.OpenOrCreate)))
				{
					// записываем в файл значение каждого поля структуры
					foreach (BinaryNode s in BinFiles)
					{
						writer.Write(s.Filepath);
						writer.Write(s.Size);
						writer.Write(s.Createdate);
					}
				}
				
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
;
		}
	}

}

