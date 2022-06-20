using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    class Geometry
    {
        private List<Shape> _shapes = new List<Shape>();

        public void AddShape(Shape shape)
        {
            _shapes.Add(shape);
        }

        public Dictionary<string, int> CountContainsPoint(Point point)
        {
            Dictionary<string, int> counts = new Dictionary<string, int>
            {
                ["Ellipse"] = 0,
                ["Quadrilateral"] = 0,
                ["Square"] = 0,
                ["Triangle"] = 0
            };

            foreach (Shape shape in _shapes)
            {
                if (shape is Ellipse)
                    counts["Ellipse"] += shape.Contains(point) ? 1 : 0;

                else if (shape is Quadrilateral)
                    counts["Quadrilateral"] += shape.Contains(point) ? 1 : 0;

                else if (shape is Square)
                    counts["Square"] += shape.Contains(point) ? 1 : 0;

                else if (shape is Triangle)
                    counts["Triangle"] += shape.Contains(point) ? 1 : 0;
            }

            return counts;
        }
    }
}
