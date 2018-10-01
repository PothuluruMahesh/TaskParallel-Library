using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TaskParallelLibrary1
{
    class ThreadLock2
    {
        void Test1()
        {
            lock (this)
            {
                for (int i = 0; i <= 10; i++)
                {

                    Thread.Sleep(800);
                    Console.WriteLine("Test1 :" + i);

                }
            }
        }
        void Test2()
        {
            lock (this)
            {
                for (int i = 0; i <= 10; i++)
                {
                    Thread.Sleep(800);
                    Console.WriteLine("Test2 :" + i);
                }
            }
        }
        void Test3()
        {
            lock (this)
            {
                for (int i = 0; i <= 10; i++)
                {
                    Thread.Sleep(800);
                    Console.WriteLine("Test3 :" + i);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("From Main Thread Starting..............");
            ThreadLock2 tl = new ThreadLock2();
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

