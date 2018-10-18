using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void PrintCollection<T>(ICollection<T> collection)
        {
            Console.WriteLine($"Length {collection.Count}");
            foreach (var i in collection)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        static bool CompareCollections(IList<int> c1, IList<int> c2)
        {
            if (c1.Count != c2.Count) return false;
            for (int i = 0; i < c1.Count; i++)
            {
                if(c1[i] != c2[i])
                    return false;
            }

            return true;
        }
        static void Main(string[] args)
        {
            bool f = true;
            while (f)
            {
                var array = new DynamicArray<int>();
                var list = new List<int>();
                var r = new Random();
                for (int i = 0; i < 1000; i++)
                {
                    var t = r.Next();
                    list.Add(t);
                    array.Add(t);
                }

                f &= CompareCollections(list, array); 
                for (int i = 0; i < 250; i++)
                {
                    var index = r.Next(0, list.Count - 1);
                    list.RemoveAt(index);
                    array.RemoveAt(index);
                }

                f &= CompareCollections(list, array);

                for (int i = 0; i < 250; i++)
                {
                    var index = r.Next(0, list.Count - 1);
                    var tmp = r.Next();
                    list.Insert(index, tmp);
                    array.Insert(index, tmp);
                }

                f &= CompareCollections(list, array);
                Console.WriteLine("OK");
            }
        }
    }
}
