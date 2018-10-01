using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TaskParallelLibrary1
{
    class Thread4
    {
        static void Test()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Form Test :" + i);
            }
        }
        static void Test1()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Form Test1 :" + i);
            }
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Main Start.......");
             ThreadStart ts = new ThreadStart(Test);
             ThreadStart ts1 = new ThreadStart(Test1);

          //  ThreadStart ts = Test;
           // ThreadStart ts1 = Test1;

          //  ThreadStart ts=delegate (){ Test(); };
           // ThreadStart ts1=delegate (){ Test1(); };

           // ThreadStart ts= () =>Test();
           // ThreadStart ts1= () =>Test1();
            
            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(ts);
            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();
            Console.WriteLine("Main End.......");
        }
    }
}
