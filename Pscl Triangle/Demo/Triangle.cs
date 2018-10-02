using System;
using System.Threading;

namespace Demo
{
    public partial class Program
    {
        private static void triangle(ushort[][] triangle, byte index)
        {
            #region PreSettings
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 5);
            #endregion

            for (byte row = 0; row < index; row++)
            {
                // tab before numbers
                var tab = new String(' ', (32 - triangle[row].Length) * 3);
                Console.Write(tab);


                var line = String.Empty;
                for (byte column = 0; column < triangle[row].Length; )
                {
                    line += triangle[row][column].ToString();


                    // space between numbers
                    var space = new String(' ', 5);
                    line += (++column < triangle[row].Length) ?
                        space.Remove(0, (triangle[row][column].ToString().Length) - 1) : "\n";
                }
                Console.WriteLine(line);
                Thread.Sleep(250);
            }
        }
    }
}
