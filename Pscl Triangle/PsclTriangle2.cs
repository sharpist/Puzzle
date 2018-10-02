namespace PascalTriangle2
{
    sealed class PsclTriangle
    {
        public static ushort[][] Construct(byte index)
        {
            var triangle = new ushort[index][];
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
            return triangle;
        }

        public static ushort[] FibDiagonal(ushort[][] triangle, byte index)
        {
            var capacity = (index + 2) / 2;
            var diagonal = new ushort[capacity];

            for ( ; capacity > 0; capacity--)
            {
                var row    = index - (capacity - 1);
                var column = capacity - 1;

                diagonal[column] = triangle[row][column];
            }
            return diagonal;
        }

        private PsclTriangle() { }
    }
}
