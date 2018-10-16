using System;

namespace Task1
{
    public class Rectangle : Shape
    {
        private Point _secondPoint;

        public double A => Math.Abs(_secondPoint.X - Point.X);
        public double B => Math.Abs(_secondPoint.Y - Point.Y);
        public double Square => A * B;

        public Rectangle(Point point1, Point point2) : base(point1)
        {
            if (point1 == point2) throw new ArgumentException("Points should be different");
            _secondPoint = point2;
        }
        
        public override void Draw(ICanvas canvas)
        {
            canvas.DrawRectangle(Point, _secondPoint);
        }

        public override void Move(int horizontal, int vertical)
        {
            Point.X += horizontal;
            _secondPoint.X += horizontal;
            Point.Y += vertical;
            _secondPoint.Y += vertical;
        }
    }
}