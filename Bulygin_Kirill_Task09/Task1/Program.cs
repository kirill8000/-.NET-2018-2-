using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static int RemoveEachSecondItem(LinkedList<int> list)
        {
            if (list.Count == 0)
                return -1;
            var node = list.First.Next ?? list.First;
            while (list.Count != 1)
            {
                var next = node.Next ?? list.First;
                list.Remove(node);
                node = next?.Next ?? list.First;
            }

            return list.First.Value;
        }

        static int RemoveEachSecondItem(List<int> list)
        {
            if (list.Count == 0)
                return -1;
            for (int i = 1; list.Count > 1; i = (i + 1) % list.Count)
            {
                list.RemoveAt(i);
            }

            return list[0];
        }
        
        static void Main(string[] args)
        {
            var n = 5;
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
