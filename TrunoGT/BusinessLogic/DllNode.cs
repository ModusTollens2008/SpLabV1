using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    class DllNode
    {
        private string name;
        private string version;
        private string lastchange;


        public string Name {
            get { return name; }
            set { name = value; }
        }

        public string Vers {
            get {return version; }
            set { version = value; }
        }
        public string Lastchange {
            get { return lastchange; }
            set { lastchange = value; }
        }


        //public _Lastchange{get {return lastchange;} }
        public DllNode(string name, string version, string lastchange)
        {
            this.name = name;
            this.version = version;
            this.lastchange = lastchange;
        }

    }
}
