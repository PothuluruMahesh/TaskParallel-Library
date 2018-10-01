using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParallelLibrary1
{
    class Task4
    {
        
        static void Test1()
        {
            long Count = 0;
            for (int i = 0; i <= 100000000; i++)
            {
                Count =Count+i;
            }
            Console.WriteLine(Count);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("From Main Start...........");
            Stopwatch sw = new Stopwatch();
            Thread t1 = new Thread(Test1);
            sw.Start();
            t1.Start();
            t1.Join();
            sw.Stop();
            Console.WriteLine("The elapsed time is :" + sw.ElapsedMilliseconds);
            Console.WriteLine("From Main End...........");
        }
    }
}
