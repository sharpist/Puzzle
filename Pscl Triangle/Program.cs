using PascalTriangle2;
using System.Threading;

namespace Demo
{
    public partial class Program
    {
        static void Main()
        {
            Thread thread = new Thread(() => triangle(PsclTriangle.Construct(40), 20));
            thread.Start();

        }
    }
}
