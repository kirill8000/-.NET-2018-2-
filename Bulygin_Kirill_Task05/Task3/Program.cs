using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {

        static double ReadDouble(Func<double, bool> predicate)
        {
            var culture = CultureInfo.CurrentCulture;
            double n;
            string nstr = Console.ReadLine();
            while (!Double.TryParse(nstr, NumberStyles.Any, culture, out n) || !predicate(n))
            {
                Console.Write("Ошибка! Попробуйте еще раз: ");
                nstr = Console.ReadLine();
            }

            return n;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите сторону A: ");
            var a = ReadDouble(d => d > 0);
            Console.Write("Введите сторону B: ");
            var b = ReadDouble(d => d > 0);
            Console.Write("Введите сторону C: ");
            var c = ReadDouble(d => d > 0);
            var triangle = new Triangle(a, b, c);
            Console.WriteLine($"Перииметр: {triangle.Perimeter}\nПлощадь: {triangle.Square}");
        }
    }
}
