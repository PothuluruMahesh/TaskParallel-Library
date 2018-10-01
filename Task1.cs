using System;
using System.Threading.Tasks;

namespace TaskParallelLibrary1
{
    class Task1
    {
        static void Test()
        {
            Console.WriteLine("Hello Task");
        }
        static void Main(string[] args)
        {             
            
            Action ac= new Action(Test);
            Task t1 = new Task(ac);


            Task t2 = new Task(delegate
            {
                Test();
            });            
            Task t3 = new Task(() => Test());
            t1.Start();
            t2.Start();
            t3.Start();
            Console.WriteLine("Main method competed.");            
        }
    }
}
