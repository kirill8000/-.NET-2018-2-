using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Round
    {
        private double _radius;
        public Point Center { get; set; }

        public double Radius
        {
            get => _radius;
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Radius must be positive");
                }
                else
                {
                    _radius = value;
                }
            }
        }

        public double Length => 2 * Math.PI * Radius;
        public double Square => Math.Pow(Radius, 2) * Math.PI;

        public Round(Point center, double radius)
        {
            Radius = radius;
            Center = center;
        }
    }
}
