using System;
using System.Collections;
using System.Collections.Generic;

namespace Task1
{
    public class ArrayUtils
    {
        private class MyComparer<T> : IComparer
        {
            private Func<T, T, int> _comparer;

            public MyComparer(Func<T, T, int> comparer)
            {
                _comparer = comparer;
            }

            public int Compare(object x, object y)
            {
                return _comparer((T) x, (T) y);
            }
        }

        public static void Sort<T>(T[] ar, Func<T, T, int> comparer)
        {
            Array.Sort(ar, new MyComparer<T>(comparer));
        }
    }
}