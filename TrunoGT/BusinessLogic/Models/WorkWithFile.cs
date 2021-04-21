using BusinessLogic.IModels;
using System;
using System.Collections.Generic;
using System.IO;
namespace BusinessLogic
{

    public class WorkWithFiles:IWorkFile
    {

		public  IEnumerable<BinaryNode> ReadFromBin(string filepath)
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
		public  void WriteBinFile(string filename,List<BinaryNode> binlist)
		{
			try
			{
				// создаем объект BinaryWriter
				using (BinaryWriter writer = new BinaryWriter(File.Open(filename, FileMode.OpenOrCreate)))
				{
					// записываем в файл значение каждого поля структуры
					foreach (BinaryNode s in binlist)
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


    

