using LowFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrunoGT.Models
{
    class ModelLowLevel
    {
        private LowLevelFunctions _ILow=new LowLevelFunctions();
        public int XOR(int a)
        {
           return _ILow.LowLevelNot(a);
        }
        public int Mul(int a, int b)
        {
            return _ILow.LowLevelMultiple(a,b);
        }

    }
}
