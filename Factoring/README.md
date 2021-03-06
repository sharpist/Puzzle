## Метод факторизации Ферма

* алгоритм факторизации (разложения на множители) нечётного целого числа ```n```
_________________________________

Для разложения на множители нечётного числа ```n``` ищется пара чисел ```(x, y)``` таких, что ```(x - y) * (x + y) = n``` или ```x² - y² = n```.
При этом числа ```(x - y)``` и ```(x + y)``` являются множителями ```n```.
_________________________________

### Пример: ###

#### итерация 1 ####

Возьмём число ```n``` = 10873 и вычислим ```S``` равную квадратному кореню ```n``` = 105.
Далее для каждого ```k``` = 1, 2, 3... вычисляются значения функции ```S + k```.

Находим:
1. ```y = (S + k)² - n```

(105 + 1)² - 10873 = 363

2. квадратный корень ```y```

квадратный корень 363 = 19,052


#### итерация 2 ####

(105 + 2)² - 10873 = 576

квадратный корень 576 = 24 =>

#### получено целое значение квадрата ```y``` ####

Таким образом имеет место следующее выражение:

(105 + 2)² - ```n``` = 24² =>

```n``` = 107² - 24² = 131 * 83 = 10873

