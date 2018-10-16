using System;

namespace Task1
{
    public class Circle : Shape
    {
        private int _radius;
        public Point Center => Point;

        public int Radius
        {
            get => _radius;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Radius must be positive");
                }

                _radius = value;
            }
        }

        public double Length => 2 * Math.PI * Radius;

        public Circle(Point center, int radius) : base(center)
        {
            Radius = radius;
        }

        public override void Draw(ICanvas canvas)
        {
            canvas.DrawRound(Center, Radius);
        }

        public override void Move(int horizontal, int vertical)
        {
            Point.X += horizontal;
            Point.Y += vertical;
        }
    }
}