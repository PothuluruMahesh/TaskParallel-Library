using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TaskParallelLibrary1
{
    class Thread3
    {
        static void Test1()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Form Test :" + i);
            }
        }
        static void Test2()
        {
            for (int i = 1; i <= 100; i++)
            {
                if(i==50)
                {
                    Thread.Sleep(5000);//main also waiting until thraed2 exicution completed.
                }
                Console.WriteLine("Form Test1 :" + i);
            }
        }static void Test3()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Form Test1 :" + i);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Start.......");
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);
            t1.Start();
            t2.Start();
            t3.Start();

           // t1.Join();//t1.Join(10000); this time Main don't wait for the t1 exicution. after main t1 thread exicute
           // t2.Join();
           // t3.Join();
            Console.WriteLine("Main End.......");
        }
    }
}
