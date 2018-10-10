using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task4
{
    class MyString
    {
        private readonly char[] _massive;

        public int Length => _massive.Length;

        public static implicit operator MyString(string s)
        {
            return new MyString(s);
        }

        public static implicit operator string(MyString s)
        {
            return s.ToString();
        }

        public MyString(string s)
        {
            _massive = new char[s.Length];
            for (int i = 0; i < _massive.Length; i++)
            {
                _massive[i] = s[i];
            }
        }

        public override bool Equals(object obj)
        {
            return obj is MyString mystring &&
                   _massive.SequenceEqual(mystring._massive);
        }

        public static bool operator == (MyString s1, MyString s2)
        {
            if (ReferenceEquals(s1, null) || ReferenceEquals(s2, null))
                return false;
            return s1.Equals(s2);
        }

        public static bool operator !=(MyString s1, MyString s2)
        {
            return !(s1 == s2);
        }

        public override int GetHashCode()
        {
            return new string(_massive).GetHashCode();
        }

        public static MyString operator +(MyString s1, MyString s2)
        {
            char[] arr = new char[s1.Length + s2.Length];
            Array.Copy(s1._massive, 0, arr, 0, s1.Length);
            Array.Copy(s2._massive, 0, arr, s1.Length, s2.Length);
            MyString s = new MyString(arr);
            return s;
        }

        public static MyString operator -(MyString s1, MyString s2)
        {
            
            var replace = s1.ToString().Replace(s2, string.Empty);
            return new MyString(replace.ToCharArray());
        }

        private MyString(char[] arr)
        {
            _massive = arr;
        }

        public override string ToString()
        {
            return new string(_massive);
        }
    }
}
