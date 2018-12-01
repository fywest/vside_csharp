using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace friend_unsigned_B
{
    class Program
    {
        static void Main(string[] args)
        {
            // Access an internal type.  
            Class1 inst1 = new Class1();
            inst1.Test();

            Class2 inst2 = new Class2();
            // Access an internal member of a public type.  
            inst2.Test();

            System.Console.ReadLine();
        }
    }
}
