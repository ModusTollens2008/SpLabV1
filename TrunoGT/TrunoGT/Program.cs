using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace TrunoGT
{
    
	static class Program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new Form1());         
            List<DllNode> list = new List<DllNode>();
            list.Add(new DllNode("chlenodevka","chlenodevka2","chlenodevka3"));
            list.Add(new DllNode("chlenodevka2", "chlenodevka4", "chlenodevka14"));
           // WorkWithXML.writeNodeFile("Z:/универ/3 курс 2 семак/СИС/ЛР/call/SpLabV1/TrunoGT/TrunoGT/TRUNOGTFILES/TRUNOGTFILExml.xml", typoi);
            WorkWithXML.writeList("Z:/универ/3 курс 2 семак/СИС/ЛР/call/SpLabV1/TrunoGT/TrunoGT/TRUNOGTFILES/TRUNOGTFILExml.xml", list);
            // WorkWithXML.deleteXML("Z:/универ/3 курс 2 семак/СИС/ЛР/call/SpLabV1/TrunoGT/TrunoGT/TRUNOGTFILES/TRUNOGTFILExml.xml");
            ListOperations listOp = new ListOperations();
            listOp.setList(WorkWithXML.readFile("Z:/универ/3 курс 2 семак/СИС/ЛР/call/SpLabV1/TrunoGT/TrunoGT/TRUNOGTFILES/TRUNOGTFILExml.xml").ToList());
            listOp.printall();

        }
	}
}
