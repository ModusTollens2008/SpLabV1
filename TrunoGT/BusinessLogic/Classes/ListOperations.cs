using BusinessLogic.IModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace BusinessLogic
{
    public class ListOperations:IListXMLOperations
    {
        private List<DllNode> mainList = new List<DllNode>();       
        public List<DllNode>GetList
        {
            get { return mainList; }
            set { mainList = value; }
        }
        public void addNewElement(string filepath)
        {
            FileInfo fileInf = new FileInfo(filepath);        
            if (fileInf.Exists)
            {
				string fvers = FileVersionInfo.GetVersionInfo(filepath).FileVersion;
				if (fvers==null)
				{
					fvers = "1";
				}

				mainList.Add(new DllNode(fileInf.Name, fvers, fileInf.LastWriteTime.ToString()));
            }
        }
        public void deleteElement(int index)
        {
			if (index >= 0 && index <= GetList.Count && GetList != null)
			{
				mainList.RemoveAt(index);
			}
        }
        public void editElement(int index, string name, string version, string lastchange)
        {
            GetList[index].Name = name;
            GetList[index].Vers = version;
            GetList[index].Lastchange = lastchange;
        }
        public void deleteList()
        {
            mainList = new List<DllNode>();
        }
        public void setList(List<DllNode> dllNodes) 
        {
            mainList = dllNodes;
        }
        public void printall()
        {
            foreach (DllNode d in mainList)
            {
                Console.WriteLine(d.Lastchange);
                Console.WriteLine(d.Name);
                Console.WriteLine(d.Vers);
            }
        }
    }
}
