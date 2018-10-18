using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Task3
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

        public event EventHandler SortComplete;

        public async Task SortAsync<T>(T[] ar, Func<T, T, int> comparer)
        {
            await Task.Run(() =>
            {
                Sort(ar, comparer);
            });
            SortComplete?.Invoke(this, new EventArgs());
        }
    }
}