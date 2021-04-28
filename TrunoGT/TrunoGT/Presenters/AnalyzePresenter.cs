using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrunoGT.IViews;
using TrunoGT.Models;

namespace TrunoGT.Presenters
{
    /// <summary>
    /// Презентер аналаза кода
    /// </summary>
	class AnalyzePresenter
	{
        /// <summary>
        /// Интерфейс формы
        /// </summary>
		private IForm _IForm;
        /// <summary>
        /// Экземпляр модели
        /// </summary>
		private ModelAnalyse _Istr;
        /// <summary>
        /// Инициализация презентера
        /// </summary>
        /// <param name="Iform">Экземпляр формы</param>
		public AnalyzePresenter(IForm Iform)
		{
			_IForm = Iform;
			_IForm.Analyze10 += Analyze10;
			_IForm.Analyze13 += Analyze13;
			_Istr = new ModelAnalyse();          
        }
        /// <summary>
        /// Анализ кода для 10 варианта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		public void Analyze10(object sender, EventArgs e)
		{
           
            _IForm.Result = _Istr.CheckStucture(_IForm.Code).ToString();                        
            _IForm.AnalyseLog = _Istr.AnalyseLog;
        }
        /// <summary>
        /// Анализ кода для 13 варианта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		public void Analyze13(object sender, EventArgs e)
		{
			if (_Istr.CheckWhileDoStucture(_IForm.CodeGT) > 0)
			{
				_IForm.Result = "Да!";
			}
			else
			{
				_IForm.Result = "Нет!";
			}
                
            _IForm.AnalyseLog = _Istr.AnalyseLog;
		}
	}
}
