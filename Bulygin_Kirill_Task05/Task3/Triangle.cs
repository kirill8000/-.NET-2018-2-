using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Triangle
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }
        public double Perimeter => A + B + C;
        public double Square 
            => Math.Sqrt((Perimeter / 2) * ((Perimeter / 2) - A) * ((Perimeter / 2) - B) * ((Perimeter / 2) - C)); //Heron's formula

        public Triangle(double a, double b, double c)
        {
            if(a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Side must be positive");
            A = a;
            B = b;
            C = c;
        }
    }
}
