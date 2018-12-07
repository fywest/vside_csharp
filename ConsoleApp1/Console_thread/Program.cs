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

        public int cnt = 0;
        public  void Count()
        {
            while(cnt < 30)
            {
                cnt++;
                Console.WriteLine(Thread.CurrentThread.Name + "count number is " + cnt);
                Thread.Sleep(100);
            }
        }

        public static void threadstart_test()
        {
            Program obj0 = new Program();
            Thread.CurrentThread.Name = "Thread 0 ";

            Program obj1 = new Program();
            Thread thread1 = new Thread(new ThreadStart(obj1.Count));
            thread1.Name = "Thread 1 ";

            Program obj2 = new Program();
            Thread thread2 = new Thread(new ThreadStart(obj2.Count));
            thread2.Name = "Thread 2 ";

            Program obj3 = new Program();
            Thread thread3 = new Thread(new ThreadStart(obj3.Count));
            thread3.Name = "Thread 3 ";

            obj0.Count();
            thread1.Start();
            thread2.Start();
            thread3.Start();
            Thread.Sleep(200);
            Console.WriteLine("200ms");
            thread2.Suspend();
            Thread.Sleep(200);
            Console.WriteLine("200ms");
            thread2.Resume();
            Thread.Sleep(200);
            Console.WriteLine("200ms");
            thread2.Join();
        }

        private static void ThreadFuncOne()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + ":i=" + i);
            }
            Console.WriteLine(Thread.CurrentThread.Name + " has finished");
        }

        static void Main(string[] args)
        {
            //thread_test();//write x,y
            //thread_go();//
            //thread_para();
            //threadstart_test();
            Thread.CurrentThread.Name = "MainThread";

            Thread newThread = new Thread(new ThreadStart(Program.ThreadFuncOne));
            newThread.Name = "NewThread";

            for (int j = 0; j < 20; j++)
            {
                if (j == 10)
                {
                    newThread.Start();
                    newThread.Join();
                }
                else
                {
                    Console.WriteLine(Thread.CurrentThread.Name + ":j=" + j);
                }
            }
            Console.Read();

        }


    }
}
