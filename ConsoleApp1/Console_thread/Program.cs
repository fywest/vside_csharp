using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Console_thread
{
    public delegate void ParameterizedThreadStart(object obj);
    class Program
    {
        static bool done;
        //
        static void thread_test()
        {
            Thread t = new Thread(WriteY);
            t.Start();
            while (true)
            {
                Console.Write("x");
            }
        }

        static void WriteY()
        {
            while (true)
            {
                Console.Write("y");
            }
        }

        //
        void go()
        {
            if (!done)
            {
                done = true;
                Console.WriteLine("Done");
            }

            //for(int cycles=0;cycles<5;cycles++)
            //{
            //    Console.WriteLine("?");
            //}
        }

        static void thread_go()
        {
            Program tt = new Program();
            new Thread(tt.go).Start();
            tt.go();
        }

        // 
        static void go_para(object upperCase)
        {
            bool upper = (bool)upperCase;
            Console.WriteLine(upper ? "HELLO" : "hello");
        }
        static void thread_para()
        {
            Thread t = new Thread(go_para);
            t.Start(true);
            go_para(false);
        }

        static void Main(string[] args)
        {
            //thread_test();//write x,y
            //thread_go();//
            thread_para();

        }


    }
}
