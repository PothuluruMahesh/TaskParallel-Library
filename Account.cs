using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskParallelLibrary1
{
    public class Account
    {
        int Id;
        double Balance;
        public Account(int i,double j)
        {
            this.Id = i;
            this.Balance = j;
        }
        public int ID
        {
            get { return Id; }
        }
        public void WithDraw(double amount)
        {
            Balance = Balance - amount;
        }
        public void Diposite(double amount)
        {
            Balance = Balance + amount;
        }
    }
}
