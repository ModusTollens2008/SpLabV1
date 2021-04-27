using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrunoGT.IViews;
using TrunoGT.Models;

namespace TrunoGT.Presenters
{
	class LowLevelPresenter
	{
		private IForm _IForm;
        private ModelLowLevel _ILow=new ModelLowLevel();

		public LowLevelPresenter(IForm Iform)
		{
			_IForm = Iform;
			_IForm.Mul += Mul;
			_IForm.XOR += XOR;
            _IForm.LowLog += "Форма запущена!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
		}
		public void Mul(object sender, EventArgs e)
		{
            _IForm.MulResult = _ILow.Mul(_IForm.FirstNum, _IForm.SecondNum);
            _IForm.LowLog = _ILow.LowLog;
		}
		public void XOR(object sender, EventArgs e)
		{
			int a = 0;
			try
			{
				a = int.Parse(_IForm.XorNum);
			}

			catch (ArgumentNullException)
			{
				_IForm.LowLog += "Ошибка! " + "Первое число не было введено" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
			}
			catch (FormatException)
			{
				_IForm.LowLog += "Ошибка! Первое число имело неверный формат" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
			}
			catch (OverflowException)
			{
				_IForm.LowLog += "Слишком большое первое число!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
			}
			catch (Exception)
			{
				_IForm.LowLog += "Неизвестная ошибка в обработке первого числа!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
			}
			//_IForm.XorRes = _ILow.XOR(a);
			_IForm.LowLog += "Операция произошла успешно!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
		}
	}

}
