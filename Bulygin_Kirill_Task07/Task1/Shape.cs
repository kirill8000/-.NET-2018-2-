namespace Task1
{
    public abstract class Shape
    {
        protected Point Point;
        public abstract void Draw();
        public abstract void Move(int horizontal, int vertical);

        protected Shape(Point point)
        {
            Point = point;
        }
    }
}