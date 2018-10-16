using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Triangle
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }
        public double Perimeter => A + B + C;
        public double Square 
            => Math.Sqrt((Perimeter / 2) * ((Perimeter / 2) - A) * ((Perimeter / 2) - B) * ((Perimeter / 2) - C)); //Heron's formula

        public Triangle(double a, double b, double c)
        {
            if(a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Side must be positive");
            if(a + b <= c || c + b <= a || a + c <= b)
                throw new ArgumentException("Invalid sides");
            A = a;
            B = b;
            C = c;
        }
    }
}
