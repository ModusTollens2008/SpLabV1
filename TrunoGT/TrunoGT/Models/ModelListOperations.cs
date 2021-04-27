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
		public void SavingList(string FilePath)
		{

			try
			{
				BinListOp.addNewElement(FilePath);
                OPLog += "Файл успешно выбран!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
			}
			catch (Exception)
			{
                OPLog += "Упс, при выборе бинарника произошла ошибка!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
			}

		}
		public void DeleteNode(int index)
		{
		
			BinListOp.deleteElement(index);
            OPLog += "Файл успешно удалён!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
		}
		public void SaveToFile(object sender, EventArgs e)
		{
			try
			{
				WWFiles.WriteBinFile("Z:/универ/SpLabV1/TrunoGT/TrunoGT/TRUNOGTFILES/binfile.bin", BinListOp.GetList);
                OPLog += "Запись сохранена в файл!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
				WWFiles.WriteToBD(BinListOp.GetList);
			}
			catch (System.IO.IOException)
			{
                OPLog += "ERROR: Произошла ошибка при открытии бинарного файла!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
			}
			// catch (Exception)
			{
				//   _IForm.FileLog += "ERROR: Упс! Что-то пошло не так при сохранении в бинарный файл" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
			}

		}
		public void ReadFromFile(object sender, EventArgs e)
		{
            OPLog += "Открываем файл для чтения!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
			try
			{
				BinListOp.GetList = WWFiles.ReadFromBin("Z:/универ/SpLabV1/TrunoGT/TrunoGT/TRUNOGTFILES/binfile.bin").ToList();
			}
			catch (System.IO.IOException)
			{
                OPLog += "ERROR: Ошибка при открытии файла!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
			}
			catch (Exception)
			{
                OPLog += "ERROR: Упс! При открытии файла что-то пошло не так!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
			}

		}
		public void EditNode(int index,string newFilePath,string newSize,string newCreateDate)
		{
			//сделать проверку параметров 
			BinListOp.editElement(index, newFilePath, newSize,newCreateDate);
		}

		public void AddDLLNode(string FilePathDLL)
		{
			try
			{
				dllop.addNewElement(FilePathDLL);
                OPLog += "Файл успешно выбран!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
			}
			catch (Exception)
			{
                OPLog += "Упс, при выборе dll произошла ошибка!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
			}
		}

		public void DeleteDLLNode(int index)
		{
			dllop.deleteElement(index);
		}
		public void SaveToFileDLL(object sender, EventArgs e)
		{
            OPLog += "Сохраняю DLL" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
			WWXml.writeList("Z:/универ/SpLabV1/TrunoGT/TrunoGT/TRUNOGTFILES/TRUNOGTFILExml.xml", dllop.GetList);
            OPLog += "Успешно сохранено!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
		}
		public void ReadFromFileDLL()
		{
            OPLog += "Начинаем чтение из файла!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
			try { dllop.GetList = WWXml.readFile("Z:/универ/SpLabV1/TrunoGT/TrunoGT/TRUNOGTFILES/TRUNOGTFILExml.xml").ToList(); }
			catch (System.IO.IOException)
			{
                OPLog += "ERROR: Ошибка при открытии файла!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
			}
			catch (Exception)
			{
                OPLog += "ERROR: Упс! При открытии файла что-то пошло не так!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
			}

            OPLog += "Операция произошла успешно!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
		}
		public void EditDllNode(int Index, string newNameDLL, string newVersionDLL,string newLastChangeDLL)
		{
            OPLog += "Изменяем файл!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
			dllop.editElement(Index, newNameDLL,newVersionDLL,newLastChangeDLL);
            OPLog += "Изменения произошли успешно!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
		}

	}
}
