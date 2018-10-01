using System;
using System.Threading;

class Program
{
    static void Main()
    {
        var pscl = PsclTriangle.Construct();

        for (byte i = 0; i < 20; i++)
        {
            // tab before numbers
            var tab = new String(' ', (32 - pscl[i].Length) * 3);
            Console.Write(tab);


            var line = String.Empty;
            for (byte j = 0; j < pscl[i].Length; )
            {
                line += pscl[i][j].ToString();

                // space between numbers
                var space = new String(' ', 5);
                line += (++j < pscl[i].Length) ?
                    space.Remove(0, (pscl[i][j].ToString().Length) - 1) : "\n";
            }
            Console.WriteLine(line);
            Thread.Sleep(500);
        }
    }
}

struct PsclTriangle
{
    private static ushort[][] triangle;
    public ushort this[byte i, byte j]
    {
        get { return triangle[i][j]; }
        private set { triangle[i][j] = value; }
    }
    static PsclTriangle() => triangle = new ushort[100][];


    public static ushort[][] Construct()
    {
        for (byte i = 0; i < triangle.Length; i++)
        {
            triangle[i] = new ushort[i + 1];

            triangle[i][0] = 1;
            triangle[i][triangle[i].Length - 1] = 1;

            // check subsets
            if ((triangle[i].Length - 2) > 0)
            {
                ushort sum = 0;
                var subset = false;
                for (byte j = 0; j < triangle[i].Length; j++)
                {
                    sum += triangle[i - 1][j];
                    if (subset)
                    {
                        subset = false;
                        triangle[i][j] = sum;
                        // all subsets have been found
                        if (triangle[i].Length - 2 == j) break;

                        // search for other subsets
                        sum = 0; j--;
                        continue;
                    }
                    subset = true;
                }
            }
        }
        return triangle;
    }

    public static ushort[] FibDiagonal(ushort[][] triangle, byte row)
    {
        var diagonal = new ushort[(row + 2) / 2];

        for (byte Row = row, column = 0; row > 0; row--, column++)
        {
            diagonal[column] = triangle[row][column];

            // row equal even-numbered
            if ((Row - 1) % 2 == 0)
                if ((Row + 1) / 2 == triangle[row][column]) break;
            // row equal odd-numbered
            if (column == triangle[row - 1].Length) break;
        }
        return diagonal;
    }
}

