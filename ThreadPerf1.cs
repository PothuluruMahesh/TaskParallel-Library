using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace TaskParallelLibrary1
{
    class ThreadPerf1
    {
        public static void Test1()
        {
            long count = 0;
            for (int i = 0; i <= 100000000; i++)
                count++;
            Console.WriteLine("The total count is " + count);
        }
        public static void Test2()
        {
            long count = 0;
            for (int i = 0; i <= 100000000; i++)
                count++;
            Console.WriteLine("The total count is " + count);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Started...........");
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            Test1();
            Test2();
            sw1.Stop();
            Console.WriteLine("The Total time Taken by without Threads :" + sw1.ElapsedMilliseconds);

            Stopwatch sw = new Stopwatch();
            sw.Start();
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            sw.Stop();
           
            Console.WriteLine("The Total time Taken by using Threads :"+sw.ElapsedMilliseconds);
            Console.WriteLine("\nMain End...........");
        }
    }
}
