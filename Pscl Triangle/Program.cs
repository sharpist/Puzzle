using PascalTriangle2;

namespace Demo
{
    public partial class Program
    {
        static void Main()
        {
            triangle(PsclTriangle.Construct(40), 20);

            diagonal(PsclTriangle.Construct(40), 20);

            fibonacci(PsclTriangle.Construct(40), 20);
        }
    }
}
