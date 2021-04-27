using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrunoGT.IViews;
using TrunoGT.Models;

namespace TrunoGT.Presenters
{
	class AnalyzePresenter
	{
		private IForm _IForm;
		private ModelAnalyse _Istr;
		public AnalyzePresenter(IForm Iform)
		{
			_IForm = Iform;
			_IForm.Analyze10 += Analyze10;
			_IForm.Analyze13 += Analyze13;
			_Istr = new ModelAnalyse();
            _IForm.AnalyseLog += "Форма запущена!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
        }
		public void Analyze10(object sender, EventArgs e)
		{
           
            _IForm.Result = _Istr.CheckStucture(_IForm.Code).ToString();                        
            _IForm.AnalyseLog = _Istr.AnalyseLog;
        }
		public void Analyze13(object sender, EventArgs e)
		{

            _IForm.Result = _Istr.CheckWhileDoStucture(_IForm.CodeGT).ToString();       
            _IForm.AnalyseLog = _Istr.AnalyseLog;
            //_IForm.Result = _Istr.CheckWhileDoStucture(_IForm.CodeGT).ToString();

			/* int[] a = new int[] { 1, 2, 3 };
			 foreach (int b in a)
			 {
				 Console.WriteLine(b);
			 }
			 */
		}
	}
}
