using System;
using System.Collections.Generic;
using System.IO;
namespace BusinessLogic
{

    public class WorkWithFiles
    {
        private List<DllNode> Antonya = new List<DllNode>();
        public IEnumerable<DllNode> readFromFile(string filename)
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
        {
            StreamWriter fstream = new StreamWriter(filename);
            foreach (DllNode node in Antonya)
            {
                fstream.WriteLine(node.Name);
                fstream.WriteLine(node.Vers);
                fstream.WriteLine(node.Lastchange);
            }
            fstream.Close();
        }

    
}
}
