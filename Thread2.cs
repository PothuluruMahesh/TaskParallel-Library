using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TaskParallelLibrary1
{
    class Thread2
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
            Thread t1 = new Thread(Test);
            Thread t2 = new Thread(Test1);
            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();//after completion of t1 and t1 then main will be exicute
            Console.WriteLine("Main End.......");
        }
    }
}
