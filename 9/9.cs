using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using static System.Console;

class Program
{
    static void Main()
    {
        Write("Enter value: ");
        Int32.TryParse(ReadLine(), out var value);

        while (value > 9)
        {
            // get all digits from the number
            var chars  = value.ToString().ToCharArray();
            var digits = new List<int>(chars.ToList().Select(x => x - 48));

            Thread.Sleep(200);
            // subtract the sum of all digits from the number
            value -= digits.Sum();
            Write(value!=9?$"{value} ":$"[{value}]\n");
        }
        /*
        Enter value: 32
        27 18 [9]

        [32] - (3 + 2) = 27
        [27] - (2 + 7) = 18
        [18] - (1 + 8) = 9 always!

        Enter value: 421
        414 405 396 378 360 ... [9]

        Enter value: 175380
        175356 175329 175302 175284 175257 ... [9]
        */
    }
}
