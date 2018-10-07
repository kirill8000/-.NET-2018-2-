using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    internal class Program
    {
        private static int ReadPositiveInt()
        {
            int n;
            var nstr = Console.ReadLine();
            while (!int.TryParse(nstr, out n) || n <= 0)
            {
                Console.Write("Ошибка! Нужно ввести целое положительное число. Попробуте еще раз: ");
                nstr = Console.ReadLine();
            }
            return n;
        }

        private static int[] GetRandomArray(int size, Random r)
        {
            var ar = new int[size];
            for (var i = 0; i < ar.Length; i++)
            {
                ar[i] = r.Next();
            }

            return ar;
        }

        private static void PrintArray(int[] ar)
        {
            foreach (var i in ar)
            {
                Console.Write($"\t{i}");
            }
            Console.WriteLine();
        }

        private static void Main(string[] args)
        {
            Console.Write("Введите длину массива: ");
            var length = ReadPositiveInt();
            var ar = GetRandomArray(length, new Random());
            Console.WriteLine("\nСлучайно сгенерированный массив: ");
            PrintArray(ar);
            Alghoritm.Sort(ar);
            Console.WriteLine("\nОтсортированный массив: ");
            PrintArray(ar);
            Console.WriteLine($"\nМаксимум массива:\t{Alghoritm.Max(ar)}");
            Console.WriteLine($"\nМинимум массива:\t{Alghoritm.Min(ar)}");
        }
    }
}
