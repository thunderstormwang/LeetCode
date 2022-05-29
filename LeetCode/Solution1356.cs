namespace LeetCode
{
    public class Solution1356
    {
        public int[] SortByBits(int[] arr)
        {
            IComparer<int> comparer = new Comparer();
            Array.Sort(arr, comparer);
            return arr;
        }

        private class Comparer : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                if (x == y)
                {
                    return 0;
                }

                var countOfX = 0;
                var countOfY = 0;

                var temp = x;
                while (temp != 0)
                {
                    countOfX += temp & 1;
                    temp >>= 1;
                }

                temp = y;
                while (temp != 0)
                {
                    countOfY += temp & 1;
                    temp >>= 1;
                }

                if (countOfX != countOfY)
                {
                    return countOfX > countOfY ? 1 : -1;
                }

                return x > y ? 1 : -1;
            }
        }
    }
}