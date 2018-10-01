using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TaskParallelLibrary1
{
    class AccountManger
    {
        Account fA;Account TA; double ATT;
        public AccountManger(Account i,Account j,double k)
        {
            this.fA = i;
            this.TA = j;
            this.ATT = k;
        }
        public void Transfor()
        {
            
               object lock1, lock2;
               if(fA.ID < TA.ID)
               {
                   lock1 = fA;
                   lock2 = TA;
               }
               else
               {
                   lock1 = TA;
                   lock2 = fA;
               }
            Console.WriteLine( Thread.CurrentThread.Name + " Trying to take object lock " + ((Account)lock1).ID.ToString());
            lock (lock1)
               {
                Console.WriteLine(Thread.CurrentThread.Name + "  take the object lock " + ((Account)lock1).ID.ToString());
                Console.WriteLine(Thread.CurrentThread.Name+" Suspend 1 second");
                   Thread.Sleep(1000);
                   lock(lock2)
                   {
                        Console.WriteLine(Thread.CurrentThread.Name + " Aquere Lock on "+((Account)lock2).ID.ToString());
                        fA.WithDraw(ATT);
                        TA.Diposite(ATT);
                        Console.WriteLine(Thread.CurrentThread.Name + " Transfor " + ATT.ToString() + " from " + fA.ID.ToString());
                   }
               }
            /*

             lock (fA)
             {
                 Thread.Sleep(1000);
                 lock (TA)
                 {
                    Console.WriteLine("This code will Not be Exicute");
                     fA.WithDraw(ATT);
                     TA.Diposite(ATT);
                 }
             }
             */
        }
    }
}
