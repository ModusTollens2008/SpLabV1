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
			_IForm.LowLog += "Инициализация умножения!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
			int a = 0;
			int b = 0;
			try
			{
				a = int.Parse(_IForm.FirstNum);
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

			try
			{
				b = int.Parse(_IForm.SecondNum);
			}
			catch (ArgumentNullException)
			{
				_IForm.LowLog += "Ошибка! " + "Второе число не было введено" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
			}
			catch (FormatException)
			{
				_IForm.LowLog += "Ошибка! Второе число имело неверный формат" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
			}
			catch (OverflowException)
			{
				_IForm.LowLog += "Слишком большое второе число!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
			}
			catch (Exception)
			{
				_IForm.LowLog += "Неизвестная ошибка в обработке второго числа!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
			}
			if ((b == 0) && (a == b))
			{
				_IForm.MulResult = 0;
				_IForm.LowLog += "Упс! Что-то пошло не так :С" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
			}
			else
			{
				_IForm.MulResult = _ILow.Mul(a, b);
				_IForm.LowLog += "Операция произошла успешно!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
			}
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
			_IForm.XorRes = _ILow.XOR(a);
			_IForm.LowLog += "Операция произошла успешно!" + " Дата " + DateTime.Now.ToString("dd.MM.yyyy ") + "Текущее время " + DateTime.Now.ToString("HH:mm:ss ") + "\n";
		}
	}

}
