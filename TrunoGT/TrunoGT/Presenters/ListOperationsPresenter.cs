using BusinessLogic;
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
		private BinListOperations BinListOp = new BinListOperations();
		public ListOperationsPresenter(IForm Iform)
		{
			_IForm = Iform;
			_IForm.Save += SavingList;
			_IForm.Delete += DeleteNode;
		}
		private void SavingList(object sender,EventArgs e)
		{
			BinListOp.addNewElement(_IForm.FilePath);
			_IForm.OutTable(BinListOp.BinFiles);
		}
		private void DeleteNode(object sender, EventArgs e)
		{
			BinListOp.deleteElement(_IForm.BinIndex);
		}

	}
}
