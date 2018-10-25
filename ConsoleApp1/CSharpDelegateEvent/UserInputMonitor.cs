using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDelegateEvent
{
    class UserInputMonitor
    {
        public delegate void UserRequest(object sender, EventArgs e);
        //定义委托
        public event UserRequest OnUserRequest;
        //此委托类型类型的事件
        public void Run()
        {
            bool finished = false;
            do
            {
                if (Console.ReadLine() == "h")
                {
                    OnUserRequest(this, new EventArgs());
                }
            } while (!finished);
        }
    }
}
