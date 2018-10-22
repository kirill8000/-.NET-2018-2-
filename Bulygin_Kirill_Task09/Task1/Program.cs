using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {

        static int RemoveEachSecondItem(ICollection<int> list)
        {
            if (list.Count < 2)
                return -1;
            var isEven = false;
            while (list.Count > 1)
            {
                var evens = new List<int>();
                foreach (var i in list)
                {
                    if (isEven)
                    {
                        evens.Add(i);
                    }
                    isEven = !isEven;
                }

                foreach (var even in evens)
                {
                    list.Remove(even);
                }
            }
            return list.First();
        }
        
        static void Main(string[] args)
        {
            
            var n = 10;
            var linkedList = new LinkedList<int>();
            var list = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                linkedList.AddLast(i);
                list.Add(i);
            }

            Console.WriteLine(RemoveEachSecondItem(list));
            Console.WriteLine(RemoveEachSecondItem(linkedList));
        }
    }
}
