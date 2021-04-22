using BusinessLogic;
using BusinessLogic.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrunoGT.IViews;

namespace TrunoGT.Presenters
{
	class ListOperationsPresenter
	{
		private IForm _IForm;
		private IListOperations BinListOp;
		private IWorkFile WWFiles;
		private IWorkWithXml WWXml;
		private IListXMLOperations dllop;
		public ListOperationsPresenter(IForm Iform)
		{
			_IForm = Iform;
			_IForm.Add += SavingList;
			_IForm.Delete += DeleteNode;
			_IForm.Save += SaveToFile;
			_IForm.ReadFromFile += ReadFromFile;
			_IForm.Edit += EditNode;

			_IForm.AddDLL += AddDLLNode;
			_IForm.DeleteDLL += DeleteDLLNode;
			_IForm.SaveDLL += SaveToFileDLL;
			_IForm.ReadFromFileDLL += ReadFromFileDLL;
			_IForm.EditDLL += EditDllNode;
			BinListOp = new BinListOperations();
			dllop = new ListOperations();
			WWFiles = new WorkWithFiles();
			WWXml = new WorkWithXML();
            _IForm.FileLog += "Форма запущена!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
        }
		private void SavingList(object sender,EventArgs e)
		{

            try { BinListOp.addNewElement(_IForm.FilePath);
                _IForm.FileLog += "Файл успешно выбран!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
            }
            catch (Exception)
            {
                _IForm.FileLog += "Упс, при выборе бинарника произошла ошибка!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
            }
			_IForm.OutTable(BinListOp.GetList);

            
        }
		private void DeleteNode(object sender, EventArgs e)
		{
			BinListOp.deleteElement(_IForm.BinIndex);           
        }
		private void SaveToFile(object sender, EventArgs e)
		{
            try
            { WWFiles.WriteBinFile("Z:/универ/SpLabV1/TrunoGT/TrunoGT/TRUNOGTFILES/binfile.bin", BinListOp.GetList);
                _IForm.FileLog += "Запись сохранена в файл!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
            }
            catch (System.IO.IOException)
            {
                _IForm.FileLog += "ERROR: Произошла ошибка при открытии бинарного файла!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
            }
            catch (Exception)
            {
                _IForm.FileLog += "ERROR: Упс! Что-то пошло не так при сохранении в бинарный файл" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
            }
            
        }
		private void ReadFromFile(object sender, EventArgs e)
		{
            _IForm.FileLog += "Открываем файл для чтения!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
            try
            {
                BinListOp.GetList = WWFiles.ReadFromBin("Z:/универ/SpLabV1/TrunoGT/TrunoGT/TRUNOGTFILES/binfile.bin").ToList();
            }
            catch (System.IO.IOException)
            {
                _IForm.FileLog += "ERROR: Ошибка при открытии файла!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
            }
            catch (Exception)
            {
                _IForm.FileLog += "ERROR: Упс! При открытии файла что-то пошло не так!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
            }

            _IForm.OutTable(BinListOp.GetList);
            }
		private void EditNode(object sender, EventArgs e)
		{
			BinListOp.editElement(_IForm.BinIndex,_IForm.newFilePath,_IForm.newSize,_IForm.newCreateDate);
			_IForm.OutTable(BinListOp.GetList);
		}

		private void AddDLLNode(object sender, EventArgs e)
		{
            try { dllop.addNewElement(_IForm.FilePathDLL);
                _IForm.FileLog += "Файл успешно выбран!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
            }
            catch (Exception)
            {
                _IForm.FileLog += "Упс, при выборе dll произошла ошибка!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
            }
            _IForm.OutTableDLL(dllop.GetList);
		}

		private void DeleteDLLNode(object sender, EventArgs e)
		{
			dllop.deleteElement(_IForm.DLLIndex);
		}
		private void SaveToFileDLL(object sender, EventArgs e)
		{
            _IForm.FileLog += "Сохраняю DLL" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
            WWXml.writeList("Z:/универ/SpLabV1/TrunoGT/TrunoGT/TRUNOGTFILES/TRUNOGTFILExml.xml", dllop.GetList);
            _IForm.FileLog += "Успешно сохранено!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
        }
		private void ReadFromFileDLL(object sender, EventArgs e)
		{
            _IForm.FileLog += "Начинаем чтение из файла!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
            try { dllop.GetList = WWXml.readFile("Z:/универ/SpLabV1/TrunoGT/TrunoGT/TRUNOGTFILES/TRUNOGTFILExml.xml").ToList(); }
            catch (System.IO.IOException)
            {
                _IForm.FileLog += "ERROR: Ошибка при открытии файла!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
            }
            catch (Exception)
            {
                _IForm.FileLog += "ERROR: Упс! При открытии файла что-то пошло не так!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
            }
            _IForm.OutTableDLL(dllop.GetList);
            _IForm.FileLog += "Операция произошла успешно!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
        }
		private void EditDllNode(object sender, EventArgs e)
		{
            _IForm.FileLog += "Изменяем файл!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
            dllop.editElement(_IForm.DLLIndex,_IForm.newNameDLL, _IForm.newVersionDLL, _IForm.newLastChangeDLL);
			_IForm.OutTableDLL(dllop.GetList);
            _IForm.FileLog += "Изменения произошли успешно!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
        }

	}
}
