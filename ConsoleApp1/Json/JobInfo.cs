using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json
{
    class JobInfo
    {

        public string TaskRoleSpaces { get; set; }
        public string TaskRoles { get; set; }
        public string ProxyUserID { get; set; }
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string UserSystemName { get; set; }
        public string OperationName { get; set; }
        public string OperationValue { get; set; }
        public string OperationValueText { get; set; }
        public DateTime SignDate { get; set; }
        public string Comment { get; set; }
        public string FormDataHashCode { get; set; }
        public string SignatureDivID { get; set; }
    }

    public class Info
    {
        public string phantom { get; set; }
        public string id { get; set; }
        public data data { get; set; }
    }

    public class data
    {
        public int MID { get; set; }
        public string Name { get; set; }
        public string Des { get; set; }
        public string Disable { get; set; }
        public string Remark { get; set; }
    }


    public class Data
    {
        public Boolean success { get; set; }
        public Data1 data { get; set; }
    }

    public class Data1
    {
        public Int32 id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public Int32 qty { get; set; }
        public List<Data2> bins { get; set; }
    }

    public class Data2
    {
        public string code { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public Int32 qty { get; set; }
    }

    class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Demage { get; set; }

        public override string ToString()
        {
            return "Id:" + Id + " Name:" + Name + " Demage:" + Demage;
        }
    }
}
