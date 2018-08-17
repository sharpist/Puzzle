using System;

class Program
{
    static void Main()
    {
        // 32-ое число (порядковый номер) ряда Фибоначчи
        // ...3524578 => 24578
        var result = Fibonacci.Last5(32);
    }
}


// алгоритм нахождения последних 5 цифр n-ого числа Фибоначчи
public class Fibonacci
{
    static private int fibonacci(int counter, int a, int b)
    {
        if (counter == 0) return a;

        return fibonacci(counter - 1, b, (a + b) % 100000);
    }

    static public int Last5(int number)
    {
        if (number < 0) throw new Exception();

        return fibonacci(number, 1, 1);
    }
}
