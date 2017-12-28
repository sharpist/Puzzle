using System;

namespace ChangeVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            // поменять местами значения переменных
            int a = 248,   b = 63;
            // 11111000 ^ 00111111 = 11000111
            a  =  a     ^     b;  // 199

            // 11000111 ^ 00111111 = 11111000
            b  =  a     ^     b;  // 248

            // 11000111 ^ 11111000 = 00111111
            a  =  a     ^     b;  // 63


            Console.WriteLine($"Было:  248 и  63\nСтало:  {a} и {b}");
            // Было:  248 и  63
            // Стало:  63 и 248

        }
    }
}
