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
            _IForm.ClrMul += ClrMul;
            _IForm.ClrXOR += ClrXOR;
        }
        public void ClrMul(object sender, EventArgs e)
        {
            _ILow.MulClr();
            _IForm.LowLog = _ILow.LowLog;
        }
        public void ClrXOR(object sender, EventArgs e)
        {
            _ILow.XORClr();
            _IForm.LowLog = _ILow.LowLog;
        }
        public void Mul(object sender, EventArgs e)
		{
            _IForm.MulResult = _ILow.Mul(_IForm.FirstNum, _IForm.SecondNum);
            _IForm.LowLog = _ILow.LowLog;
		}
		public void XOR(object sender, EventArgs e)
		{
            _IForm.XorRes = _ILow.XOR(_IForm.XorNum);
            _IForm.LowLog = _ILow.LowLog;
        }
	}

}
