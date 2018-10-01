using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskParallelLibrary1
{
    class Task7
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int> { 2, 4, 5, 33, 54, 7, 8, 7, 9, 8, 89, 76, 77, 55, 9 };
            Parallel.ForEach(li, (i) => Console.WriteLine(i));//this is block for loop.

        }
    }
}
