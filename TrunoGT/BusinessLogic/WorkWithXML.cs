using System.Collections.Generic;
using System.Xml;
namespace BusinessLogic
{
    class WorkWithXML
    {
       
        public IEnumerable<DllNode> readFile(string fileName)
        {
            List<DllNode> dllList = new List<DllNode>();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(fileName);
            XmlElement xRoot = xDoc.DocumentElement;
            string name = "";
            string version = "";
            string changedate = "";
            foreach (XmlNode node in xRoot)
            {
                if (node.Attributes.Count > 0)
                {
                    XmlNode attr = node.Attributes.GetNamedItem("name");
                    if (attr != null)
                    {
                        name = attr.Value;
                    }
                }

                foreach (XmlNode childNode in node.ChildNodes)
                {
                    if (childNode.Name == "version")
                    {
                        version = childNode.Value;
                    }
                    else if (childNode.Name == "changedate")
                    {
                        changedate = childNode.Value;
                    }
                }

                dllList.Add(new DllNode(name, version, changedate));


            }

            return dllList;
        }


        public void writeFile(string fileName,List<DllNode> dllNodes)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(fileName);
            XmlElement xRoot = xDoc.DocumentElement;
            XmlElement xname = xDoc.CreateElement("name");
            XmlElement xversion = xDoc.CreateElement("version");
            XmlElement xchangedate = xDoc.CreateElement("changedate");

            
        }
    }
}
