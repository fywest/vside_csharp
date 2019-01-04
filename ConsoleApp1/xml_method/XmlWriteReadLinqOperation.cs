using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace xml_method
{
    internal class XmlWriteReadOperation
    {

    }
    internal class XmlWriteReadLinqOperation
    {

        public void CreatXmlTree(string xmlPath)
        {
            XElement xElement = new XElement(
                new XElement("BookStore",
                    new XElement("Book",
                        new XElement("Name", "C#入门", new XAttribute("BookName", "C#")),
                        new XElement("Author", "Martin", new XAttribute("Name", "Martin")),
                        new XElement("Adress", "上海"),
                        new XElement("Date", DateTime.Now.ToString("yyyy-MM-dd"))
                        ),
                    new XElement("Book",
                        new XElement("Name", "WCF入门", new XAttribute("BookName", "WCF")),
                        new XElement("Author", "Mary", new XAttribute("Name", "Mary")),
                        new XElement("Adress", "北京"),
                        new XElement("Date", DateTime.Now.ToString("yyyy-MM-dd"))
                        )
                        )
                );

            //需要指定编码格式，否则在读取时会抛：根级别上的数据无效。 第 1 行 位置 1异常
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = new UTF8Encoding(false);
            settings.Indent = true;
            XmlWriter xw = XmlWriter.Create(xmlPath, settings);
            xElement.Save(xw);
            //写入文件
            xw.Flush();
            xw.Close();
        }




        public void WriteXml(string xmlPath)
        {
            XElement xElement = new XElement(
                new XElement("Store",
                    new XElement("Book", "技术类",
                        new XElement("Name", "C#入门", new XAttribute("BookName", "C#")),
                        new XElement("Author", "Martin", new XAttribute("Name", "Zery")),
                        new XComment("以下为注释"),//xml注释
                        new XElement("Date", DateTime.Now.ToString(), new XAttribute("PublicDate", DateTime.Now.ToString()))
                        ))
                );

            XmlWriter xw = XmlWriter.Create(xmlPath);
            //保存到XmlWriter
            xElement.Save(xw);
            //写入文件
            xw.Flush();
            xw.Close();

        }



    }
}
