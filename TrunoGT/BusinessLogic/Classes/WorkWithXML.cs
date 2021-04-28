using BusinessLogic.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
namespace BusinessLogic
{
    public class WorkWithXML:IWorkWithXml
    {

		BinNodes context = new BinNodes();
		public void WriteToBD(List<DllNode> dlllist)
		{
			{
				try
				{
					context.DllList.RemoveRange(context.DllList.ToList());
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex);
				}
				context.SaveChanges();
				for (int i = 0; i < dlllist.Count; i++)
				{
					context.DllList.Add(dlllist[i]);
					Console.WriteLine(context.DllList.ToList()[i].Name);
				}
				context.SaveChanges();
			}

		}

		public List<DllNode> ReadFromBD()
		{
			List<DllNode> dlllist = new List<DllNode>();
			{
				try
				{
					dlllist = context.DllList.ToList();
				}
				catch (Exception e) { Console.WriteLine(e); }
			}
			return dlllist;
		}

		public  IEnumerable<DllNode> readFile(string fileName)
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
                        version = childNode.InnerText;
                    }
                    else if (childNode.Name == "changedate")
                    {
                        changedate = childNode.InnerText;
                    }
                }
                dllList.Add(new DllNode(name, version, changedate));
            }

            return dllList;
        }



        public static void writeNodeFile(string fileName, DllNode dllNode)
        {          
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(fileName);
            XmlElement xRoot = xDoc.DocumentElement;
            XmlElement xdll = xDoc.CreateElement("dll");
            XmlAttribute xname = xDoc.CreateAttribute("name");
            XmlElement xversion = xDoc.CreateElement("version");
            XmlElement xchangedate = xDoc.CreateElement("changedate");
            XmlText xTextName = xDoc.CreateTextNode(dllNode.Name);
            XmlText xTextVersion = xDoc.CreateTextNode(dllNode.Vers);
            XmlText xTextChangeDate = xDoc.CreateTextNode(dllNode.Lastchange);
            xname.AppendChild(xTextName);
            xversion.AppendChild(xTextVersion);
            xchangedate.AppendChild(xTextChangeDate);
            xdll.Attributes.Append(xname);
            xdll.AppendChild(xversion);
            xdll.AppendChild(xchangedate);
            xRoot.AppendChild(xdll);
            xDoc.Save(fileName);
        }
        public void writeList(string fileName, List<DllNode> dllList)
        {
            deleteXML(fileName);
            foreach (DllNode dllNode in dllList)
            {
                writeNodeFile(fileName, dllNode);
            }
        }
        public static void deleteXML(string fileName)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(fileName);
            XmlElement xRoot = xDoc.DocumentElement;
            xRoot.RemoveAll();
            xDoc.Save(fileName);

        }      
    }
}
