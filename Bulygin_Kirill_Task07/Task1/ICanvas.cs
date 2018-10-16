namespace Task1
{
    public interface ICanvas
    {
        void DrawLine(Point p1, Point p2);
        void DrawRound(Point p1, int radius);
        void DrawRectangle(Point p1, Point p2);
    }
}