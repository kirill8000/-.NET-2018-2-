using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static string Transorm(string s1, string s2)
        {
            for (; !string.IsNullOrEmpty(s2) && !string.IsNullOrEmpty(s1);)
            {
                s1 = s1.Replace($"{s2[0]}", $"{s2[0]}{s2[0]}");
                s2 = s2.Replace($"{s2[0]}", string.Empty);
            }

            return s1;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите первую строку: ");
            var s1 = Console.ReadLine();
            Console.Write("Введите вторую строку: ");
            var s2 = Console.ReadLine();
            Console.WriteLine($"Результирующая строка: {Transorm(s1, s2)}");
        }
    }
}
