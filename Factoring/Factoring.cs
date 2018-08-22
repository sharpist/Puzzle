using System;
using static System.Console;
using static System.Math;

class Program
{
    static void Main()
    {
        // 8616460799
        WriteLine("Enter an odd integer number: ");
        var value = ReadLine();

        var factors = FermatFactorization(value);
        WriteLine($"\nFactors of this number:\n{factors.Item1} * {factors.Item2}");
        // Factors of this number: 96079 * 89681
    }


    static Tuple<int, int> FermatFactorization(String value)
    {
        Int64.TryParse(value, out var n);

        var k = 0;
        var S = Round(Sqrt(n));
        double y = 0;

        //double eps = 1E-14; // error permissible
        do
        {
            S = S + k++;
            y = Pow(S, 2) - n;
            y = Round(Sqrt(y), 3);
        } while (y != Truncate(y));
        //while (!(Abs(y % 1) < eps));

        int a = (int)(S + y);
        int b = (int)(S - y);

        return Tuple.Create(a, b);
    }
}