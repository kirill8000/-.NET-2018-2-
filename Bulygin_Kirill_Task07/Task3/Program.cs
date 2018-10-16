using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            IIndexable progression = new GeometricProgression(10, 2);
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(progression[i]);
            }
        }
    }
}
