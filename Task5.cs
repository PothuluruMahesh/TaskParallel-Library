using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParallelLibrary1
{
    class Task5
    {

        static void Test6()
        {
            long Count = 0;
            for (int i = 0; i <= 100000000; i++)
            {
                Count = Count + i;
            }
            Console.WriteLine(Count);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("From Main Start...........");
            Stopwatch sw = new Stopwatch();
            Thread t1 = new Thread(Test6);
            sw.Start();
            Parallel.For(0, 5, x => Test6());
            sw.Stop();
            Console.WriteLine("The elapsed time is :" + sw.ElapsedMilliseconds);
            Console.WriteLine("From Main End...........");
        }
    }
}
