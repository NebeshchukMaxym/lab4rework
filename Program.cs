using System;
using System.Text.Json;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Geometry geometry = new Geometry();
            Point point = new Point(1, 1);



            Square square = new Square(new Point(0, 5), 7, "Red");
            Console.WriteLine(square);
            Console.WriteLine($"Angles: [ {string.Join(", ", square.GetCornersAngles())} ]");
            Console.WriteLine($"{point}  is {(square.Contains(point) ? "" : "not")} within {square}");
            Console.WriteLine();

            Ellipse ellipse = new Ellipse(new Point(7, 3), 5, 10, "Green");
            Console.WriteLine(ellipse);
            Console.WriteLine($"Circumference Length: {ellipse.GetCircumferenceLength()}");
            Console.WriteLine($"{point} is {(ellipse.Contains(point) ? "" : "not")} within {ellipse}");
            Console.WriteLine();

            Triangle triangle = new Triangle(new Point(0, 0), new Point(1, 2), new Point(-1, 5), "Yellow");
            Console.WriteLine(triangle);
            Console.WriteLine($"Angles: [ {string.Join(", ", triangle.GetCornersAngles())} ]");
            Console.WriteLine($"{point} is {(triangle.Contains(point) ? "" : "not")} within {triangle}");
            Console.WriteLine();

            Quadrilateral quadrilateral = new Quadrilateral(new Point(1, 2), new Point(2, 2), new Point(-3, 5), new Point(-3, -5), "Blue");
            Console.WriteLine(quadrilateral);
            Console.WriteLine($"Angles: [ {string.Join(", ", quadrilateral.GetCornersAngles())} ]");
            Console.WriteLine($"{point} is {(quadrilateral.Contains(point) ? "" : "not")} within {quadrilateral}");
            Console.WriteLine();

            geometry.AddShape(square);
            geometry.AddShape(ellipse);
            geometry.AddShape(triangle);
            geometry.AddShape(quadrilateral);


            Console.WriteLine(JsonSerializer.Serialize(geometry.CountContainsPoint(point)));
        }
    }
}
