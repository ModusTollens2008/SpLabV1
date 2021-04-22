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
            _IForm.AnalyseLog += "Форма запущена!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
        }
		public void Analyze10(object sender, EventArgs e)
		{
            int a;
			a = _Istr.CheckStucture(_IForm.Code);
            if (a >= 0)
            {
                _IForm.Result = a.ToString();
                _IForm.AnalyseLog += "Анализ цикла произошел успешно! Количество иттераций = " +a + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
            }
            else {
                _IForm.AnalyseLog += "Неверно введен код для анализа цикла foreach!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
            }

        }
		public void Analyze13(object sender, EventArgs e)
		{
            int a;
            a = _Istr.CheckWhileDoStucture(_IForm.CodeGT);
            if (a >= 0)
            {
                _IForm.AnalyseLog += "Анализ цикла do while произошел успешно! Количество иттераций = " + a + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
                _IForm.Result= a.ToString();
            }
            
                else _IForm.AnalyseLog += "Неверно введен код для анализа цикла do while!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
            
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
