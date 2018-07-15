using System.Collections.Generic;

namespace LeetCode
{
    public class Solution119
    {
        public IList<int> GetRow(int rowIndex)
        {
            IList<int> result = new List<int>();
            result.Add(1);

            if (rowIndex == 0)
            {
                return result;
            }

            for (int i = 1; i <= rowIndex; i++)
            {
                result.Add(1);

                for (int reverseIndex = i - 1; reverseIndex > 0; reverseIndex--)
                {
                    result[reverseIndex] = result[reverseIndex] + result[reverseIndex - 1];
                }
            }

            return result;
        }
    }
}