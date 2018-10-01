using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParallelLibrary1
{
    class Task8
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
            Task task = new Task(new Action(Test));
            task.Start();
 
            Console.WriteLine("Waiting for task to complete.");
            task.Wait();
            Console.WriteLine("Task Completed.");            
            task = new Task(new Action(Test));
            task.Start();
            Console.WriteLine("Waiting 2 secs for task to complete.");
            task.Wait(2000);
            Console.WriteLine("Wait ended - task completed.");
            
            Console.WriteLine("Main method complete. Press any key to finish.");
        }
    }
}
