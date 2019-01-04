using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace xml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // 1.用XMLDocument来解析

            string path = "test.xml";
            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<book ISBN='1-861001-57-5'>" +
                        "<title>Pride And Prejudice</title>" +
                        "<price>19.95</price>" +
                        "</book>");
            doc.Save(path);
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("test.xml");
            

            //创建新节点 
            XmlElement nn = xmlDocument.CreateElement("image");
            nn.SetAttribute("imageUrl", "6.jpg");

            //XmlNode node = xmlDocument.SelectSingleNode("content/section/page/gall/folder");//定位到folder节点
            XmlNode node = xmlDocument.SelectSingleNode("book");
            node.AppendChild(nn);//附加新节点

            //保存
            xmlDocument.Save("test.xml");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            XElement root = XElement.Load("test.xml");
            foreach (XAttribute att in root.Attributes())
            {
                root.Add(new XElement(att.Name, (string)att));
            }
            //Console.WriteLine(root);
            MessageBox.Show(root.ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            IList<CarCost> resultList = new List<CarCost>();

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("car.xml");

            XmlNodeList xmlNodeList = xmlDocument.SelectSingleNode("Car").ChildNodes;
            foreach (XmlNode list in xmlNodeList)
            {
                CarCost carcost = new CarCost
                (
                    list.SelectSingleNode("ID").InnerText,
                    list.SelectSingleNode("uptime").InnerText,
                    list.SelectSingleNode("downtime").InnerText,
                    float.Parse(list.SelectSingleNode("price").InnerText)
                );
                resultList.Add(carcost);
            }

            IEnumerator enumerator = resultList.GetEnumerator();
            string carInfo="";
            while (enumerator.MoveNext())
            {
                CarCost carCost = enumerator.Current as CarCost;
                //Console.WriteLine(carCost.ID + " " + carCost.UpTime + " " + carCost.DownTime + " " + carCost.Price);
                carInfo += (carCost.ID + " " + carCost.UpTime + " " + carCost.DownTime + " " + carCost.Price+"\n");
            }
            MessageBox.Show(carInfo);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string xml = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>"
+ "<Flow>"
    + "<FlowInfo FlowID=\"100\" FlowName=\"某个数据\">"
        + "<NodeConfig NodeName=\"阿士大夫\" NodeID=\"10001\">"
          + "<TabConfigList>"
            + "<TabConfig TabName=\"是说\">"
              + "<FormList>"
                + "<Form ID=\"formXMXX\" Name=\"是说\" FormPath=\"CRYW/XMSL.aspx\" Editable=\"true\" Visible=\"false\"/>"
              + "</FormList>"
            + "</TabConfig>"
            + "<TabConfig TabName=\"消息\">"
              + "<FormList>"
                + "<Form ID=\"formsAS\" Name=\"消息\" FormPath=\"。。。\" Editable=\"true\" Visible=\"false\"/>"
              + "</FormList>"
            + "</TabConfig>"
          + "</TabConfigList>"
          + "<ToolList>"
            + "<Tool Name=\"是的\" ID=\"btn_Save\" Visible=\"true\" Icon=\"icon-save\" OnClientClick=\"return validate(); \"/>"
             + "<Tool Name=\"放到\" ID=\"btn_Send\" Visible=\"true\" Icon=\"icon-back\" OnClientClick=\"return validate(); \"/>"
           + "</ToolList>"
        + "</NodeConfig>"
        + "<NodeConfig NodeName=\"阿士大夫1\"  NodeID=\"10006\">"
          + "<TabConfigList>"
            + "<TabConfig TabName=\"是说1\">"
              + "<FormList>"
                + "<Form ID=\"formASD\" Name=\"是说1\" FormPath=\"CRYW/XMSL.aspx\" Editable=\"true\" Visible=\"false\"/>"
                + "<Form ID=\"formAEW\" Name=\"是说1\" FormPath=\"CRYW/AAA.aspx\" Editable=\"true\" Visible=\"false\"/>"
              + "</FormList>"
            + "</TabConfig>"
            + "<TabConfig TabName=\"消息22\">"
              + "<FormList>"
                + "<Form ID=\"formQWER\" Name=\"消息22\" FormPath=\"。。。\" Editable=\"true\" Visible=\"false\"/>"
              + "</FormList>"
            + "</TabConfig>"
          + "</TabConfigList>"
          + "<ToolList>"
            + "<Tool Name=\"是的12\" ID=\"btn_Save\" Visible=\"true\" Icon=\"icon-save\" OnClientClick=\"return validate(); \"/>"
             + "<Tool Name=\"放到21\" ID=\"btn_Send\" Visible=\"true\" Icon=\"icon-back\" OnClientClick=\"return validate(); \"/>"
           + "</ToolList>"
        + "</NodeConfig>"
    + "</FlowInfo>"
    + "<FlowInfo FlowID=\"103\" FlowName=\"某个数据\">"
        + "<NodeConfig NodeName=\"阿士大夫\"  NodeID=\"10022\">"
          + "<TabConfigList>"
            + "<TabConfig TabName=\"是说\">"
              + "<FormList>"
                + "<Form ID=\"formDFHF\" Name=\"是说\" FormPath=\"CRYW/XMSL.aspx\" Editable=\"true\" Visible=\"false\"/>"
              + "</FormList>"
            + "</TabConfig>"
            + "<TabConfig TabName=\"消息\">"
              + "<FormList>"
                + "<Form ID=\"formWQRW\" Name=\"消息\" FormPath=\"。。。\" Editable=\"true\" Visible=\"false\"/>"
              + "</FormList>"
            + "</TabConfig>"
          + "</TabConfigList>"
          + "<ToolList>"
            + "<Tool Name=\"是的\" ID=\"btn_Save\" Visible=\"true\" Icon=\"icon-save\" OnClientClick=\"return validate(); \"/>"
             + "<Tool Name=\"放到\" ID=\"btn_Send\" Visible=\"true\" Icon=\"icon-back\" OnClientClick=\"return validate(); \"/>"
           + "</ToolList>"
        + "</NodeConfig>"
        + "<NodeConfig NodeName=\"阿士大夫1\"  NodeID=\"10012\">"
          + "<TabConfigList>"
            + "<TabConfig TabName=\"是说1\">"
              + "<FormList>"
                + "<Form ID=\"formFHDFGH\" Name=\"是说1\" FormPath=\"CRYW/XMSL.aspx\" Editable=\"true\" Visible=\"false\"/>"
              + "</FormList>"
            + "</TabConfig>"
            + "<TabConfig TabName=\"消息22\">"
              + "<FormList>"
                + "<Form ID=\"formASDS\" Name=\"消息22\" FormPath=\"。。。\" Editable=\"true\" Visible=\"false\"/>"
              + "</FormList>"
            + "</TabConfig>"
          + "</TabConfigList>"
         + "<ToolList>"
            + "<Tool Name=\"是的12\" ID=\"btn_Save\" Visible=\"true\" Icon=\"icon-save\" OnClientClick=\"return validate(); \"/>"
             + "<Tool Name=\"放到21\" ID=\"btn_Send\" Visible=\"true\" Icon=\"icon-back\" OnClientClick=\"return validate(); \"/>"
           + "</ToolList>"
        + "</NodeConfig>"
    + "</FlowInfo>"
+ "</Flow>";

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);//xml为你上面的一大串xml
            doc.Save("xpath.xml");

            string xpathMsg = "";
            var node = doc.SelectSingleNode("//FlowInfo[@FlowID='100']/NodeConfig[@NodeID='10006']//Form[@ID='formAEW']");
            if (node != null && node.Attributes != null)
            {
                xpathMsg = node.Attributes["Editable"].Value + "\n";
                //Console.WriteLine(node.Attributes["Editable"].Value);//true
                MessageBox.Show(xpathMsg);
            }
        }
    }
}