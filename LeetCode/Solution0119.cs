namespace LeetCode
{
    public class Solution0119
    {
        public IList<int> GetRow(int rowIndex)
        {
            var result = new List<int>();
            result.Add(1);

            if (rowIndex == 0)
            {
                return result;
            }

            for (var i = 1; i <= rowIndex; i++)
            {
                result.Add(1);

                for (var reverseIndex = i - 1; reverseIndex > 0; reverseIndex--)
                {
                    result[reverseIndex] += result[reverseIndex - 1];
                }
            }

            return result;
        }
    }
}