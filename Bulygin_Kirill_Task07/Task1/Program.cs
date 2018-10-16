using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>
            {
                new Rectangle(new Point(10, 10), new Point(10, 20)),
                new Round(new Point(0, 0), 10),
                new Line(new Point(0, 0), new Point(10, 10)),
                new Ring(new Point(12, 12), 10, 12),
                new Circle(new Point(12, 12), 11)
            };
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
