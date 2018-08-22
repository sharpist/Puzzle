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
            // first-last values
            triangle[i][0] = triangle[i][triangle[i].Length - 1] = 1;

            // check subsets
            if (triangle[i].Length - 2 > 0)
                for (byte j = 0; j < triangle[i].Length - 2; j++)
                    triangle[i][j + 1] = (ushort)(
                        triangle[i - 1][j] + triangle[i - 1][j + 1]);
        }
        return triangle;
    }
}
