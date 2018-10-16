using System;

namespace Task1
{
    public class ConsoleCanvas : ICanvas
    {
        public void DrawLine(Point p1, Point p2)
        {
            Console.WriteLine($"Line. Point 1 {p2} Point 2 {p1}.");
        }

        public void DrawRound(Point p1, int radius)
        {
            Console.WriteLine($"Round. Point {p1}. Radius {radius}.");
        }

        public void DrawRectangle(Point p1, Point p2)
        {
            Console.WriteLine($"Rectangle. Point {p1}. Point {p2}");
        }
    }
}