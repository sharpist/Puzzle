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
        get { return  triangle[i][j]; }
        private set { triangle[i][j] = value; }
    }
    static PsclTriangle() => triangle = new ushort[100][];


    public static ushort[][] Construct()
    {
        for (byte i = 0; i < triangle.Length; i++)
        {
            triangle[i] = new ushort[i + 1];


            for (byte line = 0; line < triangle[i].Length - 2; line++)
            {
                if (i != 0)
                {
                    byte f = 0;
                    ushort sum = 0;
                    for (byte pair = 0; pair < triangle[i].Length; pair++)
                    {
                        sum += triangle[i - 1][pair];
                        if (++f == 2)
                        {
                            f = 0;
                            triangle[i][0] = 1;
                            triangle[i][triangle[i].Length - 1] = 1;
                            triangle[i][pair] = sum;
                            if (triangle[i].Length-2 == pair) break;
                            sum = 0;
                            pair--;
                            continue;
                        }
                    }


                    if ((triangle[i].Length - 1) == 1)
                        triangle[i][line] = sum;
                    else
                    {
                        triangle[i][0] = 1;
                        triangle[i][triangle[i].Length - 1] = 1;
                        triangle[i][line + 1] = sum;
                    }
                }

            }
            triangle[0] = new ushort[1];
            triangle[1] = new ushort[2];
            triangle[0][0] = 1;
                triangle[1][0] = 1;
                triangle[1][1] = 1;


        }
        return triangle;
    }
}

