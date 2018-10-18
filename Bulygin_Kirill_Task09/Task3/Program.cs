using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine(
                    "Путь к файлу необходимо передавать через   через командную строку, а именно: Task1.exe textfile\n" +
                    "• Task1.exe - исполняемый файл приложения\n" +
                    "• textfile - файл с исходными данными");
                Console.ReadKey();
                Environment.Exit(1);
            }

            if (!File.Exists(args[0]))
            {
                Console.WriteLine("Файл не найден");
                Environment.Exit(1);
            }

            var text = File.ReadAllText(args[0]);

            var result = from g in Regex.Split(text, @"\W+")
                                   .Where(s => !String.IsNullOrWhiteSpace(s))
                                   .Select(s => s.ToLower())
                                   .GroupBy(s => s)
                select new { Word = g.Key, Count = g.Count() };
            /*var t = from g in (from i in Regex.Split(text, @"\W+") where !String.IsNullOrWhiteSpace(i) group i by i) select new { Word = g.Key, Count = g.Count() };*/
            foreach (var v in result)
            {
                Console.WriteLine($"{v.Word} - {v.Count}");
            }
        }
    }
}
