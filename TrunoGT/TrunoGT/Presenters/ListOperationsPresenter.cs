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
		}
		private void SavingList(object sender,EventArgs e)
		{
			BinListOp.addNewElement(_IForm.FilePath);
			_IForm.OutTable(BinListOp.GetList);
		}
		private void DeleteNode(object sender, EventArgs e)
		{
			BinListOp.deleteElement(_IForm.BinIndex);
		}
		private void SaveToFile(object sender, EventArgs e)
		{
			WWFiles.WriteBinFile("D:/SPLabV1/SpLabV1/TrunoGT/TrunoGT/TRUNOGTFILES/binfile.bin", BinListOp.GetList);
		}
		private void ReadFromFile(object sender, EventArgs e)
		{
			BinListOp.GetList = WWFiles.ReadFromBin("D:/SPLabV1/SpLabV1/TrunoGT/TrunoGT/TRUNOGTFILES/binfile.bin").ToList();
			_IForm.OutTable(BinListOp.GetList);
		}
		private void EditNode(object sender, EventArgs e)
		{
			BinListOp.editElement(_IForm.BinIndex,_IForm.newFilePath,_IForm.newSize,_IForm.newCreateDate);
			_IForm.OutTable(BinListOp.GetList);
		}

		private void AddDLLNode(object sender, EventArgs e)
		{
			dllop.addNewElement(_IForm.FilePathDLL);
			_IForm.OutTableDLL(dllop.GetList);
		}

		private void DeleteDLLNode(object sender, EventArgs e)
		{
			dllop.deleteElement(_IForm.DLLIndex);
		}
		private void SaveToFileDLL(object sender, EventArgs e)
		{
			WWXml.writeList("D:/SPLabV1/SpLabV1/TrunoGT/TrunoGT/TRUNOGTFILES/TRUNOGTFILExml.xml",dllop.GetList);
		}
		private void ReadFromFileDLL(object sender, EventArgs e)
		{
			dllop.GetList = WWXml.readFile("D:/SPLabV1/SpLabV1/TrunoGT/TrunoGT/TRUNOGTFILES/TRUNOGTFILExml.xml").ToList();
			_IForm.OutTableDLL(dllop.GetList);
		}
		private void EditDllNode(object sender, EventArgs e)
		{
			dllop.editElement(_IForm.DLLIndex,_IForm.newNameDLL, _IForm.newVersionDLL, _IForm.newLastChangeDLL);
			_IForm.OutTableDLL(dllop.GetList);
		}

	}
}
