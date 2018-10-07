using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Print(int n, TimeSpan t1, TimeSpan t2)
        {
            const int aligin = -40;
            Console.Write($"{n, -6}");
            double diff;
            if (t1 > t2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{t1, aligin}");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{t2, aligin}");
                diff = (double)t1.Ticks / t2.Ticks;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{t1,aligin}");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{t2,aligin}");
                diff = (double)t2.Ticks / t1.Ticks;
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{diff,aligin:F}");
        }
        static (TimeSpan str, TimeSpan builder) ExecutionTime(int n)
        {
            var l = '*';
            Stopwatch watch = Stopwatch.StartNew();
            string str = "";
            
            for (int i = 0; i < n; i++)
            {
                str += l;
            }
            watch.Stop();
            var t1 = watch.Elapsed;

            watch.Restart();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.Append(l);
            }
            var s = sb.ToString();
            watch.Stop();
            var t2 = watch.Elapsed;
            return (t1, t2);
        }
        static void Main(string[] args)
        {
            var r = new Random();
            Console.WriteLine($"{"№", -6}{"String", -40}{"StringBulder", -40}{"Разница, раз", -40}");
            for (int i = 0; i <= 1000; i+=50)
            {
                var times = ExecutionTime(i);
                Print(i, times.str, times.builder);
                GC.Collect();
            }
        }
    }
}
