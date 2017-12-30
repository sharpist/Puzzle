using System;
using System.Collections.Generic;
using System.Linq;

namespace Slide
{
    class Program {
        public static void Main()
        {   // получить правильный результат вычисления (*без доп. массива)
            var arrayToPower = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9};

            PrintArray(GetPoweredArray(arrayToPower, 1));
            PrintArray(GetPoweredArray(arrayToPower, 2));
            PrintArray(GetPoweredArray(arrayToPower, 3));
            PrintArray(GetPoweredArray(new int[0], 1));
            PrintArray(GetPoweredArray(new[] { 42 }, 0));
            /*
             * 1 2 3 4 5 6 7 8 9
             * 1 4 9 16 25 36 49 64 81
             * 1 8 27 64 125 216 343 512 729
             * Массив длинной в 0
             * 1
             */
        }

        // вывод результатов
        private static void PrintArray(IEnumerable<int> arr)
        {
            if (arr.Count() != 0) {
                ushort i = 0;
                foreach (var e in arr) Console.Write(e.ToString() +
                                       /*интервал*/(++i<arr.Count()?" ":"\n"));
            }
            else Console.Write($"Массив длинной в {arr.Count()}\n");
        }

        // возведение в степень N
        private static IEnumerable<int> GetPoweredArray(int[] arr, int power)
        {
            for (int i = 0; i < arr.Length; i++)
                yield return (int)Math.Pow(arr[i], power);
        }
    }
}