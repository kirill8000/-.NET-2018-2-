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
        static double AverageLength(string[] words) => words.Average(s => s.Length);
        static string TrimString(string s) => Regex.Replace(s, "[\\W]", " ");

        static void Main(string[] args)
        {
            Console.Write("Введите строку для анализа: ");
            var s = Console.ReadLine();
            var average = 0.0;
            if (s != string.Empty)
            {
                average = AverageLength(TrimString(s).Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries));
            }
            Console.WriteLine($"Средняя длина слова в строке: {average}");
        }
    }
}
