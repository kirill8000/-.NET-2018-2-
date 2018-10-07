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
        static void ShowDifference(CultureInfo c1, CultureInfo c2)
        {
            const int aligin = -40;
            var random = new Random();
            var date = DateTime.Now;
            var dob = random.NextDouble() + random.Next();
            var integer = random.Next();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{c1.DisplayName, aligin}{c2.DisplayName, aligin}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Вывод чисел");
            Console.WriteLine("Стандартный:");
            Console.WriteLine($"{dob.ToString(c1), aligin}{dob.ToString(c2), aligin}");
            Console.WriteLine();
            Console.WriteLine("Экспоненциальный:");
            Console.WriteLine($"{dob.ToString("E",c1),aligin}{dob.ToString("E",c2),aligin}");
            Console.WriteLine($"{dob.ToString("e", c1),aligin}{dob.ToString("e", c2),aligin}");
            Console.WriteLine();
            Console.WriteLine("Общие: ");
            Console.WriteLine($"{dob.ToString("G", c1),aligin}{dob.ToString("G", c2),aligin}");
            Console.WriteLine();
            Console.WriteLine("Число:");
            Console.WriteLine($"{dob.ToString("N", c1),aligin}{dob.ToString("N", c2),aligin}");
            Console.WriteLine();
            Console.WriteLine("С фиксированной запятой: ");
            Console.WriteLine($"{dob.ToString("F", c1),aligin}{dob.ToString("F", c2),aligin}");
            Console.WriteLine();
            Console.WriteLine("Строка, дающая при обратном преобразовании идентичное число:");
            Console.WriteLine($"{dob.ToString("R", c1),aligin}{dob.ToString("R", c2),aligin}");
            Console.WriteLine();
            Console.WriteLine("Процент: ");
            Console.WriteLine($"{dob.ToString("P", c1),aligin}{dob.ToString("P", c2),aligin}");
            Console.WriteLine();
            Console.WriteLine("Валюта: ");
            Console.WriteLine($"{dob.ToString("C", c1),aligin}{dob.ToString("C", c2),aligin}");
            Console.WriteLine();
            Console.WriteLine("HEX (для целых): ");
            Console.WriteLine($"{integer.ToString("X", c1),aligin}{integer.ToString("X", c2),aligin}");
            Console.WriteLine();
            Console.WriteLine("Вывод дат");
            Console.WriteLine($"{date.ToString(c1), aligin}{date.ToString(c2), aligin}");
            Console.WriteLine($"{date.ToString("D", c1), aligin}{date.ToString("D", c2), aligin}");
            Console.WriteLine($"{date.ToString("F", c1), aligin}{date.ToString("F", c2), aligin}");
            Console.WriteLine($"{date.ToString("Y", c1), aligin}{date.ToString("Y", c2), aligin}");
            Console.WriteLine($"{date.ToString("f", c1), aligin}{date.ToString("f", c2), aligin}");
            Console.WriteLine($"{date.ToString("d", c1),aligin}{date.ToString("d", c2),aligin}");
            Console.WriteLine($"{date.ToString("U", c1),aligin}{date.ToString("U", c2),aligin}");
            Console.WriteLine($"{date.ToString("u", c1),aligin}{date.ToString("u", c2),aligin}");
        }

        static void Main(string[] args)
        {
            ShowDifference(new CultureInfo("ru-RU"), new CultureInfo("en-US"));
            Console.WriteLine("\n");
            ShowDifference(new CultureInfo("EN"), CultureInfo.InvariantCulture);
            Console.WriteLine("\n");
            ShowDifference(new CultureInfo("RU"), CultureInfo.InvariantCulture);
        }
    }
}
