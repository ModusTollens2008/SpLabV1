using System;
using System.Collections.Generic;
using System.IO;
namespace BusinessLogic
{

    public class WorkWithFiles
    {
        private List<DllNode> Antonya = new List<DllNode>();
		private List<BinaryNode> BinFiles = new List<BinaryNode>();
		public IEnumerable<DllNode> readFromFile(string filename)
        {

            StreamReader fstream = new StreamReader(filename);
            string name;
            string vers;
            string lastchange;
            while (!fstream.EndOfStream)
            {
                name = fstream.ReadLine();
                vers = fstream.ReadLine();
                lastchange = fstream.ReadLine();
                Antonya.Add(new DllNode(name, vers, lastchange));
            }

            return Antonya;
        }
        public void writeIntoFile(string filename)
        {
            StreamWriter fstream = new StreamWriter(filename);
            foreach (DllNode node in Antonya)
            {
                fstream.WriteLine(node.Name);
                fstream.WriteLine(node.Vers);
                fstream.WriteLine(node.Lastchange);
            }
            fstream.Close();
        }

	
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
		public void AddFileWrite(string filepath)
		{
			FileInfo fileInf = new FileInfo(filepath);
			if (fileInf.Exists)
			{
				BinFiles.Add(new BinaryNode(fileInf.FullName,fileInf.Length.ToString(),fileInf.CreationTime.ToString()));
			}
		}
		public void DeleteFileWrite(int index)
		{
			if (index>0 && BinFiles!=null)
			{
				BinFiles.RemoveAt(index);
			}

		}
		public void EditFileWrite(int index,string newPath,string newSize,string newDate)
		{
			if (index > 0 && BinFiles != null)
			{
				BinFiles[index].Filepath=newPath;
				BinFiles[index].Size = newSize;
				BinFiles[index].Createdate = newDate;
			}

		}
	}

}


    

