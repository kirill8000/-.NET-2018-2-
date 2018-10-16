using System;
using Task2.Task2;

namespace Task2
{
    internal class Ring
    {
        private readonly Round _round;
        private readonly Round _inRound;

        public Ring(Point center, double radius, double inRadius)
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
    }
}