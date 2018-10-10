using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{

    class Program
    {
        static double ReadDouble()
        {
            return ReadDouble(d => true);
        }

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
            var point = new Point();
            Console.Write("Введите координату Х центра: ");
            point.X = ReadDouble();
            Console.Write("Введите координату Y центра: ");
            point.Y = ReadDouble();
            Console.Write("Введите радиус: ");
            double radius = ReadDouble(d => d > 0);
            var round = new Round(point, radius);
            Console.WriteLine($"Площадь круга: {round.Square}\nДлина окружности: {round.Length}");
        }
    }
}
