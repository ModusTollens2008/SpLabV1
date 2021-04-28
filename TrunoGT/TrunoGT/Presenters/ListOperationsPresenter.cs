using BusinessLogic;
using BusinessLogic.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrunoGT.IViews;
using TrunoGT.Models;

namespace TrunoGT.Presenters
{
	class ListOperationsPresenter
	{
		private IForm _IForm;
		private IListOperations BinListOp;
		private IWorkFile WWFiles;
		private IWorkWithXml WWXml;
		private IListXMLOperations dllop;
        private ModelListOperations IModel;
		public ListOperationsPresenter(IForm Iform)
		{
			_IForm = Iform;
			_IForm.Add += SavingList;
			_IForm.Delete += DeleteNode;
			_IForm.Save += SaveToFile;
			_IForm.ReadFromBD += ReadFromBD;
			_IForm.WriteToBD += WriteToBD;
			_IForm.ReadFromBDDLL += ReadFromBDDLL;
			_IForm.WriteToBDDLL += WriteToBDDLL;
			_IForm.ReadFromFile += ReadFromFile;
			_IForm.Edit += EditNode;
			_IForm.AddDLL += AddDLLNode;
			_IForm.DeleteDLL += DeleteDLLNode;
			_IForm.SaveDLL += SaveToFileDLL;
			_IForm.ReadFromFileDLL += ReadFromFileDLL;
			_IForm.EditDLL += EditDllNode;
			//_IForm.ReadFromBD += ReadFromBD;
			BinListOp = new BinListOperations();
			dllop = new ListOperations();
			WWFiles = new WorkWithFiles();
			WWXml = new WorkWithXML();
            IModel = new ModelListOperations();
        }
		private void SavingList(object sender,EventArgs e)
		{                             
			_IForm.OutTable(BinListOp.GetList= IModel.SavingList(_IForm.FilePath));
            _IForm.FileLog = IModel.OPLog;

        }
		private void DeleteNode(object sender, EventArgs e)
		{
            BinListOp.GetList=IModel.DeleteNode(_IForm.BinIndex);
			_IForm.FileLog=IModel.OPLog;
            


        }
		private void SaveToFile(object sender, EventArgs e)
		{
            IModel.SaveToFile();
            _IForm.FileLog = IModel.OPLog;
            
        }
		private void ReadFromFile(object sender, EventArgs e)
		{          
            _IForm.OutTable(BinListOp.GetList= IModel.ReadFromFile());
            _IForm.FileLog = IModel.OPLog;
        }
		private void EditNode(object sender, EventArgs e)
		{			
			_IForm.OutTable(BinListOp.GetList= IModel.EditNode(_IForm.BinIndex, _IForm.newFilePath, _IForm.newSize, _IForm.newCreateDate));
            _IForm.FileLog = IModel.OPLog;
		}



		private void AddDLLNode(object sender, EventArgs e)
		{
            _IForm.OutTableDLL(dllop.GetList=IModel.AddDLLNode(_IForm.FilePathDLL));
            _IForm.FileLog = IModel.OPLog;
        }

		private void DeleteDLLNode(object sender, EventArgs e)
		{
            dllop.GetList = IModel.DeleteDLLNode(_IForm.DLLIndex);
            _IForm.FileLog = IModel.OPLog;
        }
		private void SaveToFileDLL(object sender, EventArgs e)
		{
            dllop.GetList=IModel.SaveToFileDLL();
            _IForm.FileLog = IModel.OPLog;           
        }
		private void ReadFromFileDLL(object sender, EventArgs e)
		{           
            _IForm.OutTableDLL(dllop.GetList=IModel.ReadFromFileDLL());
            _IForm.FileLog = IModel.OPLog;
        }
		private void EditDllNode(object sender, EventArgs e)
		{            
			_IForm.OutTableDLL(dllop.GetList= IModel.EditDllNode(_IForm.DLLIndex, _IForm.newNameDLL, _IForm.newVersionDLL, _IForm.newLastChangeDLL));
            _IForm.FileLog = IModel.OPLog;
        }
		private void ReadFromBD(object sender, EventArgs e)
		{
			_IForm.OutTable(BinListOp.GetList = IModel.ReadFromBD());
			_IForm.FileLog = IModel.OPLog;
		}
		private void WriteToBD(object sender, EventArgs e)
		{
			_IForm.OutTable(BinListOp.GetList = IModel.WriteToBD());
			_IForm.FileLog = IModel.OPLog;
		}

		private void ReadFromBDDLL(object sender, EventArgs e)
		{
			_IForm.OutTableDLL(dllop.GetList = IModel.ReadFromBDDLL());
			_IForm.FileLog = IModel.OPLog;
		}
		private void WriteToBDDLL(object sender, EventArgs e)
		{
			_IForm.OutTableDLL(dllop.GetList = IModel.WriteToBDDLL());
			_IForm.FileLog = IModel.OPLog;
		}

	}
}
