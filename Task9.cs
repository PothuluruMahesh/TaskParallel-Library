using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParallelLibrary1
{
    class Task9 
    {
        static void Test()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Task - iteration {0}", i);
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {           
            Task task1 = new Task(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Task 1 - iteration {0}", i);                    
                    Thread.Sleep(1000);
                }
                Console.WriteLine("Task 1 complete");
            });
            Task task2 = new Task(() =>
            {
                Console.WriteLine("Task 2 complete");
            });
            task1.Start();
            task2.Start();
            Console.WriteLine("Waiting for tasks to complete.");
            Task.WaitAll(task1, task2);
            Console.WriteLine("Tasks Completed.");
            Console.WriteLine("Main method complete.");
            
        }
    }
}
