using System;
using System.Threading;

namespace Demo
{
    public partial class Program
    {
        private static void diagonal(ushort[][] triangle, byte index)
        {
            for (byte row = 0; row < index; row++)
            {
                // tab before numbers
                var tab = new String(' ', (32 - triangle[row].Length) * 3);
                Console.Write(tab);


                var line = String.Empty;
                for (byte column = 0; column < triangle[row].Length; )
                {
                    string space;

                    // row selection
                    if (row == 0 || row == 4 || row == 11)
                    {
                        var Row = row; // local dupl. row

                        // diagonal capacity
                        var capacity = (row + 2) / 2;
                        for ( ; capacity > 0; capacity--)
                        {
                            // search row/column
                            var r = row - (capacity - 1);
                            var c = capacity - 1;

                            for (byte C = 0; C < triangle[r].Length; C++)
                            {
                                if (C == c)
                                    line += $"[{triangle[r][C]}]";
                                else
                                    line += triangle[r][C];
                                // exit
                                if (C == triangle[r].Length - 1) break;


                                space = new String(' ', 5);
                                line += (C == c - 1 || C == c) ? // space between numbers
                                    space.Remove(0, (triangle[r][C + 1].ToString().Length)) :
                                    space.Remove(0, (triangle[r][C + 1].ToString().Length) - 1);
                            }
                            // stand on a row
                            Console.SetCursorPosition(0, 5 + (Row + (Row % 2))); Row += 2;
                            tab = (c != 0) ? // tab before numbers
                                new String(' ', (32 - triangle[r].Length) * 3) :
                                new String(' ', (((32 - triangle[r].Length) * 3) - 1));
                            Console.Write(tab);


                            Console.WriteLine(line); line = String.Empty;
                            Thread.Sleep(500); // make a pause
                        }
                        break;
                    }
                    else line += triangle[row][column];


                    space = new String(' ', 5);
                    line += (++column < triangle[row].Length) ? // space between numbers
                        space.Remove(0, (triangle[row][column].ToString().Length) - 1) : "\n";
                }
                Console.WriteLine(line);
            }
        }
    }
}
