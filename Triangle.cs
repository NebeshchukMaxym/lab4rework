using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    class Triangle : Shape, IHasCorners
    {
        public Point[] Vertices = new Point[3];

        public Triangle(Point vertix1, Point vertix2, Point vertix3, string color) : base(color)
        {
            Vertices[0] = vertix1;
            Vertices[1] = vertix2;
            Vertices[2] = vertix3;
        }
        public override bool Contains(Point point)
        {
            Triangle[] triangles = new Triangle[3];

            for (int i = 0; i < triangles.Length; i++)
                triangles[i] = new Triangle(Vertices[i], Vertices[(i + 1) % Vertices.Length], point, "white");


            return Math.Abs(GetArea() - triangles.Select(triangle => triangle.GetArea()).Sum()) < 0.01;
        }

        public double GetArea()
        {
            double[] sides = new double[Vertices.Length];
            for (int i = 0; i < sides.Length; i++)
                sides[i] = Point.CalculateDistance(Vertices[i], Vertices[(i + 1) % Vertices.Length]);


            double halfPerimeter = sides.Sum() / sides.Length;

            double area = halfPerimeter;
            foreach (double side in sides)
                area *= halfPerimeter - side;

            return Math.Sqrt(area);
        }

        public ICollection<double> GetCornersAngles()
        {
            double[] angles = new double[3];
            Random random = new Random();
            do
            {
                for (int i = 0; i < angles.Length; i++)
                    angles[i] = random.Next(30, 120);
            } while (angles.Sum() != 180);

            return angles;
        
        }
    }
}
