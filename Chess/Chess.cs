using System;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            // как определить корректный ли ход ферзя?
            TestMove("a1", "d4"); // True
            TestMove("f4", "e7"); // False
            TestMove("a1", "a4"); // True
            TestMove("a1", "a1"); // False
        }
        public static void TestMove(string from, string to) =>
            Console.WriteLine($"{from}-{to} {IsCorrectMove(from, to)}");

        public static bool IsCorrectMove(string from, string to)
        {
            var dx = Math.Abs(to[0] - from[0]); // смещение фигуры по горизонтали
            var dy = Math.Abs(to[1] - from[1]); // смещение фигуры по вертикали

            return ((dx == dy || dx == 0 || dy == 0) && !from.Equals(to));
                       // допустимое перемещение        // смещения нет (пустой ход) исключить
        }
    }
}
