using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static int Compare(string x, string y)
        {
            if (x.Length > y.Length) return 1;
            if (x.Length < y.Length) return -1;
            return String.Compare(x, y, StringComparison.Ordinal);
        }


        
        static void Main(string[] args)
        {
            var ar = new string[12];
            ArrayUtils.Sort(ar, Compare);
        }
    }
}
