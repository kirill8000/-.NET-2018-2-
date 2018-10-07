using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
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

        static string ConstructPattern(int n, int whiteSpaces = 0)
        {
            StringBuilder b = new StringBuilder();
            for (int i = n, k = 0; i > 0; i--, k++)
            {
                for (int j = 0; j < whiteSpaces; j++)
                {
                    b.Append(' ');
                }
                for (int j = 1; j <= n + k; j++)
                {
                    if (j < i)
                    {
                        b.Append(' ');
                    }
                    else
                    {
                        b.Append('*');
                    }
                }
                if(i != 1)
                    b.Append('\n');
            }

            return b.ToString();
        }
        static void Main(string[] args)
        {
            Console.Write("Введите цело число N: ");
            var n = ReadPositiveInt();
            for (int i = 1, spaces = n - 1; i <= n; i++, spaces--)
            {
                Console.WriteLine(ConstructPattern(i, spaces));
            }
        }
    }
}
