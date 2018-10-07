using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static int SumOfElementsWithEvenIndexes(int[,] ar)
        {
            int sum = 0;

            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(1); j++)
                {
                    if (i + j % 2 == 0)
                    {
                        sum += ar[i, j];
                    }
                }
            }

            return sum;
        }
        static void Main(string[] args)
        {
        }
    }
}
