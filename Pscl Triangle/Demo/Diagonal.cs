using System;
using System.Threading;

namespace Demo
{
    public partial class Program
    {
        private static void diagonal()
        {
            #region PreSettings
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(0, 5);
            #endregion

            Console.SetCursorPosition(98, 9);
            Console.WriteLine("(1)");
            Thread.Sleep(500);
            Console.SetCursorPosition(89, 11);
            Console.WriteLine("(3)");
            Thread.Sleep(500);
            Console.SetCursorPosition(80, 13);
            Console.WriteLine("(1)");
            Thread.Sleep(500);
            Console.SetCursorPosition(75, 14);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("5");
            Console.ForegroundColor = ConsoleColor.Green;
            Thread.Sleep(1000);

            Console.SetCursorPosition(104, 13);
            Console.WriteLine("(1)");
            Thread.Sleep(500);
            Console.SetCursorPosition(94, 15);
            Console.WriteLine("(10)");
            Thread.Sleep(500);
            Console.SetCursorPosition(85, 17);
            Console.WriteLine("(15)");
            Thread.Sleep(500);
            Console.SetCursorPosition(77, 19);
            Console.WriteLine("(7)");
            Thread.Sleep(500);
            Console.SetCursorPosition(68, 21);
            Console.WriteLine("(1)");
            Thread.Sleep(500);
            Console.SetCursorPosition(62, 22);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("34");
            Console.ForegroundColor = ConsoleColor.Green;
            Thread.Sleep(1000);

            Console.SetCursorPosition(110, 17);
            Console.WriteLine("(1)");
            Thread.Sleep(500);
            Console.SetCursorPosition(100, 19);
            Console.WriteLine("(21)");
            Thread.Sleep(500);
            Console.SetCursorPosition(91, 21);
            Console.WriteLine("(70)");
            Thread.Sleep(500);
            Console.SetCursorPosition(82, 23);
            Console.WriteLine("(84)");
            Thread.Sleep(500);
            Console.SetCursorPosition(73, 25);
            Console.WriteLine("(45)");
            Thread.Sleep(500);
            Console.SetCursorPosition(64, 27);
            Console.WriteLine("(11)");
            Thread.Sleep(500);
            Console.SetCursorPosition(56, 29);
            Console.WriteLine("(1)");
            Thread.Sleep(500);
            Console.SetCursorPosition(49, 30);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("233");
            Console.ForegroundColor = ConsoleColor.Green;
            Thread.Sleep(1000);
        }
    }
}
