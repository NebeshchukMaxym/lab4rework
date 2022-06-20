using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    abstract class Shape
    {
        public string Color { get; set; }

        public Shape(string color)
        {
            Color = color;
        }

        public abstract bool Contains(Point point);
        public override string ToString()
        {
            return $"Shape {GetType()}, Color {Color}";
        }
    }
}
