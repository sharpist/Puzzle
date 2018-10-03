using PascalTriangle2;
using System.Threading;

namespace Demo
{
    public partial class Program
    {
        static void Main()
        {
            triangle(PsclTriangle.Construct(40), 20);

            diagonal();
            Thread.Sleep(2000);

            fibonacci(PsclTriangle.Construct(40), 20);
        }
    }
}
