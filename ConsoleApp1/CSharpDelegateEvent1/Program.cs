using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDelegateEvent1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("please input selection for char or string");
            string inputString = Console.ReadLine();
            Console.WriteLine("please input {0}", inputString);
 
            UserInputMonitor monitor_char = new UserInputMonitor();
            UserStrInputMonitor monitor_string = new UserStrInputMonitor();
            Client client_char=new Client(monitor_char);
            Client client_string = new Client(monitor_string);
            if (inputString == "char")
            {
                monitor_char.Run();
            }
            else if (inputString == "string")
            {
                monitor_string.Run();
            }
            

        }
    }
}
