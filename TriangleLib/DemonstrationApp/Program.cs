using System;
using TriangleLib;
using static TriangleLib.Triangle;

namespace DemonstrationApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // определить тип треугольника со сторонами 5, 4 и 3
            var result = new Demonstration(5, 4, 3);

            if (result.IsTriangle)
                Console.WriteLine(result.Type);

            else
                Console.WriteLine("неверные значения");

            Console.ReadKey(true);
        }
    }

    public class Demonstration
    {
        public bool IsTriangle { get; }

        TriangleType? t;
        public TriangleType? Type => t;

        public Demonstration(double a, double b, double c) =>
            IsTriangle = Triangle.GetTriangleType(a, b, c, out t);
    }
}
