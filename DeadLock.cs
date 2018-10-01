using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TaskParallelLibrary1
{
    class DeadLock
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main STarted..........");
            Account ac1 = new Account(10210, 5000);
            Account ac2 = new Account(20319, 2000);

            AccountManger am = new AccountManger(ac1, ac2, 2000);
            Thread t1 = new Thread(am.Transfor);
            t1.Name = "T1";

            AccountManger am1 = new AccountManger(ac2, ac1, 1000);
            Thread t2 = new Thread(am1.Transfor);
            t2.Name = "T2";

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();
            Console.WriteLine("Main Ended............");
        }
    }
}
