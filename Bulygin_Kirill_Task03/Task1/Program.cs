using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static string[] SplitString(string s) => Regex.Split(s, @"\W");

        static void Main(string[] args)
        {
            Console.Write("Введите строку для анализа: ");
            var s = Console.ReadLine();
            var average = 0.0;
            if (s != string.Empty)
            {
                average = SplitString(s).Average(s1 => s1.Length);
            }
            Console.WriteLine($"Средняя длина слова в строке: {average}");
        }
    }
}
