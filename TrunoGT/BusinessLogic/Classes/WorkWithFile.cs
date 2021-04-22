using BusinessLogic.IModels;
using System;
using System.Collections.Generic;
using System.IO;
namespace BusinessLogic
{

	public class WorkWithFiles:IWorkFile
    {
		public void WriteToBD(List<BinaryNode> binlist)
		{
			using (UserContext db = new UserContext())
			{
				// создаем два объекта User

				// добавляем их в бд

				db.BinNodes.Add(binlist[0]);

				
				db.SaveChanges();
				Console.WriteLine("Объекты успешно сохранены");

				// получаем объекты из бд и выводим на консоль
				var users = db.BinNodes;
				Console.WriteLine("Список объектов:");
				foreach (BinaryNode u in users)
				{
					Console.WriteLine("{0}.{1} - {2}", u.Filepath);
				}
			}
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

			
			
;
		}
		
	}

}


    

