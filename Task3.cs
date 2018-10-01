using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskParallelLibrary1
{
    class Task3
    {
        static void Test()
        {
            for(int i=0;i<=100;i++)
            {
                Console.WriteLine("Test :" + i);
            }
        }
        static void Test1()
        {
            for(int i=0;i<=100;i++)
            {
                Console.WriteLine("Test1 :" + i);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("From Main Start...........");
            Task t1 = new Task(Test);
            Task t2 = new Task(Test);
            t1.Start();
            t2.Start();
            t1.Wait();
            t2.Wait();
            Console.WriteLine("Id of Test1 is :"+t1.Id);
            Console.WriteLine("Id of Test2 is :L"+t2.Id);
            Console.WriteLine("From Main End...........");
        }
    }
}
