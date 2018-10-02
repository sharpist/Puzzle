namespace PascalTriangle1
{
    sealed class PsclTriangle
    {
        public static ushort[][] Construct(byte index)
        {
            var triangle = new ushort[index][];
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
            return triangle;
        }

        public static ushort[] FibDiagonal(ushort[][] triangle, byte index)
        {
            var diagonal = new ushort[(index + 2) / 2];

            for (byte row = index, column = 0; row > 0; row--, column++)
            {
                diagonal[column] = triangle[row][column];

                // row equal even-numbered
                if ((index - 1) % 2 == 0)
                    if ((index + 1) / 2 == triangle[row][column]) break;
                // row equal odd-numbered
                if (column == triangle[row - 1].Length) break;
            }
            return diagonal;
        }

        private PsclTriangle() { }
    }
}