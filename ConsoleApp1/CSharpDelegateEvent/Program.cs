using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDelegateEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInputMonitor monitor = new UserInputMonitor();
            Client client = new Client(monitor);
            monitor.Run();
        }
    }
}
