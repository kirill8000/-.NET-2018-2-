using System;

namespace Task1
{
    public class Line : Shape
    {
        private Point _secondPoint;

        public double Length 
            => Math.Sqrt(Math.Pow(Point.X - _secondPoint.X, 2) + Math.Pow(Point.Y - _secondPoint.Y, 2));

        public override void Draw()
        {
            Console.WriteLine($"Line Point 1 {Point} Point 2 {_secondPoint}. Length {Length}");
        }

        public override void Move(int horizontal, int vertical)
        {
            Point.X += horizontal;
            _secondPoint.X += horizontal;
            Point.Y += vertical;
            _secondPoint.Y += vertical;
        }

        public Line(int x1, int y1, int x2, int y2) : this(new Point(x1, y1), new Point(x2, y2))
        {

        }

        public Line(Point p1, Point p2):base(p1)
        {
            if(p1 == p2) throw new ArgumentException("Points should be different");
            _secondPoint = p2;
        }
    }
}