using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Ring : Shape
    {
        private readonly Round _round;
        private readonly Round _inRound;

        public Ring(Point center, int inRadius, int radius) : base(center)
        {
            if (radius <= inRadius)
            {
                throw new ArgumentException("Inner radius should be less");
            }
            _round = new Round(center, radius);
            _inRound = new Round(center, inRadius);
        }

        public double Square => _round.Square - _inRound.Square;
        public double InLength => _inRound.Length;
        public double OutLength => _round.Length;
        public double Length => _round.Length + _inRound.Length;

        public Point Center => Point;
        public override void Draw()
        {
            Console.WriteLine($"Ring Center {Point}. Inner radius {_inRound.Radius}. Out radius {_round.Radius}. Length {_inRound.Length} {_round.Length}. Square {Square}.");
        }

        public override void Move(int horizontal, int vertical)
        {
            _round.Move(horizontal, vertical);
            _inRound.Move(horizontal, vertical);
        }
    }
}
