using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using LitJson;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Json
{
    //[DataContract]
    public class Student
    {
        //[DataMember]
        public int ID { get; set; }

        //[DataMember]
        public string Name { get; set; }

        //[DataMember]
        public int Age { get; set; }

        //[DataMember]
        public string Sex { get; set; }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string json = @"[{'TaskRoleSpaces':'','TaskRoles':'','ProxyUserID':'5d9ad5dc1c5e494db1d1b4d8d79b60a7','UserID':'5d9ad5dc1c5e494db1d1b4d8d79b60a7','UserName':'姓名','UserSystemName':'2234','OperationName':'送合同负责人','OperationValue':'同意','OperationValueText':'','SignDate':'2013-06-19 10:31:26','Comment':'同意','FormDataHashCode':'','SignatureDivID':''},{'TaskRoleSpaces':'','TaskRoles':'','ProxyUserID':'2c96c3943826ea93013826eafe6d0089','UserID':'2c96c3943826ea93013826eafe6d0089','UserName':'姓名2','UserSystemName':'1234','OperationName':'送合同负责人','OperationValue':'同意','OperationValueText':'','SignDate':'2013-06-20 09:37:11','Comment':'同意','FormDataHashCode':'','SignatureDivID':''}]
";


            List<JobInfo> jobInfoList = JsonConvert.DeserializeObject<List<JobInfo>>(json);

            string jsonMsg = "";

            foreach (JobInfo jobInfo in jobInfoList)
            {
                //Console.WriteLine("UserName:" + jobInfo.UserName + "UserID:" + jobInfo.UserID);
                jsonMsg+= ("UserName:" + jobInfo.UserName + "UserID:" + jobInfo.UserID+"\n");
            }
            MessageBox.Show(jsonMsg);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string json = @"[{'phantom':true,'id':'20130717001','data':{'MID':1019,'Name':'aaccccc','Des':'cc','Disable':'启用','Remark':'cccc'}}]";
            List<Info> infoList = JsonConvert.DeserializeObject<List<Info>>(json);

            string jsonMsg = "";

            foreach (Info info in infoList)
            {
                //Console.WriteLine("id:" + info.data.MID);
                jsonMsg += ("id:" + info.data.MID+"\n");
            }
            

            MessageBox.Show(jsonMsg);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string json = "{success:true,data:{id:100001,code:\"JTL-Z38005\",name:\"奥迪三轮毂\",location:\"A-202\",qty:100,bins:[{code:\"JTL-Z38001\",name:\"奥迪三轮毂\",location:\"A-001\",qty:100},{ code:\"JTL-Z38002\",name:\"奥迪三轮毂\",location:\"A-002\",qty:100}]}}";
            Data data = JsonConvert.DeserializeObject<Data>(json);

            string jsonMsg = "";

            foreach (var item in data.data.bins)
            {
                //输出：JTL-Z38001、JTL-Z38002，其它类似
                //Console.WriteLine(item.code);
                jsonMsg += (item.code + "\n");
            }
           


            MessageBox.Show(jsonMsg);
        }

        //litJson
        private void button4_Click(object sender, EventArgs e)
        {
            List<Skill> skillList = new List<Skill>();
            //右键引用，选择管理Nuget程序包，搜索litjson安装
            JsonData jsonData = JsonMapper.ToObject(File.ReadAllText("json.txt"));
           
            foreach (JsonData temp in jsonData)
            {
                Skill skill = new Skill();
                JsonData idValue = temp["id"];
                JsonData nameValue = temp["name"];
                JsonData demageValue = temp["demage"];
                int id = int.Parse(idValue.ToString());
                string name = nameValue.ToString();
                int demage = int.Parse(demageValue.ToString());
                skill.Id = id;
                skill.Name = name;
                skill.Demage = demage;
                skillList.Add(skill);
            }

            string jsonMsg = "";
            foreach (var s in skillList)
            {
                //Console.WriteLine(s);
                jsonMsg += (s+ "\n");
            }

            MessageBox.Show(jsonMsg);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<Student> lstStuModel = new List<Student>()
            {

            new Student(){ID=1,Name="张飞",Age=250,Sex="男"},
            new Student(){ID=2,Name="潘金莲",Age=300,Sex="女"}
            };

            //Json.NET序列化
            string jsonData = JsonConvert.SerializeObject(lstStuModel);

            MessageBox.Show(jsonData);

            string json = @"{ 'Name':'C#','Age':'3000','ID':'1','Sex':'女'}";
            Student descJsonStu = JsonConvert.DeserializeObject<Student>(json);//反序列化
            MessageBox.Show(string.Format("反序列化： ID={0},Name={1},Sex={2},Sex={3}", descJsonStu.ID, descJsonStu.Name, descJsonStu.Age, descJsonStu.Sex));

            Readjson();
            
        }

        public static void Readjson()
        {
            string jsonfile = "tsconfig1.json";

            using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
            {
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    JObject o = (JObject)JToken.ReadFrom(reader);
                    string a = o["lotname"].ToString();
                    var b = o["other"];
                    var c = b["lotaddress"];
                    var d = o["devices"];
                    foreach (JObject e in d)
                    {
                        var deviceID = e["deviceID"];
                        var name = e["name"];
                        var IP = e["IP"];
                    }
                }
            }

        }
    }
}
