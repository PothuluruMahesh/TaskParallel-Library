using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParallelLibrary1
{
    class Task2
    {
        static void Test()
        {
            int count = 0;
            for (int i = 0; i <= 1000000; i++)
            {
                count++;
               
            }
            Console.WriteLine(count);
        }static void Test1()
        {
            int count = 0;
            for (int i = 0; i <= 1000000; i++)
            {
                count++;
               
            }
            Console.WriteLine(count);
        }
        static void Main(string[] args)
        {
            Stopwatch st1 = new Stopwatch();
            Thread t2 = new Thread(Test);
            st1.Start();
            t2.Start();
            t2.Join();
            st1.Stop();
            Console.WriteLine("Thread Taking time is :" + st1.ElapsedMilliseconds);

            Stopwatch st = new Stopwatch();
            Task t1 = new Task(Test1);
            st.Start();
            t1.Start();
            
            st.Stop();
            Console.WriteLine("Task Taking time is :"+st.ElapsedMilliseconds);
            



        }
    }
}
