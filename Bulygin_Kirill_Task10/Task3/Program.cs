using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var ar = new int[] {122, 34, 432, 432, 334, 2, 4, 53, 1};
            var s = new ArrayUtils();
            s.SortComplete += (sender, eventArgs) => {
                foreach (var i in ar)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            };
            s.SortAsync(ar, (i, i1) => i.CompareTo(i1)).Wait();
        }
    }
}
