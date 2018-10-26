using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDelegateEvent1
{
    class UserInputMonitor
    {
        public delegate void UserRequest(object sender, MyEventArgs e);
        //定义委托
        public event UserRequest OnUserRequest;
        //此委托类型类型的事件
        public void Run()
        {
            bool finished = false;
            do
            {
                string inputString = Console.ReadLine();
                if (inputString != "")
                    OnUserRequest(this, new MyEventArgs(inputString[0]));
            } while (!finished);
        }

    }

    class UserStrInputMonitor
    {
        public delegate void UserStrRequest(object sender, MyStrEventArgs e);
        //定义委托
        public event UserStrRequest OnUserStrRequest;
        //此委托类型类型的事件
        public void Run()
        {
            bool finished = false;
            do
            {
                string inputString = Console.ReadLine();
                if (inputString != "")
                    OnUserStrRequest(this, new MyStrEventArgs(inputString));
            } while (!finished);
        }

    }
}
