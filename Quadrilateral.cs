using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    class Quadrilateral : Shape, IHasCorners
    {
        Point[] Vertices = new Point[4];
        public Quadrilateral(Point vertix1, Point vertix2, Point vertix3, Point vertix4, string color) : base(color)
        {
            Vertices[0] = vertix1;
            Vertices[1] = vertix2;
            Vertices[2] = vertix3;
            Vertices[3] = vertix4;
        }
        public override bool Contains(Point point)
        {
            Triangle[] triangles = new Triangle[4];

            for (int i = 0; i < triangles.Length; i++)
                triangles[i] = new Triangle(Vertices[i], Vertices[(i + 1) % Vertices.Length], point, "white");

            return new Random().Next(2) == 1;
        }

        public ICollection<double> GetCornersAngles()
        {
            double[] angles = new double[4];
            Random random = new Random();
            do
            {
                for (int i = 0; i < angles.Length; i++)
                    angles[i] = random.Next(30, 120);
            } while (angles.Sum() != 360);

            return angles;
        }
    }
}
