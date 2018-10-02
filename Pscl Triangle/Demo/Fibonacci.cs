using PascalTriangle2;
using System;
using System.Linq;
using System.Threading;

namespace Demo
{
    public partial class Program
    {
        private static void fibonacci(ushort[][] triangle, byte index)
        {
            #region PreSettings
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(0, 6);
            #endregion

            for (byte row = 0; row < index; row++)
            {
                // fibonacci number are the sum of the diagonal
                var diagonal  = PsclTriangle.FibDiagonal(triangle, row);
                var fibNumber = diagonal.Sum(x => x);

                // tab before numbers
                var tab = new String(' ',
                    (32 - triangle[row].Length) * 3 -
                    (fibNumber.ToString().Length) - 5);
                Console.Write(tab);


                Console.WriteLine(fibNumber + "\n");
                Thread.Sleep(250);
            }
        }
    }
}
