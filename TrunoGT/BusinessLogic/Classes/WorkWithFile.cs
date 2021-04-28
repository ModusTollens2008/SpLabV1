using BusinessLogic.IModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BusinessLogic
{

	public class WorkWithFiles:IWorkFile
    {
		BinNodes context = new BinNodes();
		public void WriteToBD(List<BinaryNode> binlist)
		{
			context.BinList.RemoveRange(context.BinList.ToList());
			context.SaveChanges();
			for (int i = 0; i < binlist.Count; i++)
			{
				context.BinList.Add(binlist[i]);
			}
			context.SaveChanges();	

		}

		public List<BinaryNode> ReadFromBD()
		{
			List<BinaryNode> binlist = new List<BinaryNode>();
			{
				try
				{
					binlist = context.BinList.ToList();
				}
				catch (Exception e) { Console.WriteLine(e); }
			}
			return binlist;
		}
	
		public  IEnumerable<BinaryNode> ReadFromBin(string filepath)
		{
			List<BinaryNode> p = new List<BinaryNode>();
			
			
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
			return p;
		}
		public  void WriteBinFile(string filename,List<BinaryNode> binlist)
		{
			
				// создаем объект BinaryWriter
				using (BinaryWriter writer = new BinaryWriter(File.Open(filename, FileMode.Create)))
				{
					// записываем в файл значение каждого поля структуры
					foreach (BinaryNode s in binlist)
					{
						writer.Write(s.Filepath);
						writer.Write(s.Size);
						writer.Write(s.Createdate);
					}
				}

			
			
;
		}
		
	}

}


    

