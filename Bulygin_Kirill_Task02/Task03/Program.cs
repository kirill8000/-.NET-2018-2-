using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static int SumOfPositiveElements(int[] ar) => ar.Where(i => i > 0).Sum();
        static void Main(string[] args)
        {
            var arr = new int[] {1, 2, 3, 4, 5};
            var res = arr.Where(x => x > 3);


        }
    }
}
