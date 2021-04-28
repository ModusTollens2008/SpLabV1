using BusinessLogic;
using BusinessLogic.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrunoGT.Models
{
	class ModelListOperations
	{     
		private IListOperations BinListOp = new BinListOperations();
		private IWorkFile WWFiles= new WorkWithFiles();
		private IWorkWithXml WWXml= new WorkWithXML();
		private IListXMLOperations dllop= new ListOperations();
		public string OPLog
		{ get; set; }
        /// <summary>
        /// сохрание списка
        /// </summary>
        /// <param name="FilePath">Список файлов</param>
		public List<BinaryNode> SavingList(string FilePath)
		{

			try
			{
				BinListOp.addNewElement(FilePath);
                OPLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Файл успешно выбран!" + "\n";
			}
			catch (Exception)
			{
                OPLog +=DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Упс, при выборе бинарника произошла ошибка!" + "\n";
			}
            return BinListOp.GetList;
		}
		public List<BinaryNode> DeleteNode(int index)
		{
           
            {
                try
                {

                    BinListOp.deleteElement(index);
                    OPLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Файл успешно удалён!" + "\n";
                }
                catch (Exception)
                {
                    OPLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Удаляемый файл не выбран!" + "\n";
                }
            }          
            return BinListOp.GetList;
		}
		public void SaveToFile()
		{
			try
			{
				WWFiles.WriteBinFile("Z:/универ/SpLabV1/TrunoGT/TrunoGT/TRUNOGTFILES/binfile.bin", BinListOp.GetList);
                OPLog += DateTime.Now.ToString("dd.MM.yyyy ")+ DateTime.Now.ToString("HH:mm:ss ") +"Запись сохранена в файл!"+ "\n";
				//WWFiles.WriteToBD(BinListOp.GetList);
			}
			catch (System.IO.IOException)
			{
                OPLog +=  DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Произошла ошибка при открытии бинарного файла!" + "\n";
			}
			catch (Exception)
			{
				  OPLog += "ERROR: Упс! Что-то пошло не так при сохранении в бинарный файл" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
			}

		}
        public List<BinaryNode> ReadFromFile()
		{
            OPLog += DateTime.Now.ToString("dd.MM.yyyy ")  + DateTime.Now.ToString("HH:mm:ss ") + "Открываем файл для чтения!" + "\n";
			try
			{
				BinListOp.GetList = WWFiles.ReadFromBin("Z:/универ/SpLabV1/TrunoGT/TrunoGT/TRUNOGTFILES/binfile.bin").ToList();
			}
			catch (System.IO.IOException)
			{
                OPLog +=  DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Ошибка при открытии файла!"+ "\n";
			}
			catch (Exception)
			{
                OPLog += DateTime.Now.ToString("dd.MM.yyyy ")  + DateTime.Now.ToString("HH:mm:ss ") + "Упс! При открытии файла что-то пошло не так!" + "\n";
			}
            return BinListOp.GetList;
		}
		public List<BinaryNode> EditNode(int index,string newFilePath,string newSize,string newCreateDate)
		{
            int size;
            DateTime dt;          
            try {dt= DateTime.Parse(newCreateDate);
                size = int.Parse(newSize);
                if (size >= 0)
                {
                    OPLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Начинаем изменение файла!" + "\n";
                    BinListOp.editElement(index, newFilePath, newSize, newCreateDate);
                    OPLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Успешно изменено!" + "\n";
                }
                else
                {
                    OPLog +=  DateTime.Now.ToString("dd.MM.yyyy ")  + DateTime.Now.ToString("HH:mm:ss ") + "Неправильный размер файла"+"\n";
                }
            }
            catch (Exception)
            {
                OPLog +=  DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Неправильная дата или размер файла" + "\n";
            }			
            return BinListOp.GetList;
		}

		public List<DllNode> AddDLLNode(string FilePathDLL)
		{
			try
			{
                if (FilePathDLL.IndexOf(".dll") < 0)
                {
                    OPLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Выбранный файл не является файлом с раширением .dll" + "\n";
                    return dllop.GetList;
                }
                dllop.addNewElement(FilePathDLL);
                OPLog +=  DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Файл успешно выбран!" + "\n";
			}
			catch (Exception)
			{
                OPLog +=  DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Упс, при выборе dll произошла ошибка!" + "\n";
			}
            return dllop.GetList;
		}

		public List<DllNode> DeleteDLLNode(int index)
		{
            try
            {
                OPLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Начинаем удаление файла!" + "\n";
                dllop.deleteElement(index);
                OPLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Файл удален!" + "\n";
            }
            catch (Exception)
            {
                OPLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Удаляемый файл не выбран" + "\n";
            }
            return dllop.GetList;
		}
		public List<DllNode> SaveToFileDLL()
		{
            
            OPLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Сохраняю DLL" + "\n";
			WWXml.writeList("Z:/универ/SpLabV1/TrunoGT/TrunoGT/TRUNOGTFILES/TRUNOGTFILExml.xml",dllop.GetList);
            OPLog +=  DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Успешно сохранено!"+ "\n";
            return dllop.GetList;
		}
		public List<DllNode> ReadFromFileDLL()
		{
            OPLog +=DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Начинаем чтение из файла!"+ "\n";
			try { dllop.GetList = WWXml.readFile("Z:/универ/SpLabV1/TrunoGT/TrunoGT/TRUNOGTFILES/TRUNOGTFILExml.xml").ToList(); }
			catch (System.IO.IOException)
			{
                OPLog += DateTime.Now.ToString("dd.MM.yyyy ")+ DateTime.Now.ToString("HH:mm:ss ") + "Ошибка при открытии файла!"+"\n";
			}
			catch (Exception)
			{
                OPLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Упс! При открытии файла что-то пошло не так!" + "\n";
			}

            OPLog +=  DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Операция произошла успешно!" + "\n";
            return dllop.GetList;
		}
		public List<DllNode> EditDllNode(int Index, string newNameDLL, string newVersionDLL,string newLastChangeDLL)
		{
            OPLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Изменяем файл!"+"\n";
            DateTime dt = new DateTime();
            int version = 0;
            try
            {
                if (newNameDLL.IndexOf(".dll") < 0)
                {
                    OPLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Выбранный файл не является файлом с раширением .dll" + "\n";
                    return dllop.GetList;
                }
                
                dt = DateTime.Parse(newLastChangeDLL);
                version = int.Parse(newVersionDLL);
                if (version < 0)
                {
                    OPLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Неправильная версия файла" + "\n";
                    return dllop.GetList;                  
                }
                dllop.editElement(Index, newNameDLL, newVersionDLL, newLastChangeDLL);
                OPLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Изменения произошли успешно!" + "\n";
            }
            catch (Exception)
            {
                OPLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Неправильная дата или версия файла" + "\n";
            }

            return dllop.GetList;
		}

		public List<BinaryNode> WriteToBD()
		{
			OPLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Сохраняю в БД" + "\n";
			//try
			{
				WWFiles.WriteToBD(BinListOp.GetList);
			}
			//catch (InvalidOperationException e)
			{
				OPLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Что-то пошло не так, возможно есть повторяющиеся записи" + "\n";
			}
			OPLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Успешно сохранено!" + "\n";
			return BinListOp.GetList;
		}

		public List<BinaryNode> ReadFromBD()
		{
			OPLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Загрузка из БД" + "\n";
			try
			{
				BinListOp.GetList = WWFiles.ReadFromBD();
			}
			catch (InvalidOperationException e)
			{
				OPLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Ошибка при загрузке из БД" + "\n";
			}
			OPLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Успешно загружено!" + "\n";
			return BinListOp.GetList;
		}

		public List<DllNode> WriteToBDDLL()
		{
			OPLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Сохраняю в БД" + "\n";
			try
			{
				WWXml.WriteToBD(dllop.GetList);
			}
			catch (InvalidOperationException e)
			{
				OPLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Что-то пошло не так, возможно есть повторяющиеся записи" + "\n";
			}
			OPLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Успешно сохранено!" + "\n";
			return dllop.GetList;
		}

		public List<DllNode> ReadFromBDDLL()
		{
			OPLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Загрузка из БД" + "\n";
			try
			{
				dllop.GetList = WWXml.ReadFromBD();
			}
			catch (InvalidOperationException e)
			{
				OPLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Ошибка при загрузке из БД" + "\n";
			}
			OPLog += DateTime.Now.ToString("dd.MM.yyyy ") + DateTime.Now.ToString("HH:mm:ss ") + "Успешно загружено!" + "\n";
			return dllop.GetList;
		}

	}
}
