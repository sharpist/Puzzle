## "Pascal's triangle"
_______________________________________________________________________

* Pascal's triangle is a triangular array of the binomial coefficients.
* The Fibonacci numbers occur in the sums of "shallow" diagonals in Pascal's triangle.
* These numbers help to count the number of compositions of 1s and 2s that sum to a given total ```n```:

If ```n``` = 5, then ```Fn₊₁``` = F₆ = 8 counts the eight compositions
(1+1+1+1+1 = 1+1+1+2 = 1+1+2+1 = 1+2+1+1 = 2+1+1+1 = 2+2+1 = 2+1+2 = 1+2+2, 
all of which sum to 5).

* Produces a sequence of coefficients in powers of binomial
(производит последовательность коэффициентов в степенях двучлена):
```
monomial 7xz
         7xz + 7x² binomial
```
#### Example 1 ####

Raising a simple binomial to a second power:

```(x + y)²``` = ```(x + y)(x + y)``` = F+O+I+L

FIRSTS x*x
OUTERS x*y
INNERS y*x
LASTS  y*y

```xx + (xy + yx) + yy```

```x² +    2xy    + y²```

The second power and therefore is used a second row in Pascal's triangle for coefficients in an answer 1, 2, 1:

```1x² + 2xy + 1y²```

#### Example 2 ####

```(x + y)⁴``` =

```x⁴ + x³ + x² + x¹ + x⁰``` =

```x⁴ + x³ + x² + x``` =>

```x⁴ + x³y + x²y² + xy³ + y⁴```

Now let's find coefficients before members for the power 4 => 4th row 1, 4, 6, 4, 1:

```1x⁴ + 4x³y + 6x²y² + 4xy³ + 1y⁴```
_______________________________________________________________________

### Demonstration: ###
![screen capture 1](01.gif)
_______________________________________________________________________

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
