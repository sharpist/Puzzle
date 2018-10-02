## "Pascal's triangle"

* Pascal's triangle is a triangular array of the binomial coefficients.

### Demonstration: ###
![screen capture 1](01.gif)

### v.1 Construction of a triangle: ###
```c#
for (byte row = 0; row < triangle.Length; row++)
{
    triangle[row] = new ushort[row + 1];

    triangle[row][0] = 1;
    triangle[row][triangle[row].Length - 1] = 1;

    // check subsets
    if ((triangle[row].Length - 2) > 0)
    {
        ushort sum = 0;
        var subset = false;
        for (byte column = 0; column < triangle[row].Length; column++)
        {
            sum += triangle[row - 1][column];
            if (subset)
            {
                subset = false;
                triangle[row][column] = sum;
                // all subsets have been found
                if (triangle[row].Length - 2 == column) break;

                // search for other subsets
                sum = 0; column--;
                continue;
            }
            subset = true;
        }
    }
}
```

### v.2 Construction of a triangle: ###
```c#
for (byte row = 0; row < triangle.Length; row++)
{
    triangle[row] = new ushort[row + 1];
    // first-last values
    triangle[row][0] = triangle[row][triangle[row].Length - 1] = 1;
    // check subsets
    if (triangle[row].Length - 2 > 0)
        for (byte column = 0; column < triangle[row].Length - 2; column++)
            triangle[row][column + 1] = (ushort)(
                triangle[row - 1][column] + triangle[row - 1][column + 1]);
}
```
