using NUnit.Framework;

namespace LeetCode.Tests
{
    [TestFixture()]
    public class Solution53Tests
    {
        [TestCase(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6)]
        public void MaxSubArrayTest(int[] array, int expected)
        {
            Solution53 solution53 = new Solution53();

            int actual = solution53.MaxSubArray(array);

            Assert.AreEqual(expected, actual);
        }
    }
}