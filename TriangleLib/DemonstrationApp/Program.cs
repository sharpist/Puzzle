using System;
using TriangleLib;

namespace DemonstrationApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // определить тип треугольника со сторонами 5, 4 и 3
            var result = new Demonstration(5, 4, 3).TriangleType;

            Console.WriteLine(result);
            Console.ReadKey(true);
        }
    }

    public struct Demonstration
    {
        public string TriangleType { get; }

        public Demonstration(double a, double b, double c) =>
            TriangleType = Triangle.TriangleType(a, b, c);
    }
}
