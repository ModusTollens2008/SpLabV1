using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace BusinessLogic
{
    class ListOperations
    {
        private List<DllNode> mainList = new List<DllNode>();       
        public List<DllNode> MainList
        {
            get { return mainList; }
            set { mainList = value; }
        }
        public void addNewElement(string filepath)
        {
            FileInfo fileInf = new FileInfo(filepath);
            if (fileInf.Exists)
            {
                
                mainList.Add(new DllNode(fileInf.Name, FileVersionInfo.GetVersionInfo(filepath).FileVersion, fileInf.LastWriteTime.ToString()));
            }
        }
        public void deleteElement(int index)
        {
            mainList.Remove(mainList[index]);
        }
        public void editElement(int index, string name, string version, string lastchange)
        {
            MainList[index].Name = name;
            MainList[index].Vers = version;
            MainList[index].Lastchange = lastchange;
        }
        public void deleteList()
        {
            mainList = new List<DllNode>();
        }
        public void setList(List<DllNode> dllNodes) 
        {
            mainList = dllNodes;
        }

    }
}
