using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDelegateEvent1
{
    class Client
    {
        private void ShowMessage(object sender, MyEventArgs e)
        {
            Console.WriteLine("捕捉到：{0}", e.KeyChar);
        }
        public Client(UserInputMonitor m)
        {
            m.OnUserRequest += new UserInputMonitor.UserRequest(this.ShowMessage);
            //m.OnUserRequest+=new m.UserRequest(this.ShowMessage);
            //注意这种写法是错误的，因为委托是静态的
        }

        private void ShowMessage(object sender, MyStrEventArgs e)
        {
            Console.WriteLine("捕捉到：{0}", e.KeyChar);
        }

        public Client(UserStrInputMonitor m)
        {
            m.OnUserStrRequest += new UserStrInputMonitor.UserStrRequest(this.ShowMessage);
            //m.OnUserRequest+=new m.UserRequest(this.ShowMessage);
            //注意这种写法是错误的，因为委托是静态的
        }

    }
}
