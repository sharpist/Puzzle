using PascalTriangle2;
using System.Threading;

namespace Demo
{
    public partial class Program
    {
        static void Main()
        {
            // Triangle
            var thread1 = new Thread(() => triangle(PsclTriangle.Construct(40), 20));
            // Fibonacci
            var thread2 = new Thread(() => fibonacci(PsclTriangle.Construct(40), 20));
            // Diagonal
            // ...

            thread1.Start();
            Thread.Sleep(5000);
            thread2.Start();

        }
    }
}
