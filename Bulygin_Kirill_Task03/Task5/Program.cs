using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static string ReplaceTags(string s) => Regex.Replace(s, @"<.*?>", "_");

        static void Main(string[] args)
        {
            Console.Write("Введите HTLM текст: ");
            var htmlText = Console.ReadLine();
            Console.WriteLine($"Результат замены: {ReplaceTags(htmlText)}");
        }
    }
}
