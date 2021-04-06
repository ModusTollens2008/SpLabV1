using System;
using System.Collections.Generic;
using System.IO;
namespace BusinessLogic
{

    public class WorkWithFiles
    {
        private List<DllNode> Antonya = new List<DllNode>();
        private IEnumerable<DllNode> readFromFile(string filename)
        {
            
            StreamReader fstream = new StreamReader(filename);
            string name;
            string vers;
            string lastchange;
            while (!fstream.EndOfStream)
            {
                name = fstream.ReadLine();
                vers = fstream.ReadLine();
                lastchange = fstream.ReadLine();
                Antonya.Add(new DllNode(name, vers, lastchange));
            }
            
            return Antonya;
        }
        public void writeIntoFile(string filename)



    }
}
