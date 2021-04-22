using BusinessLogic;
using BusinessLogic.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrunoGT.Models
{
    class ModelAnalyse
    {
        private IStructureAnalyse _Istr =new StructureAnalyse();

        public int CheckWhileDoStucture(string code)
        {
            return _Istr.CheckWhileDoStucture(code);

        }
        public int CheckStucture(string code)
        {
            return _Istr.CheckStucture(code);
        }
    }
}
