using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    class Square : Shape, IHasCorners
    {
        public Point LeftmostVertix;
        public double Side;
  
        public Square(Point leftmostVertix, double side, string color) : base(color)
        {
            LeftmostVertix = leftmostVertix;
            Side = side;
        }
        Point[] Vertices = new Point[4];
        public override bool Contains(Point point)
        {
            return LeftmostVertix.X <= point.X && point.X <= LeftmostVertix.X + Side && LeftmostVertix.Y - Side <= point.Y && point.Y <= LeftmostVertix.Y;
        }

        public ICollection<double> GetCornersAngles()
        {
            return new double[] { 90, 90, 90, 90 };
        }


    }
}
