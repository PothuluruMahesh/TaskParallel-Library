using System;
using System.Threading.Tasks;
using System.Threading;

namespace TaskParallelLibrary1
{
    class Task6
    {
        static void Test()
        {
            Console.WriteLine("Test exicution started");
            Thread.Sleep(3000);
            Console.WriteLine("Test exicution ended");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("From Main start");
            // var t1 = new Task(()=> { Test(); });
            // var t1 = new Task(Test);
            // t1.Start();
            var t1 = Task.Factory.StartNew(Test);
            Console.WriteLine("From Main end");
            Console.ReadLine();
        }
    }
}