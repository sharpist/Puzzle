## TriangleLib

> **Треугольник** — геометрическая фигура, образованная тремя отрезками, которые соединяют три точки, не лежащие на одной прямой.

Типы треугольников: ```прямоугольный```, ```тупоугольный``` и ```остроугольный```.
___

### Задание

На языке **C#** написать библиотеку, содержащую единственный метод.  
Этот метод должен ==по трём сторонам определить тип треугольника: прямоугольный, тупоугольный или остроугольный==.

### Решение

```c#
using System;
using System.Linq;

namespace TriangleLib
{
    public struct Triangle
    {
        public static String TriangleType(double a, double b, double c)
        {
            var sides = new[] { a, b, c };
            var maxSide = sides.Max();
            var minSide = sides.Min();
            var midSide = 0d;

            midSide = (from s in sides where s < maxSide && s > minSide select s)
                .FirstOrDefault();

            for (int i = 0; i < sides.Length; i++)
                for (int j = i + 1; j < sides.Length; j++)
                    if (sides[i] == sides[j]) midSide = sides[i];

            // C<a+b
            if (!(maxSide < minSide + midSide)) return "Неверные значения";

            // C²=a²+b² прямоугольный
            else if (Math.Pow(maxSide, 2) == Math.Pow(minSide, 2) + Math.Pow(midSide, 2))
                return "Прямоугольный треугольник";

            // C²<a²+b² остроугольный
            else if (Math.Pow(maxSide, 2) < Math.Pow(minSide, 2) + Math.Pow(midSide, 2))
                return "Остроугольный треугольник";

            // C²>a²+b² тупоугольный
            else if (Math.Pow(maxSide, 2) > Math.Pow(minSide, 2) + Math.Pow(midSide, 2))
                return "Тупоугольный треугольник";

            else return default;
        }
    }
}
````

### Демонстрация

![demo](demo.gif)

___

###### *решение подготовил Александр Усов*
