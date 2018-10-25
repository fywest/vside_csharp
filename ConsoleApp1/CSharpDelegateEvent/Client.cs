using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDelegateEvent
{
    class Client
    {

        private void ShowMessage(object sender, EventArgs e)
        {
            Console.WriteLine("HaHa!!");
        }
        public Client(UserInputMonitor m)
        {
            m.OnUserRequest += new UserInputMonitor.UserRequest(this.ShowMessage);
            //m.OnUserRequest+=new m.UserRequest(this.ShowMessage);
            //注意这种写法是错误的，因为委托是静态的
        }

    }
}
