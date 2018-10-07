using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static int TimeMatchesCount(string input) =>
            Regex.Matches(input, @"\b([01]?[0-9]|[2][0-3]):[0-5][0-9]\b").Count;
        
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            var text = Console.ReadLine();
            int count = TimeMatchesCount(text);
            Console.WriteLine($"Время в тексте присутствует {count} раз");
            
        }
    }
}
