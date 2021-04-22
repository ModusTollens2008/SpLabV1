using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrunoGT.IViews;
using BusinessLogic;
using BusinessLogic.IModels;

namespace TrunoGT.Presenters
{
	class AnalyzePresenter
	{
		private IForm _IForm;
		private IStructureAnalyse _Istr;
		public AnalyzePresenter(IForm Iform)
		{
			_IForm = Iform;
			_IForm.Analyze10 += Analyze10;
			_IForm.Analyze13 += Analyze13;
			_Istr = new StructureAnalyse();
		}
		public void Analyze10(object sender, EventArgs e)
		{
			_IForm.Result = _Istr.CheckStucture(_IForm.Code).ToString();
		}
		public void Analyze13(object sender, EventArgs e)
		{
			_IForm.Result = _Istr.CheckWhileDoStucture(_IForm.CodeGT).ToString();
		}
	}
}
