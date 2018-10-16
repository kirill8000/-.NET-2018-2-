using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Round : Circle
    {
        public double Square => Math.Pow(Radius, 2) * Math.PI;

        public Round(Point center, int radius) : base(center, radius)
        {
        }

        public override void Draw()
        {
            Console.WriteLine($"Round R = {Radius} {nameof(Length)} = {Length} {nameof(Square)} = {Square}");
        }

        public override void Move(int horizontal, int vertical)
        {
            Point.X += horizontal;
            Point.Y += vertical;
        }
    }
}
