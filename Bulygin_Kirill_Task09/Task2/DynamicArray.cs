using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;

namespace Task2
{
    public class DynamicArray<T> : ICollection<T>, IList<T>, IEnumerable<T> where T : new()
    {
        private const int DefaultCapacity = 8;
        private T[] _array;
        private int _length;
        public int Count => _length;
        public bool IsReadOnly => false;
        public int Capacity => _array.Length;

        private void Resize(int capacity)
        {
            Debug.Assert(_length <= capacity);
            T[] tempAr = new T[capacity];
            Array.Copy(_array, tempAr, _length);
            _array = tempAr;
        }

        private void CheckBound(int index)
        {
            if (index < 0 || index >= _length)
                throw new ArgumentOutOfRangeException();
        }

        public DynamicArray()
        {
            _array = new T[DefaultCapacity];
        }

        public DynamicArray(int capacity)
        {
            _array = new T[capacity];
        }

        public DynamicArray(IEnumerable<T> enumerable)
        {
            foreach (var e in enumerable)
            {
                Add(e);
            }
        }

        public DynamicArray(T[] array)
        {
            _array = new T[array.Length];
            Array.Copy(array, _array, array.Length);
            _length = array.Length;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _length; i++)
            {
                yield return _array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            Insert(_length, item);
        }

        public void Clear()
        {
            _array = new T[DefaultCapacity];
        }

        public bool Contains(T item)
        {
            return IndexOf(item) != -1;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            Array.Copy(_array, 0, array, arrayIndex, _length);
        }

        public bool Remove(T item)
        {
            int i = IndexOf(item);
            if (i == -1)
                return false;          
            RemoveAt(i);
            return true;
        }

        public void AddRange(T[] array)
        {
            if (_length + array.Length < Capacity)
            {
                Resize(_length + array.Length);
            }
            Array.Copy(array, 0, _array, _length, array.Length);
            _length += array.Length;
        }

        public int IndexOf(T item)
        {
            return Array.IndexOf(_array, item, 0, _length);
        }

        public void Insert(int index, T item)
        {
            if((index < 0) || (index > _length))
                throw new ArgumentOutOfRangeException();

            if (_length == Capacity)
                Resize(_length * 2);

            for (int i = _length; i > index; i--)
            {
                _array[i] = _array[i - 1];
            }
            _array[index] = item;
            _length++;
        }

        public void RemoveAt(int index)
        {
            CheckBound(index);
            for (int j = index + 1; j < _length; j++)
            {
                _array[j - 1] = _array[j];
            }
            if (index == _length - 1)
            {
                _array[index] = default(T);
            }
            _length--;
            if (_length <= Capacity / 4 && _length > DefaultCapacity)
            {
                Resize(Capacity / 2);
            }
        }

        public T this[int index]
        {
            get
            {
                CheckBound(index);
                return _array[index];
            }
            set => _array[index] = value;
        }
    }
}