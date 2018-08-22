class Program
{
    static void Main() =>
        System.Console.WriteLine(GCD(8, 16)); // 8


    // рекурсивный метод, вычисляющий наибольший
    // общий делитель двух целых чисел
    static int GCD(int a, int b)
    {
        if (b == 0) return a;

        return GCD(b, a % b);
    }
}