using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Web;
using System.Xml.Linq;

namespace xml_method
{
    class Program
    {
        static void Main(string[] args)
        {
            /*=============Linq 读写XML==================*/
            string wxmlPath = @"F:\XmlTest\test.xml";
            XmlWriteReadLinqOperation writeReadLinq = new XmlWriteReadLinqOperation();
            // writeReadLinq.WriteXml(wxmlPath);
            writeReadLinq.CreatXmlTree(wxmlPath);




            string xmlPath = @"F:\XmlTest\XML.xml";
            //string xmlPath = @"C:\Users\zery.zhang\Desktop\ProjectDemo\XML.xml";
            /*
             * 1 三者之间的关系用图画出
             * 2 XMLElement 主要是针对节点的一些属性进行操作
             * 3 XMLDocument 主要是针对节点的CUID操作
             * 4 XMLNode 为抽象类，做为以上两类的基类，提供一些操作节点的方法 
             */

            //===========C# to Xml==========//
            XmlOperation xmlOperation = new XmlOperation();
            //xmlOperation.Create(xmlPath);
            //xmlOperation.CreateAttribute(xmlPath);

            //xmlOperation.Delete(xmlPath);
            //xmlOperation.DeleteAttribute(xmlPath);

            //xmlOperation.Modify(xmlPath);
            //xmlOperation.ModifyAttribute(xmlPath);

            //xmlOperation.Select(xmlPath);
            //xmlOperation.SelectAttribute(xmlPath);
            /*=============Linq to Xml===========*/
            XmlOperationToLinq xOperation = new XmlOperationToLinq();
            // xOperation.Create(xmlPath);
            /*
             *1 给指定的XML节点的所有子节点增加一个节点，并增加属性
             *2 删除指定节点的子节点的指定属性
             *3 
             */
            string lxmlPath = @"F:\XmlTest\test.xml";
            xOperation.Create(lxmlPath);
            xOperation.CreateAttribute(lxmlPath);
            //xperation.Delete(lxmlPath);
            //xOperation.DeleteAttribute(lxmlPath);
            // xOperation.ModifyAttribute(lxmlPath);

            /*=============C# 读写XML===============*/
            XmlWriteReadOperation writeRead = new XmlWriteReadOperation();


            Console.Read();

        }
    }
}
