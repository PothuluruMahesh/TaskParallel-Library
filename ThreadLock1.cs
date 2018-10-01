using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParallelLibrary1
{
    class ThreadLock1
    {
        void Test1()
        {
            for(int i=0;i<=10;i++)
            {
                Thread.Sleep(800);
                Console.WriteLine("Test1 :" + i);
            }
        }
        void Test2()
        {
            for (int i = 0; i <= 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Test2 :" + i);
            }
        }
         void Test3()
        {
            for (int i = 0; i <= 10; i++)
            {
                Thread.Sleep(2000);
                Console.WriteLine("Test3 :" + i);
            }
        } 
        static void Main(string[] args)
        {
            Console.WriteLine("From Main Thread Starting..............");
            ThreadLock1 tl = new ThreadLock1();
            Thread t1 = new Thread(tl.Test1);
            Thread t2 = new Thread(tl.Test2);
            Thread t3 = new Thread(tl.Test3);
            t1.Name = "Test1";
            t2.Name = "Test2";
            t3.Name = "Test3";
            t1.Start();
            t2.Start();
            t3.Start();
            t1.Join();
            t2.Join();
            t3.Join();

            Console.WriteLine("From Main Thread Ending..................");
        }
    }
}
