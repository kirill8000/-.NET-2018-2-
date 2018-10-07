using System;
using System.Text;


namespace Task2
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

        static string ConstructPattern(int n)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 1; i <= n; i++)
            {
                    builder.Append('*', i);
                if (i != n)
                    builder.Append('\n');
            }

            return builder.ToString();
        }

        static void Main(string[] args)
        {
            Console.Write("Введите цело число N: ");
            int n = ReadPositiveInt();
            Console.WriteLine(ConstructPattern(n));
        }
    }
}
