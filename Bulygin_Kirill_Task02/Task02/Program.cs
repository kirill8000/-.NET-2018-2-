using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void ReplacePozitiveByZeros(int[ , , ] ar)
        {
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(1); j++)
                {
                    for (int k = 0; k < ar.GetLength(2); k++)
                    {
                        if (ar[i, j, k] > 0)
                            ar[i, j, k] = 0;

                    }
                }
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
