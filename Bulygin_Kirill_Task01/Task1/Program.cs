using System;


namespace Task1
{
    class Program
    {
        static int ReadPositiveInt()
        {
            int n;
            string nstr = Console.ReadLine();
            while (!Int32.TryParse(nstr, out n) || n <= 0)
            {
                Console.Write("Ошибка! Нужно ввести целое положительное число. Попробуте еще раз: ");
                nstr = Console.ReadLine();
            }
            return n;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Программа находит площадь прямоугольника");
            Console.Write("Введите длину (целое число): ");
            var a = ReadPositiveInt();
            Console.Write("Введите ширину (целое число): ");
            var b = ReadPositiveInt();
            Console.WriteLine($"Площадь прямоугольника равна {a * b}");
        }
    }
}
