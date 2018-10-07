using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static long SumOfProgression(int first, int d, int count)
        {
            var last = first + d * (count - 1);

            return (first + last) * count / 2;
        }
        static void Main(string[] args)
        {
            int bound = 1000;
            int a = 3, b = 5;
            var s = SumOfProgression(a, a, (bound - 1) / a) + SumOfProgression(b, b, (bound - 1) / b) - SumOfProgression(a * b, a * b, (bound - 1) / (a * b));
            Console.WriteLine($"Cумма всех чисел меньше 1000, кратных 3 или 5 равна {s}");
        }
    }
}
