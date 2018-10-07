using System;

namespace Task01
{
    internal class Alghoritm
    {
        private const int IntrosortSizeThreshold = 16;
        private static void Swap<T>(T[] ar, int a, int b) where T : IComparable<T>
        {
            var t = ar[a];
            ar[a] = ar[b];
            ar[b] = t;
        }

        private static void SwapIfLarger<T>(T[] ar, int a, int b) where T : IComparable<T>
        {
            if (ar[a].CompareTo(ar[b]) > 0)
            {
                var t = ar[a];
                ar[a] = ar[b];
                ar[b] = t;
            }
        }


        private static bool Less<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) < 0;
        }

        private static void InsertionSort<T>(T[] array, int lo, int hi) where T : IComparable<T>
        {
            for (var i = lo; i <= hi; i++)
            for (var j = i; j > lo && Less(array[j], array[j - 1]); j--)
            {
                Swap(array, j, j - 1);
            }
        }


        public static bool IsSorted<T>(T[] a) where T : IComparable<T>
        {
            for (var i = 0; i < a.Length - 1; i++)
            {
                if (a[i].CompareTo(a[i + 1]) > 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static void QuickSort<T>(T[] ar, int lo, int hi, int depthLimit) where T : IComparable<T>
        {
            while (lo < hi)
            {
                var partSize = hi - lo + 1;
                if (partSize < IntrosortSizeThreshold)
                {
                    if (partSize == 1)
                    {
                        return;
                    }

                    if (partSize == 2)
                    {
                        SwapIfLarger(ar, lo, hi);
                        return;
                    }

                    if (partSize == 3)
                    {
                        SwapIfLarger(ar, lo, hi - 1);
                        SwapIfLarger(ar, lo, hi);
                        SwapIfLarger(ar, hi - 1, hi);
                        return;
                    }
                    InsertionSort(ar, lo, hi);
                    return;
                }

                if (depthLimit == 0)
                {
                    //TODO HeapSort
                }
                var mid = lo + (hi - lo) / 2;
                SwapIfLarger(ar, lo, mid);
                SwapIfLarger(ar, lo, hi);
                SwapIfLarger(ar, mid, hi);
                Swap(ar, lo, mid);
                int lt = lo, gt = hi;
                var v = ar[lo];
                var i = lo;
                while (i <= gt)
                {
                    var cmp = ar[i].CompareTo(v);
                    if (cmp < 0)
                    {
                        Swap(ar, lt++, i++);
                    }
                    else if (cmp > 0)
                    {
                        Swap(ar, i, gt--);
                    }
                    else
                    {
                        i++;
                    }
                }
                depthLimit--;
                if (lt - lo < hi - gt)
                {
                    QuickSort(ar, lo, lt - 1, depthLimit);
                    lo = gt + 1;
                }
                else
                {
                    QuickSort(ar, gt + 1, hi, depthLimit);
                    hi = lt - 1;
                }
            }
        }

        public static void Sort<T>(T[] ar) where T : IComparable<T>
        {
            QuickSort(ar, 0, ar.Length - 1, (int)Math.Log(ar.Length, 2));
        }

        public static T Max<T>(T[] ar) where T : IComparable<T>
        {
            var max = ar[0];
            for (var i = 1; i < ar.Length; i++)
            {
                if (Less(max, ar[i]))
                {
                    max = ar[i];
                }
            }

            return max;
        }

        public static T Min<T>(T[] ar) where T : IComparable<T>
        {
            var min = ar[0];
            for (var i = 1; i < ar.Length; i++)
            {
                if (Less(ar[i], min))
                {
                    min = ar[i];
                }
            }

            return min;
        }
    }
}