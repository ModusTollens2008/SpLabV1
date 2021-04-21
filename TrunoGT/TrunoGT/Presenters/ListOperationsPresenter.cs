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
		WorkWithFiles WWFiles = new WorkWithFiles();
		public ListOperationsPresenter(IForm Iform)
		{
			_IForm = Iform;
			_IForm.Add += SavingList;
			_IForm.Delete += DeleteNode;
			_IForm.Save += SaveToFile;
			_IForm.ReadFromFile += ReadFromFile;
			_IForm.Edit += EditNode;
			BinListOp = new BinListOperations();
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


	}
}
