using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Task1
{
    public class DynamicArray<T> : ICollection<T>, IList<T>, IEnumerable<T> where T : new()
    {
        private const int DefaultCapacity = 8;
        private T[] _array;
        private int _length = 0;
        public int Count => _length;
        public bool IsReadOnly => false;

        private void Resize(int capacity)
        {
            Debug.Assert(_length <= capacity);
            T[] tempAr = new T[capacity];
            Array.Copy(_array, tempAr, _length);
            _array = tempAr;
        }

        private int GetIndex(T item)
        {
            for (int i = 0; i < _length; i++)
            {
                if (item.Equals(_array[i]))
                    return i;
            }

            return -1;
        }

        public int Capacity => _array.Length;

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
            if(_length == _array.Length)
                Resize(_array.Length * 2);
            _array[_length++] = item;
        }

        public void Clear()
        {
            _array = new T[DefaultCapacity];
        }

        public bool Contains(T item)
        {
            return GetIndex(item) != -1;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            Array.Copy(_array, 0, array, arrayIndex, _length);
        }

        public bool Remove(T item)
        {
            int i = GetIndex(item);
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
            return GetIndex(item);
        }

        public void Insert(int index, T item)
        {
            if (index < 0 || index > _length)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (index == _length)
            {
                Add(item);
                return;
            }

            Add(_array[_length - 1]);
            for (int i = _length - 2; i > index; i--)
            {
                _array[i] = _array[i - 1];
            }

            _array[index] = item;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= _length)
                throw new ArgumentOutOfRangeException("Argument out of range");
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
                if(index < 0 || index >= _length)
                    throw new ArgumentOutOfRangeException("Argument out of range");
                return _array[index];
            }
            set
            {
                var t = this[index];
                _array[index] = value;
            }
        }
    }
}