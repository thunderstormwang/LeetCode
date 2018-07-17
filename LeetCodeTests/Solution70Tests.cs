using NUnit.Framework;

namespace LeetCode.Tests
{
    [TestFixture()]
    public class Solution70Tests
    {
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        public void ClimbStairsTest(int x, int expected)
        {
            Solution70 solution70 = new Solution70();

            int actual = solution70.ClimbStairs(x);

            Assert.AreEqual(expected, actual);
        }
    }
}