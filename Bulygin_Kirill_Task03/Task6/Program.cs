using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void PrintFormat(string input)
        {
            if (Regex.IsMatch(input, @"^-?\d+[\.,]?\d*$"))
            {
                Console.WriteLine("Это число в обычной нотации");
            }
            else if (Regex.IsMatch(input, @"^-?\d[\.,]?\d*[Ee]-?\d+$"))
            {
                Console.WriteLine("Это число в научной нотации");
            }
            else
            {
                Console.WriteLine("Это не число");
            }
            
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            var input = Console.ReadLine();
            PrintFormat(input);
        }
    }
}
