using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new DynamicArray<int>() {1, 2, 3, 4, 5};
            array.Add(11);
            array.Insert(0, 0);
            foreach (var i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}
