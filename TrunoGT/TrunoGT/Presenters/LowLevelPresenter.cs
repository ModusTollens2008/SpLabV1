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
    /// Презентер для работы с низкоуровневыми функциями
    /// </summary>
	class LowLevelPresenter
	{
        /// <summary>
        /// Интерфейс для работы с формой
        /// </summary>
		private IForm _IForm;
        /// <summary>
        /// Модель класса работы с низкоуровневыми функциями
        /// </summary>
        private ModelLowLevel _ILow=new ModelLowLevel();
        /// <summary>
        /// Инициализация презентера
        /// </summary>
        public LowLevelPresenter(IForm Iform)
		{
			_IForm = Iform;
			_IForm.Mul += Mul;
			_IForm.XOR += XOR;
            _IForm.ClrMul += ClrMul;
            _IForm.ClrXOR += ClrXOR;
        }
        /// <summary>
        /// Очистка полей для умножения
        /// </summary>
        public void ClrMul(object sender, EventArgs e)
        {
            _ILow.MulClr();
            _IForm.LowLog = _ILow.LowLog;
        }
        /// <summary>
        /// Очистка полей для НЕ
        /// </summary>
        public void ClrXOR(object sender, EventArgs e)
        {
            _ILow.XORClr();
            _IForm.LowLog = _ILow.LowLog;
        }
        /// <summary>
        /// Вызов умножения
        /// </summary>
        public void Mul(object sender, EventArgs e)
		{
            _IForm.MulResult = _ILow.Mul(_IForm.FirstNum, _IForm.SecondNum);
            _IForm.LowLog = _ILow.LowLog;
		}
        /// <summary>
        /// Вызов побитового НЕ
        /// </summary>
        public void XOR(object sender, EventArgs e)
		{
            _IForm.XorRes = _ILow.XOR(_IForm.XorNum);
            _IForm.LowLog = _ILow.LowLog;
        }
	}

}
