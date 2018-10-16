using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class VectorEditor
    {
        private List<Shape> _shapes = new List<Shape>();
        private ICanvas _canvas;
        public VectorEditor(ICanvas canvas)
        {
            _canvas = canvas;
        }
        public void AddShape(Shape shape)
        {
            _shapes.Add(shape);
        }

        public void AddShapesRange(List<Shape> shapes)
        {
            _shapes.AddRange(shapes);
        }

        public void Render()
        {
            foreach (var shape in _shapes)
            {
                shape.Draw(_canvas);
            }
        }
    }
}
