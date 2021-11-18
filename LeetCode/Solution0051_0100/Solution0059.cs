namespace LeetCode.Solution0051_0100
{
    public class Solution0059
    {
        public int[][] GenerateMatrix_Version1(int n)
        {
            var result = new int [n][];
            for (var i = 0; i < result.Length; i++)
            {
                result[i] = new int[n];
            }

            var counter = 1;
            var row = 0;
            var column = 0;
            var sideLength = n;

            while (counter < n * n)
            {
                var length = sideLength - 1;
                for (var i = 0; i < length; i++)
                {
                    result[row][column++] = counter++;
                }

                for (var i = 0; i < length; i++)
                {
                    result[row++][column] = counter++;
                }

                for (var i = 0; i < length; i++)
                {
                    result[row][column--] = counter++;
                }

                for (var i = 0; i < length; i++)
                {
                    result[row--][column] = counter++;
                }

                sideLength -= 2;
                row++;
                column++;
            }

            if (sideLength == 1)
            {
                result[row][column] = counter;
            }

            return result;
        }

        public int[][] GenerateMatrix_Version2(int n)
        {
            var result = new int [n][];
            for (var i = 0; i < result.Length; i++)
            {
                result[i] = new int[n];
            }

            var directArray = new int[4][]
            {
                new int[2] { 0, 1 },
                new int[2] { 1, 0 },
                new int[2] { 0, -1 },
                new int[2] { -1, 0 }
            };
            var counter = 1;
            var row = 0;
            var column = 0;
            var sideLength = n;

            while (counter < n * n)
            {
                for (var direction = 0; direction < 4; direction++)
                {
                    for (var i = 0; i < sideLength - 1; i++)
                    {
                        result[row][column] = counter++;
                        row += directArray[direction][0];
                        column += directArray[direction][1];
                    }
                }

                sideLength -= 2;
                row++;
                column++;
            }

            if (sideLength == 1)
            {
                result[row][column] = counter;
            }

            return result;
        }

        // 這題沒用到演算法, 就是考寫程式的功力
        // 正方形有四個邊, 邊長為 n, 在每一個方向走 n-1 步, 走完一圈就往內圈走
        // 最後有一個 n=1 的 special case
    }
}