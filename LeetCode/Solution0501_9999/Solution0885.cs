namespace LeetCode.Solution0501_9999
{
    public class Solution0885
    {
        public int[][] SpiralMatrixIII(int rows,
            int cols,
            int rStart,
            int cStart)
        {
            var result = new int[rows * cols][];
            var counter = 0;
            var direction = 0;
            var directArray = new int[4][]
            {
                new int[2] { 0, 1 },
                new int[2] { 1, 0 },
                new int[2] { 0, -1 },
                new int[2] { -1, 0 }
            };
            var lengthArray = new int[] { 1, 1, 2, 2 };

            result[counter++] = new int [2] { rStart, cStart };
            while (true)
            {
                if (counter == rows * cols)
                {
                    break;
                }

                for (var i = 0; i < lengthArray[direction]; i++)
                {
                    rStart += directArray[direction][0];
                    cStart += directArray[direction][1];
                    if (IsBeyondBoundary(rows,
                        cols,
                        rStart,
                        cStart))
                    {
                        result[counter++] = new int [2] { rStart, cStart };
                    }
                }

                lengthArray[direction] += 2;
                direction = (direction + 1) % 4;
            }

            return result;
        }

        private bool IsBeyondBoundary(int rows,
            int cols,
            int rStart,
            int cStart)
        {
            return 0 <= rStart && rStart <= (rows - 1) && 0 <= cStart && cStart <= (cols - 1);
        }
    }
}