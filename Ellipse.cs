using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    class Ellipse : Shape, IIsRound
    {
        public Point Center;
        public double VerticalLength;
        public double HorizontalLength;

        public Ellipse(Point center, double verticalLength, double horizontalLength, string color) : base(color)
        {
            Center = center;
            VerticalLength = verticalLength;
            HorizontalLength = horizontalLength;
        }
        public override bool Contains(Point point)
        {
            return (Math.Pow(point.X - Center.X, 2) / Math.Pow(HorizontalLength, 2)) + (Math.Pow(point.Y - Center.Y, 2) / Math.Pow(VerticalLength, 2)) <= 1;
        }

        public double GetCircumferenceLength()
        {
            return Math.PI * (VerticalLength + HorizontalLength);
        }
    }
}
