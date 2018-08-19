## "Pascal's triangle"

* Pascal's triangle is a triangular array of the binomial coefficients.

### Demonstration: ###
![screen capture 1](01.gif)

### Construction of a triangle: ###
```c#
for (byte i = 0; i < triangle.Length; i++)
{
    triangle[i] = new ushort[i + 1];

    triangle[i][0] = 1;
    triangle[i][triangle[i].Length - 1] = 1;

    // check subsets
    if ((triangle[i].Length - 2) > 0)
    {
        ushort sum = 0;
        var subset = false;
        for (byte j = 0; j < triangle[i].Length; j++)
        {
            sum += triangle[i - 1][j];
            if (subset)
            {
                subset = false;
                triangle[i][j] = sum;
                // all subsets have been found
                if (triangle[i].Length - 2 == j) break;

                // search for other subsets
                sum = 0; j--;
                continue;
            }
            subset = true;
        }
    }
}
```
