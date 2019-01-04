using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace xml_method
{
    class XmlOperation
    {
        public void Create(string xmlPath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlPath);
            var root = xmlDoc.DocumentElement;//取到根结点

            XmlNode newNode = xmlDoc.CreateNode("element", "Name", "");
            newNode.InnerText = "Zery";

            //添加为根元素的第一层子结点
            root.AppendChild(newNode);
            xmlDoc.Save(xmlPath);
        }
        //属性
        public void CreateAttribute(string xmlPath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlPath);
            XmlElement node = (XmlElement)xmlDoc.SelectSingleNode("Collection/Book");
            node.SetAttribute("Name", "C#");
            xmlDoc.Save(xmlPath);
        }

        public void Delete(string xmlPath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlPath);
            var root = xmlDoc.DocumentElement;//取到根结点

            var element = xmlDoc.SelectSingleNode("Collection/Name");
            root.RemoveChild(element);
            xmlDoc.Save(xmlPath);
        }

        public void DeleteAttribute(string xmlPath)
        {

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlPath);
            XmlElement node = (XmlElement)xmlDoc.SelectSingleNode("Collection/Book");
            //移除指定属性
            node.RemoveAttribute("Name");
            //移除当前节点所有属性，不包括默认属性
            node.RemoveAllAttributes();

            xmlDoc.Save(xmlPath);

        }

        public void Modify(string xmlPath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlPath);
            var root = xmlDoc.DocumentElement;//取到根结点
            XmlNodeList nodeList = xmlDoc.SelectNodes("/Collection/Book");
            //xml不能直接更改结点名称，只能复制然后替换，再删除原来的结点
            foreach (XmlNode node in nodeList)
            {
                var xmlNode = (XmlElement)node;
                xmlNode.SetAttribute("ISBN", "Zery");
            }
            xmlDoc.Save(xmlPath);

        }

        public void ModifyAttribute(string xmlPath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlPath);
            XmlElement element = (XmlElement)xmlDoc.SelectSingleNode("Collection/Book");
            element.SetAttribute("Name", "Zhang");
            xmlDoc.Save(xmlPath);

        }

        public void Select(string xmlPath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlPath);
            //取根结点
            var root = xmlDoc.DocumentElement;//取到根结点
            //取指定的单个结点
            XmlNode singleNode = xmlDoc.SelectSingleNode("Collection/Book");

            //取指定的结点的集合
            XmlNodeList nodes = xmlDoc.SelectNodes("Collection/Book");

            //取到所有的xml结点
            XmlNodeList nodelist = xmlDoc.GetElementsByTagName("*");
        }

        public void SelectAttribute(string xmlPath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlPath);
            XmlElement element = (XmlElement)xmlDoc.SelectSingleNode("Collection/Book");
            string name = element.GetAttribute("Name");

        }
    }

}
