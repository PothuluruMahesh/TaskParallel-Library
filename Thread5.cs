using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TaskParallelLibrary1
{
    class Thread5
    {
        static void Test(object j)
        {
          
                Console.WriteLine("Form Test :" + j);
            
        }
        static void Test1(object j)
        {
                Console.WriteLine("Form Test1 :" + j);
           
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Start.......");
            ParameterizedThreadStart ts = new ParameterizedThreadStart(Test);
            ParameterizedThreadStart ts1 = new ParameterizedThreadStart(Test1);
            
         //   ThreadStart ts = new ThreadStart(Test);
         //   ThreadStart ts1 = new ThreadStart(Test1);

            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(ts);
            t1.Start(10);
            t2.Start(20);

            t1.Join();
            t2.Join();
            Console.WriteLine("Main End.......");
        }
    }
}

