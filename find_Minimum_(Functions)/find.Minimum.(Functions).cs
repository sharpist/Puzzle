using System;

namespace Slide
{
    class Program
    {
        public static void Main()
        {
            // найти минимум функции

            // найти такой 'x' при котором парабола "y(x) = ax2 + bx + c"
            // принимает минимальное значение
            // 
            // функция получает неотрицательный коэффициент 'a', 'b' и 'c'
            // если решение существует, вернуть искомый 'x', иначе — строку Impossible

            WriteParabolaMinX(1, 2, 3); // -1
            WriteParabolaMinX(0, 3, 2); // Impossible
            WriteParabolaMinX(5, 2, 1); // -0,2
            WriteParabolaMinX(4, 3, 2); // -0,375
            WriteParabolaMinX(0, 4, 5); // Impossible
        }

        private static void WriteParabolaMinX(int a, int b, int c)
        {
            // формула для искомого 'x'    "-b / (2.0 * a)"
            double x = -b / (2.0 * a);

            if (!double.IsInfinity(x) &&
                !double.IsNaN(x))
                Console.WriteLine(x);
            else
                Console.WriteLine("Impossible");
        }
    }
}