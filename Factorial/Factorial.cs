using System;
using System.Threading;
using System.Numerics;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        long n = 20; // найти факториал натурального числа n


        Task.Run(() => { myThread(n); })
            .ConfigureAwait(false).GetAwaiter().GetResult();

        Console.WriteLine($"Factorial of {n} equals {result}");
        // Factorial of 20 equals 2432902008176640000
    }


    static void myThread(long n)
    {
        var thread = new Thread(() => { result = Factorial(n); });
        thread.Start(); thread.Join(); // запустить и ждать завершения 
    }

    static BigInteger Factorial(long n)
    {
        BigInteger result = n; int factor = 0;
        while (!(++factor >= n)) result *= factor;

        return result!=0?result:1;
    }
    static BigInteger result;
}