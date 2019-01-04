using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace xml_method
{
    class XmlOperationToLinq
    {
        //其它操作
        public void OtherOperaton()
        {
            //加文件头
        }



        public void Create(string xmlPath)
        {
            XDocument xDoc = XDocument.Load(xmlPath);
            XElement xElement = xDoc.Element("BookStore");
            xElement.Add(new XElement("Test", new XAttribute("Name", "Zery")));
            xDoc.Save(xmlPath);
        }

        public void CreateAttribute(string xmlPath)
        {
            XDocument xDoc = XDocument.Load(xmlPath);
            IEnumerable<XElement> xElement = xDoc.Element("BookStore").Elements("Book");
            foreach (var element in xElement)
            {
                element.SetAttributeValue("Name", "Zery");
            }
            xDoc.Save(xmlPath);
        }

        public void Delete(string xmlPath)
        {
            XDocument xDoc = XDocument.Load(xmlPath);
            XElement element = (XElement)xDoc.Element("BookStore").Element("Book");
            element.Remove();
            xDoc.Save(xmlPath);
        }

        public void DeleteAttribute(string xmlPath)
        {
            XDocument xDoc = XDocument.Load(xmlPath);
            //不能跨级取节点
            XElement element = xDoc.Element("BookStore").Element("Book").Element("Name");
            element.Attribute("BookName").Remove();
            xDoc.Save(xmlPath);
        }

        public void ModifyAttribute(string xmlPath)
        {
            XDocument xDoc = XDocument.Load(xmlPath);
            XElement element = xDoc.Element("BookStore").Element("Book");
            element.SetAttributeValue("BookName", "ZeryTest");
            xDoc.Save(xmlPath);
        }


    }
}
