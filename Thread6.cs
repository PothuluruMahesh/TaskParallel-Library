using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TaskParallelLibrary1
{
    class Thread6
    {
        static int Count=0;
        static int Count1=500;
         static void Test1()
        {
            while(true)
            {
                Console.WriteLine(Count);
                Count++;
            }
        }
        static void Test2()
        {
            while (true)
            {
                Console.WriteLine(Count1);
                Count1++;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main THread STart..........");
            
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            t1.Start();
            t2.Start();
            

            t1.Abort();
            t2.Abort();
            
            Console.WriteLine("\nMain Thread End........");

        }
    }
}
